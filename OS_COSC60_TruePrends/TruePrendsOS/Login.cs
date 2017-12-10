using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace TruePrendsOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Login lg = new Login();
                lg.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void buttonShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to shut down your computer?", "Shut Down", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                Process.Start("shutdown", "/s /t 0");
            }
            else if (result == DialogResult.Cancel)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
