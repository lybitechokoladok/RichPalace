using RichPalace.Domain.Models;
using RichPalace.WPF.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.ViewModels
{
    public class ClientViewModel : ViewModelBase
    {
        private readonly Client _client;
        public string Name => _client.Name;
        public string Email => _client.Email;

        public ClientViewModel(Client client)
        {
            _client = client;
        }
    }
}
