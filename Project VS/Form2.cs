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
        string simpanServiceGantiPart;
        public FormService()
        {
            InitializeComponent();
        }

        

        private void FormService_Load(object sender, EventArgs e)
        {

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

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }
  
            else if (comboBoxPilihanService.SelectedIndex == 6)
            {
                comboBoxServiceBerkala.Visible = false;
                comboBoxGantiPart.Visible = true;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
            }

            else if (comboBoxPilihanService.SelectedIndex == 4)
            {
                comboBoxServiceBerkala.Visible = false;
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = true;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = false;

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
            }

            else if (comboBoxPilihanService.SelectedIndex == 2)
            {
                comboBoxServiceBerkala.Visible = false;
                comboBoxGantiPart.Visible = false;
                comboBoxOli.Visible = false;
                comboBoxRepaint.Visible = false;
                comboBoxGantiFilter.Visible = false;
                comboBoxOli.Visible = true;

                simpanPilihanService = comboBoxPilihanService.SelectedItem.ToString();
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
            }

            
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
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
