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

namespace parentalContribution
{
    public partial class AddStudent : Form
    {
        MySqlConnection conn;
        public AddStudent()
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

            School deKubus = new School("De Kubus");

            string query = "SELECT * FROM `categories`;";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, this.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "categories");
            DataTable dt = ds.Tables["categories"];

            Category underSix = new Category(dt.Rows[0]["name"].ToString(), Convert.ToDouble(dt.Rows[0]["price"]));
            Category fromSixToTen = new Category(dt.Rows[1]["name"].ToString(), Convert.ToDouble(dt.Rows[1]["price"]));
            Category tenAndUp = new Category(dt.Rows[2]["name"].ToString(), Convert.ToDouble(dt.Rows[2]["price"]));

            string query2 = "SELECT * FROM `students`;";
            MySqlDataAdapter adapter2 = new MySqlDataAdapter(query2, this.conn);
            DataSet ds2 = new DataSet();
            adapter2.Fill(ds2, "students");
            DataTable dt2 = ds2.Tables["students"];
            foreach (DataRow dr in dt2.Rows)
            {
                if (new Student(dr["name"].ToString(), Convert.ToInt32(dr["yearOfBirth"]), Convert.ToInt32(dr["monthOfBirth"]), Convert.ToInt32(dr["dayOfBirth"])).calculateAge() < 6)
                {
                    underSix.addStudent(new Student(dr["name"].ToString(), Convert.ToInt32(dr["yearOfBirth"]), Convert.ToInt32(dr["monthOfBirth"]), Convert.ToInt32(dr["dayOfBirth"])));
                }
                else if (new Student(dr["name"].ToString(), Convert.ToInt32(dr["yearOfBirth"]), Convert.ToInt32(dr["monthOfBirth"]), Convert.ToInt32(dr["dayOfBirth"])).calculateAge() > 6 && new Student(dr["name"].ToString(), Convert.ToInt32(dr["yearOfBirth"]), Convert.ToInt32(dr["monthOfBirth"]), Convert.ToInt32(dr["dayOfBirth"])).calculateAge() < 10)
                {
                    fromSixToTen.addStudent(new Student(dr["name"].ToString(), Convert.ToInt32(dr["yearOfBirth"]), Convert.ToInt32(dr["monthOfBirth"]), Convert.ToInt32(dr["dayOfBirth"])));
                }
                else
                {
                    tenAndUp.addStudent(new Student(dr["name"].ToString(), Convert.ToInt32(dr["yearOfBirth"]), Convert.ToInt32(dr["monthOfBirth"]), Convert.ToInt32(dr["dayOfBirth"])));
                }
            }
            deKubus.addCategories(underSix);
            deKubus.addCategories(fromSixToTen);
            deKubus.addCategories(tenAndUp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameBox.Text = "Name";
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (nameBox.Text == "Name")
            {
                nameBox.Text = "";
            }
        }

        private void yearBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dayBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            try
            {
                int category = 0;
                if (new Student(nameBox.Text, Convert.ToInt32(yearBox.Text), Convert.ToInt32(monthBox.Text), Convert.ToInt32(dayBox.Text)).calculateAge() < 6)
                {
                    category = 1;
                }
                else if (new Student(nameBox.Text, Convert.ToInt32(yearBox.Text), Convert.ToInt32(monthBox.Text), Convert.ToInt32(dayBox.Text)).calculateAge() >= 6 && new Student(nameBox.Text, Convert.ToInt32(yearBox.Text), Convert.ToInt32(monthBox.Text), Convert.ToInt32(dayBox.Text)).calculateAge() < 10)
                {
                    category = 2;
                }
                else
                {
                    category = 3;
                }
                string query = $"INSERT INTO `students` (`category_id`, `name`, `yearOfBirth`, `monthOfBirth`, `dayOfBirth`) VALUES ('{category}', '{nameBox.Text}', '{yearBox.Text}', '{monthBox.Text}', '{dayBox.Text}');";
                Console.WriteLine(query);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                resultLabel.Text = "Submit succesful";
            }
            catch (Exception ex)
            {
                resultLabel.Text = ex.Message;
            }
        }
    }
}
