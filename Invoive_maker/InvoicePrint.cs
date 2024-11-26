using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Invoive_maker
{
    public partial class InvoicePrint : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\Source\Repos\Invoicce_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";

        public EventHandler ComboBoxSelectType_SelectedIndexChanged { get; }

        public InvoicePrint()
        {
            InitializeComponent();

           
        }
    
        void connection() {
            con = new SqlConnection(s);
            con.Open();
        }
      private void invoiceprintbutton_Click(object sender, EventArgs e)
{
            connection();

            // Define the query string
            string query = string.Empty;

            if (invoiceprintcomboBox.Text == "Specific Date")
            {
                // Get the selected date from specificdatedateTimePicker
                DateTime selectedDate = specificdatedateTimePicker.Value.Date;

                // Update the query to filter by the specific date
                query = "SELECT * FROM Invoice_Make WHERE CAST(Date AS DATE) = @SelectedDate";
        
                // Use SqlCommand to prevent SQL injection
                using (SqlCommand cmd = new SqlCommand(query, con))
                {

                    cmd.Parameters.AddWithValue("@SelectedDate", selectedDate);

                    da = new SqlDataAdapter(cmd);
                }
            }
            else if (invoiceprintcomboBox.Text == "Specific Range")
            {
                // Get the selected start date and end date
                DateTime startDate = startdateTimePicker.Value.Date;
                DateTime endDate = enddateTimePicker.Value.Date;

                // Update the query to filter by the date range
                query = "SELECT * FROM Invoice_Make WHERE CAST(Date AS DATE) BETWEEN @StartDate AND @EndDate";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    da = new SqlDataAdapter(cmd);
                }
            }

            else if (invoiceprintcomboBox.Text == "All Over")
            {
                // Default query if no specific date is selected
                query = "SELECT * FROM Invoice_Make";
                da = new SqlDataAdapter(query, con);
            }

            else
            {
                // Default query if no specific date is selected
                MessageBox.Show("Your All Over Data Will Be Show In Invoise !!");
                query = "SELECT * FROM Invoice_Make";
                da = new SqlDataAdapter(query, con);
            }

            ds = new DataSet();
            da.Fill(ds);

            string xml = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/data.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/invoiceprint.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;
        }




        private void InvoicePrint_Load(object sender, EventArgs e)
        {
            connection();
            customerlist();
            itemlist();
            // datesetup();
            startdateTimePicker.Visible = false;
            enddateTimePicker.Visible = false;
            specificdatedateTimePicker.Visible = false;

            // If you have labels for these, set their visibility as well
            startdateLabel.Visible = false;
            enddateLabel.Visible = false;
            specificdateLabel.Visible = false;
        }

        private void invoiceprintcomboBox_TextChanged(object sender, EventArgs e)
        {
            connection();
            // Update the visibility based on the selected type
            if (invoiceprintcomboBox.Text == "Specific Range")
            {
                startdateTimePicker.Visible = true;
                enddateTimePicker.Visible = true;
                specificdatedateTimePicker.Visible = false;

                // If you have labels for these, set their visibility as well
                startdateLabel.Visible = true;
                enddateLabel.Visible = true;
                specificdateLabel.Visible = false;
            }
            else if (invoiceprintcomboBox.Text == "Specific Date")
            {
                startdateTimePicker.Visible = false;
                enddateTimePicker.Visible = false;
                specificdatedateTimePicker.Visible = true;

                // If you have labels for these, set their visibility as well
                startdateLabel.Visible = false;
                enddateLabel.Visible = false;
                specificdateLabel.Visible = true;
            }

            else if (invoiceprintcomboBox.Text == "All Over")
            {
                startdateTimePicker.Visible = false;
                enddateTimePicker.Visible = false;
                specificdatedateTimePicker.Visible = false;

                // If you have labels for these, set their visibility as well
                startdateLabel.Visible = false;
                enddateLabel.Visible = false;
                specificdateLabel.Visible = false;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Check if the customer name is not empty
            if (!string.IsNullOrEmpty(invoiceprintcustomername.Text))
            {
                try
                {
                    // Establish the connection to the database
                    connection();

                    // Get the customer name from the textbox
                    string customerName = invoiceprintcustomername.Text;

                    // Update the query to filter by the customer name
                    string query = "SELECT * FROM Invoice_Make WHERE CustomerName = @CustomerName";

                    // Use SqlCommand to prevent SQL injection
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@CustomerName", customerName);
                        da = new SqlDataAdapter(cmd);
                    }

                    // Fill the dataset with the results
                    ds = new DataSet();
                    da.Fill(ds);

                    // Write the dataset schema to an XML file (optional)
                    string xml = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/data.xml";
                    ds.WriteXmlSchema(xml);

                    // Load the Crystal Report with the dataset
                    string Crypath = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/invoiceprint.rpt";
                    cr.Load(Crypath);
                    cr.SetDataSource(ds);
                    cr.Database.Tables[0].SetDataSource(ds);
                    cr.Refresh();
                    crystalReportViewer1.ReportSource = cr;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the process
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                // Clear the report if the customer name textbox is empty
                crystalReportViewer1.ReportSource = null;
            }
        }

        // Add this method to set up the connection (if not already present)


        void customerlist() {
            try
            {
                AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
                connection();
                String sql = "select * from Invoice_Make";
                cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = null;
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    acsc.Add(sdr["CustomerName"].ToString());
                }
                sdr.Close();
                invoiceprintcustomername.AutoCompleteCustomSource = acsc;
                con.Close();
            }
            catch (Exception result)
            {
                MessageBox.Show("Error !" + result);
            }
        }

        void itemlist()
        {
            try
            {
                AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
                connection();
                String sql = "select * from Invoice_Make";
                cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = null;
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    acsc.Add(sdr["ItemName"].ToString());
                }
                sdr.Close();
                invoiceprintcustomername.AutoCompleteCustomSource = acsc;
                con.Close();
            }
            catch (Exception result)
            {
                MessageBox.Show("Error !" + result);
            }
        }

        private void invoiceprintitemname_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(invoiceprintitemname.Text))
            {
                try
                {
                    // Establish the connection to the database
                    connection();

                    // Get the customer name from the textbox
                    string itemname = invoiceprintitemname.Text;

                    // Update the query to filter by the customer name
                    string query = "SELECT * FROM Invoice_Make WHERE ItemName = @ItemName";

                    // Use SqlCommand to prevent SQL injection
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ItemName", itemname);
                        da = new SqlDataAdapter(cmd);
                    }

                    // Fill the dataset with the results
                    ds = new DataSet();
                    da.Fill(ds);

                    // Write the dataset schema to an XML file (optional)
                    string xml = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/data.xml";
                    ds.WriteXmlSchema(xml);

                    // Load the Crystal Report with the dataset
                    string Crypath = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/invoiceprint.rpt";
                    cr.Load(Crypath);
                    cr.SetDataSource(ds);
                    cr.Database.Tables[0].SetDataSource(ds);
                    cr.Refresh();
                    crystalReportViewer1.ReportSource = cr;
                }
                catch (Exception ex)
                {
                    // Handle any exceptions that occur during the process
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    // Ensure the connection is closed
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                    }
                }
            }
        }
    }
    
}
