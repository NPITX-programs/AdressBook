using System.IO;
using System.Windows.Forms;
using System;
using System.Windows.Documents;
using System.Collections.Generic;

namespace AdressBook
{
    internal class dataInput
    {
        internal dynamic firstname; //first name
        internal dynamic lastname; //last name
        internal dynamic email; //e-mail address
        internal dynamic phone; //phone number
        internal dynamic buisness; //buisness
        internal dynamic notes; //notes about contact
        internal dynamic index; //the index of the entry
    }
    internal partial class fileCode
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

        internal static void read(string path, char sep, int min) //the read function, which has the refferenced class hardcoded
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
                                   Contact c = storageSystem.newContact(cont[0], cont[1], cont[2], cont[3], Convert.ToBoolean(cont[4]), cont[5], Convert.ToInt32(cont[6]) - 1);
 
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
        internal static dataInput readFile2(string filePath, char sep = ',')
        {
            dataInput dI = new dataInput();

            return dI;
        }
    } //the code for fileCode
    internal static class manipulateData
    {

    }
}
