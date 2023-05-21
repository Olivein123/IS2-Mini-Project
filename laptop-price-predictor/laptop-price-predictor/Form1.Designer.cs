namespace laptop_price_predictor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            button1 = new Button();
            label10 = new Label();
            comboBox10 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            comboBoxHDD = new ComboBox();
            label13 = new Label();
            label14 = new Label();
            comboBoxSSD = new ComboBox();
            label15 = new Label();
            comboBoxHybrid = new ComboBox();
            label16 = new Label();
            comboBoxFS = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(37, 51);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 0;
            label1.Text = "Operating System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(272, 50);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 105);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 2;
            label3.Text = "CPU Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(272, 107);
            label4.Name = "label4";
            label4.Size = new Size(140, 21);
            label4.TabIndex = 3;
            label4.Text = "CPU Speed (GHz)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(37, 237);
            label5.Name = "label5";
            label5.Size = new Size(106, 21);
            label5.TabIndex = 4;
            label5.Text = "Storage(Gb):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(272, 163);
            label7.Name = "label7";
            label7.Size = new Size(43, 21);
            label7.TabIndex = 6;
            label7.Text = "GPU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(272, 227);
            label8.Name = "label8";
            label8.Size = new Size(161, 21);
            label8.TabIndex = 7;
            label8.Text = "Screen Size (inches)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(272, 282);
            label9.Name = "label9";
            label9.Size = new Size(149, 21);
            label9.TabIndex = 8;
            label9.Text = "Resolution(pixels)";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(208, 245, 190);
            comboBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "macOS", "macOS X", "Linux", "Android", "Windows 7", "Windows 10", "Windows 10S", "Chrome OS", "No OS" });
            comboBox1.Location = new Point(58, 74);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 25);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(208, 245, 190);
            comboBox2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Notebook", "Ultrabook", "Gaming", "2 in 1 Convertible ", "Netbook", "Workstation" });
            comboBox2.Location = new Point(293, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(143, 25);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(208, 245, 190);
            comboBox3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Intel Atom", "Intel Celeron", "Intel Pentium", "Intel Xeon", "Intel i3", "Intel i5", "Intel i7", "Intel Core M", "AMD A4-Series", "AMD A6-Series", "AMD A8-Series", "AMD A9-Series", "AMD A10-Series", "AMD A12-Series", "AMD E-Series", "AMD FX", "AMD Ryzen", "Others" });
            comboBox3.Location = new Point(58, 129);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(143, 25);
            comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.BackColor = Color.FromArgb(208, 245, 190);
            comboBox4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0.9", "1", "1.1", "1.2", "1.3", "1.44", "1.5", "1.6", "1.8", "1.9", "1.92", "2", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3", "3.1", "3.2", "3.6", "6.3" });
            comboBox4.Location = new Point(293, 130);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(143, 25);
            comboBox4.TabIndex = 12;
            // 
            // comboBox6
            // 
            comboBox6.BackColor = Color.FromArgb(208, 245, 190);
            comboBox6.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "2", "4", "6", "8", "12", "16", "24", "32" });
            comboBox6.Location = new Point(58, 195);
            comboBox6.Margin = new Padding(3, 2, 3, 2);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(143, 25);
            comboBox6.TabIndex = 14;
            // 
            // comboBox7
            // 
            comboBox7.BackColor = Color.FromArgb(208, 245, 190);
            comboBox7.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Integrated", "Dedicated" });
            comboBox7.Location = new Point(293, 190);
            comboBox7.Margin = new Padding(3, 2, 3, 2);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(143, 25);
            comboBox7.TabIndex = 15;
            // 
            // comboBox8
            // 
            comboBox8.BackColor = Color.FromArgb(208, 245, 190);
            comboBox8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "10.1", "11.3", "11", "12", "12.3", "12.5", "13", "13.3", "13.5", "13.9", "14", "14.1", "15", "15.4", "15.6", "17", "17.3", "18.4" });
            comboBox8.Location = new Point(293, 250);
            comboBox8.Margin = new Padding(3, 2, 3, 2);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(143, 25);
            comboBox8.TabIndex = 16;
            // 
            // comboBox9
            // 
            comboBox9.BackColor = Color.FromArgb(208, 245, 190);
            comboBox9.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "768", "900", "1080", "1200", "1440", "1504", "1600", "1800", "1824", "2160" });
            comboBox9.Location = new Point(293, 309);
            comboBox9.Margin = new Padding(3, 2, 3, 2);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(143, 25);
            comboBox9.TabIndex = 17;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(251, 255, 221);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(117, 430);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 18;
            button1.Text = "Predict Price";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(293, 429);
            label10.Name = "label10";
            label10.Size = new Size(99, 30);
            label10.TabIndex = 19;
            label10.Text = "Php 0.00";
            // 
            // comboBox10
            // 
            comboBox10.BackColor = Color.FromArgb(208, 245, 190);
            comboBox10.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "0.6", "0.8", "0.9", "1.0", "1.0", "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9", "5.0" });
            comboBox10.Location = new Point(293, 365);
            comboBox10.Margin = new Padding(3, 2, 3, 2);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(143, 25);
            comboBox10.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(272, 341);
            label11.Name = "label11";
            label11.Size = new Size(97, 21);
            label11.TabIndex = 20;
            label11.Text = "Weight(kg)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(37, 163);
            label12.Name = "label12";
            label12.Size = new Size(79, 21);
            label12.TabIndex = 23;
            label12.Text = "RAM(Gb)";
            // 
            // comboBoxHDD
            // 
            comboBoxHDD.BackColor = Color.FromArgb(208, 245, 190);
            comboBoxHDD.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxHDD.FormattingEnabled = true;
            comboBoxHDD.Items.AddRange(new object[] { "0", "8", "16", "32", "64", "128", "256", "512", "1024", "2048" });
            comboBoxHDD.Location = new Point(58, 293);
            comboBoxHDD.Name = "comboBoxHDD";
            comboBoxHDD.Size = new Size(83, 25);
            comboBoxHDD.TabIndex = 24;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label13.Location = new Point(58, 270);
            label13.Name = "label13";
            label13.Size = new Size(38, 17);
            label13.TabIndex = 25;
            label13.Text = "HDD";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.Location = new Point(58, 326);
            label14.Name = "label14";
            label14.Size = new Size(32, 17);
            label14.TabIndex = 27;
            label14.Text = "SSD";
            // 
            // comboBoxSSD
            // 
            comboBoxSSD.BackColor = Color.FromArgb(208, 245, 190);
            comboBoxSSD.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxSSD.FormattingEnabled = true;
            comboBoxSSD.Items.AddRange(new object[] { "0", "8", "16", "32", "64", "128", "256", "512", "1024", "2048" });
            comboBoxSSD.Location = new Point(58, 352);
            comboBoxSSD.Name = "comboBoxSSD";
            comboBoxSSD.Size = new Size(83, 25);
            comboBoxSSD.TabIndex = 26;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label15.Location = new Point(153, 270);
            label15.Name = "label15";
            label15.Size = new Size(48, 17);
            label15.TabIndex = 29;
            label15.Text = "Hybrid";
            // 
            // comboBoxHybrid
            // 
            comboBoxHybrid.BackColor = Color.FromArgb(208, 245, 190);
            comboBoxHybrid.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxHybrid.FormattingEnabled = true;
            comboBoxHybrid.Items.AddRange(new object[] { "0", "8", "16", "32", "64", "128", "256", "512", "1024", "2048" });
            comboBoxHybrid.Location = new Point(153, 293);
            comboBoxHybrid.Name = "comboBoxHybrid";
            comboBoxHybrid.Size = new Size(83, 25);
            comboBoxHybrid.TabIndex = 28;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label16.Location = new Point(153, 326);
            label16.Name = "label16";
            label16.Size = new Size(88, 17);
            label16.TabIndex = 31;
            label16.Text = "Flash Storage";
            // 
            // comboBoxFS
            // 
            comboBoxFS.BackColor = Color.FromArgb(208, 245, 190);
            comboBoxFS.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            comboBoxFS.FormattingEnabled = true;
            comboBoxFS.Items.AddRange(new object[] { "0", "8", "16", "32", "64", "128", "256", "512", "1024", "2048" });
            comboBoxFS.Location = new Point(153, 352);
            comboBoxFS.Name = "comboBoxFS";
            comboBoxFS.Size = new Size(83, 25);
            comboBoxFS.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(494, 490);
            Controls.Add(label16);
            Controls.Add(comboBoxFS);
            Controls.Add(label15);
            Controls.Add(comboBoxHybrid);
            Controls.Add(label14);
            Controls.Add(comboBoxSSD);
            Controls.Add(label13);
            Controls.Add(comboBoxHDD);
            Controls.Add(label12);
            Controls.Add(comboBox10);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(comboBox9);
            Controls.Add(comboBox8);
            Controls.Add(comboBox7);
            Controls.Add(comboBox6);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Laptop Price Predictor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private Button button1;
        private Label label10;
        private ComboBox comboBox10;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxHDD;
        private Label label13;
        private Label label14;
        private ComboBox comboBoxSSD;
        private Label label15;
        private ComboBox comboBoxHybrid;
        private Label label16;
        private ComboBox comboBoxFS;
    }
}