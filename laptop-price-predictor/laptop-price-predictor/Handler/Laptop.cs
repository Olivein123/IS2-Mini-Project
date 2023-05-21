using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laptop_price_predictor.Handler
{
    public class Laptop
    {
        public float Category { get; set; }
        public float ScreenSize { get; set}           
        public float ScreenRes { get; set; }
        public float CpuType { get; set; }
        public float CpuSpeed { get; set; }
        public float GpuType { get; set; }
        public float RamSize { get; set; }
        public float StorageType { get; set; }
        public float OperatingSystem { get; set; }
        public float Weight { get; set; }  
    }
}

