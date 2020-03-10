using System;
using System.Collections.Generic;
using System.Text;

namespace Dojo
{
    public class Room
    {
        public Guid RoomId { get; set; }
        public String Name { get; set; }
        public Structure Structure { get; set; }
    }
}
