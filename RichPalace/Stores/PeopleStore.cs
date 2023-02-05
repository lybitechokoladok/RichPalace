using RichPalace.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RichPalace.WPF.Stores
{
    public class PeopleStore
    {

        public event Action<string, string> PersonAdded;

        public void AddPerson(string name, string role)
        {
            PersonAdded?.Invoke(name, role);
        }
    }
}
