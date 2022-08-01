using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class Ticket
    {
        private int _id;
        private string _ticketType;
        private double _price;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string TicketType { get => _ticketType; set => _ticketType = value; }
        public double Price { get => _price; set => _price = value; }
    }
}
