using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Unit(int id, string name, string note)
        {
            Id = id;
            Name = name;
            Note = note;
        }
        public Unit() { }
    }
}
