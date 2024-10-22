
namespace Invoive_maker
{
    partial class addcustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcustomer));
            this.addcustomertoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addcustomercustomername = new System.Windows.Forms.TextBox();
            this.addcustomercustomeremeil = new System.Windows.Forms.TextBox();
            this.addcustomercustomerphone = new System.Windows.Forms.TextBox();
            this.addcustomercustomercity = new System.Windows.Forms.TextBox();
            this.addcustomercustomergstno = new System.Windows.Forms.TextBox();
            this.addcustomercustomeradd = new System.Windows.Forms.Button();
            this.addcustomercustomercancel = new System.Windows.Forms.Button();
            this.listcustomerdataGridView = new System.Windows.Forms.DataGridView();
            this.Customer_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addcustomerinvoice = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.addcustomertoolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listcustomerdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addcustomertoolStrip
            // 
            this.addcustomertoolStrip.BackColor = System.Drawing.Color.Teal;
            this.addcustomertoolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.addcustomertoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.addcustomertoolStrip.Location = new System.Drawing.Point(0, 0);
            this.addcustomertoolStrip.Name = "addcustomertoolStrip";
            this.addcustomertoolStrip.Size = new System.Drawing.Size(1917, 70);
            this.addcustomertoolStrip.TabIndex = 2;
            this.addcustomertoolStrip.Text = "toolStrip1";
            this.addcustomertoolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.addcustomertoolStrip_ItemClicked);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(8);
            this.toolStripButton1.Size = new System.Drawing.Size(239, 60);
            this.toolStripButton1.Text = "Add Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(172, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Customer Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(172, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer E-mail Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(172, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Customer Phone No :\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(172, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Customer City :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(172, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Customer GST No :";
            // 
            // addcustomercustomername
            // 
            this.addcustomercustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomercustomername.Location = new System.Drawing.Point(410, 175);
            this.addcustomercustomername.Multiline = true;
            this.addcustomercustomername.Name = "addcustomercustomername";
            this.addcustomercustomername.Size = new System.Drawing.Size(262, 29);
            this.addcustomercustomername.TabIndex = 9;
            // 
            // addcustomercustomeremeil
            // 
            this.addcustomercustomeremeil.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomercustomeremeil.Location = new System.Drawing.Point(410, 221);
            this.addcustomercustomeremeil.Multiline = true;
            this.addcustomercustomeremeil.Name = "addcustomercustomeremeil";
            this.addcustomercustomeremeil.Size = new System.Drawing.Size(262, 29);
            this.addcustomercustomeremeil.TabIndex = 10;
            // 
            // addcustomercustomerphone
            // 
            this.addcustomercustomerphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomercustomerphone.Location = new System.Drawing.Point(410, 265);
            this.addcustomercustomerphone.Multiline = true;
            this.addcustomercustomerphone.Name = "addcustomercustomerphone";
            this.addcustomercustomerphone.Size = new System.Drawing.Size(262, 29);
            this.addcustomercustomerphone.TabIndex = 11;
            // 
            // addcustomercustomercity
            // 
            this.addcustomercustomercity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomercustomercity.Location = new System.Drawing.Point(410, 308);
            this.addcustomercustomercity.Multiline = true;
            this.addcustomercustomercity.Name = "addcustomercustomercity";
            this.addcustomercustomercity.Size = new System.Drawing.Size(262, 29);
            this.addcustomercustomercity.TabIndex = 12;
            // 
            // addcustomercustomergstno
            // 
            this.addcustomercustomergstno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomercustomergstno.Location = new System.Drawing.Point(410, 351);
            this.addcustomercustomergstno.Multiline = true;
            this.addcustomercustomergstno.Name = "addcustomercustomergstno";
            this.addcustomercustomergstno.Size = new System.Drawing.Size(262, 29);
            this.addcustomercustomergstno.TabIndex = 13;
            // 
            // addcustomercustomeradd
            // 
            this.addcustomercustomeradd.BackColor = System.Drawing.Color.Teal;
            this.addcustomercustomeradd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addcustomercustomeradd.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addcustomercustomeradd.Location = new System.Drawing.Point(167, 412);
            this.addcustomercustomeradd.Name = "addcustomercustomeradd";
            this.addcustomercustomeradd.Size = new System.Drawing.Size(120, 41);
            this.addcustomercustomeradd.TabIndex = 14;
            this.addcustomercustomeradd.Text = "ADD";
            this.addcustomercustomeradd.UseVisualStyleBackColor = false;
            this.addcustomercustomeradd.Click += new System.EventHandler(this.addcustomercustomeradd_Click);
            // 
            // addcustomercustomercancel
            // 
            this.addcustomercustomercancel.BackColor = System.Drawing.Color.Teal;
            this.addcustomercustomercancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addcustomercustomercancel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addcustomercustomercancel.Location = new System.Drawing.Point(310, 412);
            this.addcustomercustomercancel.Name = "addcustomercustomercancel";
            this.addcustomercustomercancel.Size = new System.Drawing.Size(137, 41);
            this.addcustomercustomercancel.TabIndex = 15;
            this.addcustomercustomercancel.Text = "CLEAR";
            this.addcustomercustomercancel.UseVisualStyleBackColor = false;
            this.addcustomercustomercancel.Click += new System.EventHandler(this.customercancel_Click);
            // 
            // listcustomerdataGridView
            // 
            this.listcustomerdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listcustomerdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listcustomerdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Customer_Id,
            this.Customer_Name,
            this.Customer_Email,
            this.Customer_Phone,
            this.Customer_City,
            this.Customer_GST,
            this.Edit,
            this.Remove});
            this.listcustomerdataGridView.Location = new System.Drawing.Point(170, 664);
            this.listcustomerdataGridView.Name = "listcustomerdataGridView";
            this.listcustomerdataGridView.RowHeadersWidth = 51;
            this.listcustomerdataGridView.RowTemplate.Height = 100;
            this.listcustomerdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listcustomerdataGridView.Size = new System.Drawing.Size(1405, 399);
            this.listcustomerdataGridView.TabIndex = 20;
            this.listcustomerdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listcustomerdataGridView_CellClick);
            this.listcustomerdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listcustomerdataGridView_CellContentClick);
            // 
            // Customer_Id
            // 
            this.Customer_Id.DataPropertyName = "Customer_Id";
            this.Customer_Id.HeaderText = "Customer_Id";
            this.Customer_Id.MinimumWidth = 6;
            this.Customer_Id.Name = "Customer_Id";
            this.Customer_Id.Width = 125;
            // 
            // Customer_Name
            // 
            this.Customer_Name.DataPropertyName = "Customer_Name";
            this.Customer_Name.HeaderText = "Customer_Name";
            this.Customer_Name.MinimumWidth = 6;
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Width = 125;
            // 
            // Customer_Email
            // 
            this.Customer_Email.DataPropertyName = "Customer_Email";
            this.Customer_Email.HeaderText = "Customer_Email";
            this.Customer_Email.MinimumWidth = 6;
            this.Customer_Email.Name = "Customer_Email";
            this.Customer_Email.Width = 125;
            // 
            // Customer_Phone
            // 
            this.Customer_Phone.DataPropertyName = "Customer_Phone";
            this.Customer_Phone.HeaderText = "Customer_Phone";
            this.Customer_Phone.MinimumWidth = 6;
            this.Customer_Phone.Name = "Customer_Phone";
            this.Customer_Phone.Width = 125;
            // 
            // Customer_City
            // 
            this.Customer_City.DataPropertyName = "Customer_City";
            this.Customer_City.HeaderText = "Customer_City";
            this.Customer_City.MinimumWidth = 6;
            this.Customer_City.Name = "Customer_City";
            this.Customer_City.Width = 125;
            // 
            // Customer_GST
            // 
            this.Customer_GST.DataPropertyName = "Customer_GST";
            this.Customer_GST.HeaderText = "Customer_GST";
            this.Customer_GST.MinimumWidth = 6;
            this.Customer_GST.Name = "Customer_GST";
            this.Customer_GST.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.MinimumWidth = 6;
            this.Remove.Name = "Remove";
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            this.Remove.Width = 125;
            // 
            // addcustomerinvoice
            // 
            this.addcustomerinvoice.BackColor = System.Drawing.Color.Teal;
            this.addcustomerinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.addcustomerinvoice.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addcustomerinvoice.Location = new System.Drawing.Point(467, 412);
            this.addcustomerinvoice.Name = "addcustomerinvoice";
            this.addcustomerinvoice.Size = new System.Drawing.Size(205, 41);
            this.addcustomerinvoice.TabIndex = 21;
            this.addcustomerinvoice.Text = "INVOICE PRINT";
            this.addcustomerinvoice.UseVisualStyleBackColor = false;
            this.addcustomerinvoice.Click += new System.EventHandler(this.addcustomerinvoice_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(706, 179);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(869, 452);
            this.crystalReportViewer1.TabIndex = 22;
            // 
            // addcustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1917, 1102);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.addcustomerinvoice);
            this.Controls.Add(this.listcustomerdataGridView);
            this.Controls.Add(this.addcustomercustomercancel);
            this.Controls.Add(this.addcustomercustomeradd);
            this.Controls.Add(this.addcustomercustomergstno);
            this.Controls.Add(this.addcustomercustomercity);
            this.Controls.Add(this.addcustomercustomerphone);
            this.Controls.Add(this.addcustomercustomeremeil);
            this.Controls.Add(this.addcustomercustomername);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addcustomertoolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addcustomer";
            this.Text = "addcustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.addcustomer_Load);
            this.addcustomertoolStrip.ResumeLayout(false);
            this.addcustomertoolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listcustomerdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip addcustomertoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addcustomercustomername;
        private System.Windows.Forms.TextBox addcustomercustomeremeil;
        private System.Windows.Forms.TextBox addcustomercustomerphone;
        private System.Windows.Forms.TextBox addcustomercustomercity;
        private System.Windows.Forms.TextBox addcustomercustomergstno;
        private System.Windows.Forms.Button addcustomercustomeradd;
        private System.Windows.Forms.Button addcustomercustomercancel;
        private System.Windows.Forms.DataGridView listcustomerdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_GST;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
        private System.Windows.Forms.Button addcustomerinvoice;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}