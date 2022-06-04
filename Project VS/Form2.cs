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
        private void FormService_Load(object sender, EventArgs e)
        {
            sqlQuery = "";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLayanan);
            dgvTabelLayanan.DataSource = dtLayanan;
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
                comboBoxServiceBerkala.Visible = true;
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
            }
  
            else if (comboBoxPilihanService.SelectedIndex == 6)
            {
                comboBoxServiceBerkala.Visible = false;
                comboBoxGantiPart.Visible = true;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
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

            else if (comboBoxPilihanService.SelectedIndex == 4)
            {
                comboBoxServiceBerkala.Visible = false;
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
                comboBoxServiceBerkala.Visible = false;
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
                comboBoxServiceBerkala.Visible = false;
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
                comboBoxServiceBerkala.Visible = false;
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();

                sqlQuery = "SELECT Pegawai_Nama, pegawai_id FROM pegawai WHERE layanan_id != '001' and layanan_id != '003'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawaiUmum);

                comboBoxPegawai.DataSource = dtPegawaiUmum;
                comboBoxPegawai.DisplayMember = "pegawai_nama";
                comboBoxPegawai.ValueMember = "pegawai_ID";
            }
            
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            /*simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();

            if (comboBoxGantiPart.Visible = true)
            {
                simpanServiceGantiPart = comboBoxGantiPart.SelectedItem.ToString();
            }
            else if (comboBoxOli.Visible = true)
            {
                simpanGantiOli = comboBoxOli.SelectedItem.ToString();
            }
            else if (comboBoxRepaint.Visible = true)
            {
                simpanBodyRepaint = comboBoxRepaint.SelectedItem.ToString();
            }
            else if (comboBoxGantiFilter.Visible = true)
            {
                simpanGantiFilter = comboBoxGantiFilter.SelectedItem.ToString();
            }*/


            MessageBox.Show("Berikut adalah stock yang tersedia ! \nJika Barang yang dibutuhkan kosong, silahkan menunggu 3 hari.");
            this.Hide();

            FormCheckStock BukaFormStock = new FormCheckStock();
            BukaFormStock.ShowDialog();

        }

        /*public void dataService(int posisi)
        {
            if(comboBoxPilihanService.SelectedIndex == 0)
            {
                simpanServiceBerkala = "Service Berkala " + comboBoxServiceBerkala.Text;
            }
            else if(comboBoxPilihanService.SelectedIndex == 3)
            {
                simpanServiceBerkala = comboBoxGantiPart.Text;
            }
            else
            {
                simpanServiceBerkala = comboBoxPilihanService.Text;
            }
        }*/

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }
    }
}
