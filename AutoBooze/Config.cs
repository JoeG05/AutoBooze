using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AutoBooze
{
    class Config
    {
        public Dictionary<string, string> attributes = new Dictionary<string, string>();

        public string loadConfig(string file)
        {
            if (!File.Exists(file))
            {
                return ("File not found.\n");
            }

            StreamReader configFile = new StreamReader(file);
            string line;
            while((line = configFile.ReadLine()) != null)
            {
                string attribute, value;
                string[] splitLine = line.Split('=');
                attribute = splitLine[0];
                value = splitLine[1];
                attribute = attribute.Trim();
                value = value.Trim();

                attributes.Add(attribute, value);
            }
            configFile.Close();
            return ("Config file loaded.\n");
        }
    }
}
