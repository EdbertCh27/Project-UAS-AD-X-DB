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
    public partial class FormService : Form
    {
        public static string simpanServiceBerkala;
        public static string simpanPilihanService;
        public static string simpanServiceGantiPart;
        public static string simpanGantiOli;
        public static string simpanBodyRepaint;
        public static string simpanGantiFilter;

        public static int hitungJumlahService;

        public static string simpanTanggal;

        public static int simpanHargaService;

        public static string simpanPegawaiID;

        public static int hitungDetailService;

        public static string simpanIDLayanan;

        public static string simpanTanggalSelesai;

        public FormService()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=servicehonda");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPegawaiSB = new DataTable();
        DataTable dtPegawaiOli = new DataTable();
        DataTable dtPegawaiUmum = new DataTable();

        DataTable dtLayanan = new DataTable();

        DataTable dtInputService = new DataTable();
        DataTable dtDataServiceSekarang = new DataTable();

        DataTable dtDataDetailServiceSekarang = new DataTable();

        private void FormService_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT layanan_nama AS 'Jenis Layanan', layanan_biaya AS 'Biaya', part_nama AS 'Part', biaya_pasang_part AS 'Harga Part' FROM layanan;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLayanan);
            dgvTabelLayanan.DataSource = dtLayanan;


            sqlQuery = "SELECT * FROM trans_service;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataServiceSekarang);

            sqlQuery = "SELECT * FROM detail_service;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataDetailServiceSekarang);

            hitungJumlahService = Convert.ToInt32(dtDataServiceSekarang.Rows.Count) + 1;
            hitungDetailService = Convert.ToInt32(dtDataDetailServiceSekarang.Rows.Count) + 1;

            labelCurrDate.Text = DateTime.Now.ToString().Substring(0, 10).Replace("/","-");
            simpanTanggal = DateTime.Now.ToString().Substring(0, 10).Replace("/","-");
            simpanTanggalSelesai = DateTime.Now.AddDays(1).ToString().Substring(0, 10).Replace("/", "-");
        }

        private void FormService_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        public void comboBoxPilihanService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPilihanService.SelectedIndex == 0)
            {
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 001";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                simpanHargaService = 250000;
                simpanIDLayanan = "001";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
  
            else if (comboBoxPilihanService.SelectedIndex == 6)
            {
                comboBoxGantiPart.Visible = true;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                
                if(comboBoxGantiPart.SelectedIndex == 0)
                {
                    sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 013";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPegawaiSB);

                    comboBoxPegawai.DataSource = dtPegawaiSB;
                    comboBoxPegawai.DisplayMember = "pegawai_nama";
                    comboBoxPegawai.ValueMember = "pegawai_ID";

                    simpanHargaService = 550000;
                    simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                    simpanIDLayanan = "013";
                    simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                }
                
                else if(comboBoxGantiPart.SelectedIndex == 1)
                {
                    sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 014";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPegawaiSB);

                    comboBoxPegawai.DataSource = dtPegawaiSB;
                    comboBoxPegawai.DisplayMember = "pegawai_nama";
                    comboBoxPegawai.ValueMember = "pegawai_ID";

                    simpanHargaService = 650000;
                    simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                    simpanIDLayanan = "014";
                    simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                }

                else if (comboBoxGantiPart.SelectedIndex == 2)
                {
                    sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 015";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPegawaiSB);

                    comboBoxPegawai.DataSource = dtPegawaiSB;
                    comboBoxPegawai.DisplayMember = "pegawai_nama";
                    comboBoxPegawai.ValueMember = "pegawai_ID";

                    simpanHargaService = 225000;
                    simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                    simpanIDLayanan = "015";
                    simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                }

                else if (comboBoxGantiPart.SelectedIndex == 3)
                {
                    sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 016";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPegawaiSB);

                    comboBoxPegawai.DataSource = dtPegawaiSB;
                    comboBoxPegawai.DisplayMember = "pegawai_nama";
                    comboBoxPegawai.ValueMember = "pegawai_ID";

                    simpanHargaService = 325000;
                    simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                    simpanIDLayanan = "016";
                    simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                }

                else if (comboBoxGantiPart.SelectedIndex == 4)
                {
                    sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 017";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPegawaiSB);

                    comboBoxPegawai.DataSource = dtPegawaiSB;
                    comboBoxPegawai.DisplayMember = "pegawai_nama";
                    comboBoxPegawai.ValueMember = "pegawai_ID";

                    simpanHargaService = 1200000;
                    simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                    simpanIDLayanan = "017";
                    simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                }

                else if (comboBoxGantiPart.SelectedIndex == 5)
                {
                    sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 018";
                    sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                    sqlAdapter = new MySqlDataAdapter(sqlCommand);
                    sqlAdapter.Fill(dtPegawaiSB);

                    comboBoxPegawai.DataSource = dtPegawaiSB;
                    comboBoxPegawai.DisplayMember = "pegawai_nama";
                    comboBoxPegawai.ValueMember = "pegawai_ID";

                    simpanHargaService = 400000;
                    simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                    simpanIDLayanan = "018";
                    simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                }

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();

            }

            else if (comboBoxPilihanService.SelectedIndex == 4)
            {
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = true;
                comboBoxGantiFilter.Visible = false;

                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 001";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 10)
            {
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = true;
                comboBoxOli.Visible = false;

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();

                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 001";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";
            }

            else if (comboBoxPilihanService.SelectedIndex == 2)
            {
                comboBoxGantiPart.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = true;

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();

                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 003";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiOli);

                comboBoxPegawai.DataSource = dtPegawaiOli;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";
            }

            else
            {
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                // simpanHargaService = 50;

                sqlQuery = "SELECT Pegawai_Nama, pegawai_id FROM pegawai WHERE layanan_id != '001' and layanan_id != '003'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiUmum);

                comboBoxPegawai.DataSource = dtPegawaiUmum;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";
            }
            
        }

        private void comboBoxGantiPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxGantiPart.SelectedIndex == 0)
            {
                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 013";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanHargaService = 550000;
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "013";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 1)
            {
                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 014";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanHargaService = 650000;
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "014";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 2)
            {
                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 015";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanHargaService = 225000;
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "015";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 3)
            {
                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 016";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanHargaService = 325000;
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "016";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 4)
            {
                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 017";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanHargaService = 1200000;
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "017";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 5)
            {
                sqlQuery = "SELECT Pegawai_Nama, pegawai_ID FROM pegawai WHERE layanan_id = 018";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiSB);

                comboBoxPegawai.DataSource = dtPegawaiSB;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";

                simpanHargaService = 400000;
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "018";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

        }

        private void buttonInput_Click(object sender, EventArgs e)
        {

            if (dtDataServiceSekarang.Rows.Count < 10)
            {
                string sqlInputService = "INSERT INTO trans_service VALUES ('S00"+hitungJumlahService+"','C00"+FormInputCostumer.hitungJumlahCust+"',str_to_date('"+simpanTanggal+"','%d-%m-%Y'),'01:00:00','"+simpanHargaService+"','"+textBoxKiloMeterMobil.Text+"','"+textBoxMobilKeteranganWarna.Text+"','0');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputService, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();

                string sqlInputDetailService = "INSERT INTO detail_service VALUES('DS00"+hitungDetailService+"','"+simpanIDLayanan+"','"+simpanPegawaiID+"','S00"+hitungJumlahService+"',str_to_date('"+simpanTanggal+"','%d-%m-%Y'), str_to_date('"+simpanTanggalSelesai+"','%d-%m-%Y'),false,'"+simpanHargaService+"','0');";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlInputDetailService, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            

            MessageBox.Show("Berikut adalah stock yang tersedia ! \nJika Barang yang dibutuhkan kosong, silahkan menunggu 3 hari.");
            this.Hide();

            FormCheckStock BukaFormStock = new FormCheckStock();
            BukaFormStock.ShowDialog();

        }


        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        
    }
}
