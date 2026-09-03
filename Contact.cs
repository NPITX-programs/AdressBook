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
        internal int index; //the index of the entry
    }
    internal class contConst
    {

    }
    internal partial class storageSystem
    {
        
        internal Contact newContact(string firstname, string lastname, string email, string phone, bool buisness, string notes, int index)
        {
            Contact c = new Contact();
            c.firstname = firstname;
            c.lastname = lastname;
            c.email = email;
            c.phone = phone;
            c.buisness = buisness;
            c.notes = notes;
            c.index = index;
            return c;
        }

    }
}
