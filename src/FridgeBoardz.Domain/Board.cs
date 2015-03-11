using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeBoardz.Domain
{
   public abstract class Board
    {
       public Guid BoardId { get; set; }
       public string BoardName { get; set; }
       public string BoardType { get; set; }
       public User CreatedBy { get; set; }
       public DateTime CreatedDate { get; set; }
       public Group Group { get; set; }
    }
}
