using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBooze
{
    class Data
    {
        struct SalesData
        {
            public double Sold;
            public double OH;
            public string Code;
        };

        private string customFormat = "MM.dd.yy";

        public string getLastSunday()
        {
            DateTime today = DateTime.Today;
            int daysSinceSunday = ((int)today.DayOfWeek - (int)DayOfWeek.Sunday + 7) % 7;
            DateTime lastSunday = today.AddDays(-daysSinceSunday);
            return lastSunday.ToString(customFormat);
        }

        public string getNextSunday()
        {
            DateTime today = DateTime.Today;
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextSunday = today.AddDays(daysUntilSunday);
            return nextSunday.ToString(customFormat);
        }

        private Dictionary<string, SalesData> d;
    }
}
