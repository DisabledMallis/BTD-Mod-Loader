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
            this.Console = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.WelcomeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LaunchGame
            // 
            this.LaunchGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.LaunchGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.LaunchGame.ForeColor = System.Drawing.Color.White;
            this.LaunchGame.Location = new System.Drawing.Point(33, 566);
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
            this.ModsListBox.Location = new System.Drawing.Point(315, 100);
            this.ModsListBox.Name = "ModsListBox";
            this.ModsListBox.Size = new System.Drawing.Size(296, 342);
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
            this.PluginsListBox.Location = new System.Drawing.Point(617, 100);
            this.PluginsListBox.Name = "PluginsListBox";
            this.PluginsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.PluginsListBox.Size = new System.Drawing.Size(296, 342);
            this.PluginsListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "BTD Mods";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(675, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "NKHook Plugins";
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
            this.label4.Location = new System.Drawing.Point(402, 45);
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
            this.label5.Location = new System.Drawing.Point(360, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(497, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Select \"No Mods\" or \"No Plugins\" if you dont want to play with mods or plugins";
            // 
            // Console
            // 
            this.Console.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.Console.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Console.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.Console.ForeColor = System.Drawing.SystemColors.Window;
            this.Console.Location = new System.Drawing.Point(304, 518);
            this.Console.Name = "Console";
            this.Console.ReadOnly = true;
            this.Console.Size = new System.Drawing.Size(621, 103);
            this.Console.TabIndex = 9;
            this.Console.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.richTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.richTextBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.richTextBox3.Location = new System.Drawing.Point(-424, 8);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(660, 627);
            this.richTextBox3.TabIndex = 11;
            this.richTextBox3.Text = resources.GetString("richTextBox3.Text");
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.ConsoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ConsoleLabel.ForeColor = System.Drawing.Color.White;
            this.ConsoleLabel.Location = new System.Drawing.Point(301, 495);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(63, 17);
            this.ConsoleLabel.TabIndex = 14;
            this.ConsoleLabel.Text = "Console:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.pictureBox2.Location = new System.Drawing.Point(301, 515);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(627, 109);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(947, 25);
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
            this.backupGameFilesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.backupGameFilesToolStripMenuItem.Text = "Backup game files";
            this.backupGameFilesToolStripMenuItem.Click += new System.EventHandler(this.BackupGameFilesToolStripMenuItem_Click);
            // 
            // restoreGameFilesToolStripMenuItem
            // 
            this.restoreGameFilesToolStripMenuItem.Name = "restoreGameFilesToolStripMenuItem";
            this.restoreGameFilesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.restoreGameFilesToolStripMenuItem.Text = "Restore game files";
            this.restoreGameFilesToolStripMenuItem.Click += new System.EventHandler(this.RestoreGameFilesToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
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
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.pictureBox3.Location = new System.Drawing.Point(272, 483);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(702, 213);
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // WelcomeButton
            // 
            this.WelcomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.WelcomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WelcomeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.WelcomeButton.ForeColor = System.Drawing.Color.White;
            this.WelcomeButton.Location = new System.Drawing.Point(19, 44);
            this.WelcomeButton.Name = "WelcomeButton";
            this.WelcomeButton.Size = new System.Drawing.Size(234, 49);
            this.WelcomeButton.TabIndex = 20;
            this.WelcomeButton.Text = "Welcome";
            this.WelcomeButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(19, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "Mod Manager";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(19, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(234, 49);
            this.button2.TabIndex = 22;
            this.button2.Text = "Mod Updater";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 505);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 36);
            this.label3.TabIndex = 19;
            this.label3.Text = "BTD Mod Loader";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.pictureBox4.Location = new System.Drawing.Point(-9, -38);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(291, 691);
            this.pictureBox4.TabIndex = 23;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox6.Location = new System.Drawing.Point(273, 479);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(674, 10);
            this.pictureBox6.TabIndex = 25;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(272, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 623);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(947, 647);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WelcomeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Console);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModLoaderText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PluginsListBox);
            this.Controls.Add(this.ModsListBox);
            this.Controls.Add(this.LaunchGame);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "BTD Mod Loader by Gurrenm3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed_1);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.RichTextBox Console;
        private System.Windows.Forms.RichTextBox richTextBox3;
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
        private PictureBox pictureBox3;
        private Button WelcomeButton;
        private Button button1;
        private Button button2;
        private Label label3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
    }
}

