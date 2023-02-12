using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.Domain.Models
{
    public class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public RoomID ReservedRoom { get; set; }
    }
}
