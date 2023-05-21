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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            comboBox7 = new ComboBox();
            comboBox8 = new ComboBox();
            comboBox9 = new ComboBox();
            button1 = new Button();
            label10 = new Label();
            comboBox10 = new ComboBox();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 50);
            label1.Name = "label1";
            label1.Size = new Size(135, 21);
            label1.TabIndex = 0;
            label1.Text = "Operating System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(213, 50);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 1;
            label2.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(41, 109);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 2;
            label3.Text = "CPU Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(213, 109);
            label4.Name = "label4";
            label4.Size = new Size(130, 21);
            label4.TabIndex = 3;
            label4.Text = "CPU Speed (GHz)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(41, 293);
            label5.Name = "label5";
            label5.Size = new Size(99, 21);
            label5.TabIndex = 4;
            label5.Text = "Storage Type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(41, 170);
            label6.Name = "label6";
            label6.Size = new Size(74, 21);
            label6.TabIndex = 5;
            label6.Text = "RAM(Gb)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(213, 170);
            label7.Name = "label7";
            label7.Size = new Size(41, 21);
            label7.TabIndex = 6;
            label7.Text = "GPU";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(41, 233);
            label8.Name = "label8";
            label8.Size = new Size(147, 21);
            label8.TabIndex = 7;
            label8.Text = "Screen Size (inches)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(213, 233);
            label9.Name = "label9";
            label9.Size = new Size(133, 21);
            label9.TabIndex = 8;
            label9.Text = "Resolution(pixels)";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "macOS", "macOS X", "Linux", "Android", "Windows 7", "Windows 10", "Windows 10S", "Chrome OS", "No OS" });
            comboBox1.Location = new Point(41, 74);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(143, 25);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Notebook", "Ultrabook", "Gaming", "2 in 1 Convertible ", "Netbook", "Workstation" });
            comboBox2.Location = new Point(213, 74);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(143, 25);
            comboBox2.TabIndex = 10;
            // 
            // comboBox3
            // 
            comboBox3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "Intel Atom", "Intel Celeron", "Intel Pentium", "Intel Xeon", "Intel i3", "Intel i5", "Intel i7", "Intel Core M", "AMD A4-Series", "AMD A6-Series", "AMD A8-Series", "AMD A9-Series", "AMD A10-Series", "AMD A12-Series", "AMD E-Series", "AMD FX", "AMD Ryzen", "Others" });
            comboBox3.Location = new Point(41, 133);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(143, 25);
            comboBox3.TabIndex = 11;
            // 
            // comboBox4
            // 
            comboBox4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "0.9", "1", "1.1", "1.2", "1.3", "1.44", "1.5", "1.6", "1.8", "1.9", "1.92", "2", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3", "3.1", "3.2", "3.6", "6.3" });
            comboBox4.Location = new Point(213, 133);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(143, 25);
            comboBox4.TabIndex = 12;
            // 
            // comboBox5
            // 
            comboBox5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "HDD ONLY", "SSD ONLY", "HDD + SSD", "HYBRID", "FLASH STORAGE" });
            comboBox5.Location = new Point(41, 317);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(143, 25);
            comboBox5.TabIndex = 13;
            // 
            // comboBox6
            // 
            comboBox6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "2", "4", "6", "8", "12", "16", "24", "32" });
            comboBox6.Location = new Point(41, 194);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(143, 25);
            comboBox6.TabIndex = 14;
            // 
            // comboBox7
            // 
            comboBox7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox7.FormattingEnabled = true;
            comboBox7.Items.AddRange(new object[] { "Integrated", "Dedicated" });
            comboBox7.Location = new Point(213, 194);
            comboBox7.Name = "comboBox7";
            comboBox7.Size = new Size(143, 25);
            comboBox7.TabIndex = 15;
            // 
            // comboBox8
            // 
            comboBox8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox8.FormattingEnabled = true;
            comboBox8.Items.AddRange(new object[] { "10.1", "11.3", "11", "12", "12.3", "12.5", "13", "13.3", "13.5", "13.9", "14", "14.1", "15", "15.4", "15.6", "17", "17.3", "18.4" });
            comboBox8.Location = new Point(41, 257);
            comboBox8.Name = "comboBox8";
            comboBox8.Size = new Size(143, 25);
            comboBox8.TabIndex = 16;
            // 
            // comboBox9
            // 
            comboBox9.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox9.FormattingEnabled = true;
            comboBox9.Items.AddRange(new object[] { "768", "900", "1080", "1200", "1440", "1504", "1600", "1800", "1824", "2160" });
            comboBox9.Location = new Point(213, 257);
            comboBox9.Name = "comboBox9";
            comboBox9.Size = new Size(143, 25);
            comboBox9.TabIndex = 17;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(135, 374);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 18;
            button1.Text = "Predict Price";
            button1.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(147, 426);
            label10.Name = "label10";
            label10.Size = new Size(97, 30);
            label10.TabIndex = 19;
            label10.Text = "Php 0.00";
            // 
            // comboBox10
            // 
            comboBox10.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox10.FormattingEnabled = true;
            comboBox10.Items.AddRange(new object[] { "0.6", "0.8", "0.9", "1.0", "1.0", "1.0", "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "1.7", "1.8", "1.9", "2.0", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "2.7", "2.8", "2.9", "3.0", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6", "3.7", "3.8", "3.9", "4.0", "4.1", "4.2", "4.3", "4.4", "4.5", "4.6", "4.7", "4.8", "4.9", "5.0" });
            comboBox10.Location = new Point(213, 317);
            comboBox10.Name = "comboBox10";
            comboBox10.Size = new Size(143, 25);
            comboBox10.TabIndex = 21;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(213, 293);
            label11.Name = "label11";
            label11.Size = new Size(86, 21);
            label11.TabIndex = 20;
            label11.Text = "Weight(kg)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(407, 482);
            Controls.Add(comboBox10);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(comboBox9);
            Controls.Add(comboBox8);
            Controls.Add(comboBox7);
            Controls.Add(comboBox6);
            Controls.Add(comboBox5);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private Button button1;
        private Label label10;
        private ComboBox comboBox10;
        private Label label11;
    }
}