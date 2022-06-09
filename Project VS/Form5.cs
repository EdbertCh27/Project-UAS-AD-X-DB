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
    public partial class FormInvoice : Form
    {
        public static int hitungStockVelg;
        public static int hitungStockBumper;
        public static int hitungStockWiperBlade;
        public static int hitungStockSpion;
        public static int hitungStockBan;
        public static int hitungStockLampu;

        public FormInvoice()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=servicehonda");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;

        DataTable dtCustomerID = new DataTable();
        DataTable dtStockBarang = new DataTable();
        DataTable dtDetailServID = new DataTable();

        string pilianService = FormService.simpanPilihanService;

        public void FormInvoice_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT customer_ID FROM customer ORDER BY 1 DESC limit 1 ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomerID);

            sqlQuery = "SELECT PART_ID, STOCK FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStockBarang);

            sqlQuery = "SELECT DETAIL_SERVICE_ID FROM DETAIL_SERVICE ORDER BY 1 DESC LIMIT 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDetailServID);

            labelIsiCodeCost.Text = dtCustomerID.Rows[0][0].ToString();
            labelIsiCustomerName.Text = FormInputCostumer.simpanNama;
            labelIsiService.Text = pilianService;
            labelIsiTypeMobil.Text = FormInputCostumer.simpanTypeMobil.ToUpper();
            labelIsiNoPol.Text = FormInputCostumer.simpanNoPol.ToUpper();
            labelTotalHarga.Text = FormService.simpanHargaService.ToString();
            labelUsePart.Text = FormService.simpanDetailPilihanService;

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (FormService.simpanDetailPilihanService == "Velg")
            {
                hitungStockVelg = Convert.ToInt32(dtStockBarang.Rows[0][1].ToString()) - 1;

                sqlQuery = "UPDATE SPAREPARTS SET STOCK = '"+hitungStockVelg+"' WHERE PART_ID = 'PT001';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStockBarang);

                string sqlInputUsePart = "INSERT INTO USE_PART VALUES ('"+dtDetailServID.Rows[0][0].ToString()+"','PT001'); ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputUsePart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else if(FormService.simpanDetailPilihanService == "Bumper")
            {
                hitungStockBumper = Convert.ToInt32(dtStockBarang.Rows[1][1].ToString()) - 1;

                sqlQuery = "UPDATE SPAREPARTS SET STOCK = '" + hitungStockBumper + "' WHERE PART_ID = 'PT002';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStockBarang);

                string sqlInputUsePart = "INSERT INTO USE_PART VALUES ('" + dtDetailServID.Rows[0][0].ToString() + "','PT002'); ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputUsePart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else if (FormService.simpanDetailPilihanService == "Wiper Blade")
            {
                hitungStockWiperBlade = Convert.ToInt32(dtStockBarang.Rows[2][1].ToString()) - 1;

                sqlQuery = "UPDATE SPAREPARTS SET STOCK = '" + hitungStockWiperBlade + "' WHERE PART_ID = 'PT003';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStockBarang);

                string sqlInputUsePart = "INSERT INTO USE_PART VALUES ('" + dtDetailServID.Rows[0][0].ToString() + "','PT003'); ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputUsePart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else if (FormService.simpanDetailPilihanService == "Spion")
            {
                hitungStockSpion = Convert.ToInt32(dtStockBarang.Rows[3][1].ToString()) - 1;

                sqlQuery = "UPDATE SPAREPARTS SET STOCK = '" + hitungStockSpion + "' WHERE PART_ID = 'PT004';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStockBarang);

                string sqlInputUsePart = "INSERT INTO USE_PART VALUES ('" + dtDetailServID.Rows[0][0].ToString() + "','PT004'); ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputUsePart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else if (FormService.simpanDetailPilihanService == "Ban")
            {
                hitungStockBan = Convert.ToInt32(dtStockBarang.Rows[4][1].ToString()) - 1;

                sqlQuery = "UPDATE SPAREPARTS SET STOCK = '" + hitungStockBan + "' WHERE PART_ID = 'PT005';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStockBarang);

                string sqlInputUsePart = "INSERT INTO USE_PART VALUES ('" + dtDetailServID.Rows[0][0].ToString() + "','PT005'); ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputUsePart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else if (FormService.simpanDetailPilihanService == "Lampu")
            {
                hitungStockLampu = Convert.ToInt32(dtStockBarang.Rows[5][1].ToString()) - 1;

                sqlQuery = "UPDATE SPAREPARTS SET STOCK = '" + hitungStockVelg + "' WHERE PART_ID = 'PT006';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtStockBarang);

                string sqlInputUsePart = "INSERT INTO USE_PART VALUES ('" + dtDetailServID.Rows[0][0].ToString() + "','PT006'); ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputUsePart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }

            else
            {

            }

            MessageBox.Show("Terimakasih telah mempercayakan kendaraan anda kepada kami!");
            this.Close();
        }
    }
}
