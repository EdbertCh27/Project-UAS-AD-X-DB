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
    public partial class FormCheckStock : Form
    {
        public FormCheckStock()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_06_SERVICEMOBIL");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtStokBarang = new DataTable();
        DataTable dtCustTerakhir = new DataTable();
        DataTable hitungBarang = new DataTable();

        string updateTanggalSelesai = DateTime.Now.AddDays(4).ToString().Substring(0, 10).Replace("/", "-");

        public void checkStockNol()
        {
            if (Convert.ToInt32(hitungBarang.Rows[0][0]) <= 0)
            {
                labelStockVelg.Text = "0 Buah";
                labelStockVelg.BackColor = Color.Red;
            }
            if (Convert.ToInt32(hitungBarang.Rows[1][0]) <= 0)
            {
                labelStockBumper.Text = "0 Buah";
                labelStockBumper.BackColor = Color.Red;
            }
            if (Convert.ToInt32(hitungBarang.Rows[2][0]) <= 0)
            {
                labelStockWiper.Text = "0 Buah";
                labelStockWiper.BackColor = Color.Red;
            }
            if (Convert.ToInt32(hitungBarang.Rows[3][0]) <= 0)
            {
                labelStockSpion.Text = "0 Buah";
                labelStockSpion.BackColor = Color.Red;
            }
            if (Convert.ToInt32(hitungBarang.Rows[4][0]) <= 0)
            {
                labelStockBan.Text = "0 Buah";
                labelStockBan.BackColor = Color.Red;
            }
            if (Convert.ToInt32(hitungBarang.Rows[5][0]) <= 0)
            {
                labelStockLampu.Text = "0 Buah";
                labelStockLampu.BackColor = Color.Red;
            }
            
        }

        public void checkStockDipilih()
        {
            if (FormService.simpanDetailPilihanService == "Velg" && Convert.ToInt32(hitungBarang.Rows[0][0]) <= 0)
            {
                labelStockVelg.Text = "0 Buah";
                MessageBox.Show("Stock yang anda butuhkan sedang habis, akan tersedia 3 hari dari sekarang");
            }

            else if (FormService.simpanDetailPilihanService == "Bumper" && Convert.ToInt32(hitungBarang.Rows[1][0]) <= 0)
            {
                labelStockBumper.Text = "0 Buah";
                MessageBox.Show("Stock yang anda butuhkan sedang habis, akan tersedia 3 hari dari sekarang");
            }

            else if (FormService.simpanDetailPilihanService == "Wiper Blade" && Convert.ToInt32(hitungBarang.Rows[2][0]) <= 0)
            {
                MessageBox.Show("Stock yang anda butuhkan sedang habis, akan tersedia 3 hari dari sekarang");
            }

            else if (FormService.simpanDetailPilihanService == "Spion" && Convert.ToInt32(hitungBarang.Rows[3][0]) <= 0)
            {
                MessageBox.Show("Stock yang anda butuhkan sedang habis, akan tersedia 3 hari dari sekarang");
            }

            else if (FormService.simpanDetailPilihanService == "Ban" && Convert.ToInt32(hitungBarang.Rows[4][0]) <= 0)
            {
                MessageBox.Show("Stock yang anda butuhkan sedang habis, akan tersedia 3 hari dari sekarang");
            }

            else if (FormService.simpanDetailPilihanService == "Lampu" && Convert.ToInt32(hitungBarang.Rows[5][0]) <= 0)
            {
                MessageBox.Show("Stock yang anda butuhkan sedang habis, akan tersedia 3 hari dari sekarang");
            }
            else
            {
                MessageBox.Show("Berikut adalah stock yang tersedia");
            }
        }
        private void FormCheckStock_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT concat(PART_STOCK, ' Buah') FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStokBarang);

            sqlQuery = "SELECT PART_STOCK FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(hitungBarang);

            sqlQuery = "SELECT DETAIL_SERVICE_ID FROM DETAIL_SERVICE ORDER BY 1 DESC LIMIT 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustTerakhir);

            labelStockVelg.Text = dtStokBarang.Rows[0][0].ToString();
            labelStockBumper.Text = dtStokBarang.Rows[1][0].ToString();
            labelStockWiper.Text = dtStokBarang.Rows[2][0].ToString();
            labelStockSpion.Text = dtStokBarang.Rows[3][0].ToString();
            labelStockBan.Text = dtStokBarang.Rows[4][0].ToString();
            labelStockLampu.Text = dtStokBarang.Rows[5][0].ToString();

            checkStockNol();
            checkStockDipilih();

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (FormService.simpanDetailPilihanService == "Velg" && Convert.ToInt32(hitungBarang.Rows[0][0]) <= 0)
            {

                sqlQuery = "UPDATE DETAIL_SERVICE SET SELESAI_KERJA = str_to_date('" + updateTanggalSelesai + "','%d-%m-%Y') WHERE DETAIL_SERVICE_ID = '" + dtCustTerakhir.Rows[0][0].ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustTerakhir);
            }

            else if (FormService.simpanDetailPilihanService == "Bumper" && Convert.ToInt32(hitungBarang.Rows[1][0]) <= 0)
            {
                sqlQuery = "UPDATE DETAIL_SERVICE SET SELESAI_KERJA = str_to_date('" + updateTanggalSelesai + "','%d-%m-%Y') WHERE DETAIL_SERVICE_ID = '" + dtCustTerakhir.Rows[0][0].ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustTerakhir);
            }

            else if (FormService.simpanDetailPilihanService == "Wiper Blade" && Convert.ToInt32(hitungBarang.Rows[2][0]) <= 0)
            {
                sqlQuery = "UPDATE DETAIL_SERVICE SET SELESAI_KERJA = str_to_date('" + updateTanggalSelesai + "','%d-%m-%Y') WHERE DETAIL_SERVICE_ID = '" + dtCustTerakhir.Rows[0][0].ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustTerakhir);
            }

            else if (FormService.simpanDetailPilihanService == "Spion" && Convert.ToInt32(hitungBarang.Rows[3][0]) <= 0)
            {
                sqlQuery = "UPDATE DETAIL_SERVICE SET SELESAI_KERJA = str_to_date('" + updateTanggalSelesai + "','%d-%m-%Y') WHERE DETAIL_SERVICE_ID = '" + dtCustTerakhir.Rows[0][0].ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustTerakhir);
            }

            else if (FormService.simpanDetailPilihanService == "Ban" && Convert.ToInt32(hitungBarang.Rows[4][0]) <= 0)
            {
                sqlQuery = "UPDATE DETAIL_SERVICE SET SELESAI_KERJA = str_to_date('" + updateTanggalSelesai + "','%d-%m-%Y') WHERE DETAIL_SERVICE_ID = '" + dtCustTerakhir.Rows[0][0].ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustTerakhir);
            }

            else if (FormService.simpanDetailPilihanService == "Lampu" && Convert.ToInt32(hitungBarang.Rows[5][0]) <= 0)
            {
                sqlQuery = "UPDATE DETAIL_SERVICE SET SELESAI_KERJA = str_to_date('" + updateTanggalSelesai + "','%d-%m-%Y') WHERE DETAIL_SERVICE_ID = '" + dtCustTerakhir.Rows[0][0].ToString() + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtCustTerakhir);
            }

            MessageBox.Show("INVOICE");
            this.Hide();

            FormInvoice bukaFormInvoice = new FormInvoice();
            bukaFormInvoice.ShowDialog();

        }
    }
}
