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
        public string Phone1 { get; set; }
        public string IconFile { get; set; }
       
       public string Email { get; set; }

        public string Address { get; set; }

        public int Zipcode { get; set; }

        public ContactCategory Category { get; set; }
        public Contact(string name, ContactCategory category,string phone1,string address)
        {
            Name = name;
            Category = category;
            Phone1 = phone1;
            Address = address;
            
            ;
         

        }

    }
}
