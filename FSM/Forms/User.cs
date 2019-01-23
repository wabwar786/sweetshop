using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FSM
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            Login f1 = new Login();
            Hide();
            f1.ShowDialog();
            Close();


          

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup f2 = new Signup();
            this.Hide();
            f2.ShowDialog();
            this.Show();
            
        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }  
    }
}
