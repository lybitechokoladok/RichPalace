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

namespace RichPalace.WPF.ViewModels
{
    public class ClientListingViewModel : ViewModelBase
    {
        private readonly ClientStore _clientStore;

        private readonly ObservableCollection<ClientViewModel> _client;

        public IEnumerable<ClientViewModel> Client => _client;

        public ICommand AddPersonCommand { get; }

        public ClientListingViewModel(ClientStore clientStore, INavigationService addPersonNavigationService)
        {
            _clientStore = clientStore;

            AddPersonCommand = new NavigateCommand(addPersonNavigationService);
            _client = new ObservableCollection<ClientViewModel>();

            _client.Add(new ClientViewModel("Angela", "admin@gmail.com"));
            _client.Add(new ClientViewModel("Georgy", "admin@gmail.com"));
            _client.Add(new ClientViewModel("Zina", "admin@gmail.com"));

            _clientStore.ClientAdded += OnClientAdded;
        }

        private void OnClientAdded(string name, string email)
        {
            _client.Add(new ClientViewModel(name, email));
        }
    }
}
