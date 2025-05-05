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
        string sep = "~";
        public frm_main()
        {
            InitializeComponent();
        }
        string filepath = "placeholder";
        bool debug = true;
        private void frm_main_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void WriteToFile()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filepath))
                {
                    foreach(var c in Program.contacts) //the loop for createing the contents which will be saved
                    {
                        //csv - comma seperated values
                        //firstname-lastname-email-phone-buisness-notes
                        string line = c.firstname + sep + c.lastname + sep +  //first and last name
                            c.email + sep + c.phone + sep + c.buisness + sep + //contact information
                            c.notes; //notes
                        sw.Write(line); //write the information to the line
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("error" + ex.Message); //show error
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
            int ind = leng - 1; //get the index (a.k.a the length minus 1)
            Contact curr = Program.contacts[ind]; //get the item at said index, A.K.A. the last item) (curr is for "current")
            return curr; //output that value
        }
        

        private void updateList(Contact value)
        {
            string first = value.firstname; //get last name
            string last = value.lastname; //get first name
            string entry = first + " " + last; //combine first and last name

            int leng = 0; //create length var
            int ind = 0; //create index var
            
            if (value.buisness == true) //check contact type
            {
                lst_buisnes.Items.Add(entry); //if it's buisness, add to buisness list
                leng = lst_buisnes.Items.Count;
            } else
            {
                lst_personal.Items.Add(entry); //if it's not buisness, add to personal list
                leng = lst_personal.Items.Count;
            }
            ind = leng - 1;
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
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
