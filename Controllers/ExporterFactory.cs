using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventMVC.Controllers
{
    public class ExporterFactory
    {
        public static Exporter getExporter(string type)
        {
            if (type.Equals("Csv"))
            {
                return new CsvExporter();
            }
            else if (type.Equals("JSON"))
            {
                return new JSONExporter();
            }
            return null;
        }
    }
}