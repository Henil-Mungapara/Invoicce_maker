
namespace Invoive_maker
{
    partial class additem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(additem));
            this.additemtoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.additemgoods = new System.Windows.Forms.RadioButton();
            this.additemservice = new System.Windows.Forms.RadioButton();
            this.additemitemname = new System.Windows.Forms.TextBox();
            this.additemitemprice = new System.Windows.Forms.TextBox();
            this.additemdescription = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.additemutgst = new System.Windows.Forms.TextBox();
            this.additemsgst = new System.Windows.Forms.TextBox();
            this.additemigst = new System.Windows.Forms.TextBox();
            this.additemcgst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemaddbutton = new System.Windows.Forms.Button();
            this.itemcancelbutton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.itemlistdataGridView = new System.Windows.Forms.DataGridView();
            this.Item_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Item_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UTGST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.additemtoolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // additemtoolStrip
            // 
            this.additemtoolStrip.BackColor = System.Drawing.Color.Teal;
            this.additemtoolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.additemtoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.additemtoolStrip.Location = new System.Drawing.Point(0, 0);
            this.additemtoolStrip.Name = "additemtoolStrip";
            this.additemtoolStrip.Size = new System.Drawing.Size(1900, 64);
            this.additemtoolStrip.TabIndex = 0;
            this.additemtoolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Size = new System.Drawing.Size(175, 54);
            this.toolStripButton1.Text = "Add Item";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(481, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Item Description :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(489, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "item Price :";
            // 
            // additemgoods
            // 
            this.additemgoods.AutoSize = true;
            this.additemgoods.BackColor = System.Drawing.Color.White;
            this.additemgoods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.additemgoods.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.additemgoods.Location = new System.Drawing.Point(708, 289);
            this.additemgoods.Margin = new System.Windows.Forms.Padding(4);
            this.additemgoods.Name = "additemgoods";
            this.additemgoods.Padding = new System.Windows.Forms.Padding(5);
            this.additemgoods.Size = new System.Drawing.Size(101, 39);
            this.additemgoods.TabIndex = 4;
            this.additemgoods.TabStop = true;
            this.additemgoods.Text = "Goods";
            this.additemgoods.UseVisualStyleBackColor = false;
            this.additemgoods.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // additemservice
            // 
            this.additemservice.AutoSize = true;
            this.additemservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.additemservice.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.additemservice.Location = new System.Drawing.Point(817, 289);
            this.additemservice.Margin = new System.Windows.Forms.Padding(4);
            this.additemservice.Name = "additemservice";
            this.additemservice.Padding = new System.Windows.Forms.Padding(5);
            this.additemservice.Size = new System.Drawing.Size(109, 39);
            this.additemservice.TabIndex = 5;
            this.additemservice.TabStop = true;
            this.additemservice.Text = "Service";
            this.additemservice.UseVisualStyleBackColor = true;
            this.additemservice.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // additemitemname
            // 
            this.additemitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemitemname.Location = new System.Drawing.Point(670, 153);
            this.additemitemname.Multiline = true;
            this.additemitemname.Name = "additemitemname";
            this.additemitemname.Size = new System.Drawing.Size(290, 32);
            this.additemitemname.TabIndex = 7;
            // 
            // additemitemprice
            // 
            this.additemitemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemitemprice.Location = new System.Drawing.Point(670, 335);
            this.additemitemprice.Multiline = true;
            this.additemitemprice.Name = "additemitemprice";
            this.additemitemprice.Size = new System.Drawing.Size(290, 32);
            this.additemitemprice.TabIndex = 8;
            // 
            // additemdescription
            // 
            this.additemdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemdescription.Location = new System.Drawing.Point(670, 202);
            this.additemdescription.Multiline = true;
            this.additemdescription.Name = "additemdescription";
            this.additemdescription.Size = new System.Drawing.Size(290, 80);
            this.additemdescription.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.additemutgst);
            this.panel1.Controls.Add(this.additemsgst);
            this.panel1.Controls.Add(this.additemigst);
            this.panel1.Controls.Add(this.additemcgst);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(380, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 212);
            this.panel1.TabIndex = 7;
            // 
            // additemutgst
            // 
            this.additemutgst.BackColor = System.Drawing.Color.Silver;
            this.additemutgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemutgst.Location = new System.Drawing.Point(524, 134);
            this.additemutgst.Multiline = true;
            this.additemutgst.Name = "additemutgst";
            this.additemutgst.Size = new System.Drawing.Size(192, 32);
            this.additemutgst.TabIndex = 10;
            // 
            // additemsgst
            // 
            this.additemsgst.BackColor = System.Drawing.Color.Silver;
            this.additemsgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemsgst.Location = new System.Drawing.Point(524, 79);
            this.additemsgst.Multiline = true;
            this.additemsgst.Name = "additemsgst";
            this.additemsgst.Size = new System.Drawing.Size(192, 32);
            this.additemsgst.TabIndex = 11;
            // 
            // additemigst
            // 
            this.additemigst.BackColor = System.Drawing.Color.Silver;
            this.additemigst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemigst.Location = new System.Drawing.Point(172, 134);
            this.additemigst.Multiline = true;
            this.additemigst.Name = "additemigst";
            this.additemigst.Size = new System.Drawing.Size(192, 32);
            this.additemigst.TabIndex = 12;
            // 
            // additemcgst
            // 
            this.additemcgst.BackColor = System.Drawing.Color.Silver;
            this.additemcgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additemcgst.Location = new System.Drawing.Point(172, 79);
            this.additemcgst.Multiline = true;
            this.additemcgst.Name = "additemcgst";
            this.additemcgst.Size = new System.Drawing.Size(192, 32);
            this.additemcgst.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(432, 137);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "UTGST :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(433, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "SGST :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(80, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "IGST :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(80, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "CGST :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(307, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Types of GST";
            // 
            // itemaddbutton
            // 
            this.itemaddbutton.BackColor = System.Drawing.Color.Teal;
            this.itemaddbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.itemaddbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemaddbutton.Location = new System.Drawing.Point(660, 652);
            this.itemaddbutton.Name = "itemaddbutton";
            this.itemaddbutton.Size = new System.Drawing.Size(109, 43);
            this.itemaddbutton.TabIndex = 10;
            this.itemaddbutton.Text = "ADD";
            this.itemaddbutton.UseVisualStyleBackColor = false;
            this.itemaddbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // itemcancelbutton
            // 
            this.itemcancelbutton.BackColor = System.Drawing.Color.Teal;
            this.itemcancelbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.itemcancelbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.itemcancelbutton.Location = new System.Drawing.Point(792, 652);
            this.itemcancelbutton.Name = "itemcancelbutton";
            this.itemcancelbutton.Size = new System.Drawing.Size(125, 43);
            this.itemcancelbutton.TabIndex = 11;
            this.itemcancelbutton.Text = "CANCEL";
            this.itemcancelbutton.UseVisualStyleBackColor = false;
            this.itemcancelbutton.Click += new System.EventHandler(this.itemcancelbutton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(481, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name :";
            // 
            // itemlistdataGridView
            // 
            this.itemlistdataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.itemlistdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemlistdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_Id,
            this.Item_Name,
            this.Item_Description,
            this.Item_Type,
            this.Item_Price,
            this.CGST,
            this.SGST,
            this.IGST,
            this.UTGST,
            this.Edit,
            this.Remove});
            this.itemlistdataGridView.Location = new System.Drawing.Point(28, 730);
            this.itemlistdataGridView.Name = "itemlistdataGridView";
            this.itemlistdataGridView.RowHeadersWidth = 51;
            this.itemlistdataGridView.RowTemplate.Height = 100;
            this.itemlistdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.itemlistdataGridView.Size = new System.Drawing.Size(1751, 371);
            this.itemlistdataGridView.TabIndex = 14;
            this.itemlistdataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemlistdataGridView_CellClick);
            this.itemlistdataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.itemlistdataGridView_CellContentClick);
            // 
            // Item_Id
            // 
            this.Item_Id.DataPropertyName = "Item_Id";
            this.Item_Id.HeaderText = "Item_Id";
            this.Item_Id.MinimumWidth = 6;
            this.Item_Id.Name = "Item_Id";
            this.Item_Id.ReadOnly = true;
            this.Item_Id.Width = 125;
            // 
            // Item_Name
            // 
            this.Item_Name.DataPropertyName = "Item_Name";
            this.Item_Name.HeaderText = "Item_Name";
            this.Item_Name.MinimumWidth = 6;
            this.Item_Name.Name = "Item_Name";
            this.Item_Name.Width = 125;
            // 
            // Item_Description
            // 
            this.Item_Description.DataPropertyName = "Item_Description";
            this.Item_Description.HeaderText = "Item_Description";
            this.Item_Description.MinimumWidth = 6;
            this.Item_Description.Name = "Item_Description";
            this.Item_Description.Width = 125;
            // 
            // Item_Type
            // 
            this.Item_Type.DataPropertyName = "Item_Type";
            this.Item_Type.HeaderText = "Item_Type";
            this.Item_Type.MinimumWidth = 6;
            this.Item_Type.Name = "Item_Type";
            this.Item_Type.Width = 125;
            // 
            // Item_Price
            // 
            this.Item_Price.DataPropertyName = "Item_Price";
            this.Item_Price.HeaderText = "Item_Price";
            this.Item_Price.MinimumWidth = 6;
            this.Item_Price.Name = "Item_Price";
            this.Item_Price.Width = 125;
            // 
            // CGST
            // 
            this.CGST.DataPropertyName = "CGST";
            this.CGST.HeaderText = "CGST";
            this.CGST.MinimumWidth = 6;
            this.CGST.Name = "CGST";
            this.CGST.Width = 125;
            // 
            // SGST
            // 
            this.SGST.DataPropertyName = "SGST";
            this.SGST.HeaderText = "SGST";
            this.SGST.MinimumWidth = 6;
            this.SGST.Name = "SGST";
            this.SGST.Width = 125;
            // 
            // IGST
            // 
            this.IGST.DataPropertyName = "IGST";
            this.IGST.HeaderText = "IGST";
            this.IGST.MinimumWidth = 6;
            this.IGST.Name = "IGST";
            this.IGST.Width = 125;
            // 
            // UTGST
            // 
            this.UTGST.DataPropertyName = "UTGST";
            this.UTGST.HeaderText = "UTGST";
            this.UTGST.MinimumWidth = 6;
            this.UTGST.Name = "UTGST";
            this.UTGST.Width = 125;
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
            // additem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1900, 1102);
            this.Controls.Add(this.itemlistdataGridView);
            this.Controls.Add(this.itemcancelbutton);
            this.Controls.Add(this.itemaddbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.additemdescription);
            this.Controls.Add(this.additemitemprice);
            this.Controls.Add(this.additemitemname);
            this.Controls.Add(this.additemservice);
            this.Controls.Add(this.additemgoods);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.additemtoolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "additem";
            this.Text = "Dashboard";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.additem_Load);
            this.additemtoolStrip.ResumeLayout(false);
            this.additemtoolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemlistdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip additemtoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton additemgoods;
        private System.Windows.Forms.RadioButton additemservice;
        private System.Windows.Forms.TextBox additemitemname;
        private System.Windows.Forms.TextBox additemitemprice;
        private System.Windows.Forms.TextBox additemdescription;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox additemutgst;
        private System.Windows.Forms.TextBox additemsgst;
        private System.Windows.Forms.TextBox additemigst;
        private System.Windows.Forms.TextBox additemcgst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button itemaddbutton;
        private System.Windows.Forms.Button itemcancelbutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView itemlistdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn CGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn SGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGST;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTGST;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}