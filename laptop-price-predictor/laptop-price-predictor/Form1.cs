using laptop_price_predictor.Handler;
using laptop_price_predictor.Handler.ValueConverters;
namespace laptop_price_predictor
{
    public partial class Form1 : Form
    {
        private readonly PriceGenerator _priceGen = new PriceGenerator();
        private readonly IValueConverter _categoryConvert = new CategoryConvert();
        private readonly IValueConverter _cpuTypeConvert = new CpuTypeConvert();
        private readonly IValueConverter _gpuTypeConvert = new GpuTypeConvert();
        private readonly IValueConverter _osConvert = new OperatingSystemConvert();
        private bool isDragging = false;
        private Point lastCursorPosition;
        public Form1()
        {
            InitializeComponent();
            comboBoxHDD.SelectedIndex = 0;
            comboBoxSSD.SelectedIndex = 0;
            comboBoxHybrid.SelectedIndex = 0;
            comboBoxFS.SelectedIndex = 0;
            this.FormBorderStyle = FormBorderStyle.None;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();

            laptop.Category = _categoryConvert.ReturnFloatValue(comboBox2);
            laptop.ScreenSize = Convert.ToSingle(comboBox8.SelectedItem);
            laptop.ScreenRes = Convert.ToSingle(comboBox9.SelectedItem);
            laptop.CpuType = _cpuTypeConvert.ReturnFloatValue(comboBox3);
            laptop.CpuSpeed = Convert.ToSingle(comboBox4.SelectedItem);
            laptop.GpuType = _gpuTypeConvert.ReturnFloatValue(comboBox7);
            laptop.RamSize = Convert.ToSingle(comboBox6.SelectedItem);
            laptop.HDDSize = Convert.ToSingle(comboBoxHDD.SelectedItem);
            laptop.SSDSize = Convert.ToSingle(comboBoxSSD.SelectedItem);
            laptop.HybridSize = Convert.ToSingle(comboBoxHybrid.SelectedItem);
            laptop.FlashStorageSize = Convert.ToSingle(comboBoxFS.SelectedItem);
            laptop.OperatingSystem = _osConvert.ReturnFloatValue(comboBox1);
            laptop.Weight = Convert.ToSingle(textBox1.Text);

            var result = _priceGen.Generate(laptop);

            label10.Text = $"Price: {result} PHP";

            //label6.Text = "Category: " + laptop.Category.ToString() + " \n"
            //    + "Screen Size: " + laptop.ScreenSize.ToString() + " \n"
            //    + "Resolution: " + laptop.ScreenRes.ToString() + " \n"
            //    + "Operating System: " + laptop.OperatingSystem.ToString() + " \n"
            //    + "CPU Category: " + laptop.CpuType.ToString() + " \n"
            //    + "Ram: " + laptop.RamSize.ToString() + " \n"
            //    + "HDD: " + laptop.HDDSize.ToString() + " \n"
            //    + "SSD: " + laptop.SSDSize.ToString() + " \n"
            //    + "Flash Storage: " + laptop.FlashStorageSize.ToString() + " \n"
            //    + "Hybrid: " + laptop.HybridSize.ToString() + " \n"
            //    + "GPU Type: " + laptop.GpuType.ToString() + " \n"
            //    + "Weight:" + laptop.Weight.ToString() + " \n"
            //    + "CPU Speed: " + laptop.CpuSpeed.ToString() + " \n";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOS = comboBox1.SelectedItem.ToString();
            comboBox2.Items.Clear();

            switch (selectedOS)
            {
                case "macOS":
                    comboBox2.Items.Add("Ultrabook");
                    break;
                case "macOS X":
                    comboBox2.Items.Add("Ultrabook");
                    break;
                case "Linux":
                    comboBox2.Items.Add("Gaming");
                    comboBox2.Items.Add("Notebook");
                    comboBox2.Items.Add("Ultrabook");
                    break;
                case "Android":
                    comboBox2.Items.Add("2 in 1 Convertible");
                    break;
                case "Windows 7":
                    comboBox2.Items.Add("2 in 1 Convertible");
                    comboBox2.Items.Add("Gaming");
                    comboBox2.Items.Add("Netbook");
                    comboBox2.Items.Add("Notebook");
                    comboBox2.Items.Add("Ultrabook");
                    comboBox2.Items.Add("Workstation");
                    break;
                case "Windows 10":
                    comboBox2.Items.Add("2 in 1 Convertible");
                    comboBox2.Items.Add("Gaming");
                    comboBox2.Items.Add("Netbook");
                    comboBox2.Items.Add("Notebook");
                    comboBox2.Items.Add("Ultrabook");
                    comboBox2.Items.Add("Workstation");
                    break;
                case "Windows 10S":
                    comboBox2.Items.Add("2 in 1 Convertible");
                    comboBox2.Items.Add("Gaming");
                    comboBox2.Items.Add("Netbook");
                    comboBox2.Items.Add("Notebook");
                    comboBox2.Items.Add("Ultrabook");
                    comboBox2.Items.Add("Workstation");
                    break;
                case "Chrome OS":
                    comboBox2.Items.Add("2 in 1 Convertible");
                    comboBox2.Items.Add("Netbook");
                    comboBox2.Items.Add("Notebook");
                    comboBox2.Items.Add("Ultrabook");
                    break;
                case "No OS":
                    comboBox2.Items.Add("Gaming");
                    comboBox2.Items.Add("Notebook");
                    comboBox2.Items.Add("Ultrabook");
                    break;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.ResetText();
            comboBox2.ResetText();
            comboBox8.ResetText();
            comboBox9.ResetText();
            comboBox3.ResetText();
            comboBox4.ResetText();
            comboBox7.ResetText();
            comboBox6.ResetText();
            comboBoxHDD.ResetText();
            comboBoxSSD.ResetText();
            comboBoxHybrid.ResetText();
            comboBoxFS.ResetText();
            comboBox1.ResetText();
            textBox1.Clear();
            label10.Text = $"Price: 0.00";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label18_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastCursorPosition = Cursor.Position;
        }

        private void label18_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = Cursor.Position.X - lastCursorPosition.X;
                int deltaY = Cursor.Position.Y - lastCursorPosition.Y;
                Location = new Point(Location.X + deltaX, Location.Y + deltaY);
                lastCursorPosition = Cursor.Position;
            }
        }

        private void label18_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }
    }
}