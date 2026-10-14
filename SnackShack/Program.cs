using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace snackShack
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frm_snackInvent());
        }
        internal const bool debug = true; //global var to controll default for debugs
        internal static List<snackInvent> snacks = new List<snackInvent>();
    }
    internal static class coreCommands
    {
        internal static void error(string message = constants.preMadeErrorMsg, Exception ex = null, bool revealException = false)
        {
            string msg = message; //what message to display
            if (revealException) //put the toggle
            {
                msg = msg + ": " + ex.Message; //the message
            }//a bool to toggle if the exception code should be included in the error message
            MessageBox.Show(msg); //show the message
        } //this is for error messages. the text is mandatory, but the
          //rest isn't necessary. if you don't provide an exception, it won't display one. If you provide an error, it will default to "hide error".
          // WARNING: If you provide a boolean, you can controll if it's hidden. If you provide a boolean but no error, well, it won't work righ

        internal static string path()
        {
            var pathSpliter = '\\'; //part between paths
            var loc = AppDomain.CurrentDomain.BaseDirectory; //get the current domain
            var comps = loc.Split('\\'); //array of path after being split
            var len = comps.Length; //length of path
            var completeLoc = string.Empty; //blank variable for path
            for (var i = 0; i < len-3; i++) //repeat by the length minus 2, which will lead to it excluding the 2 folders that are unwanted
            {
                var comp = comps[i];
                completeLoc = completeLoc + comp + char.ToString(pathSpliter); //add next part to path
            }
            return completeLoc; //output path
        } //derive the path of the base file
    } //base commands to aid in everything
}