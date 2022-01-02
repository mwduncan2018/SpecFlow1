using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowBdd.Config
{
    public class AppSettings
    {
        public string Environment { get; set; }
        public string GridIp { get; set; }
        public string DriverType { get; set; }
        public string Url { get; set; }
        public string TestDataPath { get; set; }
        public int ImplicitWait { get; set; }
        public int HorizontalPixels { get; set; }
        public int VerticalPixels { get; set; }
        public bool Maximize { get; set; }
    }
}
