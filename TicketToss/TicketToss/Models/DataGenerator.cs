using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TicketToss.Models
{
    public class DataGenerator
    {
        public DataGenerator()
        {
            Events = new List<Event>();
            Events.Add (new Event {Name = "Celtic vs Aberdeen", Teams = "Celtic, Aberdeen" , ID = 1 , Tickets = new List<Ticket>()} );
            Events.Add (new Event {Name = "Celtic vs Dundee", Teams = "Celtic, Dundee" , ID = 2 , Tickets = new List<Ticket>()} );
            Events.Add (new Event {Name = "Hearts vs Inverness CT", Teams = "Hearts, Inverness CT" , ID = 3 , Tickets = new List<Ticket>()} );
            Events.Add (new Event {Name = "Hearts vs Aberdeen", Teams = "Hearts, Aberdeen" , ID = 4 , Tickets = new List<Ticket>()} );
            Events.Add (new Event {Name = "Falkirk vs Motherwell", Teams = "Falkirk, Motherwell" , ID = 5 , Tickets = new List<Ticket>()} );

            Tickets = new List<Ticket>();
            Tickets.Add(new Ticket { TicketID = 123456, User = new User { Name = "Gerry949"} });
            Tickets.Add(new Ticket { TicketID = 123457, User = new User { Name = "ConorT22" } });
            Tickets.Add(new Ticket { TicketID = 123458, User = new User { Name = "Gerry949" } });
            Tickets.Add(new Ticket { TicketID = 123459, User = new User { Name = "ConorT22" } });
            Tickets.Add(new Ticket { TicketID = 1234510, User = new User { Name = "Gerry949" } });
            Tickets.Add(new Ticket { TicketID = 1234511, User = new User { Name = "Mark33" } });

            Events[0].Tickets.Add(Tickets[3]);
            Events[0].Tickets.Add(Tickets[2]);
            Events[1].Tickets.Add(Tickets[0]);
            Events[2].Tickets.Add(Tickets[1]);
            Events[3].Tickets.Add(Tickets[4]);
            Events[4].Tickets.Add(Tickets[5]);

        }
            

        public List<Event> Events { get; set; }
        public List<Ticket> Tickets { get; set; }
        public List<User> User { get; set; }    
     }

}

