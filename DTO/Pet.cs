using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Pet
    {
        public Pet()
        {
        }
        public int Id { get; set; }

        [Description("pet_number")]
        public string PetNumber { get; set; }
        public string Microchip { get; set; }
        [Description("breed_id")]
        public int BreedId { get; set; }
        [Description("customer_id")]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Weight { get; set; }
        [Description("feather_color")]
        public string FeatherColor { get; set; }
        public string Note { get; set; }
        [Description("medical_history")]
        public string MedicalHistory { get; set; }
        [Description("created_date")]
        public DateTime CreatedDate { get; set; }
        [Description("updated_date")]
        public DateTime UpdatedDate { get; set; }

        public Pet(int id, string petNumber, string microchip, int breedId, int customerId, string name, string age, string weight, string featherColor, string note, string medicalHistory, DateTime createdDate, DateTime updatedDate)
        {
            Id = id;
            PetNumber = petNumber;
            Microchip = microchip;
            BreedId = breedId;
            CustomerId = customerId;
            Name = name;
            Age = age;
            Weight = weight;
            FeatherColor = featherColor;
            Note = note;
            MedicalHistory = medicalHistory;
            CreatedDate = createdDate;
            UpdatedDate = updatedDate;
        }
    }
}
