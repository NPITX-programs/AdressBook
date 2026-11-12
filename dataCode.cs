using System.Diagnostics;
﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

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
    internal partial class dataImport
    {
        #region File

        internal static void Write(string filepath = null, char sep = ',')
        {
            if (filepath == null) {
                filepath = constants.path(); 
            }
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
                    AdressBook.coreCommands.error(constants.preMadeErrorMsg, ex, true); //show error
                }
            }
            else
            {
                AdressBook.coreCommands.error("File Not Found"); //show error
            }
        } //the write function

        internal static List<dataInput> readFile(string filePath = null, char sep = ',',int min = 7)
        {
            if (filePath == null)
            {
                filePath = constants.path();
            }
            bool status = File.Exists(filePath); //check if the file exists

            List<dataInput> results = new List<dataInput>();
            if (status || Program.debug) //check if there
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filePath)) //make stringreader
                    {
                        //csv - comma seperated values
                        //firstname-lastname-email-phone-buisness-notes
                        while (!sr.EndOfStream) //add each line to it one by one
                        {
                            string contact = sr.ReadLine(); //gets the next line of text from the file
                            var cont = contact.Split(sep); //splits it by the seperator
                            dataInput dI = new dataInput();
                            if (cont.Length >= min)
                            {
                                dI.firstname = cont[0];
                                dI.lastname = cont[1];
                                dI.email = cont[2];
                                dI.phone = cont[3];
                                dI.buisness = cont[4];
                                dI.notes = cont[5];
                                dI.index = cont[6];
                                //necessary conversions:
                                    //newContact(cont[0], cont[1], cont[2], cont[3], Convert.ToBoolean(cont[4]), cont[5], Convert.ToInt32(cont[6]) - 1);
                                    results.Add(dI);
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

            return results;
        }
        #endregion File

        #region SQL
        internal static List<dataInput> readDB()
        {
            var results = new List<dataInput>();
            results = Program.getContacts();
            return results;
        }
        #endregion

        #region import
        internal static void AccessData(bool file = true, bool db = false)
        {
            var dI = manipulateData.input(file, db);
            dI.ForEach(d =>
            {
                var con = manipulateData.convertToContact(d);
                if (con != null) {
                    Program.contacts.Add(con);
                } 
                else { 
                    //some sort of error
                }
            }
            );

        {

        }
    } //the code for accessing files

    internal static class sqlServer
        {

        } //the code for useing the SQL server?
        #endregion
        #region export
        internal static void outputData(bool file = true, bool db = false)
        {
            outputData(file, db);
            //error
        }
        #endregion
    } //the code for fileCode
    internal static class manipulateData
    {
        //name of table: Contacts
        internal static List<dataInput> input(bool file = true, bool database = false)
        {
            List<dataInput> fullInput = new List<dataInput>();
            if (file)
            {
                var values = (dataImport.readFile(constants.path(), constants.seperationChar, constants.min));
                fullInput.AddRange(values);
            } else
            if (database)
            {
                //var values = dataImport.readDB();
                //fullInput.AddRange(values);
                //location for code
            }
            return fullInput;
        }
        internal static Contact convertToContact(dataInput toFormat)
        {
            var formatFirstName = toFormat.firstname; //get firstname
            var formatLastName = toFormat.lastname; //get last name
            var formatEmail = toFormat.email; //get e-mail
            var formatPhone = toFormat.phone; //get phone
            var formatBuis = toFormat.buisness; //get buisness
            var formatNotes = toFormat.notes; //get notes
            var formatIndex = toFormat.index; //get index
            string conFirName = formatFirstName.ToString(); //ensure name string
            string conLaName = formatLastName.ToString(); //ensure name string
            string conEmail = formatEmail.ToString(); //ensure email string
            string conPhone = formatPhone.ToString(); //ensure phone string
            bool conType = Convert.ToBoolean(formatBuis); //convert buisness to bool
            string conNotes = formatNotes.ToString(); //ensure notes string
            int conIndex = Convert.ToInt32(formatIndex)-1; //convert and format index
            return storageSystem.newContact(conFirName, conLaName, conEmail, conPhone, conType, conNotes, conIndex); //turn into new contact
            
        } //the unformated thing to convert into the contact

        internal static void output(bool file = true, bool database = false)
        {
            if (file)
            {
                dataImport.Write();
            }
            if (database)
            {
                //var values = dataImport.readDB();
                //fullInput.AddRange(values);
                //location for code
            }
        }

    }
}
