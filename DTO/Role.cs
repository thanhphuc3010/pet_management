using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Role
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public Role() { }

        public Role(int id, string code, string name, string description)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
        }
        public Role(DataRow item)
        {
            this.Id = Convert.ToInt32(item.GetValueInCell("id"));
            this.Code = item.GetValueInCell("code").ToString();
            this.Name = item.GetValueInCell("name").ToString();
            this.Description = item.GetValueInCell("description").ToString();
        }
    }
}
