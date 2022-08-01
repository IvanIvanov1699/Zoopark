using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoopark.Model
{
    public class Animal
    {
        private int _id;
        private string _name;
        private string _description;
        private byte[]? _image;
        private int _idFamily;

        [Key]
        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public byte[]? Image { get => _image; set => _image = value; }
        [ForeignKey(nameof(Family))]
        public int IdFamily { get => _idFamily; set => _idFamily = value; }
        public virtual Family Family { get; set; }
    }
}
