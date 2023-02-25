using RichPalace.WPF.Services;
using RichPalace.WPF.Commands;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RichPalace.Domain.Models;

namespace RichPalace.WPF.ViewModels
{
    public class ClientListingViewModel : ViewModelBase
    {
        private readonly ObservableCollection<ClientListingItemViewModel> _clientListingItemViewModel;
        public IEnumerable<ClientListingItemViewModel> ClientListingItemViewModel => _clientListingItemViewModel;

        public ClientListingViewModel(SelectedClientStore selectedClientStore)
        {
            _clientListingItemViewModel = new ObservableCollection<ClientListingItemViewModel>();

            _clientListingItemViewModel.Add(new ClientListingItemViewModel("Patric"));
            _clientListingItemViewModel.Add(new ClientListingItemViewModel("Mary"));
            _clientListingItemViewModel.Add(new ClientListingItemViewModel("Susan"));
        }
    }
}
