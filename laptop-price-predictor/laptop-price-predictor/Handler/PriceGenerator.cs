using Laptop_price_predictor;


namespace laptop_price_predictor.Handler
{
    public class PriceGenerator
    {
        public PriceGenerator() { }

        public float Generate(Laptop laptop)
        {
            //Load sample data
            var sampleData = new Model.ModelInput()
            {
                Category = laptop.Category,
                Screen_Size_in_inches_ = laptop.ScreenSize,
                Screen_Resolution = laptop.ScreenRes,
                CPU = laptop.CpuType,
                GHz = laptop.CpuSpeed,
                RAM_in_Gb_ = laptop.RamSize,
                HDD_Size_in_Gb_ = laptop.HDDSize,
                SSD_Size_In_GB_ = laptop.SSDSize,
                FLASH_STORAGE_Size_In_GB_ = laptop.FlashStorageSize,
                HYBRID_Size_In_GB_ = laptop.HybridSize,
                GPU = laptop.GpuType,
                OS = laptop.OperatingSystem,
                Weight__in_kg_ = laptop.Weight,
            };

            //Load model and predict output
            var result = Model.Predict(sampleData);

            float converted = result.Score;
            
            return converted;

        }

    }
}
