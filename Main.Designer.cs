namespace BTDModLoader
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LaunchGame = new System.Windows.Forms.Button();
            this.ModsListBox = new System.Windows.Forms.ListBox();
            this.PluginsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ModLoaderText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LaunchGame
            // 
            this.LaunchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LaunchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LaunchGame.ForeColor = System.Drawing.Color.White;
            this.LaunchGame.Location = new System.Drawing.Point(675, 423);
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.Size = new System.Drawing.Size(172, 49);
            this.LaunchGame.TabIndex = 0;
            this.LaunchGame.Text = "Launch Game";
            this.LaunchGame.UseVisualStyleBackColor = false;
            this.LaunchGame.Click += new System.EventHandler(this.LaunchGame_Click);
            // 
            // ModsListBox
            // 
            this.ModsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ModsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.ModsListBox.ForeColor = System.Drawing.Color.White;
            this.ModsListBox.FormattingEnabled = true;
            this.ModsListBox.ItemHeight = 20;
            this.ModsListBox.Items.AddRange(new object[] {
            "No Mods"});
            this.ModsListBox.Location = new System.Drawing.Point(12, 156);
            this.ModsListBox.Name = "ModsListBox";
            this.ModsListBox.Size = new System.Drawing.Size(257, 282);
            this.ModsListBox.TabIndex = 1;
            this.ModsListBox.SelectedIndexChanged += new System.EventHandler(this.ModsListBox_SelectedIndexChanged);
            // 
            // PluginsListBox
            // 
            this.PluginsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.PluginsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PluginsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.PluginsListBox.ForeColor = System.Drawing.Color.White;
            this.PluginsListBox.FormattingEnabled = true;
            this.PluginsListBox.ItemHeight = 20;
            this.PluginsListBox.Items.AddRange(new object[] {
            "No Plugins"});
            this.PluginsListBox.Location = new System.Drawing.Point(336, 156);
            this.PluginsListBox.Name = "PluginsListBox";
            this.PluginsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PluginsListBox.Size = new System.Drawing.Size(269, 282);
            this.PluginsListBox.TabIndex = 2;
            this.PluginsListBox.SelectedIndexChanged += new System.EventHandler(this.PluginsListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mods:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(332, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NKHook Plugins:";
            // 
            // ModLoaderText
            // 
            this.ModLoaderText.AutoSize = true;
            this.ModLoaderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F, System.Drawing.FontStyle.Underline);
            this.ModLoaderText.ForeColor = System.Drawing.Color.White;
            this.ModLoaderText.Location = new System.Drawing.Point(12, 23);
            this.ModLoaderText.Name = "ModLoaderText";
            this.ModLoaderText.Size = new System.Drawing.Size(0, 39);
            this.ModLoaderText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(54, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(406, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Please choose which mods and or plugins you want to play with";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select \"No Mods\" or \"No Plugins\" if you dont want to play with mods or plugins";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(-290, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1440, 514);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(664, 317);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(194, 100);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.richTextBox2.Location = new System.Drawing.Point(336, 156);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(269, 282);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "NKHook Plugins not currently supported with BTDB";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModLoaderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PluginsListBox);
            this.Controls.Add(this.ModsListBox);
            this.Controls.Add(this.LaunchGame);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "BTD5 Mod Loader by Gurrenm3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LaunchGame;
        private System.Windows.Forms.ListBox ModsListBox;
        private System.Windows.Forms.ListBox PluginsListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ModLoaderText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

