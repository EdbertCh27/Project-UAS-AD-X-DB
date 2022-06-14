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
    public partial class FormReStock : Form
    {
        public FormReStock()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_06_SERVICEMOBIL");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtStokPartSkrg = new DataTable();
        DataTable dtSupplier = new DataTable();
        DataTable dtHistory = new DataTable();
        DataTable dtTransPembelian = new DataTable();
        DataTable dtHitungStockSekarang = new DataTable();

        string PartID;
        string supplierID;
        public static int simpanQty;
        public static int hitungJumlahBeliID;
        public static int hargaPart;
        public static int hitungTotal;
        public static string tanggalBeli;
        public static int hitungStockSekarang;
        

        public void reset()
        {
            dtStokPartSkrg = new DataTable();
            dtSupplier = new DataTable();
            dtHistory = new DataTable();
        }

        public void refresh()
        {
            reset();
            pilihanPart();

            sqlQuery = "SELECT PART_ID, PART_NAMA AS 'PART', concat(PART_STOCK, ' Buah') AS 'STOCK AVAILABLE' FROM SPAREPARTS";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStokPartSkrg);
            DGVStock.DataSource = dtStokPartSkrg;

            sqlQuery = "SELECT * FROM TRANS_PEMBELIAN;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTransPembelian);

            sqlQuery = "SELECT PART_STOCK FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHitungStockSekarang);

            
            comboBoxPilihPart.SelectedIndex = 0;
            NUDQtyPart.Value = 1;
            hitungJumlahBeliID++;
        }

        public void pilihanPart()
        {
            if(comboBoxPilihPart.SelectedIndex == 0)
            {
                PartID = "PT001";
                supplierID = "SP001";
                hargaPart = 350000;
                hitungStockSekarang = Convert.ToInt32(dtHitungStockSekarang.Rows[0][0]);
                simpanQty = Convert.ToInt32(NUDQtyPart.Value);
                labelHarga.Text = hargaPart.ToString();
                hitungTotal = hargaPart * simpanQty;
                labelTotal.Text = hitungTotal.ToString();
                NUDQtyPart.Enabled = true;
            }
            else if(comboBoxPilihPart.SelectedIndex == 1)
            {
                PartID = "PT002";
                supplierID = "SP002";
                hargaPart = 500000;
                hitungStockSekarang = Convert.ToInt32(dtHitungStockSekarang.Rows[1][0]);
                simpanQty = Convert.ToInt32(NUDQtyPart.Value);
                labelHarga.Text = hargaPart.ToString();
                hitungTotal = hargaPart * simpanQty;
                labelTotal.Text = hitungTotal.ToString();
                NUDQtyPart.Enabled = true;
            }
            else if (comboBoxPilihPart.SelectedIndex == 2)
            {
                PartID = "PT003";
                supplierID = "SP003";
                hargaPart = 150000;
                hitungStockSekarang = Convert.ToInt32(dtHitungStockSekarang.Rows[2][0]);
                simpanQty = Convert.ToInt32(NUDQtyPart.Value);
                labelHarga.Text = hargaPart.ToString();
                hitungTotal = hargaPart * simpanQty;
                labelTotal.Text = hitungTotal.ToString();
                NUDQtyPart.Enabled = true;
            }
            else if (comboBoxPilihPart.SelectedIndex == 3)
            {
                PartID = "PT004";
                supplierID = "SP004";
                hargaPart = 250000;
                hitungStockSekarang = Convert.ToInt32(dtHitungStockSekarang.Rows[3][0]);
                simpanQty = Convert.ToInt32(NUDQtyPart.Value);
                labelHarga.Text = hargaPart.ToString();
                hitungTotal = hargaPart * simpanQty;
                labelTotal.Text = hitungTotal.ToString();
                NUDQtyPart.Enabled = true;
            }
            else if (comboBoxPilihPart.SelectedIndex == 4)
            {
                PartID = "PT005";
                supplierID = "SP005";
                hargaPart = 1000000;
                hitungStockSekarang = Convert.ToInt32(dtHitungStockSekarang.Rows[4][0]);
                simpanQty = Convert.ToInt32(NUDQtyPart.Value);
                labelHarga.Text = hargaPart.ToString();
                hitungTotal = hargaPart * simpanQty;
                labelTotal.Text = hitungTotal.ToString();
                NUDQtyPart.Enabled = true;
            }
            else if (comboBoxPilihPart.SelectedIndex == 5)
            {
                PartID = "PT006";
                supplierID = "SP006";
                hargaPart = 300000;
                hitungStockSekarang = Convert.ToInt32(dtHitungStockSekarang.Rows[5][0]);
                simpanQty = Convert.ToInt32(NUDQtyPart.Value);
                labelHarga.Text = hargaPart.ToString();
                hitungTotal = hargaPart * simpanQty;
                labelTotal.Text = hitungTotal.ToString();
                NUDQtyPart.Enabled = true;
            }
        }

        private void FormReStock_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT PART_ID, PART_NAMA AS 'PART', concat(PART_STOCK, ' Buah') AS 'STOCK AVAILABLE' FROM SPAREPARTS";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStokPartSkrg);
            DGVStock.DataSource = dtStokPartSkrg;

            sqlQuery = "SELECT * FROM TRANS_PEMBELIAN;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTransPembelian);

            sqlQuery = "SELECT PART_STOCK FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHitungStockSekarang);

            pilihanPart();
            comboBoxPilihPart.SelectedIndex = 0;

            tanggalBeli = DateTime.Now.ToString().Substring(0, 10).Replace("/", "-");
            hitungJumlahBeliID = Convert.ToInt32(dtTransPembelian.Rows.Count) + 1;
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome bukaFormWelcome = new FormWelcome();
            bukaFormWelcome.ShowDialog();
        }

        private void buttonCheckStockSkrg_Click(object sender, EventArgs e)
        {
            reset();
            labelHistory.Visible = false;
            labelSTOCKSEKARANG.Visible = true;
            labelTabelHarga.Visible = false;
            sqlQuery = "SELECT PART_ID, PART_NAMA AS 'PART', concat(PART_STOCK, ' Buah') AS 'STOCK AVAILABLE' FROM SPAREPARTS";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtStokPartSkrg);
            DGVStock.DataSource = dtStokPartSkrg;
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            reset();
            labelHistory.Visible = true;
            labelSTOCKSEKARANG.Visible = false;
            labelTabelHarga.Visible = false;
            sqlQuery = "SELECT TP.BELI_ID AS 'BELI ID', SU.SUPPLIER_NAMA AS 'SUPPLIER', SU.PART_NAMA AS 'PART', TP.BELI_TGL AS 'TANGGAL TRANSAKSI', TP.BELI_QTY_PART AS 'QUANTITY', TP.BELI_TOTAL AS 'TOTAL' FROM DETAIL_BELI_PART DBP, TRANS_PEMBELIAN TP, SUPPLIER SU WHERE DBP.BELI_ID = TP.BELI_ID AND SU.SUPPLIER_ID = TP.SUPPLIER_ID ORDER BY 1;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHistory);
            DGVStock.DataSource = dtHistory;

        }

        private void buttonListHargaPart_Click(object sender, EventArgs e)
        {
            reset();
            labelHistory.Visible = false;
            labelSTOCKSEKARANG.Visible = false;
            labelTabelHarga.Visible = true;
            sqlQuery = "SELECT SU.SUPPLIER_ID AS 'SUPPLIER ID',SU.SUPPLIER_NAMA AS 'SUPPLIER', S.PART_NAMA AS 'PART', S.PART_HARGA AS 'HARGA/PCS' FROM SPAREPARTS S, SUPPLIER SU WHERE S.PART_NAMA = SU.PART_NAMA;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtSupplier);
            DGVStock.DataSource = dtSupplier;
        }

        private void comboBoxPilihPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            pilihanPart();
        }

        private void buttonAddStock_Click(object sender, EventArgs e)
        {
            if(dtTransPembelian.Rows.Count + 1 < 10)
            {
                string sqlInputTransBeli = "INSERT INTO TRANS_PEMBELIAN VALUES ('B00"+hitungJumlahBeliID+"','"+supplierID+ "', str_to_date('" + tanggalBeli + "','%d-%m-%Y'),'" + simpanQty+"','"+hitungTotal+"','0');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputTransBeli, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                string sqlInputDetailBeliPart = "INSERT INTO DETAIL_BELI_PART VALUES ('"+PartID+"','B00"+hitungJumlahBeliID+"');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputDetailBeliPart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                sqlQuery = "UPDATE SPAREPARTS SET PART_STOCK = '" + (hitungStockSekarang + simpanQty) + "' WHERE PART_ID = '"+PartID+"';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHitungStockSekarang);
            }
            else if(dtTransPembelian.Rows.Count + 1 >= 10)
            {
                string sqlInputTransBeli = "INSERT INTO TRANS_PEMBELIAN VALUES ('B0" + hitungJumlahBeliID + "','" + supplierID + "', str_to_date('" + tanggalBeli + "','%d-%m-%Y'),'" + simpanQty + "','" + hitungTotal + "','0');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputTransBeli, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                string sqlInputDetailBeliPart = "INSERT INTO DETAIL_BELI_PART VALUES ('" + PartID + "','B0" + hitungJumlahBeliID + "');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputDetailBeliPart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                sqlQuery = "UPDATE SPAREPARTS SET PART_STOCK = '" + (hitungStockSekarang + simpanQty) + "' WHERE PART_ID = '" + PartID + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHitungStockSekarang);
            }
            else if(dtTransPembelian.Rows.Count + 1 >= 100)
            {
                string sqlInputTransBeli = "INSERT INTO TRANS_PEMBELIAN VALUES ('B" + hitungJumlahBeliID + "','" + supplierID + "', str_to_date('" + tanggalBeli + "','%d-%m-%Y'),'" + simpanQty + "','" + hitungTotal + "','0');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputTransBeli, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                string sqlInputDetailBeliPart = "INSERT INTO DETAIL_BELI_PART VALUES ('" + PartID + "','B" + hitungJumlahBeliID + "');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputDetailBeliPart, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                sqlQuery = "UPDATE SPAREPARTS SET PART_STOCK = '" + (hitungStockSekarang + simpanQty) + "' WHERE PART_ID = '" + PartID + "';";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtHitungStockSekarang);
            }
            MessageBox.Show("Part Berhasil Dibeli");
            refresh();

        }

        private void NUDQtyPart_ValueChanged(object sender, EventArgs e)
        {
            pilihanPart();
        }
    }
}
