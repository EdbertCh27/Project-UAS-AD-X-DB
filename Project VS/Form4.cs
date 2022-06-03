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
        public FormInputCostumer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=servicehonda");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtInputDataCustomer = new DataTable();

        private void buttonInputDataCust_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Sudah Lengkap dan tersimpan");
            this.Hide();
            FormInvoice BukaFormInvoice = new FormInvoice();
            dataCostumer(0);

            //if(SELECT * FROM CUSTOMER)

            /*string sqlInputCustomer = "INSERT INTO customer VALUES('VC005', 'Vanessa Christie', 'VBR', '082196148989', 'L 1212 YS', 'CRV', '0')";
            sqlConnect.Open();
            sqlCommand = new MySqlCommand(sqlUpdateQuery, sqlConnect);
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();*/

            BukaFormInvoice.ShowDialog();
        }

        public void dataCostumer(int posisi) //????
        {
            simpanNama = textBoxNamaCust.Text;

            simpanAlamat = textBoxAlamatCust.Text;
            simpanNoHp = textBoxNoHpCust.Text;
            simpanTypeMobil = textBoxTypeMobilCust.Text;
            simpanNoPol = textBoxNomorPolisiCust.Text;
        }
    }
}
