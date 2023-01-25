using RichPalace.Domain.Exeptions;
using RichPalace.WPF.Services;
using RichPalace.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using RichPalace.WPF.ViewModels;
using RichPalace.WPF.Stores;

namespace RichPalace.WPF.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly ReservationStore _reservationStore;
        private readonly INavigationService _reservationViewNavigationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, ReservationStore reservationStore, INavigationService reservationViewNavigationService)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _reservationStore = reservationStore;
            _reservationViewNavigationService = reservationViewNavigationService;

        }

        public override void Execute(object? parameter)
        {
            Reservation reservation = new Reservation(
                new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
                _makeReservationViewModel.Username,
                _makeReservationViewModel.StartDate,
                _makeReservationViewModel.EndDate);

            try
            {
                _reservationStore.AddReservation(reservation);
                MessageBox.Show("Succesfully reserved room", "Succes",
                   MessageBoxButton.OK, MessageBoxImage.Information);

                _reservationViewNavigationService.Navigate();
            }
            catch (ReservationConflictExeption)
            {

                MessageBox.Show("This room is already taken", "Error",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
