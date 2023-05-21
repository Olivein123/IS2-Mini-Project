using laptop_price_predictor.Handler;
using laptop_price_predictor.Handler.ValueConverters;
namespace laptop_price_predictor
{
    public partial class Form1 : Form
    {
        private readonly IValueConverter _storageValueConvert = new StorageTypeConvert();
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Laptop laptop = new Laptop();

            laptop.Category = Convert.ToSingle(comboBox2.SelectedItem);
            laptop.ScreenSize = Convert.ToSingle(comboBox8.SelectedItem);
            laptop.ScreenRes = Convert.ToSingle(comboBox9.SelectedItem);
            laptop.CpuType = Convert.ToSingle(comboBox3.SelectedItem);
            laptop.CpuSpeed = Convert.ToSingle(comboBox4.SelectedItem);
            laptop.GpuType = Convert.ToSingle(comboBox7.SelectedItem);
            laptop.RamSize = Convert.ToSingle(comboBox6.SelectedItem);
            laptop.StorageType = _storageValueConvert.ReturnFloatValue(comboBoxHDD);
            laptop.OperatingSystem = Convert.ToSingle(comboBox1.SelectedItem);
            laptop.Weight = Convert.ToSingle(comboBox2.SelectedItem);
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
    }
}