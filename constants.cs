using System;
using System.Data.SqlClient;

namespace AdressBook
{
    internal static class constants
    {
        internal const char seperationChar = ',';
        internal const string fileName = "store";
        internal const int min = 6;//minimum total values in an entry
        internal const string baseFolder = "contacts"; //name of file
        internal const string fileExtension = "csv"; //extension of file
        internal const string pathDivide = @"/";
        internal static string root()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        } //the root of the program
        internal static string path()
        {
            return root() + baseFolder + pathDivide + fileName + "." + fileExtension;
        } //the final path to the file
        internal const string preMadeErrorMsg = "I'm sorry dave, I'm afraid I can't do that";
    }
    internal partial class inputTypes 
    {
        internal static bool file = true;
        internal static bool db = false;
    }
    internal static class SQLConstants
    {
        #region SQL Constants
        //SQL COMMAND DEFINITIONS


        //blueprint on how to create the connection

        //physical connection to the Database that we can open/close

        //instructions to the DB that allow for SQL code

        //Allows to unpack records when a SELECT query is used
        //these are for classes that will be 

        #endregion //sql constants
    }
}
