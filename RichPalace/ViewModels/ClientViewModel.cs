using RichPalace.Domain.Models;
using RichPalace.WPF.Commands;
using RichPalace.WPF.Services;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RichPalace.WPF.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        public ClientListingViewModel ClientListingViewModel {get;}
        public ClientDetailsViewModel ClientDetailsViewModel {get;}

        public ICommand AddClientCommand { get;}

        public ClientViewModel(SelectedClientStore selectedClientStore, INavigationService addClientNavigationService,
            INavigationService editClientNavigationService)
        {
            ClientDetailsViewModel= new ClientDetailsViewModel(selectedClientStore);
            ClientListingViewModel = new ClientListingViewModel(selectedClientStore, editClientNavigationService);

            AddClientCommand = new NavigateCommand(addClientNavigationService);
         }
    }
}
