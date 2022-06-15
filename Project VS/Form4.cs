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
    public partial class FormInputCostumer : Form
    {
        public static string simpanNama;
        string simpanAlamat;
        string simpanNoHp;
        public static string simpanTypeMobil;
        public static string simpanNoPol;
        public static int hitungJumlahCust;

        public FormInputCostumer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_06_SERVICEMOBIL");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtDataCustomerSekarang = new DataTable();

        private void FormInputCostumer_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM CUSTOMER;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataCustomerSekarang);

            hitungJumlahCust = Convert.ToInt32(dtDataCustomerSekarang.Rows.Count) + 1;
        }

        private void buttonInputDataCust_Click(object sender, EventArgs e)
        {
            dataCostumer();

            if(textBoxNamaCust.Text == string.Empty || textBoxAlamatCust.Text == string.Empty || textBoxNoHpCust.Text == string.Empty || textBoxTypeMobilCust.Text == string.Empty || textBoxNomorPolisiCust.Text == string.Empty)
            {
                MessageBox.Show("ADA DATA YANG BELUM TERISI !!");
            }
            else
            {
                if (dtDataCustomerSekarang.Rows.Count + 1 < 10)
                {
                    string sqlInputCustomer = "INSERT INTO CUSTOMER VALUES('C00" + hitungJumlahCust + "', '" + textBoxNamaCust.Text + "', '" + textBoxAlamatCust.Text + "', '" + textBoxNoHpCust.Text + "', '" + textBoxNomorPolisiCust.Text.ToUpper() + "', '" + textBoxTypeMobilCust.Text.ToUpper() + "', '0')";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputCustomer, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                else if (dtDataCustomerSekarang.Rows.Count + 1 >= 10)
                {
                    string sqlInputCustomer = "INSERT INTO CUSTOMER VALUES('C0" + hitungJumlahCust + "', '" + textBoxNamaCust.Text + "', '" + textBoxAlamatCust.Text + "', '" + textBoxNoHpCust.Text + "', '" + textBoxNomorPolisiCust.Text.ToUpper() + "', '" + textBoxTypeMobilCust.Text.ToUpper() + "', '0')";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputCustomer, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }
                else if (dtDataCustomerSekarang.Rows.Count + 1 >= 100)
                {
                    string sqlInputCustomer = "INSERT INTO CUSTOMER VALUES('C" + hitungJumlahCust + "', '" + textBoxNamaCust.Text + "', '" + textBoxAlamatCust.Text + "', '" + textBoxNoHpCust.Text + "', '" + textBoxNomorPolisiCust.Text.ToUpper() + "', '" + textBoxTypeMobilCust.Text.ToUpper() + "', '0')";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputCustomer, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                }

                MessageBox.Show("Data Sudah Lengkap dan tersimpan");
                this.Hide();

                FormService BukaFormService = new FormService();
                BukaFormService.ShowDialog();
            }

            
        }
        public void dataCostumer()
        {
            simpanNama = textBoxNamaCust.Text;
            simpanAlamat = textBoxAlamatCust.Text;
            simpanNoHp = textBoxNoHpCust.Text;
            simpanTypeMobil = textBoxTypeMobilCust.Text;
            simpanNoPol = textBoxNomorPolisiCust.Text;
        }

        private void textBoxNoHpCust_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
