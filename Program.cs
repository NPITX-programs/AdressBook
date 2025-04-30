using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new frm_main());
        }
        internal static List<Contact> contacts = new List<Contact>(); //makes a collection that refferences the class that will store information
        internal static List<string> controlNames = new List<string>() { "txt_firName", "txt_lastName", "txt_phoNum" , "txt_EMail" , "txt_contNote" , "chk_type" };
    }
}
