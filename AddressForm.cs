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
    public partial class frm_addressForm : Form
    {
        const bool debug = Program.debug; //this sets the debug system to the global debug variable
        const char sep = '~'; //seperation character
        public frm_addressForm()
        {
            InitializeComponent();
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

        int editInd = 0; //the index being edited
        bool editMode = false; //curent state of edit mode
        string btnAddTex = string.Empty; //placeholder button text

        const string name1 = "store"; //name of file
        const string exten1 = "con"; //extension of file
        const int min = 6; //minimum total values in an entry
                           //const string direct = AppDomain.CurrentDomain.BaseDirectory + "contacts";
        bool autoSave = false; //default auto-save
        int distFromEdge = 0;

        private void frm_addressForm_Load(object sender, EventArgs e)
        {
            filepath = CreatePath(AppDomain.CurrentDomain.BaseDirectory,"contacts",name1,exten1); //create the name, which is stored outside

            readFromFile(); //read from the file
            generateList(); //generate the list, useing the default input of 0 (which will mean that it will run for the whole list. I think.
            dgv_contacts.ClearSelection(); //make sure nothing on the table is selected
            openFileDialog1.InitialDirectory = filepath; //set the initial directory to the base default file path
            saveFileDialog1.InitialDirectory = filepath; //set the initial directory to the default file path
            toolStrip_autoSave.BackColor = Color.Red; //ensure auto-save color is red (disabled)

            int tblEdge = this.dgv_contacts.Width; //get the current width of the table
            int formWidth = this.ClientSize.Width; //get the width of the form
            distFromEdge = formWidth - tblEdge; //calculate how far the edge of the form is from the table
            btnAddTex = btn_add.Text; //sets a variable to store the current text for the button. That way, when it's text is changed in-code, when it gets replaced, it's replaced with whatever the button had, not with a hardcoded text. So, edits in the form designer are kept!

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
            if (dgv_contacts.CurrentRow != null)
            {
                dgv_contacts.ClearSelection(); //deselect row
            } //if a row is selected (which therefore means it was editing an entry), deselect all rows
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
        
        private void updateList(Contact value, bool editMode = false )
        {
            var currentRow = dgv_contacts.CurrentRow; //get current row
            if ( editMode )
            {
                if(currentRow == null)
                {
                    editMode = false; //set edit to false
                } //turns edit mode off if there is no selected row. That means it will add the entry
            } //checks if there is anything within the current row
            if (editMode == false)
            {
                dgv_contacts.Rows.Add(value.firstname, value.lastname, value.email, value.phone, value.buisness, value.notes, value.index); //update the data grid view with the contents of the contact as a new row
            } //if nothing selected, add new row
            else
            {
                currentRow.Cells[0].Value = value.firstname; //set the contents of the selected row
                currentRow.Cells[1].Value = value.lastname; //set the contents of the selected row
                currentRow.Cells[2].Value = value.email; //set the contents of the selected row
                currentRow.Cells[3].Value = value.phone; //set the contents of the selected row
                currentRow.Cells[4].Value = value.buisness; //set the contents of the selected row
                currentRow.Cells[5].Value = value.notes; //set the contents of the selected row
            } //edit selected row
            
        } //update list

        private void generateList(int total = 0) 
        {
            var val = 0; //set as a placeholder
            int ind = 0; //what will be the index to extract from the main list
            if(total == 0)
            {
                val = Program.contacts.Count; //set total to be the length of the list
            } //if the input is 0
            else
            {
                val = total; //set total to the input value
            } //if the input is a value, use it
            total = val; //set the total to val. as val was set to total, it's the same, unless it was set to 0
                         //if the "total" was 0, then it will be set to the length of the list
            for (int count = 0; count < total; count++)
            {
                updateList(Program.contacts[ind]); //update the list
                ind++; //increase index by one (apparently count doesn't increase)
            } //repeat to add all the stuff to the list
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

        private void errorIcon(Control input, string error, bool clear = false)
        {
            var errorText = error; //change name of variable
            if (clear) {
                errorText = ""; //if it's set to clear, change the text so it clears it
            }
            errorProvider1.SetError(input, errorText); //display the provider on the "input" control
        } //create error provider system

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

            //find errors (put some sort of warning system)

            if (firstName == string.Empty)
            {
                valid = false; //invalid 
                errorIcon(txt_firName, "No Input"); //display error
            } //check if no firstname
            else 
            {
                errorIcon(txt_firName, "No Input", true); //clear error
            } //clear any errors from previous checks
            
            if (lastName == string.Empty) 
            {
                valid = false; //invalid
                errorIcon(txt_lastName, "No Input"); //display error
            } //check if no lastname
            else
            {
                errorIcon(txt_lastName, "No Input", true); //clear error
            } //clear any errors from previous checks

            if (phoNum == string.Empty) 
            {
                valid = false; //invalid
                errorIcon(txt_phoNum, "No Input"); //display error
            } //check if no phonenumber
            else
            {
                errorIcon(txt_phoNum, "No Input", true); //clear error
            } //clear any errors from previous checks

            if (eMail == string.Empty)
            {
                valid = false; //invalid
                errorIcon(txt_EMail, "No Input"); //display error
            }  //check if no e-mail
            else
            {
                errorIcon(txt_EMail, "No Input", true); //clear error
            } //clear any errors from previous checks

            if (contNote == string.Empty)
            {
                valid = false; //invalid
                errorIcon(txt_contNote, "No Input"); //display error
            } //check if no note
            else {
                errorIcon(txt_contNote, "No Input", true); //clear error
            } //clear any errors from previous checks

            if (editMode)
            {
                if (valid == true || debug == true)
                {
                    Contact edit = selectContact(editInd); //find the contact related to the selected row
                    edit.firstname = firstName; //set the first name to the new first name
                    edit.lastname = lastName; //set the last name to the new last name
                    edit.phone = phoNum; //set the phone to the new phone
                    edit.email = eMail; //set the email to the new e-mail
                    edit.notes = contNote; //set the contact note to the new note
                    edit.buisness = contType; //set the contact type to the new value
                    if (autoSave)
                    {
                        WriteToFile(); //save
                    } //autosave
                    updateList(edit, editMode); //use edit mode, thereby allowing for the current entry
                    clear(); //clear entry and deselect row
                    btn_add.Text = btnAddTex; //set the button to have it's original text
                    editInd = 0; //set index to 0
                    //clear and deselect row

                } //check valid
            } //edit
            else if (editMode == false)
            {
                if (valid == true || debug == true)
                {
                    newContact = createCont(firstName, lastName, phoNum, eMail, contNote, contType, Program.contacts.Count); //create the contact
                    entry = nextEntry(); //get the next entry
                    updateList(entry); //update the list
                    if (autoSave)
                    {
                        WriteToFile(); //write to the file
                    } //if the auto-save is on, save
                    clear(); //clear inputs and set checkbox to false
                } //the creation and setting code
            } //if it isn't edit
        } //add contact

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit(); //close
        } //exit system

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
        private Contact selectContact(int index)
        {
            int leng = Program.contacts.Count; //find the length
            int check = 0; //make a temporary variable
            try
            {
                foreach (var c in Program.contacts)
                {
                    check = check + 1; //add one to check
                    if (c.index == index) {
                        return c; //if the indexes are the same, output that contact
                    } //check if selected index
                    else if(check == leng)
                    {
                        return null; //if check and length are the same, there is nothing left, so retun null
                    } //check if last item
                } //find the contact at the index
            } 
            catch (Exception ex) //get exception
            {
                error("Issue Reading Table", ex); //show error
                return null; //output null
            } //check for issue with repeat
            return null;
        } //get the selected contact
        private void dgv_contacts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int edInde = 0;
            Contact c = null;
            //check if somethings selected
            if (dgv_contacts.CurrentRow == null)
            {
                return; //output nothing
            } //make sure there is something selected
            var row = dgv_contacts.CurrentRow; //set a variable to the contents of the current row
            string indText = row.Cells[6].Value.ToString(); //get the index value from what was clicked
            c = selectContact(int.Parse(indText)); //find the correct contact
            if (c != null) {
                txt_firName.Text = c.firstname; //put first name in text box
                txt_lastName.Text = c.lastname; //put last name in text box
                txt_EMail.Text = c.email; //put e-mail in text box
                txt_phoNum.Text = c.phone; //put phone number in text box
                chk_type.Checked = c.buisness; //set the check box to match if they are buisness or not
                txt_contNote.Text = c.notes; //put notes in text box
                edInde = c.index; //set the index variable to the contacts index variable
            } //check if it exists
            editInd = edInde; //set the global editInd to the determined edit index
            editMode = true; //turn edit mode on
            btn_add.Text = "Edit Entry"; //change button text
        } //populate text boxes with the content of the selected row

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WriteToFile(); //save the file to the most recent path
                //when you hit save as, the "path" variable is updated, and write to file utilizes that path variable, so using save as on it changes the save target
        } //save

        private void toolStrip_autoSave_Click(object sender, EventArgs e)
        {
            autoSave = toolStrip_autoSave.Checked; //set external variable to what is toggled
            bool auto_save = autoSave; //internal variable to external variable
            if (auto_save )
            {
                toolStrip_autoSave.BackColor = Color.Green; //set to green
            } //toggle on
            else
            {
                 toolStrip_autoSave.BackColor = Color.Red; //set to red
            } //toggle off
        } //toggle auto-save

        private void frm_addressForm_reSize(object sender, EventArgs e)
        {
            int frmWidth = this.ClientSize.Width; //get the new form width
            int tblWidth = frmWidth - distFromEdge; //subtract the distance from edge
            dgv_contacts.Width = tblWidth; //set the width of the table
        }  //size data grid view

        private void btn_clearEntry_Click(object sender, EventArgs e)
        {
            clear(); //clear entry
            editMode = false; //disable edit mode
            editInd = 0; //set edit index to 0
            btn_add.Text = btnAddTex; //set button back to original text
        } //clear entry
    }
}