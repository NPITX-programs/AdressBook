
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace AdressBook.files
{
    internal static class files
    {
        internal static void Write() 
        {

        }

        internal static void read(string path, char sep) //the read function
        {
            bool status = File.Exists(path); //check if the file exists
            if (status || debug) //check if there
            {
                try
                {
                    using (StreamReader sr = new StreamReader(path)) //make stringreader
                    {
                        //csv - comma seperated values
                        //firstname-lastname-email-phone-buisness-notes
                        while (!sr.EndOfStream) //add each line to it one by one
                        {
                            string contact = sr.ReadLine(); //gets the next line of text from the file
                            var cont = contact.Split(sep); //splits it by the seperator
                            if (cont.Length >= min)
                            {

                                createCont(cont[0], cont[1], cont[2], cont[3], cont[5], Convert.ToBoolean(cont[4])); //create the class
                                generateList(); //generate what will go onto the listboxes
                            }
                            else
                            {
                                MessageBox.Show("error"); //show error
                            }

                        }
                    }
                } 
                catch (Exception ex) //show if exception
                {
                    MessageBox.Show("error" + ex.Message); //show error

                }
            }
            else
            {
                MessageBox.Show("file not found"); //show error

            }
        }
    }
}
