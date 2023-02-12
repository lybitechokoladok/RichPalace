using RichPalace.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private readonly Reservation _reservation;
        public string Name { get; }
        public string Email { get; }
        public string RoomId => _reservation.RoomID?.ToString();

        public ClientViewModel(string name, string role)
        {
            Name = name;
            Email = role;
        }
    }
}
