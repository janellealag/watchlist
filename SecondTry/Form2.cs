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

namespace SecondTry
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=dcm;uid=root;";
            cnn = new MySqlConnection(connetionString);

            try
            {
                cnn.Open();
                string query = "Select * from tblwatchlist order by userid desc limit 1";
                MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();

                while (MyReader2.Read())
                {
                    int newID = Convert.ToInt32(String.Format("{0}", MyReader2[0])) + 1;
                    userID.Text = newID.ToString();
                }
            }
            catch (Exception ec)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtMname.Clear();
            txtOther.Clear();
            txtComplainant.Clear();
            txtViolation.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=dcm;uid=root;";
            cnn = new MySqlConnection(connetionString);

            try
            {
                if (this.txtFname.Text=="" || this.txtLname.Text=="" || this.txtComplainant.Text=="" || this.txtViolation.Text == "")
                {
                    MessageBox.Show("You must fill the required fields!");
                }
                else
                {
                    cnn.Open();

                    string query = "Insert into tblWatchlist (lastname, firstname, othername, middlename, bdate, violation, cmplainant) values ('" + this.txtLname.Text + "', '" + this.txtFname.Text + "', '" + this.txtOther.Text + "', '" + this.txtMname.Text + "', '" + this.dateBirthdate.Value.Date.ToString("yyyy-MM-dd") + "', '" + this.txtViolation.Text + "', '" + this.txtComplainant.Text + "')";

                    MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();

                    MessageBox.Show("Successful!");
                    Form1 f1 = (Form1)Application.OpenForms["Form1"];
                    f1.loaddata();
                    this.Close();
                }
                             

            }
            catch (Exception ex)
            {

            }
            
            
           
            
        }
    }
}
