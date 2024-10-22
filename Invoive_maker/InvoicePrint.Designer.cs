
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
            this.specificdateLabel = new System.Windows.Forms.Label();
            this.specificdatedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startdateLabel = new System.Windows.Forms.Label();
            this.enddateLabel = new System.Windows.Forms.Label();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.selectdate = new System.Windows.Forms.Label();
            this.invoiceprintcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.invoiceprintcustomername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.invoiceprintitemname = new System.Windows.Forms.TextBox();
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
            this.crystalReportViewer1.Location = new System.Drawing.Point(503, 191);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1255, 734);
            this.crystalReportViewer1.TabIndex = 12;
            // 
            // specificdateLabel
            // 
            this.specificdateLabel.AutoSize = true;
            this.specificdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specificdateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.specificdateLabel.Location = new System.Drawing.Point(33, 188);
            this.specificdateLabel.Name = "specificdateLabel";
            this.specificdateLabel.Size = new System.Drawing.Size(138, 25);
            this.specificdateLabel.TabIndex = 13;
            this.specificdateLabel.Text = "Choose Date :";
            // 
            // specificdatedateTimePicker
            // 
            this.specificdatedateTimePicker.Location = new System.Drawing.Point(177, 191);
            this.specificdatedateTimePicker.Name = "specificdatedateTimePicker";
            this.specificdatedateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.specificdatedateTimePicker.TabIndex = 14;
            // 
            // startdateLabel
            // 
            this.startdateLabel.AutoSize = true;
            this.startdateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startdateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.startdateLabel.Location = new System.Drawing.Point(33, 239);
            this.startdateLabel.Name = "startdateLabel";
            this.startdateLabel.Size = new System.Drawing.Size(110, 25);
            this.startdateLabel.TabIndex = 15;
            this.startdateLabel.Text = "Start Date :";
            // 
            // enddateLabel
            // 
            this.enddateLabel.AutoSize = true;
            this.enddateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enddateLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enddateLabel.Location = new System.Drawing.Point(33, 278);
            this.enddateLabel.Name = "enddateLabel";
            this.enddateLabel.Size = new System.Drawing.Size(109, 25);
            this.enddateLabel.TabIndex = 16;
            this.enddateLabel.Text = "End Date  :";
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.Location = new System.Drawing.Point(177, 242);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.startdateTimePicker.TabIndex = 17;
            // 
            // enddateTimePicker
            // 
            this.enddateTimePicker.Location = new System.Drawing.Point(177, 278);
            this.enddateTimePicker.Name = "enddateTimePicker";
            this.enddateTimePicker.Size = new System.Drawing.Size(261, 22);
            this.enddateTimePicker.TabIndex = 18;
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
            "Specific Date",
            "All Over"});
            this.invoiceprintcomboBox.Location = new System.Drawing.Point(177, 134);
            this.invoiceprintcomboBox.Name = "invoiceprintcomboBox";
            this.invoiceprintcomboBox.Size = new System.Drawing.Size(261, 24);
            this.invoiceprintcomboBox.TabIndex = 20;
            this.invoiceprintcomboBox.TextChanged += new System.EventHandler(this.invoiceprintcomboBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(498, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search Customer :";
            // 
            // invoiceprintcustomername
            // 
            this.invoiceprintcustomername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoiceprintcustomername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoiceprintcustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceprintcustomername.Location = new System.Drawing.Point(687, 134);
            this.invoiceprintcustomername.Name = "invoiceprintcustomername";
            this.invoiceprintcustomername.Size = new System.Drawing.Size(262, 27);
            this.invoiceprintcustomername.TabIndex = 22;
            this.invoiceprintcustomername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(987, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Search Item :";
            // 
            // invoiceprintitemname
            // 
            this.invoiceprintitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoiceprintitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoiceprintitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoiceprintitemname.Location = new System.Drawing.Point(1123, 137);
            this.invoiceprintitemname.Name = "invoiceprintitemname";
            this.invoiceprintitemname.Size = new System.Drawing.Size(262, 27);
            this.invoiceprintitemname.TabIndex = 24;
            this.invoiceprintitemname.TextChanged += new System.EventHandler(this.invoiceprintitemname_TextChanged);
            // 
            // InvoicePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.invoiceprintitemname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoiceprintcustomername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoiceprintcomboBox);
            this.Controls.Add(this.selectdate);
            this.Controls.Add(this.enddateTimePicker);
            this.Controls.Add(this.startdateTimePicker);
            this.Controls.Add(this.enddateLabel);
            this.Controls.Add(this.startdateLabel);
            this.Controls.Add(this.specificdatedateTimePicker);
            this.Controls.Add(this.specificdateLabel);
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
        private System.Windows.Forms.Label specificdateLabel;
        private System.Windows.Forms.DateTimePicker specificdatedateTimePicker;
        private System.Windows.Forms.Label startdateLabel;
        private System.Windows.Forms.Label enddateLabel;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.DateTimePicker enddateTimePicker;
        private System.Windows.Forms.Label selectdate;
        private System.Windows.Forms.ComboBox invoiceprintcomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox invoiceprintcustomername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox invoiceprintitemname;
    }
}