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
        public Form1()
        {
            InitializeComponent();
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

            label6.Text = laptop.Category.ToString() + " " + laptop.ScreenSize.ToString()
                + " " + laptop.ScreenRes.ToString() + " " + laptop.CpuType.ToString()
                + " " + laptop.CpuSpeed.ToString() + " " + laptop.GpuType.ToString() + " " + laptop.RamSize.ToString()
                + " " + laptop.HDDSize.ToString() + " " + laptop.SSDSize.ToString()
                + " " + laptop.HybridSize.ToString() + " " + laptop.FlashStorageSize.ToString()
                + " " + laptop.OperatingSystem.ToString() + " " + laptop.Weight.ToString();

        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}