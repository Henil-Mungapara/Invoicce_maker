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
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\Source\Repos\Invoicce_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        int id;
        int index;
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
            int qty = Convert.ToInt32(invoicemakedataGridView.CurrentRow.Cells["Qty"].Value);
            invoicemakedataGridView.CurrentRow.Cells["Total price"].Value = 100*qty;

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

        void gridset()
        {
            table = new DataTable("table");
            table.Columns.Add("Customer Name", Type.GetType("System.String"));
            table.Columns.Add("Item Name", Type.GetType("System.String"));
            table.Columns.Add("Description", Type.GetType("System.String"));
            table.Columns.Add("Qty", Type.GetType("System.Double"));
            table.Columns.Add("Weight", Type.GetType("System.String"));
            table.Columns.Add("CGST", Type.GetType("System.Double"));
            table.Columns.Add("NGST", Type.GetType("System.Double"));
            table.Columns.Add("IGST", Type.GetType("System.Double"));
            table.Columns.Add("UTGST", Type.GetType("System.Double"));
            table.Columns.Add("Item Price", Type.GetType("System.Double"));
            table.Columns.Add("Total Price", Type.GetType("System.Double"));
            table.Columns.Add("Date", Type.GetType("System.DateTime"));
            table.Columns.Add("Month", Type.GetType("System.Int32"));

            invoicemakedataGridView.DataSource = table;
        }


        private void invoicemakenew_Click(object sender, EventArgs e)
        {
            invoicemakecustomername.Text = String.Empty;
            invoicemakeitemname.Text = String.Empty;
            invoicemakeitemdescription.Text = String.Empty;
            invoicemakeitemqty.Text = String.Empty; // Assuming it's a TextBox
            invoicemakecomboBox.SelectedIndex = -1; // Reset ComboBox selection
            invoicemakecgst.Text = String.Empty; // Assuming it's a TextBox
            invoicemakeigst.Text = String.Empty; // Assuming it's a TextBox
            invoicemakengst.Text = String.Empty; // Assuming it's a TextBox
            invoicemakeutgst.Text = String.Empty;
            invoicemakeitemprice.Text = String.Empty;// Assuming it's a TextBoxis a 
            invoicemakedateTimePicker.Value = DateTime.Now;

        }


        private void invoicemakeadd_Click(object sender, EventArgs e)
        {
            // Create a new DataRow
            DataRow newRow = table.NewRow();

            // Get and convert values from textboxes
            string customerName = invoicemakecustomername.Text;
            string itemName = invoicemakeitemname.Text;
            string description = invoicemakeitemdescription.Text;
            double qty = Convert.ToDouble(invoicemakeitemqty.Text);
            string weight = invoicemakecomboBox.SelectedItem.ToString();
            double cgst = Convert.ToDouble(invoicemakecgst.Text);
            double igst = Convert.ToDouble(invoicemakeigst.Text);
            double ngst = Convert.ToDouble(invoicemakengst.Text);
            double utgst = Convert.ToDouble(invoicemakeutgst.Text);
            double itemPrice = Convert.ToDouble(invoicemakeitemprice.Text);

            // Calculate the base total price (Qty * Item Price)
            double baseTotalPrice = qty * itemPrice;

            // Calculate the total GST amount
            double totalGstAmount = baseTotalPrice * (cgst + igst + ngst + utgst) / 100;

            // Calculate the final total price including GST
            double totalPrice = baseTotalPrice + totalGstAmount;

            // Set values to newRow
            newRow["Customer Name"] = customerName;
            newRow["Item Name"] = itemName;
            newRow["Description"] = description;
            newRow["Qty"] = qty;
            newRow["Weight"] = weight;
            newRow["CGST"] = cgst;
            newRow["IGST"] = igst;
            newRow["NGST"] = ngst;
            newRow["UTGST"] = utgst;
            newRow["Item Price"] = itemPrice;
            newRow["Total Price"] = totalPrice;
            newRow["Date"] = invoicemakedateTimePicker.Value;
            newRow["Month"] = invoicemakedateTimePicker.Value.Month;

            // Add the newRow to the table
            table.Rows.Add(newRow);
        }

        private void invoicemakedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = invoicemakedataGridView.Rows[index];

            invoicemakecustomername.Text = row.Cells[0].Value.ToString();
            invoicemakeitemname.Text = row.Cells[1].Value.ToString();
            invoicemakeitemdescription.Text = row.Cells[2].Value.ToString();
            invoicemakeitemqty.Text = row.Cells[3].Value.ToString();
            invoicemakecomboBox.SelectedItem = row.Cells[3].Value.ToString();
            invoicemakecgst.Text = row.Cells[5].Value.ToString();
            invoicemakeigst.Text = row.Cells[6].Value.ToString();
            invoicemakengst.Text = row.Cells[7].Value.ToString();
            invoicemakeutgst.Text = row.Cells[8].Value.ToString();
            invoicemakeitemprice.Text = row.Cells[9].Value.ToString();

            invoicemakedateTimePicker.Value = Convert.ToDateTime(row.Cells[11].Value);

        }

        private void invoicemakeupdate_Click(object sender, EventArgs e)
        {
            // Access the specific row to be updated in the DataGridView
            DataGridViewRow newdata = invoicemakedataGridView.Rows[index];

            // Retrieve values from the textboxes
            string customerName = invoicemakecustomername.Text;
            string itemName = invoicemakeitemname.Text;
            string description = invoicemakeitemdescription.Text;
            double qty = Convert.ToDouble(invoicemakeitemqty.Text);
            string weight = invoicemakecomboBox.SelectedItem.ToString();
            double itemPrice = Convert.ToDouble(invoicemakeitemprice.Text);

            // Retrieve and convert GST values
            double cgst = Convert.ToDouble(invoicemakecgst.Text);
            double igst = Convert.ToDouble(invoicemakeigst.Text);
            double ngst = Convert.ToDouble(invoicemakengst.Text);
            double utgst = Convert.ToDouble(invoicemakeutgst.Text);

            // Calculate the base total price (Qty * Item Price)
            double baseTotalPrice = qty * itemPrice;

            // Calculate the total GST amount
            double totalGstAmount = baseTotalPrice * (cgst + igst + ngst + utgst) / 100;

            // Calculate the final total price including GST
            double totalPrice = baseTotalPrice + totalGstAmount;

            // Update the cells in the DataGridView row
            newdata.Cells[0].Value = customerName;
            newdata.Cells[1].Value = itemName;
            newdata.Cells[2].Value = description;
            newdata.Cells[3].Value = qty;
            newdata.Cells[4].Value = weight;
            newdata.Cells[5].Value = cgst;
            newdata.Cells[6].Value = igst;
            newdata.Cells[7].Value = ngst;
            newdata.Cells[8].Value = utgst;
            newdata.Cells[9].Value = itemPrice;
            newdata.Cells[10].Value = totalPrice;
            newdata.Cells[11].Value = invoicemakedateTimePicker.Value;// Assuming the Total Price is in the 11th column (index 10)
                                                              // You may need to adjust the column index based on your DataGridView setup

            // Optionally, update the Date if needed
            // newdata.Cells[11].Value = DateTime.Now.ToString("yyyy-MM-dd"); // Adjust the column index if necessary
        }
        private void button4_Click(object sender, EventArgs e)
        {
            index = invoicemakedataGridView.CurrentCell.RowIndex;
            invoicemakedataGridView.Rows.RemoveAt(index);
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void invoicemakesavedata_Click(object sender, EventArgs e)
        {
           

            for (int i=0; i< invoicemakedataGridView.Rows.Count; i++)
                {
                if (invoicemakedataGridView.Rows[i].IsNewRow) continue;
                connection();
                cmd = new SqlCommand(@"INSERT INTO Invoice_Make(CustomerName, ItemName, Description, Qty, Weight, CGST, IGST, NGST, UTGST, ItemPrice, TotalPrice, Date, Month) values ('"+invoicemakedataGridView.Rows[i].Cells[0].Value+ "', '" + invoicemakedataGridView.Rows[i].Cells[1].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[2].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[3].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[4].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[5].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[6].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[7].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[8].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[9].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[10].Value + "', '" + invoicemakedataGridView.Rows[i].Cells[11].Value + "',  '"+invoicemakedataGridView.Rows[i].Cells[12].Value + "' )", con);


                cmd.ExecuteNonQuery();
                MessageBox.Show("Your All Data Successfully Saved.....!! ");
                con.Close();
            }
            //invoicemakedataGridView.Rows.Clear();
           
        }
    }
}
 