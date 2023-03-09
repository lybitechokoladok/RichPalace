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
    public class ClientDetailsFormViewModel : ViewModelBase
    {
		private string _username;
		public string Username
		{
			get { return _username; }
			set 
			{
				_username = value;
				OnPropertyChanged(nameof(Username));
                OnPropertyChanged(nameof(CanSubmit));
			}
		}

        private string _email;
        public string Email
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public bool CanSubmit => string.IsNullOrEmpty(Username);

        public ICommand SubmitCommand { get; }
        public ICommand CancelCommand { get; }

    }
}
