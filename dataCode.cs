using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Shapes;

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
                            if (cont.Length == min)
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
        #endregion

        #region import
        internal static void AccessData(bool file = true, bool db = false)
        {
            var dI = manipulateData.input(file, db);
            dI.ForEach(d =>
            {
                var con = manipulateData.format(d);
                var con2 = manipulateData.convert(con);
                if (con != null) {
                    Program.contacts.Add(con2);
                } 
                else { 
                    //some sort of error
                }
            }
            );

        }
        #endregion
    } //the code for fileCode
    internal static class manipulateData
    {
        internal static List<dataInput> input(bool database = false, bool file = true)
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
        internal static dataInput format(dataInput toFormat)
        {
            toFormat.phone;
            toFormat.buisness;
            toFormat.notes;
            toFormat.index;
            dataInput format = toFormat;

            var formatFirstName = format.firstname;
            string formatedFirstName = string.Empty;

            var formatLastName = format.lastname;
            string formatedLastName = string.Empty;

            var formatEmail = format.email;
            string formatedEmail = string.Empty;

            if(formatFirstName is string) {
                formatedFirstName = formatFirstName;

            }

            //format last name
            if (formatLastName is string)
            {
                formatedLastName = formatLastName;

            }

            //format email
            if (formatEmail is string)
            {
                formatedEmail = formatEmail;
            }

        }

        internal static Contact convert(dataInput toConvert)
        {
            string firName = toConvert.firstname;
            string laName = toConvert.lastname;
            string email = toConvert.email;
            string phone = toConvert.phone;
            bool buisness = toConvert.buisness;
            string notes = toConvert.notes;
            int id = toConvert.index;
            return storageSystem.newContact(firName,laName,email,phone,buisness,notes,id);
        }

    }
}
