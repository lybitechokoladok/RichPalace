using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Stores
{
    public class ClientStore
    {

        public event Action<string, string> ClientAdded;

        public void AddClient(string name, string email)
        {
            ClientAdded?.Invoke(name, email);
        }
    }
}
