using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;

namespace AutoBooze
{
    class Data
    {
        public struct SalesData
        {
            public double Sold;
            public double OH;
            public string Code;
        };

        public void setReportLocation(string location)
        {
            reportLocation = location;
        }

        public void setPerpetualLocation(string location)
        {
            perpetualLocation = location;
        }
        
        public void setPerpetualSaveAsLocation(string location)
        {
            perpetualSaveAsLocation = location + "Perpetual-WE-" + getNextSunday() + ".xlsx";
        }

        public string getperpetualSaveAsLocation()
        {
            return perpetualSaveAsLocation;
        }

        public void setOrderLocation(string location)
        {
            orderLocation = location;
        }

        public void setOrderSaveAsLocation(string location)
        {
            orderSaveAsLocation = location + "SP-" + getToday() + ".xlsx";
        }

        public string getOrderSaveAsLocation()
        {
            return orderSaveAsLocation;
        }
        
        public SalesData sales;

        private string customFormat = "MM.dd.yy";
        private DateTime today = DateTime.Today;
        public string reportLocation = "";
        public string perpetualLocation;
        public string perpetualSaveAsLocation;
        public string orderLocation;
        public string orderSaveAsLocation;
        public int storeNum;

        public string getLastSunday()
        {
            int daysSinceSunday = ((int)today.DayOfWeek - (int)DayOfWeek.Sunday + 7) % 7;
            DateTime lastSunday = today.AddDays(-daysSinceSunday);
            return lastSunday.ToString(customFormat);
        }

        public string getNextSunday()
        {
            int daysUntilSunday = ((int)DayOfWeek.Sunday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextSunday = today.AddDays(daysUntilSunday);
            return nextSunday.ToString(customFormat);
        }

        public string getToday()
        {
            return today.ToString(customFormat);
        }

        public void getInventory()
        {
            char[] delimiterChars = { ',' };
            string[] productCodes = { "584-10", "584-30", "555-00", "580-00", "581-00", "587-00" };
            string line;

           
            StreamReader file = new StreamReader(reportLocation);

            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(delimiterChars);
                if (words[0] != productCodes[0] &&
                    words[0] != productCodes[1] &&
                    words[0] != productCodes[2] &&
                    words[0] != productCodes[3] &&
                    words[0] != productCodes[4] &&
                    words[0] != productCodes[5] ||
                    words[2] == "Total $:")
                {
                    continue;
                }
                sales.Sold = double.Parse(words[9]);
                sales.OH = double.Parse(words[13]);
                sales.Code = words[0];
                d.Add(words[2], sales);
            }
            file.Close();
        }

        public void fillPerpetual(int store)
        {
            Excel.Application xl = new Excel.Application();
            Excel.Workbook xlWorkbook = xl.Workbooks.Open(perpetualLocation);
            Excel.Worksheet xlSheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlSheet.UsedRange;
            int rowCount = xlRange.Rows.Count;

            System.IO.StreamWriter logFile;
            switch(store)
            {
                case 24:
                    logFile = new System.IO.StreamWriter(@"C:\Dropbox\Work\Chatham\log " + getToday() + ".txt");
                    break;

                case 27:
                    logFile = new System.IO.StreamWriter(@"C:\Dropbox\Work\log " + getToday() + ".txt");
                    break;

                default:
                    logFile = new System.IO.StreamWriter(@"C:\Dropbox\Work\log (nostore) " + getToday() + ".txt");
                    break;
            }
            
            List<string> errorList = new List<string>();

            for (int i = 1; i < rowCount; i++)
            {
                string item = (string)(xlRange.Cells[i, 1] as Excel.Range).Value2;

                if (item == null)
                    continue;

                if (d.ContainsKey(item))
                {
                    xlRange.Cells[i, 3].Value2 = d[item].OH;
                }
                if (!d.ContainsKey(item))
                {
                    errorList.Add(item);
                }
            }

            foreach (string x in errorList)
                logFile.WriteLine(x);

            logFile.Close();
            xlWorkbook.SaveAs(perpetualSaveAsLocation);
            xlWorkbook.Close();
        }

        public void fillOrderSheet()
        {
            Excel.Application xl = new Excel.Application();
            Excel.Workbook xlWorkbook = xl.Workbooks.Open(orderLocation);
            Excel.Worksheet xlSheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlSheet.UsedRange;
            int rowCount = xlRange.Rows.Count;

            for (int i = 1; i < rowCount; i++)
            {
                string item = (string)(xlRange.Cells[i, 1] as Excel.Range).Value2;

                if (item == null)
                    continue;

                if (d.ContainsKey(item))
                {
                    xlRange.Cells[i, 3].Value2 = d[item].Sold;
                    xlRange.Cells[i, 4].Value2 = d[item].OH;
                }
            }

            xlRange.Cells[1, 5].Value2 = getToday();
            xlWorkbook.SaveAs(orderSaveAsLocation);
            xlWorkbook.Close();
        }

        private Dictionary<string, SalesData> d = new Dictionary<string, SalesData>();
    }
}
