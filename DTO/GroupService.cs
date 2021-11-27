using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GroupService
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public GroupService() { }
        public GroupService(int id, string code, string name, string description)
        {
            Id = id;
            Code = code;
            Name = name;
            Description = description;
        }
    }
}
