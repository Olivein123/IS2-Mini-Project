using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler.ValueConverters
{
    public class StorageTypeConvert : IValueConverter
    {
        public float ReturnFloatValue(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();
            
            float value = 0;

            if(selected.Equals("HDD ONLY"))
            {
                value = 1;

            }
            else if(selected.Equals("SSD ONLY"))
            {
                value = 2;

            }
            else if(selected.Equals("HDD + SSD"))
            {
                value = 3;

            }
            else if (selected.Equals("HYBRID"))
            {
                value = 4;
            }
            else
            {
                value = 5;

            }

            return value;
        }
    }
}
