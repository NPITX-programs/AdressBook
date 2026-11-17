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
        internal int dbIndex; //the index in the database (0 if not in the database)
    }

    internal partial class storageSystem
    {
        
        internal static Contact newContact(string firstname, string lastname, string email, string phone, bool buisness, string notes, int index, int dbIndex = -1)
        {
            Contact c = new Contact();
            c.firstname = firstname;
            c.lastname = lastname;
            c.email = email;
            c.phone = phone;
            c.buisness = buisness;
            c.notes = notes;
            c.index = index;
            c.dbIndex = dbIndex;
            return c;
        } //creates the contact
        internal static void contactList(string firstname, string lastname, string email, string phone, bool buisness, string notes, int index) //creates the contact, and adds it to the list.
        {
            Contact con = newContact(firstname, lastname, email, phone, buisness, notes, index);
            Program.contacts.Add(con);
        }
    }
}
