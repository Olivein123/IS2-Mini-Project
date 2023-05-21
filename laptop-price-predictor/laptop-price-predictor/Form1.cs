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
            laptop.StorageType = _storageValueConvert.ReturnFloatValue(comboBox5);
            laptop.OperatingSystem = Convert.ToSingle(comboBox1.SelectedItem);
            laptop.Weight = Convert.ToSingle(comboBox2.SelectedItem);
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}