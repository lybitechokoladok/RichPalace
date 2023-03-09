using RichPalace.Domain.Models;
using RichPalace.WPF.Services;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.ViewModels
{
    public class EditClientViewModel : ViewModelBase
    {
        public ClientDetailsFormViewModel ClientDetailsFormViewModel { get; set; }

        public EditClientViewModel(SelectedClientStore selectedClient,ClientStore clientStore, INavigationService closeNavigationService)
        {
            ClientDetailsFormViewModel= new ClientDetailsFormViewModel(closeNavigationService, clientStore)
            { 
                Username= selectedClient.SelectedClient.Username,
                Email= selectedClient.SelectedClient.Email,
            };
        }

    }
}
