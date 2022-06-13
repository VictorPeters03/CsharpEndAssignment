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
    public partial class TotalContrib : Form
    {
        MySqlConnection conn;
        private School deKubus;

        public TotalContrib()
        {
            InitializeComponent();
            string server = "localhost";
            string database = "parentalcontribution";
            string username = "root";
            string password = "";
            string port = "3306";
            try
            {
                conn = new MySqlConnection($"server={server};database={database};username={username};password={password};port={port}");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.deKubus = new School("De Kubus");

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

        private School getSchool()
        {
            return this.deKubus;
        }

        private void TotalContrib_Load(object sender, EventArgs e)
        {
            infoLabel.Text = String.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalContribution = getSchool().calculateTotalContribution();
            int youngestStudentAge = getSchool().getYoungestStudent().calculateAge();
            int[] childrenPerCategory = new int[3];
            foreach (Category category in getSchool().Categories)
            {
                childrenPerCategory.Append(category.Students.Count);
            }
            infoLabel.Text += $"Total contribution: {totalContribution}\n";
            infoLabel.Text += $"Youngest student's age: {youngestStudentAge}\n";
            infoLabel.Text += $"Children per category: \n";
            infoLabel.Text += $"under 6: {childrenPerCategory[0]}\n";
            infoLabel.Text += $"between 6 and 10: {childrenPerCategory[1]}\n";
            infoLabel.Text += $"10 and up: {childrenPerCategory[2]}\n";
        }
    }
}
