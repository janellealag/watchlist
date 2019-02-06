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
    public partial class AddRecord : Form
    {
        
        MySqlConnection cnn;
        private string connetionString = "server=localhost;database=dcm;uid=root;";

        public AddRecord()
        {
            cnn = new MySqlConnection(connetionString);
            InitializeComponent();
        }
  

        private void bntBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFname.Clear();
            txtLname.Clear();
            txtMname.Clear();
            txtOther.Clear();
            txtComplainant.Clear();
            txtViolation.Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            try
            {
                if (this.txtFname.Text == "" || this.txtLname.Text == "" || this.txtComplainant.Text == "" || this.txtViolation.Text == "")
                {
                    MessageBox.Show("You must fill the required fields!");
                }
                else
                {
                    cnn.Open();

                    string query = "Insert into tblWatchlist (lastname, firstname, othername, middlename, bdate, violation, cmplainant, watchStat) values ('" + this.txtLname.Text + "', '" + this.txtFname.Text + "', '" + this.txtOther.Text + "', '" + this.txtMname.Text + "', '" + this.dateBirthdate.Value.Date.ToString("yyyy-MM-dd") + "', '" + this.txtViolation.Text + "', '" + this.txtComplainant.Text + "', '" + this.cmbStatus.Text + "')";

                    MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();

                    MessageBox.Show("Successful!");
                    
                    Homepage f1 = (Homepage)Application.OpenForms["Homepage"];
                    
                    f1.loaddata();
                    cnn.Close();
                    this.Close(); //form close
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void AddRecordForm_Load(object sender, EventArgs e)
        {
            cnn = new MySqlConnection(connetionString);

            // declare combobox values
            cmbStatus.Items.Add("Active");
            cmbStatus.Items.Add("Permanent Cleared");
            cmbStatus.Items.Add("Temporary Cleared");
            cmbStatus.SelectedIndex = 0;


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
                cnn.Close();
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
