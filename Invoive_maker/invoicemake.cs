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
    public partial class invoicemake : Form
    {

        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable table;
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\source\repos\Invoive_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        int id;
        public invoicemake()
        {
            InitializeComponent();

        }
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void invoicemake_Load(object sender, EventArgs e)
        {
            gridset();
            customerlist();
            itemlist();
        }

        void customerlist() {
            try
            {
                AutoCompleteStringCollection acsc = new AutoCompleteStringCollection();
                connection();
                String sql = "select * from Add_Customer";
                cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = null;
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    acsc.Add(sdr["Customer_Name"].ToString());
                }
                sdr.Close();
                invoicemakecustomername.AutoCompleteCustomSource = acsc;
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
                con = new SqlConnection(s);
                con.Open();
                String sql = "select * from Add_Item";
                cmd = new SqlCommand(sql, con);
                SqlDataReader sdr = null;
                sdr = cmd.ExecuteReader();

                while (sdr.Read())
                {
                    acsc.Add(sdr["Item_Name"].ToString());
                }
                sdr.Close();
                invoicemakeitemname.AutoCompleteCustomSource = acsc;
                con.Close();
            }
            catch (Exception result)
            {
                MessageBox.Show("Error !" + result);
            }
        }

        private void invoicemakedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void invoicemakedataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //id = Convert.ToInt32(invoicemakedataGridView.CurrentRow.Cells["Item_Id"].Value);
            //cmd = new SqlCommand("select * from Add_Item where Item_Id = '"+ id +"'",con);
            //da = new SqlDataAdapter(cmd);
            //dt = new DataTable();
            //da.Fill(dt);

            //if (dt.Rows.Count > 0) {
            //    invoicemakedataGridView.CurrentRow.Cells["Item_Name"].Value = dt.Rows[0]["Item_Name"];
            //    invoicemakedataGridView.CurrentRow.Cells["price"].Value = dt.Rows[0]["Item_Price"];
            //    decimal Price = Convert.ToDecimal(invoicemakedataGridView.CurrentRow.Cells["price"].Value);
            //    int qty = Convert.ToInt32(invoicemakedataGridView.CurrentRow.Cells["Qty"].Value);
            //    invoicemakedataGridView.CurrentRow.Cells["Total_Price"].Value = Price*qty;

            //}
            //else{
            //    MessageBox.Show("No Products Found Sorry...!!","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation
            //        );
            //    invoicemakedataGridView.CurrentRow.Cells["Item_Id"].Value = "";
            //    invoicemakedataGridView.CurrentRow.Cells["Item_Name"].Value = "";
            //    invoicemakedataGridView.CurrentRow.Cells["price"].Value = "";
            //    invoicemakedataGridView.CurrentRow.Cells["price"].Value = "";

            //}
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        void gridset() {

            table = new DataTable("table");

            table.Columns.Add("Item Name", Type.GetType("System.String"));
            table.Columns.Add("Description", Type.GetType("System.String"));
            table.Columns.Add("Qty", Type.GetType("System.Int32"));
            table.Columns.Add("Weight", Type.GetType("System.String"));
            table.Columns.Add("CGST", Type.GetType("System.Double"));
            table.Columns.Add("NGST", Type.GetType("System.Double"));
            table.Columns.Add("IGST", Type.GetType("System.Double"));
            table.Columns.Add("UTGST", Type.GetType("System.Double"));
            table.Columns.Add("Item Price", Type.GetType("System.Double"));
            table.Columns.Add("Total price", Type.GetType("System.Double"));

            invoicemakedataGridView.DataSource = table;
        }

        private void invoicemakenew_Click(object sender, EventArgs e)
        {
            invoicemakecustomername.Text = String.Empty;
            invoicemakeitemname.Text = String.Empty;
            invoicemakeitemqty.Text = String.Empty;
            invoicemakecomboBox.ResetText();
            invoicemakecgst.Text = String.Empty;
            invoicemakeigst.Text = String.Empty;
            invoicemakengst.Text = String.Empty;
            invoicemakeutgst.Text = String.Empty;
        }
    }
}
