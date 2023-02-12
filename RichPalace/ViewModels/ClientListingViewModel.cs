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
        private readonly ClientStore _clientStore;

        private readonly ObservableCollection<ClientViewModel> _clients;

        public IEnumerable<ClientViewModel> Client => _clients;

        public ICommand AddClientCommand { get; }

        public ClientListingViewModel(ClientStore clientStore, INavigationService addPersonNavigationService)
        {
            _clientStore = clientStore;
            _clients = new ObservableCollection<ClientViewModel>();

            AddClientCommand = new NavigateCommand(addPersonNavigationService);

            _clientStore.ClientAdded += OnClientAdded;
        }

        private void OnClientAdded(Client client)
        {
            _clients.Add(new ClientViewModel(client));
        }
    }
}
