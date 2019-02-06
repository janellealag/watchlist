using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecondTry
{
    public partial class Login : Form
    {
        
        public Login()
        {
            // START - Initialize Components
            InitializeComponent();
            
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {

                // After success login, show form1 Dialog
                Homepage f1 = new Homepage();
                this.Hide();
                f1.ShowDialog();
                this.Close();
                
            }
            catch (Exception eee)
            {
                MessageBox.Show(eee.ToString());
            }
                            
            
        }

       

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
           
        }

        private void LoginForm_Closed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
