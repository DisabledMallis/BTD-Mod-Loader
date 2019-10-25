using System;
using System.Windows.Forms;

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
            this.Console = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ConsoleLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.backupGameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreGameFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.howToUseThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseModsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUsePluginsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LaunchGame
            // 
            this.LaunchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LaunchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LaunchGame.ForeColor = System.Drawing.Color.White;
            this.LaunchGame.Location = new System.Drawing.Point(656, 522);
            this.LaunchGame.Name = "LaunchGame";
            this.LaunchGame.Size = new System.Drawing.Size(188, 55);
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
            this.ModsListBox.Size = new System.Drawing.Size(296, 302);
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
            this.PluginsListBox.Location = new System.Drawing.Point(314, 156);
            this.PluginsListBox.Name = "PluginsListBox";
            this.PluginsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PluginsListBox.Size = new System.Drawing.Size(291, 302);
            this.PluginsListBox.TabIndex = 2;
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
            this.label2.Location = new System.Drawing.Point(314, 128);
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
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Console.ForeColor = System.Drawing.SystemColors.Window;
            this.Console.Location = new System.Drawing.Point(12, 508);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(593, 84);
            this.Console.TabIndex = 9;
            this.Console.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.Location = new System.Drawing.Point(0, 26);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(886, 578);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 36);
            this.label3.TabIndex = 12;
            this.label3.Text = "BTD Mod Loader";
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ConsoleLabel.ForeColor = System.Drawing.Color.White;
            this.ConsoleLabel.Location = new System.Drawing.Point(9, 485);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(63, 17);
            this.ConsoleLabel.TabIndex = 14;
            this.ConsoleLabel.Text = "Console:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pictureBox2.Location = new System.Drawing.Point(9, 505);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(599, 90);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(884, 25);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupGameFilesToolStripMenuItem,
            this.restoreGameFilesToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripDropDownButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(38, 22);
            this.toolStripDropDownButton1.Text = "File";
            // 
            // backupGameFilesToolStripMenuItem
            // 
            this.backupGameFilesToolStripMenuItem.Name = "backupGameFilesToolStripMenuItem";
            this.backupGameFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.backupGameFilesToolStripMenuItem.Text = "Backup game files";
            this.backupGameFilesToolStripMenuItem.Click += new System.EventHandler(this.BackupGameFilesToolStripMenuItem_Click);
            // 
            // restoreGameFilesToolStripMenuItem
            // 
            this.restoreGameFilesToolStripMenuItem.Name = "restoreGameFilesToolStripMenuItem";
            this.restoreGameFilesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.restoreGameFilesToolStripMenuItem.Text = "Restore game files";
            this.restoreGameFilesToolStripMenuItem.Click += new System.EventHandler(this.RestoreGameFilesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.CloseToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseThisProgramToolStripMenuItem,
            this.howToUseModsToolStripMenuItem,
            this.howToUsePluginsToolStripMenuItem});
            this.toolStripDropDownButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(45, 22);
            this.toolStripDropDownButton2.Text = "Help";
            // 
            // howToUseThisProgramToolStripMenuItem
            // 
            this.howToUseThisProgramToolStripMenuItem.Name = "howToUseThisProgramToolStripMenuItem";
            this.howToUseThisProgramToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.howToUseThisProgramToolStripMenuItem.Text = "How to use this program";
            // 
            // howToUseModsToolStripMenuItem
            // 
            this.howToUseModsToolStripMenuItem.Name = "howToUseModsToolStripMenuItem";
            this.howToUseModsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.howToUseModsToolStripMenuItem.Text = "How to use mods";
            // 
            // howToUsePluginsToolStripMenuItem
            // 
            this.howToUsePluginsToolStripMenuItem.Name = "howToUsePluginsToolStripMenuItem";
            this.howToUsePluginsToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.howToUsePluginsToolStripMenuItem.Text = "How to use plugins";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(884, 599);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModLoaderText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PluginsListBox);
            this.Controls.Add(this.ModsListBox);
            this.Controls.Add(this.LaunchGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "BTD Mod Loader by Gurrenm3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed_1);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            throw new NotImplementedException();
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
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label3;
        private Label ConsoleLabel;
        private PictureBox pictureBox2;
        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem backupGameFilesToolStripMenuItem;
        private ToolStripMenuItem restoreGameFilesToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripDropDownButton toolStripDropDownButton2;
        private ToolStripMenuItem howToUseThisProgramToolStripMenuItem;
        private ToolStripMenuItem howToUseModsToolStripMenuItem;
        private ToolStripMenuItem howToUsePluginsToolStripMenuItem;
    }
}

