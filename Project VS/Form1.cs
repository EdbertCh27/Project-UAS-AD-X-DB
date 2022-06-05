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
    public partial class FormWelcome : Form
    {
        public FormWelcome()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormCheck BukaFormCheck = new FormCheck();
            BukaFormCheck.ShowDialog();
        }

        private void buttonService_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInputCostumer BukaFormInputCostumer = new FormInputCostumer();
            BukaFormInputCostumer.ShowDialog();

            //FormService BukaFormService = new FormService();
            //BukaFormService.ShowDialog();
        }
    }
}
