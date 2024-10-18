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
    public partial class additem : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\source\repos\Invoive_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        int id;
        String itemtype;

        public additem()
        {
            InitializeComponent();
        }

        private void additem_Load(object sender, EventArgs e)
        {
          
            connection();
            itemfillgrid();
            gridset();

        }
        void connection()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        void gridset() {
            itemlistdataGridView.Columns["Edit"].DisplayIndex = 9; // Assuming the first column is Item_Id
            itemlistdataGridView.Columns["Delete"].DisplayIndex = 10;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (itemaddbutton.Text == "ADD") {

               
                connection();

                if (additemgoods.Checked == true)
                {
                    itemtype = additemgoods.Text; // Assign a specific integer value if the RadioButton is checked
                }
                else
                {
                    itemtype = additemservice.Text; // Or another value if it is not checked (optional, depending on your logic)
                }

               
                if (additemitemname.Text == "")
                {
                    MessageBox.Show("Please enter valid and full value in item name...!!");
                }
                else {
                    cmd = new SqlCommand("insert into Add_Item (Item_Name, Item_Description, Item_Price, Item_Type, CGST, SGST, IGST, UTGST) values ('" +
                   additemitemname.Text + "', '" +
                   additemdescription.Text + "', '" +
                   additemitemprice.Text + "', '" +
                   itemtype + "', '" +
                   additemcgst.Text + "', '" +
                   additemsgst.Text + "', '" +
                   additemigst.Text + "', '" +
                   additemutgst.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    itemfillgrid();
                    MessageBox.Show("Insert Data Successfully...!");

                }
            }
            else {
                try
                {
                    connection();

                    if (additemgoods.Checked == true)
                    {
                        itemtype = additemgoods.Text; // Assign a specific integer value if the RadioButton is checked
                    }
                    else
                    {
                        itemtype = additemservice.Text; // Or another value if it is not checked (optional, depending on your logic)
                    }

                    cmd = new SqlCommand("update Add_Item set Item_Name = '" + additemitemname.Text + "',Item_Description = '" + additemdescription.Text + "',Item_Type = '" + itemtype + "',Item_Price = '" + additemitemprice.Text + "',CGST= '" + additemcgst.Text + "',SGST = '" + additemsgst.Text + "',IGST = '" + additemigst.Text + "',UTGST = '" + additemutgst.Text + "' where Item_Id='" + id + "'", con);

                    cmd.ExecuteNonQuery();
                    itemfillgrid();
                    MessageBox.Show("Data Update Successfully!");
                    itemaddbutton.Text = "ADD";

                }
                catch (Exception result)
                {
                    MessageBox.Show("Message" + result);
                }
               

            }



        }

        private void itemlistdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        void itemfillgrid()
        {
            connection();
            da = new SqlDataAdapter("select * from Add_Item", con);
            ds = new DataSet();
            da.Fill(ds);

            itemlistdataGridView.DataSource = ds.Tables[0];
        }

        private void itemlistdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (itemlistdataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                itemaddbutton.Text = "Edit";
                connection();

                id = Convert.ToInt16(itemlistdataGridView.Rows[e.RowIndex].Cells["Item_Id"].Value);

                string itemname, itemdescription, itemtypee, itemprice, cgst, sgst, igst, utgst;

                itemname = (itemlistdataGridView.Rows[e.RowIndex].Cells["Item_Name"].Value).ToString();

                itemdescription = (itemlistdataGridView.Rows[e.RowIndex].Cells["Item_Description"].Value).ToString();

                itemtypee = (itemlistdataGridView.Rows[e.RowIndex].Cells["Item_Type"].Value).ToString();

                itemprice = (itemlistdataGridView.Rows[e.RowIndex].Cells["Item_Price"].Value).ToString();

                cgst = (itemlistdataGridView.Rows[e.RowIndex].Cells["CGST"].Value).ToString();

                sgst = (itemlistdataGridView.Rows[e.RowIndex].Cells["SGST"].Value).ToString();

                igst = (itemlistdataGridView.Rows[e.RowIndex].Cells["IGST"].Value).ToString();

                utgst = (itemlistdataGridView.Rows[e.RowIndex].Cells["UTGST"].Value).ToString();

                


                additemitemname.Text = itemname;
                additemdescription.Text = itemdescription;
                additemitemprice.Text = itemprice;
                //itemtype = itemtypee;
                additemcgst.Text = cgst;
                additemsgst.Text = sgst;
                additemigst.Text = igst;
                additemutgst.Text = utgst;

            }
            if (itemlistdataGridView.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                connection();
                id = Convert.ToInt32(itemlistdataGridView.Rows[e.RowIndex].Cells["Item_Id"].Value);

                cmd = new SqlCommand("Delete from Add_Item where Item_Id = '" + id + "'", con);
                cmd.ExecuteNonQuery();
                itemfillgrid();
               
            }

        }

        private void itemcancelbutton_Click(object sender, EventArgs e)
        {
            additemitemname.Text = String.Empty;
            additemdescription.Text = String.Empty;
            additemitemprice.Text = String.Empty;
            additemgoods.Checked = false;
            additemservice.Checked = false;
            additemcgst.Text = String.Empty;
            additemsgst.Text = String.Empty;
            additemigst.Text = String.Empty;
            additemutgst.Text = String.Empty;

        }
    }
}
