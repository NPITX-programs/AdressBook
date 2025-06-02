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
        internal const bool debug = true; //global debug var
        internal static List<Contact> contacts = new List<Contact>(); //makes a collection that refferences the class that will store information: CONCEPT- some way to externally configure it, and some sort of integration that allows both global config and granular (specifc lines change)
    }
}
