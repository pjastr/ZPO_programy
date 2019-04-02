using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Linq;

namespace LINQToJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            JObject o = JObject.Parse(@"{
                'CPU': 'Intel',
                'Drives': [
                    'DVD read/writer',
                    '500 gigabyte hard drive'
                ]
            }");

            string cpu = (string)o["CPU"];
            // Intel

            string firstDrive = (string)o["Drives"][0];
            // DVD read/writer

            IList<string> allDrives = o["Drives"].Select(t => (string)t).ToList();
            // DVD read/writer
            // 500 gigabyte hard drive
        }
    }
}
