using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdressBook.files; //this is the namespace for the files that are in the project. This is where the classes are stored

namespace AdressBook
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AddressForm());
        }
        internal static List<Contact> contacts = new List<Contact>(); //makes a collection that refferences the class that will store information
        internal static List<int> buiIndex = new List<int>(); //makes a list to store the correct index for buisness contacts. That way, when an item is selected, it will know the location
        internal static List<int> perIndex = new List<int>(); //makes a list to store the correct index for personal contacts. That way, when an item is selected, it will know the location
    }
}
