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
    public partial class Form1 : Form
    {
        private int PgSize = 20;
        private int CurrentPageIndex = 1;
        private int TotalPage = 0;

        private string showing = "";

        public Form1()
        {
            
            try
            {
                InitializeComponent();
                //start
                initializeDataGrid(1, "All");
                CalculateTotalPages("All");
            }
            catch (Exception ees)
            {

            }
            
            


        }

        

        private void initializeDataGrid(int page, string filter)
        {
            DataSet ds = new DataSet();
            
            dataGridView1.AutoGenerateColumns = false;
             dataGridView1.DataSource = GetCurrentRecords(page, filter);
            //MessageBox.Show(GetCurrentRecords(page).Rows.Count.ToString());
           
            try
            {
                getSelectedRow();
            }
            catch (Exception ee)
            {

            }
        }



        private void CalculateTotalPages(string filter)
        {
            
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=dcm;uid=root;";
            cnn = new MySqlConnection(connetionString);
            int rowCount = 0;

            try
            {
                cnn.Open();
                string query = "";
                if (filter == "All")
                {
                    query = "Select * from tblwatchlist where watchstat <> 'FALSE' order by userid desc ";
                }
                else if (filter == "Active")
                {
                    query = "Select * from tblwatchlist where watchstat = 'Active' order by userid desc ";
                }
                else if (filter == "Permanent Cleared")
                {
                    query = "Select * from tblwatchlist where watchstat = 'Permanent Cleared' order by userid desc ";
                }
                else
                {
                    query = "Select * from tblwatchlist where watchstat = 'Temporary Cleared' order by userid desc ";
                }
                
                using (MySqlConnection conn = new MySqlConnection(connetionString))
                {
                    MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                    MySqlDataReader MyReader2;
                    MyReader2 = MyCommand2.ExecuteReader();


                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        rowCount = dt.Rows.Count;
                        
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //DataGridView dataGridView1 = new DataGridView();
            
            TotalPage = rowCount / PgSize;
            // if any row left after calculated pages, add one more page 
            
            if (rowCount % PgSize > 0)
                TotalPage += 1;

            // MessageBox.Show(TotalPage.ToString());
            txtPageCount.Text = "Showing "+CurrentPageIndex.ToString()+" out of "+TotalPage.ToString()+" pages";
        }

        private DataTable GetCurrentRecords(int page, string filter)
        {
            string connetionString = null;
            MySqlConnection cnn;
            connetionString = "server=localhost;database=dcm;uid=root;";
            cnn = new MySqlConnection(connetionString);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();

            string cmd = null;


            if (page == 1 && filter == "All")
            {
                
                cmd = "Select * from tblwatchlist where watchstat <> 'FALSE' order by userid desc LIMIT " + PgSize;
                                
            }
            else if (page == 1 && filter == "Active")
            {
                cmd = "Select * from tblwatchlist where watchstat = 'Active' order by userid desc LIMIT " + PgSize;
            }
            else if (page == 1 && filter == "Permanent Cleared")
            {
                cmd = "Select * from tblwatchlist where watchstat = 'Permanent Cleared' order by userid desc LIMIT " + PgSize;
            }
            else if (page == 1 && filter == "Temporary Cleared")
            {
                cmd = "Select * from tblwatchlist where watchstat = 'Temporary Cleared' order by userid desc LIMIT " + PgSize;
            }
            else
            {
                // 10 - 1 = 9 * 20
                int PreviousPageOffSet = (page - 1) * PgSize;

                if (filter == "All")
                {
                    cmd = "Select * from tblwatchlist where userid NOT IN (Select * from (Select userID from tblwatchlist where watchstat <> 'FALSE' order by userid desc LIMIT " + PreviousPageOffSet + ") as a) and watchstat <> 'FALSE' order by userid desc LIMIT " + PgSize;
                }
                else if (filter == "Active")
                {
                    cmd = "Select * from tblwatchlist where userid NOT IN (Select * from (Select userID from tblwatchlist where watchstat = 'Active' order by userid desc LIMIT " + PreviousPageOffSet + ") as a) and watchstat = 'Active' order by userid desc LIMIT " + PgSize;
                }
                else if (filter == "Permanent Cleared")
                {
                    cmd = "Select * from tblwatchlist where userid NOT IN (Select * from (Select userID from tblwatchlist where watchstat = 'Permanent Cleared' order by userid desc LIMIT " + PreviousPageOffSet + ") as a) and watchstat = 'Permanent Cleared' order by userid desc LIMIT " + PgSize;
                }
                else
                {
                    cmd = "Select * from tblwatchlist where userid NOT IN (Select * from (Select userID from tblwatchlist where watchstat = 'Temporary Cleared' order by userid desc LIMIT " + PreviousPageOffSet + ") as a) and watchstat = 'Temporary Cleared' order by userid desc LIMIT " + PgSize;
                }

                
            
            }

            try
            {
                cnn.Open();
                MySqlCommand MyCommand2 = new MySqlCommand(cmd, cnn);
                MySqlDataReader MyReader2;
                MyReader2 = MyCommand2.ExecuteReader();

                using (MySqlConnection conn = new MySqlConnection(connetionString))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conn))
                    {   
                        adapter.Fill(dt);
                    }
                }
           
                
            }
            catch (Exception e)
            {
                
            }
            return dt;

        }

        private void getSelectedRow()
        {
            int selectedrowindex = dataGridView1.CurrentCell.RowIndex;

            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            e_userid.Text = selectedRow.Cells[0].Value.ToString();
            e_fname.Text = selectedRow.Cells[1].Value.ToString();
            e_mname.Text = selectedRow.Cells[2].Value.ToString();
            e_lname.Text = selectedRow.Cells[3].Value.ToString();
            e_oname.Text = selectedRow.Cells[4].Value.ToString();
            e_bday.Text = selectedRow.Cells[5].Value.ToString();
            e_violation.Text = selectedRow.Cells[6].Value.ToString();
            e_complainant.Text = selectedRow.Cells[7].Value.ToString();

            if (selectedRow.Cells[8].Value.ToString() == "Active")
            {
                e_cmbStatus.SelectedIndex = 0;
            }
            else if (selectedRow.Cells[8].Value.ToString() == "Permanent Cleared")
            {
                e_cmbStatus.SelectedIndex = 1;
            }
            else
            {
                e_cmbStatus.SelectedIndex = 2;
            }
        }

             
        public void loaddata()
        {
            CalculateTotalPages("All");
            initializeDataGrid(1, "All");
            getSelectedRow();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            Form2 f = new Form2();
            f.Show();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

  

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.e_userid.Text))
            {
                MessageBox.Show("You did not select any record!", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this record?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string connetionString = null;
                    MySqlConnection cnn;
                    connetionString = "server=localhost;database=dcm;uid=root;";
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        if (this.e_lname.Text=="" || this.e_fname.Text=="" || this.e_complainant.Text=="" || this.e_violation.Text=="")
                        {
                            MessageBox.Show("You must fill the required fields!");
                        }
                        else
                        {
                            cnn.Open();
                            string query = "Update tblwatchlist set lastname = '" + this.e_lname.Text + "', firstname = '" + this.e_fname.Text + "', othername = '" + this.e_oname.Text + "', bdate = '" + this.e_bday.Value.Date.ToString("yyyy-MM-dd") + "', violation = '" + this.e_violation.Text + "', cmplainant = '" + this.e_complainant.Text + "', middlename = '" + this.e_mname.Text + "', watchstat = '"+e_cmbStatus.Text+"' where userid = '" + this.e_userid.Text + "' ";
                            using (MySqlConnection conn = new MySqlConnection(connetionString))
                            {

                                MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                                MySqlDataReader MyReader2;
                                MyReader2 = MyCommand2.ExecuteReader();

                                Form1 f1 = (Form1)Application.OpenForms["Form1"];
                                f1.loaddata();
                                txtSearch.Text = "";
                                MessageBox.Show("You successfully updated the record!");


                            }
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
                else
                {

                }

                
            }
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                e_userid.Text = selectedRow.Cells[0].Value.ToString();
                e_fname.Text = selectedRow.Cells[1].Value.ToString();
                e_mname.Text = selectedRow.Cells[2].Value.ToString();
                e_lname.Text = selectedRow.Cells[3].Value.ToString();
                e_oname.Text = selectedRow.Cells[4].Value.ToString();
                e_bday.Text = selectedRow.Cells[5].Value.ToString();
                e_violation.Text = selectedRow.Cells[6].Value.ToString();
                e_complainant.Text = selectedRow.Cells[7].Value.ToString();

                if (selectedRow.Cells[8].Value.ToString() == "Active")
                {
                    e_cmbStatus.SelectedIndex = 0;
                }
                else if (selectedRow.Cells[8].Value.ToString() == "Permanent Cleared")
                {
                    e_cmbStatus.SelectedIndex = 1;
                }
                else
                {
                    e_cmbStatus.SelectedIndex = 2;
                }

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            // MessageBox.Show(dataGridView1.CurrentCell.RowIndex.ToString());

            

            try
            {
                int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];


                e_cmbStatus.Items.Add("Active");
                e_cmbStatus.Items.Add("Permanent Cleared");
                e_cmbStatus.Items.Add("Temporary Cleared");

                cmbShow.Items.Add("All");
                cmbShow.Items.Add("Active");
                cmbShow.Items.Add("Permanent Cleared");
                cmbShow.Items.Add("Temporary Cleared");
                cmbShow.SelectedIndex = 0;

                e_userid.Text = selectedRow.Cells[0].Value.ToString();
                e_fname.Text = selectedRow.Cells[1].Value.ToString();
                e_mname.Text = selectedRow.Cells[2].Value.ToString();
                e_lname.Text = selectedRow.Cells[3].Value.ToString();
                e_oname.Text = selectedRow.Cells[4].Value.ToString();
                e_bday.Text = selectedRow.Cells[5].Value.ToString();
                e_violation.Text = selectedRow.Cells[6].Value.ToString();
                e_complainant.Text = selectedRow.Cells[7].Value.ToString();

                if (selectedRow.Cells[8].Value.ToString() == "Active")
                {
                    e_cmbStatus.SelectedIndex = 0;
                }
                else if (selectedRow.Cells[8].Value.ToString() == "Permanent Cleared")
                {
                    e_cmbStatus.SelectedIndex = 1;
                }
                else
                {
                    e_cmbStatus.SelectedIndex = 2;
                }
            }
            catch (Exception es)
            {

            }
           


            

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.e_userid.Text))
            {
                MessageBox.Show("You did not select any record!", "Error");
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Warning",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string connetionString = null;
                    MySqlConnection cnn;
                    connetionString = "server=localhost;database=dcm;uid=root;";
                    cnn = new MySqlConnection(connetionString);
                    try
                    {
                        cnn.Open();
                        string query = "Update tblwatchlist set watchstat = 'FALSE' where userid = '" + this.e_userid.Text + "' ";
                        using (MySqlConnection conn = new MySqlConnection(connetionString))
                        {

                            MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                            MySqlDataReader MyReader2;
                            MyReader2 = MyCommand2.ExecuteReader();

                            Form1 f1 = (Form1)Application.OpenForms["Form1"];
                            f1.loaddata();
                            txtSearch.Text = "";
                            MessageBox.Show("You successfully deleted the record!");





                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Can not open connection ! ");
                    }
                }
                else if (result == DialogResult.No)
                {
                    //code for No
                }
                
            }
            
           
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex < this.TotalPage)
            {

                this.CurrentPageIndex++;
                //MessageBox.Show(this.CurrentPageIndex.ToString());
                dataGridView1.AutoGenerateColumns = false;
                txtPageCount.Text = "Showing " + CurrentPageIndex.ToString() + " out of " + TotalPage.ToString()+" pages";


                dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, showing);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (this.CurrentPageIndex > 1)
            {
                this.CurrentPageIndex--;
                txtPageCount.Text = "Showing " + CurrentPageIndex.ToString() + " out of " + TotalPage.ToString() + " pages";

                this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, showing);
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = 1;
            txtPageCount.Text = "Showing " + CurrentPageIndex.ToString() + " out of " + TotalPage.ToString() + " pages";

            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, showing);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            this.CurrentPageIndex = TotalPage;
            txtPageCount.Text = "Showing " + CurrentPageIndex.ToString() + " out of " + TotalPage.ToString() + " pages";

            this.dataGridView1.DataSource = GetCurrentRecords(this.CurrentPageIndex, showing);
        }

        private void txtSearch_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void txtSearch_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                btnFirst.Enabled = true;
                btnLast.Enabled = true;
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
                txtPageCount.Visible = true;
                initializeDataGrid(1, showing);

                int selectedrowindex = dataGridView1.CurrentCell.RowIndex;

                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                e_userid.Text = selectedRow.Cells[0].Value.ToString();
                e_fname.Text = selectedRow.Cells[1].Value.ToString();
                e_mname.Text = selectedRow.Cells[2].Value.ToString();
                e_lname.Text = selectedRow.Cells[3].Value.ToString();
                e_oname.Text = selectedRow.Cells[4].Value.ToString();
                e_bday.Text = selectedRow.Cells[5].Value.ToString();
                e_violation.Text = selectedRow.Cells[6].Value.ToString();
                e_complainant.Text = selectedRow.Cells[7].Value.ToString();

                if (selectedRow.Cells[8].Value.ToString() == "Active")
                {
                    e_cmbStatus.SelectedIndex = 0;
                }
                else if (selectedRow.Cells[8].Value.ToString() == "Permanent Cleared")
                {
                    e_cmbStatus.SelectedIndex = 1;
                }
                else
                {
                    e_cmbStatus.SelectedIndex = 2;
                }
            }
            else
            {
                btnFirst.Enabled = false;
                btnLast.Enabled = false;
                btnNext.Enabled = false;
                btnPrev.Enabled = false;
                txtPageCount.Visible = false;

                string connetionString = null;
                MySqlConnection cnn;
                connetionString = "server=localhost;database=dcm;uid=root;";
                cnn = new MySqlConnection(connetionString);

                try
                {
                    cnn.Open();
                    string query = "SELECT * FROM tblwatchlist WHERE CONCAT(firstname, middlename, lastname, othername, cmplainant, violation) LIKE '%"+this.txtSearch.Text+"%' and watchstat <> 'FALSE' ";

                    using (MySqlConnection conn = new MySqlConnection(connetionString))
                    {

                        MySqlCommand MyCommand2 = new MySqlCommand(query, cnn);
                        MySqlDataReader MyReader2;
                        MyReader2 = MyCommand2.ExecuteReader();

                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                        {

                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            dataGridView1.AutoGenerateColumns = false;
                            dataGridView1.DataSource = dt;

                            if (dataGridView1.Rows.Count == 0)
                            {
                                e_userid.Text = "";
                                e_fname.Text = "";
                                e_mname.Text = "";
                                e_lname.Text = "";
                                e_oname.Text = "";
                                e_bday.Text = "";
                                e_violation.Text = "";
                                e_complainant.Text = "";
                            }
                            else
                            {
                                int selectedrowindex = dataGridView1.CurrentCell.RowIndex;

                                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

                                e_userid.Text = selectedRow.Cells[0].Value.ToString();
                                e_fname.Text = selectedRow.Cells[1].Value.ToString();
                                e_mname.Text = selectedRow.Cells[2].Value.ToString();
                                e_lname.Text = selectedRow.Cells[3].Value.ToString();
                                e_oname.Text = selectedRow.Cells[4].Value.ToString();
                                e_bday.Text = selectedRow.Cells[5].Value.ToString();
                                e_violation.Text = selectedRow.Cells[6].Value.ToString();
                                e_complainant.Text = selectedRow.Cells[7].Value.ToString();

                                if (selectedRow.Cells[8].Value.ToString() == "Active")
                                {
                                    e_cmbStatus.SelectedIndex = 0;
                                }
                                else if (selectedRow.Cells[8].Value.ToString() == "Permanent Cleared")
                                {
                                    e_cmbStatus.SelectedIndex = 1;
                                }
                                else
                                {
                                    e_cmbStatus.SelectedIndex = 2;
                                }
                            }

                           
                        }


                    }
                }
                catch (Exception ee)
                {

                }
            }

           
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void cmbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbShow.SelectedIndex == 0)
            {
                // all
                showing = "All";
                CalculateTotalPages(showing);
                initializeDataGrid(1, showing);

            }
            else if (cmbShow.SelectedIndex == 1)
            {
                // active
                showing = "Active";
                CalculateTotalPages(showing);
                initializeDataGrid(1, showing);
            }
            else if (cmbShow.SelectedIndex == 2)
            {
                // Permanent cleared
                showing = "Permanent Cleared";
                CalculateTotalPages(showing);
                initializeDataGrid(1, showing);
            }
            else
            {
                // Temporary cleared
                showing = "Temporary Cleared";
                CalculateTotalPages(showing);
                initializeDataGrid(1, showing);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
