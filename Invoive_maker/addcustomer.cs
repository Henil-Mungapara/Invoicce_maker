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


    public partial class addcustomer : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\Source\Repos\Invoicce_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        int id;
        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";
        public addcustomer()
        {
            InitializeComponent();
        }

        private void customercancel_Click(object sender, EventArgs e)
        {
           this.DialogResult = DialogResult.Cancel;
           this.Close();

        }
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void addcustomer_Load(object sender, EventArgs e)
        {
            connection();
            customerfillgrid();

        }

        private void addcustomertoolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addcustomercustomeradd_Click(object sender, EventArgs e)
        {
            if (addcustomercustomeradd.Text == "ADD")
            {
               

                if (addcustomercustomername.Text == "")
                {
                    MessageBox.Show("Please enter value");
                }
                else {

                    cmd = new SqlCommand("insert into Add_Customer (Customer_Name,Customer_Email, Customer_Phone, Customer_City, Customer_GST) values ('" +
                  addcustomercustomername.Text + "', '" +
                  addcustomercustomeremeil.Text + "', '" +
                  addcustomercustomerphone.Text + "', '" +
                  addcustomercustomercity.Text + "', '" +
                  addcustomercustomergstno.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    customerfillgrid();

                    MessageBox.Show("Customer Insert Successfully...!");
                }
            }
            else
            {
                try
                {
                    connection();

                    cmd = new SqlCommand("update Add_Customer set Customer_Name = '" + addcustomercustomername.Text + "',Customer_Email = '" + addcustomercustomeremeil.Text + "',Customer_Phone='" + addcustomercustomerphone.Text + "',Customer_City = '" + addcustomercustomercity.Text + "' Where Customer_Id='" + id + "'", con);

                    cmd.ExecuteNonQuery();
                    customerfillgrid();
                    MessageBox.Show("Your Data Update Successfully!");


                    addcustomercustomeradd.Text = "ADD";
                }

                catch (Exception result)
                {
                    MessageBox.Show("Hello Error is Coming...!!" + result);
                }
            }
        }
        void customerfillgrid()
        {
            connection();
            da = new SqlDataAdapter("select * from Add_Customer", con);
            ds = new DataSet();
            da.Fill(ds);

            listcustomerdataGridView.DataSource = ds.Tables[0];
        }

        private void listcustomerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listcustomerdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (listcustomerdataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                addcustomercustomeradd.Text = "Edit";
                connection();


                id = Convert.ToInt16(listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_Id"].Value);
                string name, email, phone, city, gstno;


                name = (listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_Name"].Value).ToString();

                email = (listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_Email"].Value).ToString();


                phone = (listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_Phone"].Value).ToString();

                city = (listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_City"].Value).ToString();

                gstno = (listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_GST"].Value).ToString();


                addcustomercustomername.Text = name;
                addcustomercustomeremeil.Text = email;
                addcustomercustomerphone.Text = phone;
                addcustomercustomercity.Text = city;
                addcustomercustomergstno.Text = gstno;

            }

            else
            {
                connection();
                id = Convert.ToInt16(listcustomerdataGridView.Rows[e.RowIndex].Cells["Customer_Id"].Value);

                cmd = new SqlCommand("Delete from Add_Customer where Customer_Id = '" + id + "'", con);
                cmd.ExecuteNonQuery();
                customerfillgrid();
                MessageBox.Show("Hello ! Your Data Is Successfully Delete.....!!");
            }
        }

        private void addcustomerinvoice_Click(object sender, EventArgs e)
        {
            connection();
            da = new SqlDataAdapter("select * from Add_Customer", con);
            ds = new DataSet();
            da.Fill(ds);

            string xml = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/datatwo.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:/Users/munga/source/repos/Invoicce_maker/Invoive_maker/customerinvoice.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
