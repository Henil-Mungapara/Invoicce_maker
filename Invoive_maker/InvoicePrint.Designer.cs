
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
            this.specificdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceprintdate = new System.Windows.Forms.Label();
            this.invoiceprinttollstrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.invoiceprintcomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.invoiceprintbutton = new System.Windows.Forms.Button();
            this.invoiceprintstartdate = new System.Windows.Forms.Label();
            this.invoiceprintenddate = new System.Windows.Forms.Label();
            this.startdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enddateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.invoiceprinttollstrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // specificdateTimePicker
            // 
            this.specificdateTimePicker.Location = new System.Drawing.Point(198, 285);
            this.specificdateTimePicker.Name = "specificdateTimePicker";
            this.specificdateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.specificdateTimePicker.TabIndex = 0;
            // 
            // invoiceprintdate
            // 
            this.invoiceprintdate.AutoSize = true;
            this.invoiceprintdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoiceprintdate.Location = new System.Drawing.Point(58, 283);
            this.invoiceprintdate.Name = "invoiceprintdate";
            this.invoiceprintdate.Size = new System.Drawing.Size(108, 24);
            this.invoiceprintdate.TabIndex = 1;
            this.invoiceprintdate.Text = "Enter Date :";
            // 
            // invoiceprinttollstrip
            // 
            this.invoiceprinttollstrip.BackColor = System.Drawing.Color.Teal;
            this.invoiceprinttollstrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.invoiceprinttollstrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton12});
            this.invoiceprinttollstrip.Location = new System.Drawing.Point(0, 0);
            this.invoiceprinttollstrip.Name = "invoiceprinttollstrip";
            this.invoiceprinttollstrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.invoiceprinttollstrip.Size = new System.Drawing.Size(1857, 74);
            this.invoiceprinttollstrip.TabIndex = 3;
            this.invoiceprinttollstrip.Text = "toolStrip2";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.BackColor = System.Drawing.Color.Teal;
            this.toolStripButton12.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.toolStripButton12.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Padding = new System.Windows.Forms.Padding(10);
            this.toolStripButton12.Size = new System.Drawing.Size(238, 64);
            this.toolStripButton12.Text = "Invoice Print";
            this.toolStripButton12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // invoiceprintcomboBox
            // 
            this.invoiceprintcomboBox.FormattingEnabled = true;
            this.invoiceprintcomboBox.Items.AddRange(new object[] {
            "Specific Range",
            "Specific Date"});
            this.invoiceprintcomboBox.Location = new System.Drawing.Point(198, 126);
            this.invoiceprintcomboBox.Name = "invoiceprintcomboBox";
            this.invoiceprintcomboBox.Size = new System.Drawing.Size(251, 24);
            this.invoiceprintcomboBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label1.Location = new System.Drawing.Point(58, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 17;
            this.label1.Text = "Select Type :";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(526, 126);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1285, 785);
            this.crystalReportViewer1.TabIndex = 18;
            // 
            // invoiceprintbutton
            // 
            this.invoiceprintbutton.BackColor = System.Drawing.Color.Teal;
            this.invoiceprintbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.invoiceprintbutton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.invoiceprintbutton.Location = new System.Drawing.Point(1076, 955);
            this.invoiceprintbutton.Name = "invoiceprintbutton";
            this.invoiceprintbutton.Size = new System.Drawing.Size(195, 41);
            this.invoiceprintbutton.TabIndex = 19;
            this.invoiceprintbutton.Text = "PRINT REPORT";
            this.invoiceprintbutton.UseVisualStyleBackColor = false;
            // 
            // invoiceprintstartdate
            // 
            this.invoiceprintstartdate.AutoSize = true;
            this.invoiceprintstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoiceprintstartdate.Location = new System.Drawing.Point(58, 181);
            this.invoiceprintstartdate.Name = "invoiceprintstartdate";
            this.invoiceprintstartdate.Size = new System.Drawing.Size(99, 24);
            this.invoiceprintstartdate.TabIndex = 20;
            this.invoiceprintstartdate.Text = "Start Date :";
            // 
            // invoiceprintenddate
            // 
            this.invoiceprintenddate.AutoSize = true;
            this.invoiceprintenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.invoiceprintenddate.Location = new System.Drawing.Point(58, 230);
            this.invoiceprintenddate.Name = "invoiceprintenddate";
            this.invoiceprintenddate.Size = new System.Drawing.Size(98, 24);
            this.invoiceprintenddate.TabIndex = 21;
            this.invoiceprintenddate.Text = "End Date :";
            // 
            // startdateTimePicker
            // 
            this.startdateTimePicker.Location = new System.Drawing.Point(198, 183);
            this.startdateTimePicker.Name = "startdateTimePicker";
            this.startdateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.startdateTimePicker.TabIndex = 22;
            // 
            // enddateTimePicker
            // 
            this.enddateTimePicker.Location = new System.Drawing.Point(198, 232);
            this.enddateTimePicker.Name = "enddateTimePicker";
            this.enddateTimePicker.Size = new System.Drawing.Size(251, 22);
            this.enddateTimePicker.TabIndex = 23;
            // 
            // InvoicePrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1857, 1102);
            this.Controls.Add(this.enddateTimePicker);
            this.Controls.Add(this.startdateTimePicker);
            this.Controls.Add(this.invoiceprintenddate);
            this.Controls.Add(this.invoiceprintstartdate);
            this.Controls.Add(this.invoiceprintbutton);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.invoiceprintcomboBox);
            this.Controls.Add(this.invoiceprinttollstrip);
            this.Controls.Add(this.invoiceprintdate);
            this.Controls.Add(this.specificdateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvoicePrint";
            this.Text = "InvoicePrint";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InvoicePrint_Load);
            this.invoiceprinttollstrip.ResumeLayout(false);
            this.invoiceprinttollstrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker specificdateTimePicker;
        private System.Windows.Forms.Label invoiceprintdate;
        private System.Windows.Forms.ToolStrip invoiceprinttollstrip;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ComboBox invoiceprintcomboBox;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button invoiceprintbutton;
        private System.Windows.Forms.Label invoiceprintstartdate;
        private System.Windows.Forms.Label invoiceprintenddate;
        private System.Windows.Forms.DateTimePicker startdateTimePicker;
        private System.Windows.Forms.DateTimePicker enddateTimePicker;
    }
}