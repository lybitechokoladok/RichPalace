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

namespace RichPalace.WPF.Commands
{
    public class MakeReservationCommand : CommandBase
    {
        private readonly MakeReservationViewModel _makeReservationViewModel;
        private readonly Hotel _hotel;
        private readonly INavigationService _reservationViewNavigationService;

        public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, Hotel hotel, INavigationService reservationViewNavigationService)
        {
            _makeReservationViewModel = makeReservationViewModel;
            _hotel = hotel;
            _reservationViewNavigationService = reservationViewNavigationService;
            _makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
        }

        private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(MakeReservationViewModel.Username) ||
                e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
            {
                OnCanExecuteChanged();
            }
        }

        public override bool CanExecute(object? parameter)
        {
            return !string.IsNullOrEmpty(_makeReservationViewModel.Username) &&
                _makeReservationViewModel.FloorNumber > 0 &&
                base.CanExecute(parameter);
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
                _hotel.MakeReservation(reservation);
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
