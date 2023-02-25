using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.Domain.Models
{
    public class Client
    {
        public Client(string userName, string email)
        {
            Username = userName;
            Email = email;
        }

        public string Username { get; set; }
        public string Email { get; set; }
        public RoomID ReservedRoom { get; set; }
    }
}
