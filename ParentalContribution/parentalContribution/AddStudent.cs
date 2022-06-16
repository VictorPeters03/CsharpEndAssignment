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
using System.Threading;
using System.Threading.Tasks;

namespace parentalContribution
{
    public partial class AddStudent : Form
    {
        MySqlConnection conn;
        private Contrib contribution;
        private TotalContrib totalContrib;
        private School deKubus;
        public AddStudent()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            this.contribution = new Contrib();
            this.totalContrib = new TotalContrib();
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

        public void StartForm()
        {
            Application.Run(new SplashScreen());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameBox.Text = "Name";
            infoLabel.Text = String.Empty;
        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {
            if (nameBox.Text == "Name")
            {
                nameBox.Text = "";
            }
            resultContrib.Text = "";
        }

        private Contrib getContribution()
        {
            return this.contribution;
        }

        private TotalContrib getTotalContribution()
        {
            return this.totalContrib;
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


        private School getSchool()
        {
            return this.deKubus;
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();  
            about.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Show();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip2.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            double totalContribution = getSchool().calculateTotalContribution();
            int youngestStudentAge = getSchool().getYoungestStudent().calculateAge();
            List<int> childrenPerCategory = new List<int>();
            foreach (Category category in getSchool().Categories)
            {
                childrenPerCategory.Add(category.Students.Count);
            }
            infoLabel.Text = String.Empty;
            infoLabel.Text += $"Total contribution: {totalContribution}\n";
            infoLabel.Text += $"Youngest student's age: {youngestStudentAge}\n";
            infoLabel.Text += $"Children per category: \n";
            infoLabel.Text += $"under 6: {childrenPerCategory[0]}\n";
            infoLabel.Text += $"between 6 and 10: {childrenPerCategory[1]}\n";
            infoLabel.Text += $"10 and up: {childrenPerCategory[2]}\n";
        }

        private void submitContrib_Click_1(object sender, EventArgs e)
        {
            double price;
            string query3 = $"SELECT yearofBirth, monthOfBirth, dayOfBirth FROM `students` WHERE name = " + "'" + textBox1.Text + "'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query3, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "students");
            DataTable dt = ds.Tables["students"];
            if (new Student(textBox1.Text, Convert.ToInt32(dt.Rows[0]["yearOfBirth"]), Convert.ToInt32(dt.Rows[0]["monthOfBirth"]), Convert.ToInt32(dt.Rows[0]["dayOfBirth"])).calculateAge() < 6)
            {
                price = 38;
            }
            else if (new Student(textBox1.Text, Convert.ToInt32(dt.Rows[0]["yearOfBirth"]), Convert.ToInt32(dt.Rows[0]["monthOfBirth"]), Convert.ToInt32(dt.Rows[0]["dayOfBirth"])).calculateAge() >= 6 && new Student(nameBox.Text, Convert.ToInt32(dt.Rows[0]["yearOfBirth"]), Convert.ToInt32(dt.Rows[0]["monthOfBirth"]), Convert.ToInt32(dt.Rows[0]["dayOfBirth"])).calculateAge() < 10)
            {
                price = 50;
            }
            else
            {
                price = 65;
            }
            resultContrib.Text = $"Name: {textBox1.Text}\nParental Contribution: {price}";
        }



        private void showApp()
        {
            Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void hideApp()
        {
            Hide();
            notifyIcon1.Visible = true;
        }

        private void toolStripAddStudent_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["AddStudent1"];
        }

        private void toolStripContrib_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["GetContribution1"];
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TotalContrib1"];
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showApp();
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hideApp();
        }

        private void toolStripTotalContribution_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages["TotalContrib1"];
        }
    }
}
