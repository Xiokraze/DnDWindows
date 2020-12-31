using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DnDDM.Classes;

namespace DnDDM
{
    public partial class SplashControl : UserControl
    {
        public SplashControl()
        {
            InitializeComponent();
            splashRichTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            Program.controlCollection.Remove(this);
            Program.mainMenu.Visible = true;
        }
    }
}
