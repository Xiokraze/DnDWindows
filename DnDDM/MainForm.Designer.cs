namespace DnDDM
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.option1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.option2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.armorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.artToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generalItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trinketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.weaponsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.option2ToolStripMenuItem,
            this.option1ToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            this.menuStrip.Visible = false;
            // 
            // option1ToolStripMenuItem
            // 
            this.option1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.armorToolStripMenuItem,
            this.artToolStripMenuItem,
            this.gemsToolStripMenuItem,
            this.generalItemsToolStripMenuItem,
            this.weaponsToolStripMenuItem,
            this.trinketsToolStripMenuItem});
            this.option1ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.option1ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.option1ToolStripMenuItem.Name = "option1ToolStripMenuItem";
            this.option1ToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.option1ToolStripMenuItem.Text = "Items";
            this.option1ToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.option1ToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // option2ToolStripMenuItem
            // 
            this.option2ToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.option2ToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.option2ToolStripMenuItem.Name = "option2ToolStripMenuItem";
            this.option2ToolStripMenuItem.Size = new System.Drawing.Size(55, 23);
            this.option2ToolStripMenuItem.Text = "Spells";
            this.option2ToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.option2ToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // armorToolStripMenuItem
            // 
            this.armorToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.armorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.armorToolStripMenuItem.Name = "armorToolStripMenuItem";
            this.armorToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.armorToolStripMenuItem.Text = "Armor";
            this.armorToolStripMenuItem.Click += new System.EventHandler(this.MenuArmorClicked);
            this.armorToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.armorToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // artToolStripMenuItem
            // 
            this.artToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.artToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.artToolStripMenuItem.Name = "artToolStripMenuItem";
            this.artToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.artToolStripMenuItem.Text = "Art";
            this.artToolStripMenuItem.Click += new System.EventHandler(this.MenuArtClicked);
            this.artToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.artToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // gemsToolStripMenuItem
            // 
            this.gemsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.gemsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.gemsToolStripMenuItem.Name = "gemsToolStripMenuItem";
            this.gemsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.gemsToolStripMenuItem.Text = "Gems";
            this.gemsToolStripMenuItem.Click += new System.EventHandler(this.MenuGemsClicked);
            this.gemsToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.gemsToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // generalItemsToolStripMenuItem
            // 
            this.generalItemsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.generalItemsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.generalItemsToolStripMenuItem.Name = "generalItemsToolStripMenuItem";
            this.generalItemsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.generalItemsToolStripMenuItem.Text = "Goods";
            this.generalItemsToolStripMenuItem.Click += new System.EventHandler(this.MenuGoodsClicked);
            this.generalItemsToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.generalItemsToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // trinketsToolStripMenuItem
            // 
            this.trinketsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.trinketsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.trinketsToolStripMenuItem.Name = "trinketsToolStripMenuItem";
            this.trinketsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.trinketsToolStripMenuItem.Text = "Trinkets";
            this.trinketsToolStripMenuItem.Click += new System.EventHandler(this.MenuTrinketClicked);
            this.trinketsToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.trinketsToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // weaponsToolStripMenuItem
            // 
            this.weaponsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.weaponsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.weaponsToolStripMenuItem.Name = "weaponsToolStripMenuItem";
            this.weaponsToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.weaponsToolStripMenuItem.Text = "Weapons";
            this.weaponsToolStripMenuItem.Click += new System.EventHandler(this.MenuWeaponsClicked);
            this.weaponsToolStripMenuItem.MouseEnter += new System.EventHandler(this.MouseEnterMenuItem);
            this.weaponsToolStripMenuItem.MouseLeave += new System.EventHandler(this.MouseLeaveMenuItem);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuStrip);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "DnD Tools";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem option1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem option2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem armorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem artToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generalItemsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem weaponsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trinketsToolStripMenuItem;
    }
}

