using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBook
{
    internal class Contact
    {
        internal string firstname; //first name
        internal string lastname; //last name
        internal string email; //e-mail address
        internal string phone; //phone number
        internal bool buisness; //buisness
        internal string notes; //notes about contact
    } //the class which contains the framework for storing the contacts

    internal class manipulateContacts
    {
        internal Contact formContact(string firstName, string lastName, string phoNum, string eMail, string contNote, bool contType)
        {
            Contact c = new Contact //make new constact
            {
                firstname = firstName, //put the realevent input into the releavent field
                lastname = lastName, //same
                phone = phoNum, //same
                email = eMail, //same
                notes = contNote, //same
                buisness = contType //same
            };
            Program.contacts.Add(c); //add to list
            return c; //output the new contact 
        }
    }
}
