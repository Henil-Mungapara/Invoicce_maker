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

        //void datesetup() {

        //    connection();
        //    if (invoiceprintcomboBox.Text == "Specific Range")
        //    {
        //        choosedate.Text = "Choose Date";
        //        invoiceprintdateTimePicker.Visible = false;
        //        invoiceprintstartdateTimePicker.Visible = true;
        //        invoiceprintenddateTimePicker.Visible = true;
        //    }

        //    else if (invoiceprintcomboBox.Text == "Specific Date")
        //    {
        //        date1.Text = "From";
        //        date2.Text = "To";
        //        invoiceprintdateTimePicker.Visible = true;
        //        invoiceprintstartdateTimePicker.Visible = false;
        //        invoiceprintenddateTimePicker.Visible = false;
        //    }
        //    else
        //    {
        //        invoiceprintdateTimePicker.Visible = false;
        //        invoiceprintstartdateTimePicker.Visible = false;
        //        invoiceprintenddateTimePicker.Visible = false;
               
        //    }
        //}

        private void InvoicePrint_Load(object sender, EventArgs e)
        {
            connection();
            //datesetup();
        }
    }
    
}
