using RichPalace.WPF.Services;
using RichPalace.WPF.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using RichPalace.WPF.Stores;

namespace RichPalace.WPF.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {

        public string WelcomeMessage => "Welcome to my application. Get start use to click on button.";

        public ICommand NavigateLoginCommand { get; }

        public HomeViewModel(INavigationService loginNavigationService)
        {
            NavigateLoginCommand = new NavigateCommand(loginNavigationService);
        }
    }
}
