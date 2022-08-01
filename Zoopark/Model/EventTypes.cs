using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class EventTypes
    {
        private int _id;
        private string _eventType;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string EventType { get => _eventType; set => _eventType = value; }
    }
}
