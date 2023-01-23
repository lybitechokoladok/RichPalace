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
        private ViewModelBase _reservations;

        public ViewModelBase Reservations
        {
            get => _reservations;
            set
            {
                _reservations = value;
                ReservationAdded?.Invoke();
            }
        }


        public event Action ReservationAdded;

    }
}
