using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class Event
    {
        private int _id;
        private string _name;
        private DateTime _date;
        private string _description;
        private int _idType;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime Date { get => _date; set => _date = value; }
        public string Description { get => _description; set => _description = value; }
        [ForeignKey(nameof(EventTypes))]
        public int IdType { get => _idType; set => _idType = value; }
        public virtual EventTypes EventTypes { get; set; }  
    }
}
