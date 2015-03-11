using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeBoardz.Domain.Boardz
{
   public class ShoppingListBoard : IBoard
    {
       public ShoppingListBoard(string name, Group group, User user)
        {
            BoardId = Guid.NewGuid();
            BoardName = name;
            CreatedBy = user;
            CreatedDate = DateTime.Now;
            Group = group;
        }

        public string BoardType
        {
            get { return "Shopping List"; }

        }

        public Guid BoardId { get; private set; }
        public string BoardName { get; private set; }
        public User CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Group Group { get; private set; }
    }
}
