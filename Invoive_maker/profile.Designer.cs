
namespace Invoive_maker
{
    partial class profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile));
            this.profiletoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.profilepictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.profilepanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.profilecompanyname = new System.Windows.Forms.TextBox();
            this.profileemailaccount = new System.Windows.Forms.TextBox();
            this.profilemobileno = new System.Windows.Forms.TextBox();
            this.profilecompanyaddress = new System.Windows.Forms.TextBox();
            this.profilegstno = new System.Windows.Forms.TextBox();
            this.profileedit = new System.Windows.Forms.Button();
            this.profileupload = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.profiledataGridView = new System.Windows.Forms.DataGridView();
            this.Company_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_GST = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Image = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Image = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.profiletoolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).BeginInit();
            this.profilepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profiledataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // profiletoolStrip
            // 
            this.profiletoolStrip.BackColor = System.Drawing.Color.Teal;
            this.profiletoolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.profiletoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.profiletoolStrip.Location = new System.Drawing.Point(0, 0);
            this.profiletoolStrip.Name = "profiletoolStrip";
            this.profiletoolStrip.Size = new System.Drawing.Size(1808, 62);
            this.profiletoolStrip.TabIndex = 4;
            this.profiletoolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(8);
            this.toolStripButton1.Size = new System.Drawing.Size(111, 52);
            this.toolStripButton1.Text = "Profile";
            // 
            // profilepictureBox
            // 
            this.profilepictureBox.BackColor = System.Drawing.Color.MintCream;
            this.profilepictureBox.Location = new System.Drawing.Point(17, 13);
            this.profilepictureBox.Name = "profilepictureBox";
            this.profilepictureBox.Size = new System.Drawing.Size(195, 155);
            this.profilepictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilepictureBox.TabIndex = 5;
            this.profilepictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(535, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Company Name  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(535, 432);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "E-mail account :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(535, 482);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mobile Number :";
            // 
            // profilepanel
            // 
            this.profilepanel.BackColor = System.Drawing.Color.Teal;
            this.profilepanel.Controls.Add(this.profilepictureBox);
            this.profilepanel.Location = new System.Drawing.Point(523, 165);
            this.profilepanel.Name = "profilepanel";
            this.profilepanel.Size = new System.Drawing.Size(620, 181);
            this.profilepanel.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(535, 551);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Company Address :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(535, 624);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "GST No :";
            // 
            // profilecompanyname
            // 
            this.profilecompanyname.Location = new System.Drawing.Point(750, 382);
            this.profilecompanyname.Multiline = true;
            this.profilecompanyname.Name = "profilecompanyname";
            this.profilecompanyname.Size = new System.Drawing.Size(393, 32);
            this.profilecompanyname.TabIndex = 12;
            // 
            // profileemailaccount
            // 
            this.profileemailaccount.Location = new System.Drawing.Point(750, 429);
            this.profileemailaccount.Multiline = true;
            this.profileemailaccount.Name = "profileemailaccount";
            this.profileemailaccount.Size = new System.Drawing.Size(393, 32);
            this.profileemailaccount.TabIndex = 13;
            // 
            // profilemobileno
            // 
            this.profilemobileno.Location = new System.Drawing.Point(750, 480);
            this.profilemobileno.Multiline = true;
            this.profilemobileno.Name = "profilemobileno";
            this.profilemobileno.Size = new System.Drawing.Size(393, 32);
            this.profilemobileno.TabIndex = 14;
            this.profilemobileno.TextChanged += new System.EventHandler(this.profilemobileno_TextChanged);
            // 
            // profilecompanyaddress
            // 
            this.profilecompanyaddress.Location = new System.Drawing.Point(750, 530);
            this.profilecompanyaddress.Multiline = true;
            this.profilecompanyaddress.Name = "profilecompanyaddress";
            this.profilecompanyaddress.Size = new System.Drawing.Size(393, 72);
            this.profilecompanyaddress.TabIndex = 15;
            // 
            // profilegstno
            // 
            this.profilegstno.Location = new System.Drawing.Point(750, 622);
            this.profilegstno.Multiline = true;
            this.profilegstno.Name = "profilegstno";
            this.profilegstno.Size = new System.Drawing.Size(393, 32);
            this.profilegstno.TabIndex = 16;
            // 
            // profileedit
            // 
            this.profileedit.BackColor = System.Drawing.Color.Teal;
            this.profileedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileedit.ForeColor = System.Drawing.SystemColors.Control;
            this.profileedit.Location = new System.Drawing.Point(907, 693);
            this.profileedit.Name = "profileedit";
            this.profileedit.Size = new System.Drawing.Size(99, 49);
            this.profileedit.TabIndex = 17;
            this.profileedit.Text = "Save";
            this.profileedit.UseVisualStyleBackColor = false;
            this.profileedit.Click += new System.EventHandler(this.profileedit_Click_1);
            // 
            // profileupload
            // 
            this.profileupload.BackColor = System.Drawing.Color.Teal;
            this.profileupload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileupload.ForeColor = System.Drawing.SystemColors.Control;
            this.profileupload.Location = new System.Drawing.Point(1149, 230);
            this.profileupload.Name = "profileupload";
            this.profileupload.Size = new System.Drawing.Size(116, 57);
            this.profileupload.TabIndex = 20;
            this.profileupload.Text = "Upload";
            this.profileupload.UseVisualStyleBackColor = false;
            this.profileupload.Click += new System.EventHandler(this.profileupload_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // profiledataGridView
            // 
            this.profiledataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.profiledataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Company_Id,
            this.Company_Name,
            this.Company_Email,
            this.Company_Phone,
            this.Company_Address,
            this.Company_GST,
            this.Company_Image,
            this.Image,
            this.Edit,
            this.Remove});
            this.profiledataGridView.Location = new System.Drawing.Point(108, 759);
            this.profiledataGridView.Name = "profiledataGridView";
            this.profiledataGridView.RowHeadersWidth = 51;
            this.profiledataGridView.RowTemplate.Height = 100;
            this.profiledataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.profiledataGridView.Size = new System.Drawing.Size(1569, 290);
            this.profiledataGridView.TabIndex = 19;
            this.profiledataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.profiledataGridView_CellClick);
            // 
            // Company_Id
            // 
            this.Company_Id.DataPropertyName = "Company_Id";
            this.Company_Id.HeaderText = "Company_Id";
            this.Company_Id.MinimumWidth = 6;
            this.Company_Id.Name = "Company_Id";
            this.Company_Id.Width = 125;
            // 
            // Company_Name
            // 
            this.Company_Name.DataPropertyName = "Company_Name";
            this.Company_Name.HeaderText = "Company_Name";
            this.Company_Name.MinimumWidth = 6;
            this.Company_Name.Name = "Company_Name";
            this.Company_Name.Width = 125;
            // 
            // Company_Email
            // 
            this.Company_Email.DataPropertyName = "Company_Email";
            this.Company_Email.HeaderText = "Company_Email";
            this.Company_Email.MinimumWidth = 6;
            this.Company_Email.Name = "Company_Email";
            this.Company_Email.Width = 125;
            // 
            // Company_Phone
            // 
            this.Company_Phone.DataPropertyName = "Company_Phone";
            this.Company_Phone.HeaderText = "Company_Phone";
            this.Company_Phone.MinimumWidth = 6;
            this.Company_Phone.Name = "Company_Phone";
            this.Company_Phone.Width = 125;
            // 
            // Company_Address
            // 
            this.Company_Address.DataPropertyName = "Company_Address";
            this.Company_Address.HeaderText = "Company_Address";
            this.Company_Address.MinimumWidth = 6;
            this.Company_Address.Name = "Company_Address";
            this.Company_Address.Width = 125;
            // 
            // Company_GST
            // 
            this.Company_GST.DataPropertyName = "Company_GST";
            this.Company_GST.HeaderText = "Company_GST";
            this.Company_GST.MinimumWidth = 6;
            this.Company_GST.Name = "Company_GST";
            this.Company_GST.Width = 125;
            // 
            // Company_Image
            // 
            this.Company_Image.DataPropertyName = "Company_Image";
            this.Company_Image.HeaderText = "Company_Image";
            this.Company_Image.MinimumWidth = 6;
            this.Company_Image.Name = "Company_Image";
            this.Company_Image.Width = 125;
            // 
            // Image
            // 
            this.Image.DataPropertyName = "Image";
            this.Image.HeaderText = "Image";
            this.Image.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Image.MinimumWidth = 6;
            this.Image.Name = "Image";
            this.Image.Width = 125;
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
            // profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1808, 1102);
            this.Controls.Add(this.profileupload);
            this.Controls.Add(this.profiledataGridView);
            this.Controls.Add(this.profileedit);
            this.Controls.Add(this.profilegstno);
            this.Controls.Add(this.profilecompanyaddress);
            this.Controls.Add(this.profilemobileno);
            this.Controls.Add(this.profileemailaccount);
            this.Controls.Add(this.profilecompanyname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.profilepanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.profiletoolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "profile";
            this.Text = "profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.profile_Load);
            this.profiletoolStrip.ResumeLayout(false);
            this.profiletoolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilepictureBox)).EndInit();
            this.profilepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profiledataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip profiletoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.PictureBox profilepictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel profilepanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox profilecompanyname;
        private System.Windows.Forms.TextBox profileemailaccount;
        private System.Windows.Forms.TextBox profilemobileno;
        private System.Windows.Forms.TextBox profilecompanyaddress;
        private System.Windows.Forms.TextBox profilegstno;
        private System.Windows.Forms.Button profileedit;
        private System.Windows.Forms.Button profileupload;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView profiledataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_GST;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Image;
        private System.Windows.Forms.DataGridViewImageColumn Image;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}