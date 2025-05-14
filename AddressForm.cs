using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook
{
    public partial class AddressForm : Form
    {
        const bool debug = false; //toggle debug
        const char sep = '~'; //seperation character
        public AddressForm()
        {
            InitializeComponent();
        }

        string filepath = string.Empty;

        private string CreatePath(string root, string path, string name, string extension)
        {
            string finalPath = root + path + @"/" + name + "." + extension; //create the final path

            return finalPath; //output said path
        }

        const string name1 = "store"; //name of file
        const string exten1 = "con"; //extension of file
        const int min = 6; //minimum total values in an entry
        // const string direct = AppDomain.CurrentDomain.BaseDirectory + "contacts"; //create the directory path
        private void Frm_main_Load(object sender, EventArgs e)
        {
            filepath = CreatePath(AppDomain.CurrentDomain.BaseDirectory,"contacts",name1,exten1); //create the name, which is stored outside

            readFromFile(); //read from the file
            openFileDialog1.InitialDirectory = filepath; //set the initial directory to the base default file path
            saveFileDialog1.InitialDirectory = filepath; //set the initial directory to the default file path
        }
        int ind = 0; //index for the current contact

        private void readFromFile()
        {
            bool status = File.Exists(filepath); //check if the file exists
            if (status || debug) //check if there
            {
                try
                {
                    using (StreamReader sr = new StreamReader(filepath)) //make stringreader
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
                            else {
                                MessageBox.Show("error"); //show error
                            }
                            
                        }
                    }
                }
                catch(Exception ex) //show if exception
                {
                    MessageBox.Show("error" + ex.Message); //show error

                }
            }
            else
            {
                MessageBox.Show("file not found"); //show error

            }
        } //read from file
        private void WriteToFile()
                {
                    bool status = File.Exists(filepath); //check if the file exists
                    if (status || debug)
                    {
                        try
                        {
                            using (StreamWriter sw = new StreamWriter(filepath))
                            {
                                foreach (var c in Program.contacts) //the loop for createing the contents which will be saved
                                {
                                    //csv - comma seperated values
                                    //firstname-lastname-email-phone-buisness-notes
                                    string line = c.firstname + sep + c.lastname + sep +  //first and last name
                                        c.email + sep + c.phone + sep + c.buisness + sep + //contact information
                                        c.notes; //notes
                                    sw.WriteLine(line); //write the information to the line
                                }
                            } //streamwriter
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("error" + ex.Message); //show error
                        }
                    }
                    else
                    {
                        MessageBox.Show("file not found"); //show error
                    }
                } //write to file (effectively an auto-save)
        //save

        //save as
            //to make new file, use stream writer?
            //didin't work earlier, unknown why

        private void clear() //triger to clear inputs
        {
            txt_firName.Text = string.Empty; //empty first name
            txt_lastName.Text = string.Empty; //empty last name
            txt_phoNum.Text = string.Empty; //empty phone number
            txt_EMail.Text = string.Empty; //empty email
            txt_contNote.Text = string.Empty; //epty contact note
            chk_type.Checked = false; //set checkbox to false
        }

        private Contact nextEntry()
        {          
            int leng = Program.contacts.Count; //get the length
            ind = leng - 1; //get the index (a.k.a the length minus 1)
            Contact curr = Program.contacts[ind]; //get the item at said index, A.K.A. the last item) (curr is for "current")
            return curr; //output that value 
        } //find entry for list (the next entry to add)
        

        private void updateList(Contact value)
        {
            string first = value.firstname; //get last name
            string last = value.lastname; //get first name
            string entry = first + " " + last; //combine first and last name
            int leng = 0; //length of the list

            if (value.buisness == true) //check contact type
            {
                lst_buisnes.Items.Add(entry); //if it's buisness, add to buisness list
                leng = lst_buisnes.Items.Count;

                Program.buiIndex.Add(ind);
            } else
            {
                lst_personal.Items.Add(entry); //if it's not buisness, add to personal list
                leng = lst_personal.Items.Count;

                Program.perIndex.Add(ind);
            }
        } //update the contact list
        private void generateList() //generate the list
        {
            Contact next = nextEntry();
            updateList(next);
        } 
        private Contact createCont(string firstName, string lastName, string phoNum, string eMail, string contNote, bool contType)
        {
            Contact c = new Contact //make new constact
            {
                firstname = firstName, //put the realevent input into the releavent field
                lastname = lastName, //same
                phone = phoNum, //same
                email = eMail, //same
                notes = contNote, //same
                buisness = contType //same
            };
            Program.contacts.Add(c); //add to list
            return c; //output the new contact
        } //generate contact

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool valid = true;
            Contact entry = null;
            Contact newContact = null;

            #region contactParts
            string firstName = txt_firName.Text; //first name
            string lastName = txt_lastName.Text; //last name
            string phoNum = txt_phoNum.Text; //phone number
            string eMail = txt_EMail.Text; //email
            string contNote = txt_contNote.Text; //note
            bool contType = chk_type.Checked; //if checked
            #endregion //simplified variables for the content of the contact

            if (firstName == string.Empty) //check if no firstname
            {
                valid = false; //invalid
            }
            else if (lastName == string.Empty) //check if no lastname
            {
                valid = false; //invalid
            }
            else if (phoNum == string.Empty) //check if no phonenumber
            {
                valid = false; //invalid
            }
            else if (eMail == string.Empty) //check if no e-mail
            {
                valid = false; //invalid
            }
            else if (contNote == string.Empty) //check if no note
            {
                valid = false; //invalid
            }

            if (valid == true || debug == true) {
                newContact = createCont(firstName, lastName, phoNum, eMail, contNote, contType);
                entry = nextEntry();
                updateList(entry);
                clear(); //clear inputs and set checkbox to false
                WriteToFile(); //write to file
            }
        } //add to lists

        private void btn_close_Click(object sender, EventArgs e) //hit closed button
        {
            Application.Exit(); //close
        }

        private void select_contact(object sender, EventArgs e)
        {
            ListBox lst = sender as ListBox; //get the list being used
            int index = lst.SelectedIndex; //get the index of the current item
            if (index == -1) //if no item is selected, clear it
                {
                    clear(); //clear form
                } else {
                    string id = lst.Tag.ToString(); //get the identifyer tag
                    if (id == "per") //if it's personal
                    {
                        index = Program.perIndex[index]; //get the item at this index in the second list, which contains the indix of it's equivlent entry
                    }
                    else if (id == "bui") //if it's buisness
                    {
                        index = Program.buiIndex[index]; //get the item at this index in the second list, which contains the indix of it's equivlent entry
                    }
                    else
                    {
                        MessageBox.Show("error, tag not found"); //show error
                    }
                }
            Contact c = Program.contacts[index]; //get the contact at the index

            txt_firName.Text = c.firstname; //set the first name
            txt_lastName.Text = c.lastname; //set the last name
            txt_phoNum.Text = c.phone; //set the phone number
            txt_EMail.Text = c.email; //set the email
            txt_contNote.Text = c.notes; //set the notes
            chk_type.Checked = c.buisness; //set the checkbox

        }  //put contents of selected list in UI

        private void btn_svAs_Click(object sender, EventArgs e)
        {
            //filter
            saveFileDialog1.Filter = "All Files (*.*)|*.*|Contact Files (*.con*)|*.con"; //allow them to sort for a specific extension (the one utilized by this program), or any file

            if(saveFileDialog1.ShowDialog() == DialogResult.OK) //if the hit okay
            {
                filepath = saveFileDialog1.FileName; //gets the file path from the save file dialog
                WriteToFile(); //write to files
            }
        }  //save as

        private void btn_op_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*|Contact Files (*.con*)|*.con"; //allow them to sort for a specific extension (the one utilized by this program), or any file

            if (openFileDialog1.ShowDialog() == DialogResult.OK) //if the hit okay
            {
                filepath = openFileDialog1.FileName; //gets the file path from the save file dialog
                Program.contacts.Clear(); //clear the class
                Program.buiIndex.Clear(); //clear the buisness index
                Program.perIndex.Clear(); //clear the personal index
                readFromFile(); //read from file
            }
        } 
        } //open file

        private void btn_placeHold(object sender, EventArgs e) //temporary placeholder
        {
            WriteToFile();
        }
    }
}
