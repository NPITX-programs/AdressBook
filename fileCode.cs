
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace AdressBook.files
{
    internal static class files
    {

        internal static bool status(string path) //check if the file exists
        {
            bool status = File.Exists(path); //check if the file exists
            return status; //return the status
        }
        internal static void Write() 
        {

        }

        internal static void read(string path, char sep, int min) //the read function
        {
            bool status = File.Exists(path); //check if the file exists
            if (status || Program.debug) //check if there
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
                                Contact c = new Contact //make new constact
                                {
                                    firstname = cont[0], //put the realevent input into the releavent field
                                    lastname = cont[1], //same
                                    phone = cont[2], //same
                                    email = cont[3], //same
                                    notes = cont[5], //same
                                    buisness = Convert.ToBoolean(cont[4]) //same
                                };
                                Program.contacts.Add(c); //add to list
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
