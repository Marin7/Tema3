using EventMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventMVC.Controllers
{
    public class CsvExporter : Exporter
    {
        public void export(List<Ticket> tickets)
        {
            string text = "Title,Row,Number\n";
            foreach (Ticket ticket in tickets)
            {
                text = text + ticket.Event.title + ",";
                text = text + ticket.row + ",";
                text = text + ticket.number + ",";
                text = text + "\n";
            }
            System.IO.File.WriteAllText(@"E:\Facultate\PS\EventMVC\tickets.csv", text);
        }
    }
}