using System;

namespace AdressBook
{
    internal static class information
    {
        internal const char seperationChar = ',';
        internal const string fileName = "store";
        internal const int min = 6;//minimum total values in an entry
        internal const string baseFolder = "contacts"; //name of file
        internal const string fileExtension = "csv"; //extension of file
        internal static string root()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
        internal static string path()
        {
            return root() + baseFolder + fileName + '.' + fileExtension;
        }
    }
}
