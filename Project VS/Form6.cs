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
    public partial class FormCheckStock : Form
    {
        public FormCheckStock()
        {
            InitializeComponent();
        }

        private void FormCheckStock_Load(object sender, EventArgs e)
        {

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Silahkan Isi Data Costumer");
            this.Hide();
            FormInputCostumer BukaFormInputCost = new FormInputCostumer();
            BukaFormInputCost.ShowDialog();
        }
    }
}
