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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text == "manager" && textBoxPassword.Text == "manager")
            {
                this.Hide();
                FormReStock bukaformReStock = new FormReStock();
                bukaformReStock.ShowDialog();
            }
            else
            {
                MessageBox.Show("ID atau Password yang dimasukkan Salah !");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormWelcome BukaFormWelcome = new FormWelcome();
            BukaFormWelcome.ShowDialog();
        }
    }
}
