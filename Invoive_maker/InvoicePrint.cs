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
        DataTable dt;

        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\source\repos\Invoive_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";


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
            da = new SqlDataAdapter("select * from Invoice_Make",con);
            ds = new DataSet();
            da.Fill(ds);

            string xml = @"C:/Users/munga/source/repos/Invoive_maker/Invoive_maker/data.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:/Users/munga/source/repos/Invoive_maker/Invoive_maker\invoiceeprint.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;


        }

        private void InvoicePrint_Load(object sender, EventArgs e)
        {
            connection();
            UpdateDateTimePickersVisibility();
        }
        void UpdateDateTimePickersVisibility()
        {
            if (invoiceprintcomboBox.SelectedItem != null)
            {
                // Safely get the selected item's string representation
                string selectedType = invoiceprintcomboBox.SelectedItem.ToString();

                if (selectedType == "Specific Range")
                {
                    startdateTimePicker.Visible = true;
                    enddateTimePicker.Visible = true;
                    specificdateTimePicker.Visible = false;
                }
                else if (selectedType == "Specific Date")
                {
                    startdateTimePicker.Visible = false;
                    enddateTimePicker.Visible = false;
                    specificdateTimePicker.Visible = true;
                }
            }
        }
    }
}
