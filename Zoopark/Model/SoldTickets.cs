using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class SoldTickets
    {
        private int _id;
        private int _idUser;
        private int _idTicket;
        
        [Key]
        public int Id { get => _id; set => _id = value; }
        [ForeignKey(nameof(User))]
        public int IdUser { get => _idUser; set => _idUser = value; }
        [ForeignKey(nameof(Ticket))]
        public int IdTicket { get => _idTicket; set => _idTicket = value; }
        public virtual Ticket Ticket { get; set; }
        public virtual User User { get; set; }
    }
}
