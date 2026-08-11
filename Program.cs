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
            string sqlString = "SELECT * FROM Contacts"; //query string
            try
            {
                _conn = new SqlConnection(conString); //open connection
                _cmd = new SqlCommand(sqlString, _conn); //create command

                //open the connection to allow "travel" to and from DB
                _conn.Open();

                _reader = _cmd.ExecuteReader();

                while (_reader.Read()) //if it can read, continue
                {
                    Contact c = new Contact(); //make contact
                    c.index = Convert.ToInt32(_reader.GetValue(0)); //get the first value (which will be the auto-filled index) and store it in index
                    c.firstname = _reader.GetString(1); //get the first name, store it in firstname
                    c.lastname = _reader.GetString(2); //get the last name, st ore it in lastname
                    c.phone = _reader.GetString(3); //get the phone number, store it in phone number
                    c.email = _reader.GetString(4); //get the e-mail, store it in e-mail
                    c.buisness = _reader.GetBoolean(5); //get if buisness, store in buisness
                    if(_reader.GetValue(6) != DBNull.Value) //check for notes
                    {
                        c.notes = _reader.GetString(6); //if notes, put notes in notes
                    } else
                    {
                        c.notes = string.Empty; //if no notes, put empty string in notes
                    }

                    contacts.Add(c); //add the class into the list
                }
                _conn.Close(); //close the connection for security
            }
            catch ( Exception ex ) //check for error
            {
                MessageBox.Show("Error ocured when attempting to retrieve from dbo.contacts" + ex.Message); //if error, say what operation it was (in this case, read), then show error
                if(_conn.State != ConnectionState.Closed)
                {
                    _conn.Close(); //close the connection for security
                }
            }
            
        } //get contacts

        internal static int addContacts(string firstname, string lastname, string phone, string email,bool buisness, string notes) //add contents
        {
            int id = 0; //set ID to 0 (that way, if a 0 appears elsewhere, we know something is off)

            string sqlString = "INSERT INTO Contacts (FirstName, LastName, PhoneNum, EMail, Type, Notes) " +
                "VALUES(@firstname, @lastname, @phone, @email, @buisness, @notes); SELECT SCOPE_IDENTITY();"; //string of query

            try //attempt
            {
                _conn = new SqlConnection(conString); //connect command
                _cmd = new SqlCommand(sqlString, _conn); //connect

                _cmd.Parameters.Add("@firstname", SqlDbType.VarChar); //prepare to set first paramater to input value
                _cmd.Parameters["@firstname"].Value = firstname; //set first paramater to input value
                _cmd.Parameters.AddWithValue("@lastname", lastname); //set third paramater to input value
                _cmd.Parameters.AddWithValue("@phone", phone); //set third paramater to input value
                _cmd.Parameters.AddWithValue("@emal", email); //set fourth paramater to input value
                _cmd.Parameters.AddWithValue("@buisness", buisness); //set fifth paramater to input value
                _cmd.Parameters.AddWithValue("@notes", notes); //set sixth paramater

                _conn.Open(); //open connection

                id = (int)_cmd.ExecuteScalar(); //adds record into DB, returns identity which is stored in ID

                _conn.Close(); //close id
            }
            catch (Exception ex) //warn if error
            {
                MessageBox.Show("Error ocured when attempting to add to dbo.contacts" + ex.Message); //output the error and what was done when it happened
                if (_conn.State != ConnectionState.Closed)
                {
                    _conn.Close(); //close the connection for security
                }
            }
            return id; //output the ID
        }

        internal static void editContacts(int id, string firstname, string lastname, string phone, string email, bool buisness, string notes)
        {
            string sqlString = "UPDATE Contacts FirstName = @firstname, LastName = @lastname, PhoneNum = @phone, EMmail = @email, " +
                "Type = @buisness, Notes = @notes WHERE ContactID = @id";
            try
            {
                _conn = new SqlConnection(conString);
                _cmd = new SqlCommand(sqlString, _conn);

                _cmd.Parameters.AddWithValue("@id", id);
                _cmd.Parameters.AddWithValue("@firstname", firstname);
                _cmd.Parameters.AddWithValue("@lastname", lastname);
                _cmd.Parameters.AddWithValue("@phone", phone);
                _cmd.Parameters.AddWithValue("@email", email);
                _cmd.Parameters.AddWithValue("@buisness", buisness);
                _cmd.Parameters.AddWithValue("@notes", notes);

                _conn.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Occured when attempting to edit Contents: " + ex.Message);
                if (_conn.State != ConnectionState.Closed) {
                    _conn.Close(); 
                }
            }

        } //edit contacts
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