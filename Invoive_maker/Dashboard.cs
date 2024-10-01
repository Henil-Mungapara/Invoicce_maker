using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoive_maker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
           
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            PanelDashboard pd = new PanelDashboard();

            // Load the form into the panel
            LoadFormIntoPanel1(pd);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Create an instance of the PanelDashboard form
            PanelDashboard pd = new PanelDashboard();

            // Load the form into the panel
            LoadFormIntoPanel1(pd);

        }

        private void LoadFormIntoPanel1(PanelDashboard pd) // Use the correct type here
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            pd.TopLevel = false;


            // Set the form's Dock property to fill the panel
            pd.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(pd);

            // Show the form
            pd.Show();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            additem additemFrm = new additem();

            LoadFormIntoPanel2(additemFrm);
        }
        private void LoadFormIntoPanel2(additem form)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            form.TopLevel = false;

            // Set the form's Dock property to fill the panel
            form.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(form);

            // Show the form
            form.Show();
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Itemlist li = new Itemlist();

            // Load the form into the panel
            LoadFormIntoPanel3(li);
        }

        private void LoadFormIntoPanel3(Itemlist li)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            li.TopLevel = false;

            // Set the form's Dock property to fill the panel
            li.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(li);

            // Show the form
            li.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            addcustomer ad = new addcustomer();

            // Load the form into the panel
            LoadFormIntoPanel4(ad);
        }
        private void LoadFormIntoPanel4(addcustomer ad)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            ad.TopLevel = false;

            // Set the form's Dock property to fill the panel
            ad.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(ad);

            // Show the form
            ad.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Customer_List cl = new Customer_List();

            // Load the form into the panel
            LoadFormIntoPanel5(cl);
        }

        private void LoadFormIntoPanel5(Customer_List cl)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            cl.TopLevel = false;

            // Set the form's Dock property to fill the panel
            cl.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(cl);

            // Show the form
            cl.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            invoicemake im = new invoicemake();

            // Load the form into the panel
            LoadFormIntoPanel6(im);
        }

        private void LoadFormIntoPanel6(invoicemake im)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            im.TopLevel = false;

            // Set the form's Dock property to fill the panel
            im.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(im);

            // Show the form
            im.Show();
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            profile p = new profile();

            // Load the form into the panel
            LoadFormIntoPanel6(p);
        }

        private void LoadFormIntoPanel6(profile p)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            p.TopLevel = false;

            // Set the form's Dock property to fill the panel
            p.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(p);

            // Show the form
            p.Show();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {
            help h = new help();

            // Load the form into the panel
            LoadFormIntoPanel7(h);
        }

        private void LoadFormIntoPanel7(help h)
        {
            // Clear existing controls in the panel
            maindashboardpanel.Controls.Clear();

            // Set the form's TopLevel property to false
            h.TopLevel = false;

            // Set the form's Dock property to fill the panel
            h.Dock = DockStyle.Fill;

            // Add the form to the panel's controls
            maindashboardpanel.Controls.Add(h);

            // Show the form
            h.Show();
        }



        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            DialogResult 
                result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

               
                Login loginForm = new Login();
                loginForm.Show();
                this.Dispose();
                
            }
            else {
                MessageBox.Show("Nakki Thay to kejo tyare karsu Nirate Logout...Aavjo !!");
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {

        }

       
    }
}
