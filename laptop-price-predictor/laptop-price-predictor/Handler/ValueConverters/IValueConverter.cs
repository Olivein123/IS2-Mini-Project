﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler.ValueConverters
{
    public interface IValueConverter
    {
        public float ReturnFloatValue(ComboBox comboBox);
    }
}
