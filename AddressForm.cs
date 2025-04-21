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

                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message); //show error
            }
        }
    }
}
