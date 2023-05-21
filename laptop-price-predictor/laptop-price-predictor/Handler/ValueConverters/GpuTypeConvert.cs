using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler.ValueConverters
{
    public class GpuTypeConvert : IValueConverter
    {
        public float ReturnFloatValue(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();

            float value = 0;

            if (selected.Equals("Dedicated"))
            {
                value = 1;

            }
            return value;
        }
    }
}
