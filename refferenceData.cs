using System;

namespace AdressBook
{
    internal partial class information
    {
        const char seperationChar = ',';
        const string fileName = "store";
        const string baseFolder = "contacts"; //name of file
        const string fileExtension = "csv"; //extension of file
        const int min = 6;//minimum total values in an entry
        string root = AppDomain.CurrentDomain.BaseDirectory;
        string path = AppDomain.CurrentDomain.BaseDirectory + baseFolder + fileName + fileExtension;
        internal const char seperationChar = ',';
        internal const string fileName = "store";
        internal const int min = 6;//minimum total values in an entry
        internal const string baseFolder = "contacts"; //name of file
        internal const string fileExtension = "csv"; //extension of file
        internal static string root()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        } //the root of the program
        internal static string path()
        {
            return root() + baseFolder + fileName + '.' + fileExtension;
        } //the final path to the file
        internal const string preMadeErrorMsg = "I'm sorry dave, I'm afraid I can't do that";
    }
}
