using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler.ValueConverters
{
    public class CategoryConvert : IValueConverter
    {
        public float ReturnFloatValue(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();

            float value = 0;

            if (selected.Equals("Notebook"))
            {
                value = 1;

            }
            else if (selected.Equals("Ultrabook"))
            {
                value = 2;

            }
            else if (selected.Equals("Gaming"))
            {
                value = 3;

            }
            else if (selected.Equals("2 in 1 Convertible "))
            {
                value = 4;
            }
            else if (selected.Equals("Netbook"))
            {
                value = 5;

            }
            else
            {
                value = 6;
            }

            return value;
        }
    }
}
