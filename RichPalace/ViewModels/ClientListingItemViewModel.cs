using RichPalace.Domain.Models;
using RichPalace.WPF.Commands;
using RichPalace.WPF.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RichPalace.WPF.ViewModels
{
    public class ClientListingItemViewModel : ViewModelBase
    {
        public Client Client { get; }

        public string Username => Client.Username;

        public ICommand EditCommand { get; }
        public ICommand DeleteComannd { get; }

        public ClientListingItemViewModel(Client client, INavigationService editClientNavigationService)
        {
            EditCommand = new NavigateCommand(editClientNavigationService);

            Client = client;
        }
    }
}
