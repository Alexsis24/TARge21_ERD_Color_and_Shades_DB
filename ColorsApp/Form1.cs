using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorsApp
{
    public partial class Form1 : Form
    {
        string connectionString;
        SqlConnection connection;
        public Form1()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["ColorsApp.Properties.Settings.colorsConnectionString"].ConnectionString;
        }
        private void FillPrimaryColorsTable()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM PrimaryColors", connection))
            {
                DataTable PrimaryColorsTable = new DataTable();
                adapter.Fill(PrimaryColorsTable);

                listPrimaryColors.DisplayMember = "PrimaryColorName";
                listPrimaryColors.ValueMember = "Id";
                listPrimaryColors.DataSource = PrimaryColorsTable;
            }
        }
        private void FillShadesColorsTable()
        {
            string query = "SELECT Shades.ColorName FROM PrimaryColors INNER JOIN Shades ON Shades.PrimaryColorId = PrimaryColors.Id WHERE PrimaryColors.Id = @PrimaryColorId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@PrimaryColorId", listPrimaryColors.SelectedValue);
                DataTable ShadesTable = new DataTable();
                adapter.Fill(ShadesTable);

                listShades.DisplayMember = "ColorName";
                listShades.ValueMember = "Id";
                listShades.DataSource = ShadesTable;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FillPrimaryColorsTable();
        }

        private void listShades_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void listPrimaryColors_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillShadesColorsTable();
        }
    }
}
