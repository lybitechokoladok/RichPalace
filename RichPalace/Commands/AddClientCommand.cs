using RichPalace.Domain.Models;
using RichPalace.WPF.Services;
using RichPalace.WPF.Stores;
using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Commands
{
    public class AddClientCommand : CommandBase
    {
        private readonly ClientDetailsFormViewModel _clientDetailsFormViewModel;
        private readonly ClientStore _clientStore;
        private readonly INavigationService _navigationService;

        public AddClientCommand(ClientDetailsFormViewModel clientDetailsFormViewModel, ClientStore clientStore, INavigationService navigationService)
        {
            _clientDetailsFormViewModel = clientDetailsFormViewModel;
            _clientStore = clientStore;
            _navigationService = navigationService;
        }

        public override void Execute(object parameter)
        {
            Client client = new Client(_clientDetailsFormViewModel.Username, _clientDetailsFormViewModel.Email);


            try
            {
                _navigationService.Navigate();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
