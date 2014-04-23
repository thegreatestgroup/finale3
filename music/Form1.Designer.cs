namespace music
{
    partial class Form1
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
            this.navMenu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addSongName = new System.Windows.Forms.TextBox();
            this.addArtist = new System.Windows.Forms.TextBox();
            this.navMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navMenu
            // 
            this.navMenu.Controls.Add(this.tabPage1);
            this.navMenu.Controls.Add(this.tabPage2);
            this.navMenu.Controls.Add(this.tabPage3);
            this.navMenu.Location = new System.Drawing.Point(13, 13);
            this.navMenu.Name = "navMenu";
            this.navMenu.SelectedIndex = 0;
            this.navMenu.Size = new System.Drawing.Size(1071, 583);
            this.navMenu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1063, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Songs";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.addArtist);
            this.tabPage2.Controls.Add(this.addSongName);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1063, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add/Update Song";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1063, 557);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Remove Song";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Artist";
            // 
            // addSongName
            // 
            this.addSongName.Location = new System.Drawing.Point(63, 7);
            this.addSongName.Name = "addSongName";
            this.addSongName.Size = new System.Drawing.Size(100, 20);
            this.addSongName.TabIndex = 2;
            this.addSongName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addArtist
            // 
            this.addArtist.Location = new System.Drawing.Point(63, 34);
            this.addArtist.Name = "addArtist";
            this.addArtist.Size = new System.Drawing.Size(100, 20);
            this.addArtist.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 608);
            this.Controls.Add(this.navMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.navMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl navMenu;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox addSongName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addArtist;
    }
}

