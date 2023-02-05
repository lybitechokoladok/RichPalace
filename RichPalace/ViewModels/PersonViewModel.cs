using RichPalace.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.ViewModels
{
    public class PersonViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string Name { get; }
        public string Role { get; }
        public string RoomId => _reservation.RoomID?.ToString();

        public PersonViewModel(string name, string role)
        {
            Name = name;
            Role = role;
        }
    }
}
