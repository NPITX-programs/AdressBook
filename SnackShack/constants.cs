namespace snackShack
{
    internal static class constants //pre-defined constants
    {
        internal const char fileSepChar_con = '\\'; //seperater in file paths
        internal static string fileSepString = fileSepChar_con.ToString();
        //internal const int min = 4; //length of entries
        internal const char entrySep = ','; //seperation character
        internal const string preMadeErrorMsg = "I'm sorry dave, I'm afraid I can't do that"; //pre-made error message
        internal const decimal minPrice = 0.05M;
        internal const decimal minQuantity = 0M;
        internal const decimal maxQuantity = 100m;
        internal const decimal maxPrice = 100m;
        internal const string fileName = "snacks.csv";
    }
}