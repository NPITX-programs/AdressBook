
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System;

namespace AdressBook.files
{
    internal static class files
    {
        internal static void Write(string filepath, char sep) 
        {
            bool status = File.Exists(filepath); //check if the file exists
            if (status || Program.debug)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(filepath))
                    {
                        foreach (var c in Program.contacts) //the loop for createing the contents which will be saved
                        {
                            //csv - comma seperated values
                            //firstname-lastname-email-phone-buisness-notes
                            string ind = (c.index + 1).ToString();
                            string line = c.firstname + sep + c.lastname + sep +  //first and last name
                                c.phone + sep + c.email + sep + c.buisness + sep + //contact information
                                c.notes + sep + ind; //notes
                            sw.WriteLine(line); //write the information to the line
                        }
                    } //streamwriter
                }
                catch (Exception ex)
                {
                    AdressBook.coreCommands.error(Program.preMadeErrorMsg, ex, true); //show error
                }
            }
            else
            {
                AdressBook.coreCommands.error("File Not Found"); //show error
            }
        } //the write function

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
                                    buisness = Convert.ToBoolean(cont[4]), //same
                                    notes = cont[5], //same
                                    index = Convert.ToInt32(cont[6]) - 1 //more of the same             
                                };
                                Program.contacts.Add(c); //add to list
                            }
                            else
                            {
                             
                                AdressBook.coreCommands.error("error: below Max Length");
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
    } //the code for files
}
