using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Species
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Species()
        {
        }

        public Species(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Species(DataRow item)
        {
            this.Id = Convert.ToInt32(item.GetValueInCell("id"));
            this.Name = item.GetValueInCell("name").ToString();
            this.Description = item.GetValueInCell("description").ToString();
        }
    }
}
