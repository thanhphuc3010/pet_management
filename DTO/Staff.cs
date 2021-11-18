using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Staff
    {
        public int Id { get; set; }

        [Description("staff_number")]
        public string StaffNumber { get; set; }
        [Description("first_name")]
        public string FirstName { get; set; }
        [Description("last_name")]
        public string LastName { get; set; }
		public DateTime? Birthday { get; set; }
		public string Phone { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
        [Description("id_role")]
        public int IdRole { get; set; }
        public bool Active { get; set; }
		public string Password { get; set; }
        [Description("created_date")]
        public DateTime CreatedDate { get; set; }
        [Description("updated_date")]
        public DateTime UpdatedDate { get; set; }

        public Staff(int id, string staffNumber, string firstname, string lastname, DateTime? birthday, string phone, string email, string address, int roleId, bool active, string password)
        {
            Id = id;
            StaffNumber = staffNumber;
            FirstName = firstname;
            LastName = lastname;
            Birthday = birthday;
            Phone = phone;
            Email = email;
            Address = address;
            IdRole = roleId;
            Active = active;
            Password = password;
        }

        public Staff(DataRow item)
        {
            this.Id = Convert.ToInt32(item.GetValueInCell("id"));
            this.StaffNumber = item.GetValueInCell("staff_number").ToString();
            this.FirstName = item.GetValueInCell("first_name").ToString();
            this.LastName = item.GetValueInCell("last_name").ToString();
            this.Birthday = Convert.ToDateTime(item.GetValueInCell("birthday"));
            this.Phone = item.GetValueInCell("phone").ToString();
            this.Email = item.GetValueInCell("email").ToString();
            this.Address = item.GetValueInCell("address").ToString();
            this.IdRole = Convert.ToInt16(item.GetValueInCell("id_role"));
            this.Active = Convert.ToBoolean(item.GetValueInCell("active"));
            this.Password = item.GetValueInCell("password").ToString();
        }

        public Staff() { }
    }
}
