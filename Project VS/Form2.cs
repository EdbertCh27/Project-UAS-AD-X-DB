﻿using System;
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
        public static string simpanPilihanService;
        public static string simpanDetailPilihanService;
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

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_06_SERVICEMOBIL");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtPegawai = new DataTable();
        DataTable dtLayanan = new DataTable();

        DataTable dtDataServiceSekarang = new DataTable();
        DataTable dtDataDetailServiceSekarang = new DataTable();

        private void FormService_Load(object sender, EventArgs e)
        {

            sqlQuery = "SELECT LAYANAN_NAMA AS 'Jenis Layanan', LAYANAN_BIAYA AS 'Biaya', PART_NAMA AS 'Part', PART_HARGA AS 'Harga Part' FROM LAYANAN;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtLayanan);
            dgvTabelLayanan.DataSource = dtLayanan;


            sqlQuery = "SELECT * FROM TRANS_SERVICE;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataServiceSekarang);

            sqlQuery = "SELECT * FROM DETAIL_SERVICE;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtDataDetailServiceSekarang);

            comboBoxPilihanService.SelectedIndex = 0;
            comboBoxPegawai.SelectedIndex = 0;

            hitungJumlahService = Convert.ToInt32(dtDataServiceSekarang.Rows.Count) + 1;
            hitungDetailService = Convert.ToInt32(dtDataDetailServiceSekarang.Rows.Count) + 1;
            FormInputCostumer.hitungJumlahCust = Convert.ToInt32(dtDataDetailServiceSekarang.Rows.Count) + 1;

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

        public void pilihanOli()
        {
            if (comboBoxOli.SelectedIndex == 0)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 003";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "003";
                simpanHargaService = 100000;
                simpanDetailPilihanService = comboBoxOli.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
            else if (comboBoxOli.SelectedIndex == 1)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 004";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "004";
                simpanHargaService = 75000;
                simpanDetailPilihanService = comboBoxOli.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
        }

        public void pilihanPart()
        {
            if (comboBoxGantiPart.SelectedIndex == 0)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 013";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";

                simpanHargaService = 550000;
                simpanDetailPilihanService = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "013";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();

            }

            else if (comboBoxGantiPart.SelectedIndex == 1)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 014";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";

                simpanHargaService = 650000;
                simpanDetailPilihanService = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "014";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();

            }

            else if (comboBoxGantiPart.SelectedIndex == 2)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 015";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";

                simpanHargaService = 225000;
                simpanDetailPilihanService = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "015";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 3)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 016";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";

                simpanHargaService = 325000;
                simpanDetailPilihanService = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "016";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 4)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 017";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";

                simpanHargaService = 1200000;
                simpanDetailPilihanService = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "017";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiPart.SelectedIndex == 5)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 018";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";

                simpanHargaService = 400000;
                simpanDetailPilihanService = comboBoxGantiPart.SelectedItem.ToString();
                simpanIDLayanan = "018";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
        }

        public void pilihanRepaint()
        {
            if (comboBoxRepaint.SelectedIndex == 0)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 006";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "006";
                simpanHargaService = 500000;
                simpanDetailPilihanService = comboBoxRepaint.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
            else if (comboBoxRepaint.SelectedIndex == 1)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 007";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "007";
                simpanHargaService = 500000;
                simpanDetailPilihanService = comboBoxRepaint.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxRepaint.SelectedIndex == 2)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 008";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "008";
                simpanHargaService = 500000;
                simpanDetailPilihanService = comboBoxRepaint.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxRepaint.SelectedIndex == 3)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 009";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "009";
                simpanHargaService = 500000;
                simpanDetailPilihanService = comboBoxRepaint.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxRepaint.SelectedIndex == 4)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 010";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "010";
                simpanHargaService = 500000;
                simpanDetailPilihanService = comboBoxRepaint.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxRepaint.SelectedIndex == 5)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 011";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "011";
                simpanHargaService = 500000;
                simpanDetailPilihanService = comboBoxRepaint.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
        }
        public void pilihanFilter()
        {
            if (comboBoxGantiFilter.SelectedIndex == 0)
            {

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 022";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "022";
                simpanHargaService = 150000;
                simpanDetailPilihanService = comboBoxGantiFilter.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiFilter.SelectedIndex == 1)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 023";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "023";
                simpanHargaService = 250000;
                simpanDetailPilihanService = comboBoxGantiFilter.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxGantiFilter.SelectedIndex == 2)
            {
                dtPegawai.Clear();
                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 024";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                simpanIDLayanan = "024";
                simpanHargaService = 200000;
                simpanDetailPilihanService = comboBoxGantiFilter.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }
        }

        public void comboBoxPilihanService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPilihanService.SelectedIndex == 0)
            {
                dtPegawai.Clear();
                simpanPegawaiID = "";
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 001";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;

                simpanDetailPilihanService = "";
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                simpanHargaService = 250000;
                simpanIDLayanan = "001";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 1)
            {
                dtPegawai.Clear();
                simpanPegawaiID = "";
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 002";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;
                simpanDetailPilihanService = "";
                simpanHargaService = 150000;
                simpanIDLayanan = "002";
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 2)
            {
                dtPegawai.Clear();
                simpanPegawaiID = "";
                comboBoxGantiPart.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = true;
                simpanDetailPilihanService = "";
                pilihanOli();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                comboBoxOli.SelectedIndex = 0;
                comboBoxPegawai.SelectedIndex = 0;

            }

            else if (comboBoxPilihanService.SelectedIndex == 3)
            {
                dtPegawai.Clear();
                simpanPegawaiID = "";
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 005";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;
                simpanDetailPilihanService = "";
                simpanHargaService = 50000;
                simpanIDLayanan = "005";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 4)
            {
                dtPegawai.Clear();
                simpanPegawaiID = "";
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = true;
                comboBoxGantiFilter.Visible = false;
                simpanDetailPilihanService = "";
                pilihanRepaint();
                comboBoxRepaint.SelectedIndex = 0;
                comboBoxPegawai.SelectedIndex = 0;
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 5)
            {
                dtPegawai.Clear();
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 012";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;
                simpanDetailPilihanService = "";
                simpanHargaService = 1000000;
                simpanIDLayanan = "012";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 6)
            {
                dtPegawai.Clear();
                comboBoxGantiPart.Visible = true;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                simpanDetailPilihanService = "";
                pilihanPart();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                comboBoxGantiPart.SelectedIndex = 0;
                comboBoxPegawai.SelectedIndex = 0;

            }

            else if (comboBoxPilihanService.SelectedIndex == 7)
            {
                dtPegawai.Clear();
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 019";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;
                simpanDetailPilihanService = "";
                simpanHargaService = 2500000;
                simpanIDLayanan = "019";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 8)
            {
                dtPegawai.Clear();
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 020";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;
                simpanDetailPilihanService = "";
                simpanHargaService = 750000;
                simpanIDLayanan = "020";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 9)
            {
                dtPegawai.Clear();
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                sqlQuery = "SELECT PEGAWAI_NAMA, PEGAWAI_ID FROM PEGAWAI WHERE LAYANAN_ID = 021";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtPegawai);

                comboBoxPegawai.DataSource = dtPegawai;
                comboBoxPegawai.DisplayMember = "PEGAWAI_NAMA";
                comboBoxPegawai.ValueMember = "PEGAWAI_ID";
                comboBoxPegawai.SelectedIndex = 0;
                simpanDetailPilihanService = "";
                simpanHargaService = 5500000;
                simpanIDLayanan = "021";
                simpanPegawaiID = comboBoxPegawai.SelectedValue.ToString();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }


            else if (comboBoxPilihanService.SelectedIndex == 10)
            {
                dtPegawai.Clear();
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = true;
                simpanDetailPilihanService = "";
                pilihanFilter();
                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
                comboBoxGantiFilter.SelectedIndex = 0;
                comboBoxPegawai.SelectedIndex = 0;
            }

        }

        private void comboBoxGantiPart_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPegawai.Clear();
            pilihanPart();
        }

        private void comboBoxOli_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPegawai.Clear();
            pilihanOli();
        }

        private void comboBoxRepaint_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPegawai.Clear();
            pilihanRepaint();
        }

        private void comboBoxGantiFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPegawai.Clear();
            pilihanFilter();   
        }


        private void buttonInput_Click(object sender, EventArgs e)
        {
            
            if(textBoxKiloMeterMobil.Text == "" || textBoxMobilKeteranganWarna.Text == "")
            {
                MessageBox.Show("Data belum lengkap !!");
            }
            else
            {
                if (dtDataServiceSekarang.Rows.Count + 1 < 10)
                {
                    string sqlInputService = "INSERT INTO TRANS_SERVICE VALUES ('S00" + hitungJumlahService + "','C00" + FormInputCostumer.hitungJumlahCust + "',str_to_date('" + simpanTanggal + "','%d-%m-%Y'),'05:00:00','" + simpanHargaService + "','" + textBoxKiloMeterMobil.Text + "','" + textBoxMobilKeteranganWarna.Text + "','0');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputService, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    string sqlInputDetailService = "INSERT INTO DETAIL_SERVICE VALUES('DS00" + hitungDetailService + "','" + simpanIDLayanan + "','" + simpanPegawaiID + "','S00" + hitungJumlahService + "',str_to_date('" + simpanTanggal + "','%d-%m-%Y'), str_to_date('" + simpanTanggalSelesai + "','%d-%m-%Y'),false,'" + simpanHargaService + "','0');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputDetailService, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                else if (dtDataServiceSekarang.Rows.Count + 1 >= 10)
                {
                    string sqlInputService = "INSERT INTO TRANS_SERVICE VALUES ('S0" + hitungJumlahService + "','C0" + FormInputCostumer.hitungJumlahCust + "',str_to_date('" + simpanTanggal + "','%d-%m-%Y'),'05:00:00','" + simpanHargaService + "','" + textBoxKiloMeterMobil.Text + "','" + textBoxMobilKeteranganWarna.Text + "','0');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputService, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    string sqlInputDetailService = "INSERT INTO DETAIL_SERVICE VALUES('DS0" + hitungDetailService + "','" + simpanIDLayanan + "','" + simpanPegawaiID + "','S0" + hitungJumlahService + "',str_to_date('" + simpanTanggal + "','%d-%m-%Y'), str_to_date('" + simpanTanggalSelesai + "','%d-%m-%Y'),false,'" + simpanHargaService + "','0');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputDetailService, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                else if (dtDataServiceSekarang.Rows.Count + 1 >= 100)
                {
                    string sqlInputService = "INSERT INTO TRANS_SERVICE VALUES ('S" + hitungJumlahService + "','C" + FormInputCostumer.hitungJumlahCust + "',str_to_date('" + simpanTanggal + "','%d-%m-%Y'),'05:00:00','" + simpanHargaService + "','" + textBoxKiloMeterMobil.Text + "','" + textBoxMobilKeteranganWarna.Text + "','0');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputService, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();

                    string sqlInputDetailService = "INSERT INTO DETAIL_SERVICE VALUES('DS" + hitungDetailService + "','" + simpanIDLayanan + "','" + simpanPegawaiID + "','S" + hitungJumlahService + "',str_to_date('" + simpanTanggal + "','%d-%m-%Y'), str_to_date('" + simpanTanggalSelesai + "','%d-%m-%Y'),false,'" + simpanHargaService + "','0');";
                    sqlConnect.Open();
                    sqlCommand = new MySqlCommand(sqlInputDetailService, sqlConnect);
                    sqlCommand.ExecuteNonQuery();
                    sqlConnect.Close();
                }

                if (simpanDetailPilihanService == "Velg" || simpanDetailPilihanService == "Bumper" || simpanDetailPilihanService == "Wiper Blade" || simpanDetailPilihanService == "Spion" || simpanDetailPilihanService == "Ban" || simpanDetailPilihanService == "Lampu")
                {
                    this.Hide();
                    FormCheckStock BukaFormStock = new FormCheckStock();
                    BukaFormStock.ShowDialog();
                }
                else
                {
                    this.Hide();
                    MessageBox.Show("INVOICE");

                    FormInvoice bukaFormInvoice = new FormInvoice();
                    bukaFormInvoice.ShowDialog();
                }
            }
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void textBoxKiloMeterMobil_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}