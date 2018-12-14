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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 f1 = new Form1();
                this.Hide();
                f1.ShowDialog();
                this.Close();
                
            }
            catch (Exception eee)
            {

            }
                            
            
        }

       

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_VisibleChanged(object sender, EventArgs e)
        {
           
        }
    }
}
