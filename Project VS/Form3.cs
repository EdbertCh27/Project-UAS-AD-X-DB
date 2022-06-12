using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Project_VS
{
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_06_SERVICEMOBIL");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtCustomerData = new DataTable();
        DataTable dtPickUpMobil = new DataTable();
        DataTable dtCheckCsData = new DataTable();

        private void FormCheck_Load(object sender, EventArgs e)
        {
            
        }

        private void FormCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void buttonCheckCostNum_Click(object sender, EventArgs e)
        {
            dtCustomerData = new DataTable();
            dtCheckCsData = new DataTable();

            sqlQuery = "SELECT * FROM CUSTOMER WHERE CUSTOMER_ID ='" + textBoxCheckCostNum.Text.ToUpper() +"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCheckCsData);

            if(dtCheckCsData.Rows.Count == 1)
            {
                sqlQuery = "SELECT C.CUSTOMER_ID AS 'ID', C.CUSTOMER_NAME AS'NAMA', C.CUSTOMER_MERK_MOBIL AS 'TYPE MOBIL', C.CUSTOMER_NOPOL_MOBIL AS 'NOPOL', concat(L.LAYANAN_NAMA,' ',PART_NAMA) AS 'JENIS SERVICE',DS.SELESAI_KERJA AS 'TANGGAL PENGAMBILAN', TS.SERVICE_TOTAL AS 'TOTAL' FROM CUSTOMER C, TRANS_SERVICE TS, DETAIL_SERVICE DS, LAYANAN L WHERE C.CUSTOMER_ID = TS.CUSTOMER_ID AND TS.SERVICE_ID = DS.SERVICE_ID AND L.LAYANAN_ID = DS.LAYANAN_ID AND C.CUSTOMER_ID = '" + textBoxCheckCostNum.Text.ToUpper() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustomerData);
                dataGridViewCheckCostumer.DataSource = dtCustomerData;

                int tanggalSkrg = Convert.ToInt32(DateTime.Today.ToString("ddMMyyyy"));
                int tanggalPickup = Convert.ToInt32(Convert.ToDateTime(dtCustomerData.Rows[0][5]).ToString("ddMMyyyy"));

                if (tanggalPickup <= tanggalSkrg  && dtCheckCsData.Rows[0][6].ToString() == "0")
                {
                    buttonPickUp.Visible = true;
                    MessageBox.Show("Mobil Anda Telah Selesai di Proses,\nSilahkan diambil");
                }

                else if(tanggalPickup <= tanggalSkrg && dtCheckCsData.Rows[0][6].ToString() == "1")
                {
                    buttonPickUp.Visible = false;
                    MessageBox.Show("Mobil Anda Telah Diambil,\nTerimakasih");
                }

                else if(tanggalPickup >= tanggalSkrg)
                {
                    buttonPickUp.Visible = false;
                    MessageBox.Show("Mobil Anda sedang dalam proses,\nDapat diambil sesuai tanggal pengambilan");
                }
            }

            else
            {
                dtCustomerData = new DataTable();
                dtCheckCsData = new DataTable();
                dataGridViewCheckCostumer.DataSource = dtCustomerData;
                MessageBox.Show("Customer Tidak Terdaftar !");
            }
            
        }

        private void buttonPickUp_Click(object sender, EventArgs e)
        {
            sqlQuery = "UPDATE CUSTOMER SET STATUS_PICKUP = '1' WHERE CUSTOMER_ID = '"+textBoxCheckCostNum.Text.ToUpper()+"';";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPickUpMobil);

            MessageBox.Show("Terimakasih telah mempercayakan kendaraan anda kepada kami!");
            this.Hide();
        }
    }
}
