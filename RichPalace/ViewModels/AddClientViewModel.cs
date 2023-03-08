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
    public class AddClientViewModel : ViewModelBase
    {
        public ClientDetailsFormViewModel ClientDetailsFormViewModel { get; }

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

        public AddClientViewModel(ClientStore clientStore, INavigationService closeNavigationService)
        {
            ClientDetailsFormViewModel = new ClientDetailsFormViewModel();

            SubmitCommand = new AddClientCommand(this, clientStore, closeNavigationService);
            CancelCommand = new NavigateCommand(closeNavigationService);
        }
    }
}
