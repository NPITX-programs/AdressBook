using System;

namespace AdressBook
{
    internal partial class information
    {
        internal const char seperationChar = ',';
        internal const string fileName = "store";
        internal const string baseFolder = "contacts"; //name of file
        internal const string fileExtension = "csv"; //extension of file
        internal const int min = 6;//minimum total values in an entry
        internal string root = AppDomain.CurrentDomain.BaseDirectory;
        internal string path = AppDomain.CurrentDomain.BaseDirectory + baseFolder + fileName + '.' + fileExtension;
    }
}
