using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class Family
    {
        private int _id;
        private string _familyName;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string FamilyName { get => _familyName; set => _familyName = value; }
    }
}
