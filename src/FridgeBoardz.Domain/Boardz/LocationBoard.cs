using System;

namespace FridgeBoardz.Domain.Boardz
{
    public class LocationBoard : IBoard
    {
        public LocationBoard(string name, Group group, User user)
        {
            BoardId = Guid.NewGuid();
            BoardName = name;
            CreatedBy = user;
            CreatedDate = DateTime.Now;
            Group = group;
        }

        public string BoardType
        {
            get { return "Location"; }

        }

        public Guid BoardId { get; private set; }
        public string BoardName { get; private set; }
        public User CreatedBy { get; private set; }
        public DateTime CreatedDate { get; private set; }
        public Group Group { get; private set; }
    }
}
