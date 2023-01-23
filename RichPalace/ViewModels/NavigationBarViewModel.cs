using RichPalace.WPF.Services;
using RichPalace.WPF.Commands;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RichPalace.WPF.ViewModels
{
    public class NavigationBarViewModel : ViewModelBase
    {
        private readonly AccountStore _accountStore;

        public ICommand NavigateHomeCommand { get; }
        public ICommand NavigateAccountCommand { get; }
        public ICommand NavigateLoginCommand { get; }
        public ICommand NavigatePeopleListingCommand { get; }

        public ICommand NavigateReservationListingCommand { get; }
        public ICommand LogoutCommand { get; }

        public bool IsLoggedIn => _accountStore.IsLoggedIn;

        public NavigationBarViewModel(AccountStore accountStore,
            INavigationService homeNavigationService,
            INavigationService accountNavigationService,
            INavigationService reservationListingNavigationService,
            INavigationService loginNavigationService,
            INavigationService peopleListingNavigationService)
        {
            _accountStore = accountStore;
            NavigateReservationListingCommand = new NavigateCommand(reservationListingNavigationService);
            NavigateHomeCommand = new NavigateCommand(homeNavigationService);
            NavigateAccountCommand = new NavigateCommand(accountNavigationService);
            NavigateLoginCommand = new NavigateCommand(loginNavigationService);
            NavigatePeopleListingCommand = new NavigateCommand(peopleListingNavigationService);
            LogoutCommand = new LogoutCommand(_accountStore);

            _accountStore.CurrentAccountChanged += OnCurrentAccountChanged;
        }

        private void OnCurrentAccountChanged()
        {
            OnPropertyChanged(nameof(IsLoggedIn));
        }

        public override void Dispose()
        {
            _accountStore.CurrentAccountChanged -= OnCurrentAccountChanged;

            base.Dispose();
        }
    }
}
