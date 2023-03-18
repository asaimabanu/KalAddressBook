using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalAddressBook.Models
{
    enum ContactCategory
    {
        A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z    }
    internal class Contact
    {

        public string Name { get; set; }
        public string phone1 { get; set; }
        public string IconFile { get; set; }
       
       public string email { get; set; }

        public string address { get; set; }

        public int zipcode { get; set; }

        public ContactCategory Category { get; set; }
        public Contact(string name, ContactCategory category)
        {
            Name = name;
            Category = category;
            IconFile = $"/Assets/Icons/{category}/{name}.png";
            //phone1 = "8583309876";
            //email = "asaima@gmail.com";
         

        }

    }
}
