namespace DnDDM
{
    partial class SplashControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashControl));
            this.splashRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.splashPanel = new System.Windows.Forms.Panel();
            this.splashPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splashRichTextBox
            // 
            this.splashRichTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.splashRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.splashRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splashRichTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.splashRichTextBox.Location = new System.Drawing.Point(3, 67);
            this.splashRichTextBox.Name = "splashRichTextBox";
            this.splashRichTextBox.ReadOnly = true;
            this.splashRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.splashRichTextBox.Size = new System.Drawing.Size(287, 67);
            this.splashRichTextBox.TabIndex = 0;
            this.splashRichTextBox.Text = resources.GetString("splashRichTextBox.Text");
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.ConfirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(206)))), ((int)(((byte)(101)))));
            this.ConfirmButton.Location = new System.Drawing.Point(109, 140);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(87, 23);
            this.ConfirmButton.TabIndex = 1;
            this.ConfirmButton.Text = "I Understand";
            this.ConfirmButton.UseVisualStyleBackColor = false;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // splashPanel
            // 
            this.splashPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.splashPanel.Controls.Add(this.splashRichTextBox);
            this.splashPanel.Controls.Add(this.ConfirmButton);
            this.splashPanel.Location = new System.Drawing.Point(17, 25);
            this.splashPanel.Name = "splashPanel";
            this.splashPanel.Size = new System.Drawing.Size(295, 243);
            this.splashPanel.TabIndex = 2;
            // 
            // SplashControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.Controls.Add(this.splashPanel);
            this.Name = "SplashControl";
            this.Size = new System.Drawing.Size(328, 303);
            this.splashPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox splashRichTextBox;
        private System.Windows.Forms.Button ConfirmButton;
        private System.Windows.Forms.Panel splashPanel;
    }
}
