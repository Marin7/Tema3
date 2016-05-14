using EventMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EventMVC.Controllers
{
    public interface Exporter
    {
        void export(List<Ticket> tickets);
    }
}