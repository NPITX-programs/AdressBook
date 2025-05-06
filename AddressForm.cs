using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdressBook
{
    public partial class frm_main : Form
    {
        bool debug = true;
        string sep = "~";
        public frm_main()
        {
            InitializeComponent();
        }

        string filepath = string.Empty;

        private string CreatePath(string root, string path, string name, string extension)
        {
            string finalPath = string.Empty;
            finalPath = root + path + @"/" + name + "." + extension; //create the final path

            return finalPath;
        }

        const string name1 = "store";
        const string exten1 = "csv";
        string direct = AppDomain.CurrentDomain.BaseDirectory + "contacts"; //create the directory path
        private void frm_main_Load(object sender, EventArgs e)
        {
            filepath = CreatePath(AppDomain.CurrentDomain.BaseDirectory,"contacts",name1,exten1);

            readFromFile();
        }
        int ind = 0; //index for the current contact

        private void readFromFile()
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
                            sw.Write(line); //write the information to the line
                        }
                    } //streamwriterMessageBox.Show("test");
                }
                catch(Exception ex)
                {
                    MessageBox.Show("error" + ex.Message); //show error

                }
            }
            else
            {
                MessageBox.Show("file not found"); //show error

            }
        }
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
                                    sw.Write(line); //write the information to the line
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
                }

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
        }
        

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
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            bool valid = true;
            Contact entry = null;

            if (txt_firName.Text == string.Empty) //check if no firstname
            {
                valid = false; //invalid
            }
            else if (txt_lastName.Text == string.Empty) //check if no lastname
            {
                valid = false; //invalid
            }
            else if (txt_phoNum.Text == string.Empty) //check if no phonenumber
            {
                valid = false; //invalid
            }
            else if (txt_EMail.Text == string.Empty) //check if no e-mail
            {
                valid = false; //invalid
            }
            else if (txt_contNote.Text == string.Empty) //check if no note
            {
                valid = false; //invalid
            }

            if (valid == true || debug == true) {
                c.firstname = txt_firName.Text;
                c.lastname = txt_lastName.Text;
                c.phone = txt_phoNum.Text;
                c.email = txt_EMail.Text;
                c.notes = txt_contNote.Text;
                c.buisness = chk_type.Checked;
                Program.contacts.Add(c);

                entry = nextEntry();
                updateList(entry);
                clear(); //clear inputs and set checkbox to false
                WriteToFile(); //write to file
            }
        }

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

        }
    }
}
