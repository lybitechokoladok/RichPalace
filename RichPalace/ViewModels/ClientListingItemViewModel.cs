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
        public string Username { get; }

        public ICommand EditCommand { get; }
        public ICommand DeleteComannd { get; }

        public ClientListingItemViewModel(string username)
        {
            Username = username;
        }
    }
}
