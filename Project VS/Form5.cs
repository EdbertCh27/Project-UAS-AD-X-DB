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
    public partial class FormInvoice : Form
    {
        public FormInvoice()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=servicehonda");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtCustomerID = new DataTable();

        string pilianService = FormService.simpanPilihanService;

        public void FormInvoice_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT customer_ID FROM customer ORDER BY 1 DESC limit 1 ;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtCustomerID);

            labelIsiCodeCost.Text = dtCustomerID.Rows[0][0].ToString();
            labelIsiCustomerName.Text = FormInputCostumer.simpanNama;
            labelIsiService.Text = pilianService;
            labelIsiTypeMobil.Text = FormInputCostumer.simpanTypeMobil;
            labelIsiNoPol.Text = FormInputCostumer.simpanNoPol;
            labelUsePart.Text = FormService.simpanServiceGantiPart;
            labelTotalHarga.Text = FormService.simpanHargaService.ToString();
            labelUsePart.Text = FormService.simpanServiceGantiPart;

        }

        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
