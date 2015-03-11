using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeBoardz.Domain
{
   public interface IBoard
    {
        Guid BoardId { get; }
        string BoardName { get; }
        string BoardType { get; }
        User CreatedBy { get; }
        DateTime CreatedDate { get; }
        Group Group { get; }

    
    }
}
