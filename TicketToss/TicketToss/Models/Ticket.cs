using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketToss.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public User User { get; set; } 
    }
}