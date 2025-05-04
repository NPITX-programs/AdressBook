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

        private string add()
        {
            string add = string.Empty;
            int leng;
            leng = Program.contacts.Count;
            int ind = leng - 1;
            Program.contacts.
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            Contact c = new Contact();
            bool valid = true;
            string entry = string.Empty;

            if(debug == false)
            {
                if (txt_firName.Text == string.Empty)
                {
                    valid = false;
                }
                else if (txt_lastName.Text == string.Empty)
                {
                    valid = false;
                }
                else if (txt_phoNum.Text == string.Empty)
                {
                    valid = false;
                }
                else if (txt_EMail.Text == string.Empty)
                {
                    valid = false;
                }
                else if (txt_contNote.Text == string.Empty)
                {
                    valid = false;
                }
            }

            if (valid == true) {
                c.firstname = txt_firName.Text;
                c.lastname = txt_lastName.Text;
                c.phone = txt_phoNum.Text;
                c.email = txt_EMail.Text;
                c.notes = txt_contNote.Text;
                c.buisness = chk_type.Checked;
                Program.contacts.Add(c);
                entry = add();
                clear();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
