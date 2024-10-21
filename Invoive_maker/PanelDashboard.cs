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
    public partial class paneldashboard : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\Source\Repos\Invoicce_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        public paneldashboard()
        {
            InitializeComponent();
        }

        private void paneldashboard_Load(object sender, EventArgs e)
        {
            connection();
            chartsetup();
            invoiceentry();
        }

        void connection() {
            con = new SqlConnection(s);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection();
            SqlCommand cmd = new SqlCommand("select Month from Invoice_Make", con);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                chart1.Series[0].Points.AddY(sdr.GetString(0));
                //chart1.Series["C#"].Points.AddXY(sdr.GetString(1));
            }
        }

        void chartsetup() {
            string[] months = new string[]
            {
            "January", "February", "March", "April", "May", "June",
            "July", "August", "September", "October", "November", "December"
            };

            foreach (var month in months)
            {
                // SQL query to count invoices for the current month
                SqlCommand cmd = new SqlCommand($@"
                SELECT COUNT(*) AS InvoiceCount
                FROM Invoice_Make
                WHERE DATENAME(month, Date) = @Month", con);

                // Add parameter to prevent SQL injection
                cmd.Parameters.AddWithValue("@Month", month);

               int invoiceCount = (int)cmd.ExecuteScalar();

                // Add the data to the chart
                chart1.Series[0].Points.AddXY(month, invoiceCount);
            }
        }

        void invoiceentry() {
            connection();
            SqlCommand cmd = new SqlCommand(@"
                SELECT TOP 5 *
                FROM Invoice_Make
                ORDER BY itemName DESC", con);

            SqlDataReader sdr = cmd.ExecuteReader();

            // Assuming you have a DataGridView named dataGridView1
            DataTable dt = new DataTable();
            dt.Load(sdr);

            // Bind the data to the DataGridView
            paneldashboarddataGridView.DataSource = dt;

            sdr.Close();
        }

        private void paneldashboarddelete_Click(object sender, EventArgs e)
        {
            connection();

        }
    }
}
