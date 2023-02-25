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
        private readonly SelectedClientStore _selectedClientStore;

        public IEnumerable<ClientListingItemViewModel> ClientListingItemViewModel => _clientListingItemViewModel;

        private ClientListingItemViewModel _selectedClientListingItemViewModel;

        public ClientListingItemViewModel SelectedClientListingItemViewModel
        {
            get { return _selectedClientListingItemViewModel; }
            set 
            {
                _selectedClientListingItemViewModel = value;
                OnPropertyChanged(nameof(SelectedClientListingItemViewModel));
                _selectedClientStore.SelectedClient = _selectedClientListingItemViewModel.Client;
            }
        }


        public ClientListingViewModel(SelectedClientStore selectedClientStore)
        {
            _clientListingItemViewModel = new ObservableCollection<ClientListingItemViewModel>();

            _clientListingItemViewModel.Add(new ClientListingItemViewModel(new Client("Patric", "Gomabobagamil.com")));
            _clientListingItemViewModel.Add(new ClientListingItemViewModel(new Client("Luna", "Gbagamil.com")));
            _clientListingItemViewModel.Add(new ClientListingItemViewModel(new Client("Michail", "Gbagamil.com")));


            _selectedClientStore = selectedClientStore;
        }
    }
}
