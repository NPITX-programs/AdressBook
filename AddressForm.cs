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
        const bool debug = Program.debug; //this sets the debug system to the global debug variable
        const char sep = '~'; //seperation character
        public AddressForm()
        {
            InitializeComponent(); //initialize
        }

        string filepath = string.Empty; //a placeholder blank path

        private void error(string message, Exception ex = null, bool revealException = false)
        {
            AdressBook.coreCommands.error(message, ex, revealException); // WARNING: If you provide a boolean, you can controll if it's hidden. If you provide a boolean but no error, well, it won't work righ

        } //error system

        private string CreatePath(string root, string path, string name, string extension)
        {
            string finalPath = root + path + @"/" + name + "." + extension; //create the final path

            return finalPath; //output said path
        } //create the final directory path

        const string name1 = "store"; //name of file
        const string exten1 = "con"; //extension of file
        const int min = 6; //minimum total values in an entry
                           //const string direct = AppDomain.CurrentDomain.BaseDirectory + "contacts";
        bool autoSave = false; //default auto-save

        private void Frm_main_Load(object sender, EventArgs e)
        {
            filepath = CreatePath(AppDomain.CurrentDomain.BaseDirectory,"contacts",name1,exten1); //create the name, which is stored outside

            readFromFile(); //read from the file
            generateList(); //generate the list, useing the default input of 0 (which will mean that it will run for the whole list. I think.
            openFileDialog1.InitialDirectory = filepath; //set the initial directory to the base default file path
            saveFileDialog1.InitialDirectory = filepath; //set the initial directory to the default file path
        } //when form loads
        int ind = 0; //index for the current contact

        private void readFromFile()
        {
            //read from path: filepath
            // call other file
            files.files.read(filepath, sep, min); //call the function used to read files
        } //call the read from file method (that way I don't have to do file.files first)

        private void WriteToFile()
        {
            files.files.Write(filepath, sep); //call the function used to write files
        } //call the write to file. Same as above comment
         
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
            int leng = Program.contacts.Count; //get the length of the list
            ind = leng - 1; //get the index (a.k.a the length minus 1)
            Contact curr = Program.contacts[ind]; //get the item at said index, A.K.A. the last item) (curr is for "current")
            return curr; //output that value 
        } //gets the final entry in the list of contacts, which is the one that was just made (and thus the one that should be added)
        
        private void updateList(Contact value)
        {
            dgv_contacts.Rows.Add( value.firstname, value.lastname, value.email, value.phone, value.buisness, value.notes, value.index); //update the data grid view with the contents of the contact
        } //update list

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
                ind++; //increase index by one (apparently count doesn't increase)
            }
        } //generate the list, if no input it's assumed to use the entire length of the list

        private Contact createCont(string firstName, string lastName, string phoNum, string eMail, string contNote, bool contType, int contInd)
        {
            Contact c = new Contact //make new constact
            {
                firstname = firstName, //put the realevent input into the releavent field
                lastname = lastName, //same
                phone = phoNum, //same
                email = eMail, //same
                notes = contNote, //same
                buisness = contType, //same
                index = contInd, //
            }; //assemble contact
            Program.contacts.Add(c); //add to list
            return c; //output the new contact
        } //creates the class for the current input

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool valid = true; //default to valid
            Contact entry = null; //temporary blank contact
            Contact newContact = null; //temporary blank contact

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
                newContact = createCont(firstName, lastName, phoNum, eMail, contNote, contType, Program.contacts.Count); //create the contact
                entry = nextEntry(); //get the next entry
                updateList(entry); //update the list
                if (autoSave )
                {
                    WriteToFile(); //write to the file
                } //if the auto-save is on
                clear(); //clear inputs and set checkbox to false
            } //the creation and setting code
        } //add contact

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close
        } //used exit system

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
                    //also sets the filepath for saveing to be the new one, that way if you save the file it is now the one you used save as on, not the in-built default
                Program.contacts.Clear(); //clear the class
                readFromFile(); //read from file
            }
        } //open

        private void dgv_contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //check if somethings selected
            if (dgv_contacts.CurrentRow != null) {
                var row = dgv_contacts.CurrentRow; //set a variable to the contents of the current row
                foreach(var c in Program.contacts)
                {
                    if(c.firstname == row.Cells[0].Value.ToString() //first name match?
                        && c.lastname == row.Cells[1].Value.ToString() //last name match?
                        && c.buisness == Convert.ToBoolean(row.Cells[4].Value)) //buisness contact?
                    {
                        txt_firName.Text = c.firstname; //put first name in text box
                        txt_lastName.Text = c.lastname; //put last name in text box
                        txt_EMail.Text = c.email; //put e-mail in text box
                        txt_phoNum.Text = c.phone; //put phone number in text box
                        chk_type.Checked = c.buisness; //set the check box to match if they are buisness or not
                        txt_contNote.Text = c.notes; //put notes in text box
                    } //see if contact matches conditions.
                        //the first two are so, even if the table is re-ordered via filtersre-ordered, the correct name is chosen.
                        //The buisness is so if you have multiple for one person, (say, one for buisness, one for personal), it populates the one you selected
                } //find the correct class
            } //make sure there is something selected
        } //populate text boxes with the content of the selected row

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteToFile(); //save the file to the most recent path
                //when you hit save as, the "path" variable is updated, and write to file utilizes that path variable, so using save as on it changes the save target
        } //save

        private void toolStrip_autoSave_Click(object sender, EventArgs e)
        {
            bool autoSave = toolStrip_autoSave.Checked;
            if (autoSave)
            {
                toolStrip_autoSave.BackColor = Color.Green;
            }
            else
            {
                 toolStrip_autoSave.BackColor = Color.Red;
            }
        }
    }
}