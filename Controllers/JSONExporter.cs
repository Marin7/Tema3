using EventMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventMVC.Controllers
{
    public class JSONExporter : Exporter
    {
        public void export(List<Ticket> tickets)
        {
            string text = JsonConvert.SerializeObject(tickets.ToArray());
            System.IO.File.WriteAllText(@"E:\Facultate\PS\EventMVC\tickets.json", text);
        }
    }
}