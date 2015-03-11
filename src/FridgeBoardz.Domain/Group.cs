using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeBoardz.Domain
{
    public class Group
    {
        public Guid GroupId { get; set; }
        public string GroupName { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}