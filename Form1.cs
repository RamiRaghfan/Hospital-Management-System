using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Hospital
{
    public partial class HMS_LOGIN : Form
    {
        public HMS_LOGIN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = userNameBox.Text;
            String pwd = pwdBox.Text;

            if( username == "hosmmg1" && pwd == "pass" )
            {
                this.Hide();
                Dashboard dashb = new Dashboard();
                dashb.Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
