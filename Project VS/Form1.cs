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
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=139.255.11.84;uid=student;pwd=isbmantap;database=DBD_06_SERVICEMOBIL");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtHitungBarang = new DataTable();

        private void FormWelcome_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT PART_STOCK FROM SPAREPARTS;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtHitungBarang);

            if (Convert.ToInt32(dtHitungBarang.Rows[0][0]) <= 0)
            {
                buttonCheckStock.BackColor = Color.Red;
            }
            if (Convert.ToInt32(dtHitungBarang.Rows[1][0]) <= 0)
            {
                buttonCheckStock.BackColor = Color.Red;
            }
            if (Convert.ToInt32(dtHitungBarang.Rows[2][0]) <= 0)
            {
                buttonCheckStock.BackColor = Color.Red;
            }
            if (Convert.ToInt32(dtHitungBarang.Rows[3][0]) <= 0)
            {
                buttonCheckStock.BackColor = Color.Red;
            }
            if (Convert.ToInt32(dtHitungBarang.Rows[4][0]) <= 0)
            {
                buttonCheckStock.BackColor = Color.Red;
            }
            if (Convert.ToInt32(dtHitungBarang.Rows[5][0]) <= 0)
            {
                buttonCheckStock.BackColor = Color.Red;
            }
        }

        private void buttonCheckStock_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin bukaFormLogin = new FormLogin();
            bukaFormLogin.ShowDialog();
        }
    }
}
