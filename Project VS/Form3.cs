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
    public partial class FormCheck : Form
    {
        public FormCheck()
        {
            InitializeComponent();
        }

        private void FormCheck_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void buttonBackToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }

        private void buttonCheckCostNum_Click(object sender, EventArgs e)
        {
            if(textBoxCheckCostNum.Text == "001") // GANTI CHECK QUERY
            {
                if(textBoxSelesai.Text == "Yes") //GANTI CHECK QUERY
                {
                    MessageBox.Show("Kendaraan Anda Telah Selesai di Service, Silahkan Datang Ambil Saat Jam Kerja, Senin-Sabtu 08.00-17.00");
                }
                if(textBoxSelesai.Text == "No") //GANTI CHECK QUERY
                {
                    MessageBox.Show("Kendaraan Anda Belum Selesai di Service, Mohon Tunggu Konfirmasi dari Pihak Kami");
                }
            }
            else
            {
                MessageBox.Show("Costumer Number tidak terdaftar !!");
            }
        }
    }
}
