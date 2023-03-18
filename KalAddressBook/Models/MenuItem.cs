using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Contacts;

namespace KalAddressBook.Models
{
    internal class MenuItem
    {
        public string IconFile { get; set; }
        public ContactCategory Category { get; set; }
    }
}
