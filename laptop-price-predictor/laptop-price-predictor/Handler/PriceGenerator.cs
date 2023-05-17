using Laptop_price_predictor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler
{
    public class PriceGenerator
    {
        public PriceGenerator() { }

        public Model.ModelOutput Generate(Laptop laptop)
        {
            //Load sample data
            var sampleData = new Model.ModelInput()
            {
                Category = laptop.Category,
                Screen_Size_in_inches_ = laptop.ScreenSize,
                Screen_Resolution = laptop.ScreenRes,
                CPU = laptop.CpuType,
                GHz = laptop.CpuSpeed,
                RAM_IN_GB_ = laptop.RamSize,
                Storage_Gb_ = laptop.StorageType,
                GPU = laptop.GpuType,
                OS = laptop.OperatingSystem,
                Weight__in_kg_ = laptop.Weight,
            };

            //Load model and predict output
            var result = Model.Predict(sampleData);

            return result;

        }
    }
}
