
namespace Invoive_maker
{
    partial class InvoicePrint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InvoicePrint));
            this.invoiceprinttoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.invoiceprintbutton = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.choosedate = new System.Windows.Forms.Label();
            this.invoiceprintdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.date1 = new System.Windows.Forms.Label();
            this.date2 = new System.Windows.Forms.Label();
            this.invoiceprintstartdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceprintenddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectdate = new System.Windows.Forms.Label();
            this.invoiceprintcomboBox = new System.Windows.Forms.ComboBox();
            this.invoiceprinttoolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceprinttoolStrip
            // 
            this.invoiceprinttoolStrip.BackColor = System.Drawing.Color.Teal;
            this.invoiceprinttoolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.invoiceprinttoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.invoiceprinttoolStrip.Location = new System.Drawing.Point(0, 0);
            this.invoiceprinttoolStrip.Name = "invoiceprinttoolStrip";
            this.invoiceprinttoolStrip.Size = new System.Drawing.Size(1942, 64);
            this.invoiceprinttoolStrip.TabIndex = 1;
            this.invoiceprinttoolStrip.Text = "toolStrip1";
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
            this.toolStripButton1.Size = new System.Drawing.Size(215, 54);
            this.toolStripButton1.Text = "Invoice Print";
            // 
            // invoiceprintbutton
            // 
            this.invoiceprintbutton.BackColor = System.Drawing.Color.Teal;
            this.invoiceprintbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.invoiceprintbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invoiceprintbutton.Location = new System.Drawing.Point(70, 345);
            this.invoiceprintbutton.Name = "invoiceprintbutton";
            this.invoiceprintbutton.Size = new System.Drawing.Size(218, 43);
            this.invoiceprintbutton.TabIndex = 11;
            this.invoiceprintbutton.Text = "INVOICE PRINT";
            this.invoiceprintbutton.UseVisualStyleBackColor = false;
            this.invoiceprintbutton.Click += new System.EventHandler(this.invoiceprintbutton_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(513, 130);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1255, 734);
            this.crystalReportViewer1.TabIndex = 12;
            // 
            // choosedate
            // 
            this.choosedate.AutoSize = true;
            this.choosedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosedate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.choosedate.Location = new System.Drawing.Point(33, 188);
            this.choosedate.Name = "choosedate";
            this.choosedate.Size = new System.Drawing.Size(138, 25);
            this.choosedate.TabIndex = 13;
            this.choosedate.Text = "Choose Date :";
            // 
            // invoiceprintdateTimePicker
            // 
            this.invoiceprintdateTimePicker.Location = new System.Drawing.Point(177, 191);
            this.invoiceprintdateTimePicker.Name = "invoiceprintdateTimePicker";
            this.invoiceprintdateTimePicker.Size = new System.Drawing.Size(231, 22);
            this.invoiceprintdateTimePicker.TabIndex = 14;
            // 
            // date1
            // 
            this.date1.AutoSize = true;
            this.date1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date1.Location = new System.Drawing.Point(33, 239);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(110, 25);
            this.date1.TabIndex = 15;
            this.date1.Text = "Start Date :";
            // 
            // date2
            // 
            this.date2.AutoSize = true;
            this.date2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.date2.Location = new System.Drawing.Point(33, 278);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(109, 25);
            this.date2.TabIndex = 16;
            this.date2.Text = "End Date  :";
            // 
            // invoiceprintstartdateTimePicker
            // 
            this.invoiceprintstartdateTimePicker.Location = new System.Drawing.Point(177, 242);
            this.invoiceprintstartdateTimePicker.Name = "invoiceprintstartdateTimePicker";
            this.invoiceprintstartdateTimePicker.Size = new System.Drawing.Size(231, 22);
            this.invoiceprintstartdateTimePicker.TabIndex = 17;
            // 
            // invoiceprintenddateTimePicker
            // 
            this.invoiceprintenddateTimePicker.Location = new System.Drawing.Point(177, 278);
            this.invoiceprintenddateTimePicker.Name = "invoiceprintenddateTimePicker";
            this.invoiceprintenddateTimePicker.Size = new System.Drawing.Size(231, 22);
            this.invoiceprintenddateTimePicker.TabIndex = 18;
            // 
            // selectdate
            // 
            this.selectdate.AutoSize = true;
            this.selectdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectdate.Location = new System.Drawing.Point(33, 130);
            this.selectdate.Name = "selectdate";
            this.selectdate.Size = new System.Drawing.Size(128, 25);
            this.selectdate.TabIndex = 19;
            this.selectdate.Text = "Select Type :";
            // 
            // invoiceprintcomboBox
            // 
            this.invoiceprintcomboBox.FormattingEnabled = true;
            this.invoiceprintcomboBox.Items.AddRange(new object[] {
            "Specific Range",
            "Specific Date"});
            this.invoiceprintcomboBox.Location = new System.Drawing.Point(177, 134);
            this.invoiceprintcomboBox.Name = "invoiceprintcomboBox";
            this.invoiceprintcomboBox.Size = new System.Drawing.Size(231, 24);
            this.invoiceprintcomboBox.TabIndex = 20;
            // 
            // InvoicePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.invoiceprintcomboBox);
            this.Controls.Add(this.selectdate);
            this.Controls.Add(this.invoiceprintenddateTimePicker);
            this.Controls.Add(this.invoiceprintstartdateTimePicker);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.invoiceprintdateTimePicker);
            this.Controls.Add(this.choosedate);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.invoiceprintbutton);
            this.Controls.Add(this.invoiceprinttoolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicePrint";
            this.Text = "InvoicePrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoicePrint_Load);
            this.invoiceprinttoolStrip.ResumeLayout(false);
            this.invoiceprinttoolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip invoiceprinttoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Button invoiceprintbutton;
        //private CachedCrystalReport1 cachedCrystalReport11;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label choosedate;
        private System.Windows.Forms.DateTimePicker invoiceprintdateTimePicker;
        private System.Windows.Forms.Label date1;
        private System.Windows.Forms.Label date2;
        private System.Windows.Forms.DateTimePicker invoiceprintstartdateTimePicker;
        private System.Windows.Forms.DateTimePicker invoiceprintenddateTimePicker;
        private System.Windows.Forms.Label selectdate;
        private System.Windows.Forms.ComboBox invoiceprintcomboBox;
    }
}