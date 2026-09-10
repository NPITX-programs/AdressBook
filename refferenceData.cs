namespace AdressBook
{
    internal class information
    {
        internal char csvSeperation = ',';
    }
        private string CreatePath(string root, string path, string name, string extension)
        {
            string finalPath = root + path + @"/" + name + "." + extension; //create the final path

            return finalPath; //output said path
        } //create the final directory path
        const string name1 = "store"; //name of file
        const string exten1 = "csv"; //extension of file
        const int min = 6; //minimum total values in an entry
            filepath = CreatePath(AppDomain.CurrentDomain.BaseDirectory, "contacts", name1, exten1); //create the name, which is stored outside
}
