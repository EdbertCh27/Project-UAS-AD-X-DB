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
        DataTable dtDataCustomerSekarang = new DataTable();

        public static int hitungJumlahCust;

        private void FormInputCostumer_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM customer;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataCustomerSekarang);

            hitungJumlahCust = Convert.ToInt32(dtDataCustomerSekarang.Rows.Count) + 1;
        }

        private void buttonInputDataCust_Click(object sender, EventArgs e)
        {
            
            dataCostumer(0);

            if (dtDataCustomerSekarang.Rows.Count < 10)
            {
                string sqlInputCustomer = "INSERT INTO customer VALUES('C00"+hitungJumlahCust+"', '"+textBoxNamaCust.Text+"', '"+textBoxAlamatCust.Text+"', '"+textBoxNoHpCust.Text+"', '"+textBoxNomorPolisiCust.Text+"', '"+textBoxTypeMobilCust.Text+"', '0')";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputCustomer, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else if(dtDataCustomerSekarang.Rows.Count >= 10)
            {
                string sqlInputCustomer = "INSERT INTO customer VALUES('C0" + hitungJumlahCust + "', '" + textBoxNamaCust.Text + "', '" + textBoxAlamatCust.Text + "', '" + textBoxNoHpCust.Text + "', '" + textBoxNomorPolisiCust.Text + "', '" + textBoxTypeMobilCust.Text + "', '0')";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputCustomer, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else if(dtDataCustomerSekarang.Rows.Count >= 100)
            {
                string sqlInputCustomer = "INSERT INTO customer VALUES('C" + hitungJumlahCust + "', '" + textBoxNamaCust.Text + "', '" + textBoxAlamatCust.Text + "', '" + textBoxNoHpCust.Text + "', '" + textBoxNomorPolisiCust.Text + "', '" + textBoxTypeMobilCust.Text + "', '0')";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputCustomer, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

            }


            MessageBox.Show("Data Sudah Lengkap dan tersimpan");
            this.Hide();

            FormService BukaFormService = new FormService();
            BukaFormService.ShowDialog();

            //FormInvoice BukaFormInvoice = new FormInvoice();
            //BukaFormInvoice.ShowDialog();
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
