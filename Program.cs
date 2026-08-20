using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdressBook.files; //this is the namespace for the files that are in the project. This is where the classes are stored
using System.Data.SqlClient;
using System.Data;

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
            Application.Run(new frm_addressForm());
        }
        internal const bool debug = true; //global var to controll default for debugs
        internal static List<Contact> contacts = new List<Contact>(); //makes a collection that refferences the class that will store information
        internal const string preMadeErrorMsg = "I'm sorry dave, I'm afraid I can't do that";

        //SQL COMMAND DEFINITIONS
        #region SQL
        //blueprint on how to create the connection
        static string conString = "Data Source=nphdc2;Initial Catalog=chatch;Integrated Security=True";

        //physical connection to the Database that we can open/close
        static SqlConnection _conn;

        //instructions to the DB that allow for SQL code
        static SqlCommand _cmd;

        //Allows to unpack records when a SELECT query is used
        static SqlDataReader _reader;

        //these are for classes that will be 
        #endregion

        //clases
        #region classes
        //name of table: Contacts
        internal static void getContacts()
        {
            string sqlString = "SELECT * FROM Contacts";
            try
            {
                _conn = new SqlConnection(conString);
                _cmd = new SqlCommand(sqlString, _conn);
            }
        }
    #endregion
}
    internal static class coreCommands
    {
        internal static void error(string message, Exception ex = null, bool revealException = false)
        {
            string msg = message; //what message to display
            if (revealException) //put the toggle
            {
                msg = msg + ": " + ex.Message; //the message
            }//a bool to toggle if the exception code should be included in the error message
            MessageBox.Show(msg); //show the message
        } //this is for error messages. the text is mandatory, but the
          //rest isn't necessary. if you don't provide an exception, it won't display one. If you provide an error, it will default to "hide error".
          // WARNING: If you provide a boolean, you can controll if it's hidden. If you provide a boolean but no error, well, it won't work righ
    }
}