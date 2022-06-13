using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parentalContribution
{
    public partial class Contrib : Form
    {
        MySqlConnection conn;
        public Contrib()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "parentalcontribution";
            string username = "root";
            string password = "";
            string port = "3306";
            try
            {
                this.conn = new MySqlConnection($"server={server};database={database};username={username};password={password};port={port}");
                this.conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void contrib_Load(object sender, EventArgs e)
        {
            resultContrib.Text = String.Empty;
        }

        private void submitContrib_Click(object sender, EventArgs e)
        {
            double price;
            string query = $"SELECT yearofBirth, monthOfBirth, dayOfBirth FROM `students` WHERE name = " + "'" + nameBox.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "students");
            DataTable dt = ds.Tables["students"];
            if (new Student(nameBox.Text, Convert.ToInt32(dt.Rows[0]["yearOfBirth"]), Convert.ToInt32(dt.Rows[0]["monthOfBirth"]), Convert.ToInt32(dt.Rows[0]["dayOfBirth"])).calculateAge() < 6)
            {
                price = 38;
            }
            else if (new Student(nameBox.Text, Convert.ToInt32(dt.Rows[0]["yearOfBirth"]), Convert.ToInt32(dt.Rows[0]["monthOfBirth"]), Convert.ToInt32(dt.Rows[0]["dayOfBirth"])).calculateAge() >= 6 && new Student(nameBox.Text, Convert.ToInt32(dt.Rows[0]["yearOfBirth"]), Convert.ToInt32(dt.Rows[0]["monthOfBirth"]), Convert.ToInt32(dt.Rows[0]["dayOfBirth"])).calculateAge() < 10)
            {
                price = 50;
            }
            else
            {
                price = 65;
            }
            resultContrib.Text = $"Name: {nameBox.Text}\nParental Contribution: {price}";
        }
    }
}
