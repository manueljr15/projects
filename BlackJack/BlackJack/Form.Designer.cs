namespace BlackJack
{
    partial class MainMenu
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
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStart.BackColor = System.Drawing.Color.Firebrick;
            this.buttonStart.CausesValidation = false;
            this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonStart.Location = new System.Drawing.Point(346, 214);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStart.Size = new System.Drawing.Size(95, 40);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "New Game";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonHelp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonHelp.BackColor = System.Drawing.Color.Firebrick;
            this.buttonHelp.CausesValidation = false;
            this.buttonHelp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonHelp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonHelp.Location = new System.Drawing.Point(346, 260);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHelp.Size = new System.Drawing.Size(95, 40);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonStart);
            this.Name = "MainMenu";
            this.Text = "Black Jack";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonHelp;
    }
}

