using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDDM
{
    static class Program
    {
        // Global Variables.
        public static Control.ControlCollection controlCollection;
        public static MainForm mainForm;
        public static MenuStrip mainMenu;
        public static PrivateFontCollection PFC = new PrivateFontCollection();



        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }


        /// <summary>
        /// Removes all controls save for the new control and the header panel.
        /// </summary>
        /// <param name="newControl"></param>
        public static void AddControl(Control newControl)
        {
            controlCollection.Add(newControl);
            foreach (Control control in controlCollection)
            {
                if (!object.Equals(control, newControl) && control.Name != "menuStrip")
                {
                    controlCollection.Remove(control);
                }
            }
        }
    }
}
