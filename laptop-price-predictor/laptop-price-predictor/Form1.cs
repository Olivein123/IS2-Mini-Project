namespace laptop_price_predictor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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