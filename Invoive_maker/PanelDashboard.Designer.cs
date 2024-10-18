
namespace Invoive_maker
{
    partial class paneldashboard
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.paneldashboarddataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.paneldashboarddelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paneldashboarddataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.Location = new System.Drawing.Point(578, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(88, 32);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Month";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1583, 529);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            title1.Name = "Month";
            this.chart1.Titles.Add(title1);
            // 
            // paneldashboarddataGridView
            // 
            this.paneldashboarddataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paneldashboarddataGridView.Location = new System.Drawing.Point(26, 687);
            this.paneldashboarddataGridView.Name = "paneldashboarddataGridView";
            this.paneldashboarddataGridView.RowHeadersWidth = 51;
            this.paneldashboarddataGridView.RowTemplate.Height = 70;
            this.paneldashboarddataGridView.Size = new System.Drawing.Size(1698, 279);
            this.paneldashboarddataGridView.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(741, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Follow Item Sale Entry";
            // 
            // paneldashboarddelete
            // 
            this.paneldashboarddelete.BackColor = System.Drawing.Color.Teal;
            this.paneldashboarddelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.paneldashboarddelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.paneldashboarddelete.Location = new System.Drawing.Point(790, 972);
            this.paneldashboarddelete.Name = "paneldashboarddelete";
            this.paneldashboarddelete.Size = new System.Drawing.Size(110, 40);
            this.paneldashboarddelete.TabIndex = 12;
            this.paneldashboarddelete.Text = "Delete";
            this.paneldashboarddelete.UseVisualStyleBackColor = false;
            this.paneldashboarddelete.Click += new System.EventHandler(this.paneldashboarddelete_Click);
            // 
            // paneldashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1868, 1102);
            this.Controls.Add(this.paneldashboarddelete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.paneldashboarddataGridView);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paneldashboard";
            this.Text = "paneldashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.paneldashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paneldashboarddataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView paneldashboarddataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button paneldashboarddelete;
    }
}