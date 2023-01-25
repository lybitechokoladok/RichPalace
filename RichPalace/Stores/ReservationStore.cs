using RichPalace.Domain.Models;
using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Stores
{
    public class ReservationStore
    {
        public event Action<Reservation> ReservationAdded;

        public void AddReservation(Reservation reservation) 
        {
            ReservationAdded?.Invoke(reservation);
        }
    }
}
