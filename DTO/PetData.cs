using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PetData
    {
        public PetData() { }
        public int Id { get; set; }

        [Description("pet_number")]
        public string PetNumber { get; set; }
        public string Microchip { get; set; }

        [Description("name")] 
        public string PetName { get; set; }

        [Description("species_name")]
        public string Species { get; set; }

        [Description("breed_name")]
        public string Breed { get; set; }
        public string Weight { get; set; }
        public string Age { get; set; }

        [Description("first_name")]
        public string FirstName { get; set; }

        [Description("last_name")]
        public string LastName { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
