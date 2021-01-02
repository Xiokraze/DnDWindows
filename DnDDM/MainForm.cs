using DnDDM.Classes;
using DnDDM.Controls;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DnDDM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadDnDFont();

            menuStrip.RenderMode = ToolStripRenderMode.ManagerRenderMode;
            SplashControl control = new SplashControl()
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(control);
            this.Text = DefaultValues.DnDTitle + " - License";
            Program.controlCollection = this.Controls;
            Program.mainForm = this;
            Program.mainMenu = menuStrip;
        }


        private void LoadDnDFont()
        {
            //Select your font from the resources.
            //My font here is "Digireu.ttf"
            int fontLength = Properties.Resources.DnDC.Length;

            // create a buffer to read in to
            byte[] fontdata = Properties.Resources.DnDC;

            // create an unsafe memory block for the font data
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);

            // copy the bytes to the unsafe memory block
            Marshal.Copy(fontdata, 0, data, fontLength);

            // pass the font to the font collection
            Program.PFC.AddMemoryFont(data, fontLength);
        }


        private void MouseEnterMenuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuItem.BackColor = DefaultValues.DnDGold;
            menuItem.ForeColor = DefaultValues.DnDBlack;
        }


        private void MouseLeaveMenuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;
            menuItem.BackColor = DefaultValues.DnDBlack;
            menuItem.ForeColor = DefaultValues.DnDGold;
        }


        private void MenuArmorClicked(object sender, EventArgs e)
        {
            StandardItemControl control = new StandardItemControl(DefaultValues.Armor)
            {
                Dock = DockStyle.Fill
            };
            Program.AddControl(control);
            this.Text = DefaultValues.DnDTitle + " - " + DefaultValues.Armor;
        }


        private void MenuArtClicked(object sender, EventArgs e)
        {
            StandardItemControl control = new StandardItemControl(DefaultValues.Art)
            {
                Dock = DockStyle.Fill
            };
            Program.AddControl(control);
            this.Text = DefaultValues.DnDTitle + " - " + DefaultValues.Art;
        }


        private void MenuGemsClicked(object sender, EventArgs e)
        {
            StandardItemControl control = new StandardItemControl(DefaultValues.Gem)
            {
                Dock = DockStyle.Fill
            };
            Program.AddControl(control);
            this.Text = DefaultValues.DnDTitle + " - " + DefaultValues.Gem;
        }


        private void MenuGoodsClicked(object sender, EventArgs e)
        {
            StandardItemControl control = new StandardItemControl(DefaultValues.Good)
            {
                Dock = DockStyle.Fill
            };
            Program.AddControl(control);
            this.Text = DefaultValues.DnDTitle + " - " + DefaultValues.Good;
        }

        private void MenuWeaponsClicked(object sender, EventArgs e)
        {
            StandardItemControl control = new StandardItemControl(DefaultValues.Weapon)
            {
                Dock = DockStyle.Fill
            };
            Program.AddControl(control);
            this.Text = DefaultValues.DnDTitle + " - " + DefaultValues.Weapon;
        }


        private void MenuTrinketClicked(object sender, EventArgs e)
        {
            StandardItemControl control = new StandardItemControl(DefaultValues.Trinket)
            {
                Dock = DockStyle.Fill
            };
            Program.AddControl(control);
            this.Text = DefaultValues.DnDTitle + " - " + DefaultValues.Trinket;
        }
    }
}
