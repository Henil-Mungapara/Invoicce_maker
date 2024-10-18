
namespace Invoive_maker
{
    partial class invoicemake
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(invoicemake));
            this.label1 = new System.Windows.Forms.Label();
            this.invoicemaketoolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label2 = new System.Windows.Forms.Label();
            this.invoicemakeadd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.invoicemakedataGridView = new System.Windows.Forms.DataGridView();
            this.invoicemakecustomername = new System.Windows.Forms.TextBox();
            this.invoicemakeitemname = new System.Windows.Forms.TextBox();
            this.invoicemakeitemqty = new System.Windows.Forms.TextBox();
            this.invoicemakecomboBox = new System.Windows.Forms.ComboBox();
            this.invoicemakenew = new System.Windows.Forms.Button();
            this.invoicemakeupdate = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.invoicemakeitemdescription = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.invoicemakecgst = new System.Windows.Forms.TextBox();
            this.invoicemakeigst = new System.Windows.Forms.TextBox();
            this.invoicemakengst = new System.Windows.Forms.TextBox();
            this.invoicemakeutgst = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.invoicemakedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.invoicemakeitemprice = new System.Windows.Forms.TextBox();
            this.invoicemakesavedata = new System.Windows.Forms.Button();
            this.invoicemaketoolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicemakedataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(318, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name :";
            // 
            // invoicemaketoolStrip
            // 
            this.invoicemaketoolStrip.BackColor = System.Drawing.Color.Teal;
            this.invoicemaketoolStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.invoicemaketoolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.invoicemaketoolStrip.Location = new System.Drawing.Point(0, 0);
            this.invoicemaketoolStrip.Name = "invoicemaketoolStrip";
            this.invoicemaketoolStrip.Size = new System.Drawing.Size(1769, 54);
            this.invoicemaketoolStrip.TabIndex = 1;
            this.invoicemaketoolStrip.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Teal;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(1000, 0, 0, 0);
            this.toolStripButton1.Size = new System.Drawing.Size(1214, 44);
            this.toolStripButton1.Text = "Invoice Plus +";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(828, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name :";
            // 
            // invoicemakeadd
            // 
            this.invoicemakeadd.BackColor = System.Drawing.Color.Teal;
            this.invoicemakeadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeadd.ForeColor = System.Drawing.SystemColors.Control;
            this.invoicemakeadd.Location = new System.Drawing.Point(567, 537);
            this.invoicemakeadd.Name = "invoicemakeadd";
            this.invoicemakeadd.Size = new System.Drawing.Size(126, 39);
            this.invoicemakeadd.TabIndex = 3;
            this.invoicemakeadd.Text = "ADD";
            this.invoicemakeadd.UseVisualStyleBackColor = false;
            this.invoicemakeadd.Click += new System.EventHandler(this.invoicemakeadd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(313, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Qty             :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(828, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Weight Type :";
            // 
            // invoicemakedataGridView
            // 
            this.invoicemakedataGridView.AllowUserToAddRows = false;
            this.invoicemakedataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.invoicemakedataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.invoicemakedataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.invoicemakedataGridView.Location = new System.Drawing.Point(153, 600);
            this.invoicemakedataGridView.Name = "invoicemakedataGridView";
            this.invoicemakedataGridView.RowHeadersWidth = 51;
            this.invoicemakedataGridView.RowTemplate.Height = 40;
            this.invoicemakedataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.invoicemakedataGridView.Size = new System.Drawing.Size(1404, 331);
            this.invoicemakedataGridView.TabIndex = 6;
            this.invoicemakedataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicemakedataGridView_CellClick);
            this.invoicemakedataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicemakedataGridView_CellContentClick);
            this.invoicemakedataGridView.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.invoicemakedataGridView_CellEndEdit);
            // 
            // invoicemakecustomername
            // 
            this.invoicemakecustomername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakecustomername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakecustomername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakecustomername.Location = new System.Drawing.Point(489, 126);
            this.invoicemakecustomername.Name = "invoicemakecustomername";
            this.invoicemakecustomername.Size = new System.Drawing.Size(274, 26);
            this.invoicemakecustomername.TabIndex = 7;
            // 
            // invoicemakeitemname
            // 
            this.invoicemakeitemname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakeitemname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakeitemname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeitemname.Location = new System.Drawing.Point(969, 126);
            this.invoicemakeitemname.Name = "invoicemakeitemname";
            this.invoicemakeitemname.Size = new System.Drawing.Size(273, 26);
            this.invoicemakeitemname.TabIndex = 8;
            // 
            // invoicemakeitemqty
            // 
            this.invoicemakeitemqty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeitemqty.Location = new System.Drawing.Point(485, 311);
            this.invoicemakeitemqty.Name = "invoicemakeitemqty";
            this.invoicemakeitemqty.Size = new System.Drawing.Size(274, 26);
            this.invoicemakeitemqty.TabIndex = 9;
            // 
            // invoicemakecomboBox
            // 
            this.invoicemakecomboBox.FormattingEnabled = true;
            this.invoicemakecomboBox.ItemHeight = 16;
            this.invoicemakecomboBox.Items.AddRange(new object[] {
            "Kilograms (kg)",
            "Pounds (lbs)",
            "Grams (g)",
            "Ounces (oz)",
            "Stone (st)",
            "Tonnes (metric tons)",
            "Carats (ct)",
            "Milligrams (mg)",
            "Micrograms (µg)",
            "Troy ounces (t oz)",
            "Litres (L)",
            "Millilitres (mL)",
            "Cubic meters (m³)",
            "Cubic centimeters (cm³)",
            "Gallons (gal)",
            "Quarts (qt)",
            "Pints (pt)",
            "Fluid ounces (fl oz)",
            "Cubic inches (in³)",
            "Cubic feet (ft³)"});
            this.invoicemakecomboBox.Location = new System.Drawing.Point(969, 209);
            this.invoicemakecomboBox.Name = "invoicemakecomboBox";
            this.invoicemakecomboBox.Size = new System.Drawing.Size(273, 24);
            this.invoicemakecomboBox.TabIndex = 10;
            // 
            // invoicemakenew
            // 
            this.invoicemakenew.BackColor = System.Drawing.Color.Teal;
            this.invoicemakenew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakenew.ForeColor = System.Drawing.SystemColors.Control;
            this.invoicemakenew.Location = new System.Drawing.Point(725, 537);
            this.invoicemakenew.Name = "invoicemakenew";
            this.invoicemakenew.Size = new System.Drawing.Size(127, 39);
            this.invoicemakenew.TabIndex = 11;
            this.invoicemakenew.Text = "NEW";
            this.invoicemakenew.UseVisualStyleBackColor = false;
            this.invoicemakenew.Click += new System.EventHandler(this.invoicemakenew_Click);
            // 
            // invoicemakeupdate
            // 
            this.invoicemakeupdate.BackColor = System.Drawing.Color.Teal;
            this.invoicemakeupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.invoicemakeupdate.Location = new System.Drawing.Point(886, 537);
            this.invoicemakeupdate.Name = "invoicemakeupdate";
            this.invoicemakeupdate.Size = new System.Drawing.Size(117, 39);
            this.invoicemakeupdate.TabIndex = 12;
            this.invoicemakeupdate.Text = "UPDATE";
            this.invoicemakeupdate.UseVisualStyleBackColor = false;
            this.invoicemakeupdate.Click += new System.EventHandler(this.invoicemakeupdate_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Teal;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(1045, 537);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 39);
            this.button4.TabIndex = 13;
            this.button4.Text = "DELETE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(317, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Item Description :";
            // 
            // invoicemakeitemdescription
            // 
            this.invoicemakeitemdescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakeitemdescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakeitemdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeitemdescription.Location = new System.Drawing.Point(485, 210);
            this.invoicemakeitemdescription.Multiline = true;
            this.invoicemakeitemdescription.Name = "invoicemakeitemdescription";
            this.invoicemakeitemdescription.Size = new System.Drawing.Size(278, 29);
            this.invoicemakeitemdescription.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(828, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "CGST            :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(1185, 337);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 25);
            this.label9.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(828, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "IGST              :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(824, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 25);
            this.label8.TabIndex = 21;
            this.label8.Text = "NGST             : ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(824, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 25);
            this.label10.TabIndex = 22;
            this.label10.Text = "UIGST            :";
            // 
            // invoicemakecgst
            // 
            this.invoicemakecgst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakecgst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakecgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakecgst.Location = new System.Drawing.Point(969, 288);
            this.invoicemakecgst.Name = "invoicemakecgst";
            this.invoicemakecgst.Size = new System.Drawing.Size(273, 26);
            this.invoicemakecgst.TabIndex = 23;
            // 
            // invoicemakeigst
            // 
            this.invoicemakeigst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakeigst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakeigst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeigst.Location = new System.Drawing.Point(969, 336);
            this.invoicemakeigst.Name = "invoicemakeigst";
            this.invoicemakeigst.Size = new System.Drawing.Size(273, 26);
            this.invoicemakeigst.TabIndex = 24;
            // 
            // invoicemakengst
            // 
            this.invoicemakengst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakengst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakengst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakengst.Location = new System.Drawing.Point(969, 385);
            this.invoicemakengst.Name = "invoicemakengst";
            this.invoicemakengst.Size = new System.Drawing.Size(273, 26);
            this.invoicemakengst.TabIndex = 25;
            // 
            // invoicemakeutgst
            // 
            this.invoicemakeutgst.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoicemakeutgst.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.invoicemakeutgst.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeutgst.Location = new System.Drawing.Point(969, 431);
            this.invoicemakeutgst.Name = "invoicemakeutgst";
            this.invoicemakeutgst.Size = new System.Drawing.Size(273, 26);
            this.invoicemakeutgst.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(311, 411);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 25);
            this.label11.TabIndex = 27;
            this.label11.Text = "Print Date           :";
            // 
            // invoicemakedateTimePicker
            // 
            this.invoicemakedateTimePicker.Location = new System.Drawing.Point(485, 414);
            this.invoicemakedateTimePicker.Name = "invoicemakedateTimePicker";
            this.invoicemakedateTimePicker.Size = new System.Drawing.Size(274, 22);
            this.invoicemakedateTimePicker.TabIndex = 28;
            this.invoicemakedateTimePicker.Value = new System.DateTime(2024, 10, 1, 13, 21, 45, 0);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(311, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 25);
            this.label12.TabIndex = 29;
            this.label12.Text = "Item price           :";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // invoicemakeitemprice
            // 
            this.invoicemakeitemprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoicemakeitemprice.Location = new System.Drawing.Point(485, 363);
            this.invoicemakeitemprice.Name = "invoicemakeitemprice";
            this.invoicemakeitemprice.Size = new System.Drawing.Size(274, 26);
            this.invoicemakeitemprice.TabIndex = 30;
            // 
            // invoicemakesavedata
            // 
            this.invoicemakesavedata.BackColor = System.Drawing.Color.Teal;
            this.invoicemakesavedata.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.invoicemakesavedata.ForeColor = System.Drawing.SystemColors.Control;
            this.invoicemakesavedata.Location = new System.Drawing.Point(796, 937);
            this.invoicemakesavedata.Name = "invoicemakesavedata";
            this.invoicemakesavedata.Size = new System.Drawing.Size(158, 53);
            this.invoicemakesavedata.TabIndex = 31;
            this.invoicemakesavedata.Text = "Save Data";
            this.invoicemakesavedata.UseVisualStyleBackColor = false;
            this.invoicemakesavedata.Click += new System.EventHandler(this.invoicemakesavedata_Click);
            // 
            // invoicemake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1769, 1067);
            this.Controls.Add(this.invoicemakesavedata);
            this.Controls.Add(this.invoicemakeitemprice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.invoicemakedateTimePicker);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.invoicemakeutgst);
            this.Controls.Add(this.invoicemakengst);
            this.Controls.Add(this.invoicemakeigst);
            this.Controls.Add(this.invoicemakecgst);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.invoicemakeitemdescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.invoicemakeupdate);
            this.Controls.Add(this.invoicemakenew);
            this.Controls.Add(this.invoicemakecomboBox);
            this.Controls.Add(this.invoicemakeitemqty);
            this.Controls.Add(this.invoicemakeitemname);
            this.Controls.Add(this.invoicemakecustomername);
            this.Controls.Add(this.invoicemakedataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invoicemakeadd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.invoicemaketoolStrip);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoicemake";
            this.Text = "invoicemake";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.invoicemake_Load);
            this.invoicemaketoolStrip.ResumeLayout(false);
            this.invoicemaketoolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoicemakedataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip invoicemaketoolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button invoicemakeadd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView invoicemakedataGridView;
        private System.Windows.Forms.TextBox invoicemakecustomername;
        private System.Windows.Forms.TextBox invoicemakeitemname;
        private System.Windows.Forms.TextBox invoicemakeitemqty;
        private System.Windows.Forms.ComboBox invoicemakecomboBox;
        private System.Windows.Forms.Button invoicemakenew;
        private System.Windows.Forms.Button invoicemakeupdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox invoicemakeitemdescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox invoicemakecgst;
        private System.Windows.Forms.TextBox invoicemakeigst;
        private System.Windows.Forms.TextBox invoicemakengst;
        private System.Windows.Forms.TextBox invoicemakeutgst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker invoicemakedateTimePicker;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox invoicemakeitemprice;
        private System.Windows.Forms.Button invoicemakesavedata;
    }
}