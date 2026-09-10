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
    }
}
