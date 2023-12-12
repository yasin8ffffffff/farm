using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace farm
{
    public class Environment
    {
        public float HealthParameteTDS { get; set; }
        public float HealthParameteTemp { get; set; }
        public float HealthParameteDensity { get; set; }
        public float HealthParametedb { get; set; }
        public float HealthParameteAQI { get; set; }
        public float HealthParameteOX { get; set; }

        public DateTime daily;

    }
}
