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
                    foreach(var c in Program.contacts)
                    {
                        //csv - comma seperated values
                        //firstname-lastname-email-phone-buisness-notes
                        string line c.firstname + sep + c.lastname
                    }
                }
            } catch(Exception ex)
            {
                ex.ToString();
            }
        }
    }
}
