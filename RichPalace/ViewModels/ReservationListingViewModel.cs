using RichPalace.Domain.Models;
using RichPalace.WPF.Commands;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RichPalace.WPF.Services;
using RichPalace.WPF.Stores;

namespace RichPalace.WPF.ViewModels
{
    public class ReservationListingViewModel : ViewModelBase
    {
        private readonly ReservationStore _reservationStore;
        private readonly ObservableCollection<ReservationViewModel> _reservations;

        public IEnumerable<ReservationViewModel> Reservations => _reservations;
        public ICommand MakeReservationCommand { get; }

        public ReservationListingViewModel(ReservationStore reservationStore, INavigationService makeReservationNavigationService)
        {
            _reservationStore = reservationStore;
            _reservations = new ObservableCollection<ReservationViewModel>();

            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(1, 2), "Nikita", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(3, 4), "Nikita", DateTime.Now, DateTime.Now)));
            _reservations.Add(new ReservationViewModel(new Reservation(new RoomID(5, 6), "Nikita", DateTime.Now, DateTime.Now)));

        }

        private void OnReservationAdded(Reservation reservation)
        {
            _reservations.Add(new ReservationViewModel(reservation));
        }
    }
}
