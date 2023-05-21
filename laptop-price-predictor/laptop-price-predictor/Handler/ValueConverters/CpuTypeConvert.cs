using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler.ValueConverters
{
    public class CpuTypeConvert : IValueConverter
    {
        public float ReturnFloatValue(ComboBox comboBox)
        {
            string selected = comboBox.SelectedItem.ToString();

            float value = 0;

            if (selected.Equals("Intel Atom"))
            {
                value = 0;

            }
            else if(selected.Equals("Intel Celeron"))
            {
                value = 1;
            }
            else if (selected.Equals("Intel Pentium"))
            {
                value = 2;
            }
            else if (selected.Equals("Intel Xeon"))
            {
                value = 3;
            }
            else if (selected.Equals("Intel i3"))
            {
                value = 4;
            }
            else if (selected.Equals("Intel i5"))
            {
                value = 5;
            }
            else if (selected.Equals("Intel i7"))
            {
                value = 6;
            }
            else if (selected.Equals("Intel Core M"))
            {
                value = 7;
            }
            else if (selected.Equals("AMD A4-Series"))
            {
                value = 8;
            }
            else if (selected.Equals("AMD A6-Series"))
            {
                value = 9;
            }
            else if (selected.Equals("AMD A8-Series"))
            {
                value = 10;
            }
            else if (selected.Equals("AMD A9-Series"))
            {
                value = 11;
            }
            else if (selected.Equals("AMD A10-Series"))
            {
                value = 12;
            }
            else if (selected.Equals("AMD A12-Series"))
            {
                value = 13;
            }
            else if (selected.Equals("AMD E-Series"))
            {
                value = 14;
            }
            else if (selected.Equals("AMD FX"))
            {
                value = 15;
            }
            else if (selected.Equals("AMD Ryzen"))
            {
                value = 16;
            }
            else
            {
                value = 17;
            }

            return value;
        }
    }
}
