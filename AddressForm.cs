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
        private void frm_main_Load(object sender, EventArgs e)
        {

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

        private void clear(object txt) //input textbox to clear
        {
            txt = string.Empty; //clear the box
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            bool valid = true;
            if (txt_firName.Text == string.Empty)
            {
                valid = false;
            }
            else if(txt_lastName.Text == string.Empty) {
                valid = false;
            } else if(txt_phoNum.Text == string.Empty)
            {
                valid = false;
            } else if(txt_EMail.Text == string.Empty)
            {
                valid = false;
            } else if (txt_contNote.Text == string.Empty)
            {
                valid = false;
            }

            if (valid == true) {
                c.firstname = txt_firName.Text;
                c.lastname = txt_lastName.Text;
                c.phone = txt_phoNum.Text;
                c.email = txt_EMail.Text;
                c.notes = txt_contNote.Text;
                c.buisness = chk_type.Checked;
                Program.contacts.Add(c);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
