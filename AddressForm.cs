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

namespace AdressBook //major updates needed
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
        } //create the final default path

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
            //read from path: filepath
            // call other file
            files.files.read(filepath, sep, min); //call the function used to read files
            generateList(); //generate the list, useing the default input of 0 (which will mean that it will run for the whole list. I think.
        }
        private void WriteToFile()
        {
            files.files.Write(filepath, sep); //call the function used to write files
        }
         
        private void clear()
        {
            txt_firName.Text = string.Empty; //empty first name
            txt_lastName.Text = string.Empty; //empty last name
            txt_phoNum.Text = string.Empty; //empty phone number
            txt_EMail.Text = string.Empty; //empty email
            txt_contNote.Text = string.Empty; //epty contact note
            chk_type.Checked = false; //set checkbox to false
        } //triger to clear inputs

        private Contact nextEntry()
        {          
            int leng = Program.contacts.Count; //get the length
            ind = leng - 1; //get the index (a.k.a the length minus 1)
            Contact curr = Program.contacts[ind]; //get the item at said index, A.K.A. the last item) (curr is for "current")
            return curr; //output that value 
        }
        

        private void updateList(Contact value)
        {
            dgv_contacts.Rows.Add( value.firstname, value.lastname, value.email, value.phone, value.buisness, value.notes);
        }
        private void generateList(int total = 0) 
        {
            var val = 0; //set as a placeholder
            int ind = 0; //what will be the index to extract from the main list
            if(total == 0)
            {
                val = Program.contacts.Count; //set total to be the length of the list
            } else
            {
                val = total; //set total to the input value
            }
            total = val; //set the total to val. as val was set to total, it's the same, unless it was set to 0
                         //if the "total" was 0, then it will be set to the length of the list
            for (int count = 0; count < total; count++)
            {
                updateList(Program.contacts[ind]); //update the list
                ind++; //
            }
        } //generate the list, if no input it's assumed to use the entire length of the list
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
        }

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
                // WriteToFile(); 
                    //write to file
                    //disabled for now so it won't auto
            }
        }//add contact

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close
        } //hit closed button

        private void btn_svAs_Click(object sender, EventArgs e)
        {
            //filter
            saveFileDialog1.Filter = "All Files (*.*)|*.*|Contact Files (*.con*)|*.con"; //allow them to sort for a specific extension (the one utilized by this program), or any file

            if(saveFileDialog1.ShowDialog() == DialogResult.OK) //if the hit okay
            {
                filepath = saveFileDialog1.FileName; //gets the file path from the save file dialog
                WriteToFile(); //write to files
            }
        } //save as

        private void btn_op_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All Files (*.*)|*.*|Contact Files (*.con*)|*.con"; //allow them to sort for a specific extension (the one utilized by this program), or any file

            if (openFileDialog1.ShowDialog() == DialogResult.OK) //if the hit okay
            {
                filepath = openFileDialog1.FileName; //gets the file path from the save file dialog
                Program.contacts.Clear(); //clear the class
                readFromFile(); //read from file
            }
        }  //open

        private void dgv_contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if somethings selected
            if (dgv_contacts.CurrentRow != null) {
                var row = dgv_contacts.CurrentRow;
                foreach(var c in Program.contacts)
                {
                    if(c.firstname == row.Cells[0].Value.ToString()
                        && c.lastname == row.Cells[1].Value.ToString()
                        && c.buisness == Convert.ToBoolean(row.Cells[4].Value))
                    {
                        txt_firName.Text = c.firstname;
                        txt_lastName.Text = c.lastname;
                        txt_EMail.Text = c.email;
                        txt_phoNum.Text = c.phone;
                        chk_type.Checked = c.buisness;
                        txt_contNote.Text = c.notes;
                    }
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteToFile();
        }
    }
}
