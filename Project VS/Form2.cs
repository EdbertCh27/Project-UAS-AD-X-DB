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
        
        public FormService()
        {
            InitializeComponent();
        }

        string simpanPilihanService;

        private void FormService_Load(object sender, EventArgs e)
        {

        }

        private void FormService_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void comboBoxPilihanService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPilihanService.SelectedIndex == 0)
                comboBoxServiceBerkala.Visible = true;
            
            else if (comboBoxPilihanService.SelectedIndex == 3)
                comboBoxGantiPart.Visible = true;

            else
                comboBoxServiceBerkala.Visible = false;
        }

        private void comboBoxKeluhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxKeluhan.SelectedIndex == 0)
                textBoxKeluhan.Visible = true;
            else
                textBoxKeluhan.Visible = false;
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Permintaanmu Sudah Tercatat, Silahkan Isi Data Diri");
            this.Hide();
            FormInputCostumer BukaFormInputCost = new FormInputCostumer();
            BukaFormInputCost.ShowDialog();
        }
    }
}
