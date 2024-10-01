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
    public partial class Customer_List : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\source\repos\Invoive_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        public Customer_List()
        {
            InitializeComponent();
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {
           // connection();
            //itemfillgrid();
        }
        //void connection()
        //{
        //    con = new SqlConnection(s);
        //    con.Open();
        //}

       
    }
}
