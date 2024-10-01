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
    public partial class profile : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;
        String s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\munga\source\repos\Invoive_maker\Invoive_maker\Invoice_maker.mdf;Integrated Security=True";
        int id;
        String i, d;

        public profile()
        {
            InitializeComponent();
        }

        void connection() {
            con = new SqlConnection(s);
            con.Open();
        }

        private void profileedit_Click_1(object sender, EventArgs e)
        {
            connection();

            if (profileedit.Text == "Save")
            {
                if (profilecompanyname.Text == "")
                {
                    MessageBox.Show("Enter Company Name Must Be..$$");
                }

                else
                {

                    d = Application.StartupPath + "\\images\\" + openFileDialog1.SafeFileName.ToString();
                    System.IO.File.Copy(i, d);

                    cmd = new SqlCommand("insert into Admin_Profile(Company_Name, Comapny_Email, Company_Phone, Company_Address, Company_GST, Company_Image)values('" + profilecompanyname.Text + "','" + profileemailaccount.Text + "','" + profilemobileno.Text + "','" + profilecompanyaddress.Text + "','" + profilegstno.Text + "','" + d + "')", con);
                    cmd.ExecuteNonQuery();
                    profilefillgrid();
                }
            }
            else {
                try
                {
                    connection();

                  cmd = new SqlCommand("update Admin_Profile set Company_Name = '" + profilecompanyname.Text + "',Company_Email = '" + profileemailaccount.Text + "',Company_Phone='" + profilemobileno.Text + "',Company_Address = '" + profilecompanyaddress.Text + "',Company_GST = '" + profilegstno.Text + "' Where Company_Id='" + id + "'", con);

                    cmd.ExecuteNonQuery();
                    profilefillgrid();
                    MessageBox.Show("Your Data Update Successfully!");


                    profileedit.Text = "Save";
                }

                catch (Exception result)
                {
                    MessageBox.Show("Hello Error is Coming...!!" + result);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void profilemobileno_TextChanged(object sender, EventArgs e)
        {

        }

        private void profile_Load(object sender, EventArgs e)
        {
            connection();
            profilefillgrid();
        }

        private void profileupload_Click(object sender, EventArgs e)
        {
            uploadimage();
        }

        void uploadimage() {
            openFileDialog1.ShowDialog();

            try
            {
                i = openFileDialog1.FileName.ToString();
                profilepictureBox.Load(i);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error...!!" + e);
            }
        }

        private void profiledataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (profiledataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                profileedit.Text = "Edit";
                connection();

                id = Convert.ToInt32(profiledataGridView.Rows[e.RowIndex].Cells["Company_Id"].Value);

                string companyname, CompanyEmail, companyphone, companyaddress, companygstno;


                companyname = (profiledataGridView.Rows[e.RowIndex].Cells["Company_Name"].Value).ToString();

                CompanyEmail = (profiledataGridView.Rows[e.RowIndex].Cells["Company_Email"].Value).ToString();


                companyphone = (profiledataGridView.Rows[e.RowIndex].Cells["Company_Phone"].Value).ToString();

                companyaddress = (profiledataGridView.Rows[e.RowIndex].Cells["Company_Address"].Value).ToString();

                companygstno = (profiledataGridView.Rows[e.RowIndex].Cells["Company_GST"].Value).ToString();

                profilecompanyname.Text = companyname;
                profileemailaccount.Text = CompanyEmail;
                profilemobileno.Text = companyphone;
                profilecompanyaddress.Text = companyaddress;
                profilegstno.Text = companygstno;


            }

            if (profiledataGridView.Columns[e.ColumnIndex].HeaderText == "Remove")
            {
                connection();
                id = Convert.ToInt32(profiledataGridView.Rows[e.RowIndex].Cells["Company_Id"].Value);

                cmd = new SqlCommand("Delete from Admin_Profile where Company_Id = '" + id + "'", con);
                cmd.ExecuteNonQuery();
                profilefillgrid();

            }

        }

            void profilefillgrid()
        {
            connection();
            da = new SqlDataAdapter("select * from Admin_Profile", con);
            dt = new DataTable();
            da.Fill(dt);

            dt.Columns.Add("Image", Type.GetType("System.Byte[]"));
            profiledataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataRow drow in dt.Rows)
            {

                drow["Image"] = File.ReadAllBytes(drow["Company_Image"].ToString());

            }

            profiledataGridView.DataSource = dt;
        }

    }
}
