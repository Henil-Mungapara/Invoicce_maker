using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Invoive_maker
{
    public partial class Login : Form
    {
       
       
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserName.Text == "admin" && Password.Text == "12345")
            {
                this.Hide();
                Dashboard d = new Dashboard();
                d.Show();


                // Add other actions you want to perform on successful login
            }
            else {
                MessageBox.Show("UserName or Password Incorrect...!");
            }


        }
    }
}
