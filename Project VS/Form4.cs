using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_VS
{
    public partial class FormInputCostumer : Form
    {
        string simpanNama;
        string simpanAlamat;
        string simpanNoHp;
        string simpanMerkMobil;
        string simpanNoPol;
        public FormInputCostumer()
        {
            InitializeComponent();
        }

        private void buttonInputDataCust_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Data Sudah Lengkap dan tersimpan");
            this.Hide();
            FormInvoice BukaFormInvoice = new FormInvoice();
            BukaFormInvoice.ShowDialog();
        }

        public void dataCostumer(int posisi) //????
        {
            simpanNama = labelNamaCust.Text;
            simpanAlamat = labelAlamatCust.Text;
            simpanNoHp = labelPhone.Text;
            simpanMerkMobil = labelTypeMobil.Text;
            simpanNoPol = labelNoPolCost.Text;
        }
    }
}
