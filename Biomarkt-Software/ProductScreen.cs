using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biomarkt_Software
{
    public partial class ProductScreen : Form
    {

        private SqlConnection databaseConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\marco\Documents\Biomarkt-Software.mdf;Integrated Security=True;Connect Timeout=30");

        public ProductScreen()
        {
            InitializeComponent();

            //Start
            databaseConnection.Open();

            string query = "SELECT * FROM Products";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, databaseConnection);

            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);

            productsDGV.DataSource = dataSet.Tables[0];
            productsDGV.Columns[0].Visible = false; //ID
            productsDGV.Columns[1].HeaderText = "Produkt"; //ID
            productsDGV.Columns[2].HeaderText = "Marke"; //ID
            productsDGV.Columns[3].HeaderText = "Katergorie"; //ID
            productsDGV.Columns[4].HeaderText = "Preis €"; //ID

            databaseConnection.Close();
        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            string productName = textBoxProductName.Text;
            Console.WriteLine(productName);
        }

        private void btnProductEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnProductClear_Click(object sender, EventArgs e)
        {

        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
