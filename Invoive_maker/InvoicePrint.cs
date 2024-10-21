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
            da = new SqlDataAdapter("select * from Invoice_Make", con);
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
           
        }
    }
    
}
