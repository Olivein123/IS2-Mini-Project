using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler.ValueConverters
{
    public class OperatingSystemConvert : IValueConverter
    {
        public float ReturnFloatValue(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();

            float value = 0;

            if (selected.Equals("macOS"))
            {
                value = 0;

            }
            else if (selected.Equals("macOS X"))
            {
                value = 1;
            }
            else if (selected.Equals("Linux"))
            {
                value = 2;
            }
            else if (selected.Equals("Chrome OS"))
            {
                value = 3;
            }
            else if (selected.Equals("Windows 7"))
            {
                value = 4;
            }
            else if (selected.Equals("Windows 10"))
            {
                value = 5;
            }
            else if (selected.Equals("Windows 10 S"))
            {
                value = 6;
            }
            else
            {
                value = 7;
            }
            return value;
        }
    }
}
