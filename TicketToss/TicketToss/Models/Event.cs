using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketToss.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Teams { get; set; }
        public int ID { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}