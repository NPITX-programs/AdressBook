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
#pragma warning disable IDE0044 // Add readonly modifier
        string root = AppDomain.CurrentDomain.BaseDirectory;
//via attribute        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending>")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "<Pending>")]
=========
#pragma warning restore IDE0044 // Add readonly modifier
>>>>>>>>> Temporary merge branch 2
        string path = AppDomain.CurrentDomain.BaseDirectory + baseFolder + fileName + fileExtension;
    }
}
