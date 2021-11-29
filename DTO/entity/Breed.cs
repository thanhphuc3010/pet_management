using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Breed
    {
        public Breed()
        {
        }

        public int Id { get; set; }
        [Description("species_id")]
        public int SpeciesId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Breed(int id, int speciesId, string name, string description)
        {
            Id = id;
            SpeciesId = speciesId;
            Name = name;
            Description = description;
        }
    }
}
