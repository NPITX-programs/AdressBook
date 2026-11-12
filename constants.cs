using System;

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

    internal partial class appSettings
    {
        internal static bool debugValue = true;
        internal static void toggleDebug()
        {
            bool mode = Properties.Settings.Default.Debug.Equals("true");
            if (mode)
            {
                mode = false;
            } else
            { 
                mode = true;
            }
            Properties.Settings.Default.Debug = mode;
            debugValue = mode;
        }
    }
}
