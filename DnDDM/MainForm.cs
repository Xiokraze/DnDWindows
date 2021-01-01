﻿using DnDDM.Classes;
using DnDDM.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDDM
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
            this.Controls.Add(control);
            this.Text = DefaultValues.DnDTitle + " - Items";
        }


        private void MenuArtClicked(object sender, EventArgs e)
        {

        }


        private void MenuGemsClicked(object sender, EventArgs e)
        {

        }


        private void MenuGoodsClicked(object sender, EventArgs e)
        {

        }

        private void MenuWeaponsClicked(object sender, EventArgs e)
        {

        }


        private void MenuTrinketClicked(object sender, EventArgs e)
        {

        }
    }
}
