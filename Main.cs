using Ionic.Zip;
using Ionic.Zlib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Environment;
using static BTDModLoader.SerealizeConfig;
using System.Diagnostics;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Net.Http;

namespace BTDModLoader
{
    public partial class Main : Form
    {
        MainForm mainForm;
        internal static string livePath = Environment.CurrentDirectory;

        internal static string game;
        internal static string gamePath;
        internal static string profilePath = "\\Config\\profile.json";

        internal static string lastMod;
        internal static string currentMod;
        internal static string exeName;

        public Main()
        {
            InitializeComponent();
            PopulateModListBox();
            PopulatePluginListBox();
            label3.Hide();
            pictureBox1.Hide();
            richTextBox3.Hide();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.Show();
            PrintToConsole("Program Starting...");
            try
            {
                string serializedConfig = File.ReadAllText(livePath + profilePath);
                MainForm deserializedConfig = JsonConvert.DeserializeObject<MainForm>(serializedConfig);

                game = deserializedConfig.Game;
                exeName = deserializedConfig.ExeName;
                gamePath = deserializedConfig.GameDir;
                lastMod = deserializedConfig.LastMod;
            }
            catch (DirectoryNotFoundException)
            {
                PrintToConsole("\nDirectories not found. \nCreating directories...");
                Directory.CreateDirectory(livePath + "\\Config");
                Directory.CreateDirectory(livePath + "\\Plugins");
                Directory.CreateDirectory(livePath + "\\Plugins\\Unloaded Plugins");
                File.Create(livePath + "\\Plugins\\PUT YOUR PLUGINS INSIDE 'UNLOADED PLUGINS' FOLDER.TXT").Close();
                Directory.CreateDirectory(livePath + "\\Mods");
                Directory.CreateDirectory(livePath + "\\Game Backup");
            }
            catch (FileNotFoundException)
            {
                richTextBox3.BringToFront();
                label3.SendToBack();

                browseForBTD5Folder();
                seriealizeConfig();
            }
            if (game == null || exeName == null || gamePath == null)
            {
                richTextBox3.BringToFront();
                label3.SendToBack();

                browseForBTD5Folder();
                seriealizeConfig();
            }

            richTextBox3.SendToBack();
            if (lastMod == null)
            {
                lastMod = "No Mods";
                ModsListBox.SelectedIndex = 0;
            }
            label3.Text = game + " Mod Loader";
            PrintToConsole("\nProgram successfully loaded.");
            PrintToConsole("\nGame: " + game);
            PrintToConsole("\nChoose the mods/plugins you want to play with, then press 'Launch'");
            PrintToConsole("\nChoose 'No Mods' or 'No Plugins' if you don't want to play with any mods or plugins");
        }
        private void browseForBTD5Folder()
        {
            PrintToConsole("\nGame Directory hasn't been set. Please browse for your BTD Directory. Make sure it is the folder that has the EXE of the game you want to mod.");
            FolderBrowserDialog btd5FolderBrowse = new FolderBrowserDialog();
            btd5FolderBrowse.Description = "Please browse for your BTD directory. Make sure you select the folder that has the .EXE of BTD5, BTDB, or Monkey City.";
            btd5FolderBrowse.SelectedPath = "C:\\";
            if (btd5FolderBrowse.ShowDialog() == DialogResult.OK)
            {
                gamePath = btd5FolderBrowse.SelectedPath;

                var file = Directory.GetFiles(gamePath, "*.exe").FirstOrDefault();
                string filename = Path.GetFileName(file);
                if (file == null)
                {
                    PrintToConsole("\nInvalid directory! Please select the directory that has the game EXE in it");
                    browseForBTD5Folder();
                }
                else
                {
                    exeName = filename;
                    if (filename == "BTD5-Win.exe")
                    {
                        game = "BTD5";
                    }
                    else if (filename == "Battles-Win.exe")
                    {
                        game = "BTDB";
                    }
                    PrintToConsole("\nGame: " + game);
                    label3.Text = game + " Mod Loader";
                    label3.BringToFront();
                }
                PrintToConsole("\nNo backup detected...");
                Thread thread = new Thread(backupGame);
                thread.Start();
                label3.Text = game + " Mod Loader";
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private void backupGame()
        {
            PrintToConsole("\nBacking up game files...");
            foreach (string dirPath in Directory.GetDirectories(gamePath, "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(gamePath, livePath + "\\Game Backup"));

            foreach (string newPath in Directory.GetFiles(gamePath, "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(gamePath, livePath + "\\Game Backup"), true);
            PrintToConsole("\nFinished backing up game files.");
        }
         private void seriealizeConfig()
        {
            mainForm = new MainForm(game, exeName, gamePath, currentMod);

            StreamWriter writeMainForm = new StreamWriter(livePath + profilePath, false);
            writeMainForm.Write(JsonConvert.SerializeObject(mainForm));
            writeMainForm.Close();
        }

        private void ModsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentMod = ModsListBox.SelectedItem.ToString();
        }

        private void LaunchGame_Click(object sender, EventArgs e)
        {
            if ((IsGameRunning(game) == true) || (IsGameRunning("Battles") == true))
                PrintToConsole("\nGame is currently running!! You must exit " + game + " before continuing!!");
            else
            {
                ApplyFiles();
                seriealizeConfig();
                PrintToConsole("\nLaunching " + game);
                if (game == "BTD5")
                {
                    Thread thread = new Thread(launchWithNKHook);
                    thread.Start();
                }
                else
                {
                    Process.Start(gamePath + "\\" + exeName);
                }
            }
        }
        private void launchWithNKHook()
        {
            //Auto download latest nkhook exe <3 ~DisabledMallis
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            WebClient client = new WebClient();
            client.Headers.Add("user-agent", " Mozilla/5.0 (Windows NT 6.1; WOW64; rv:25.0) Gecko/20100101 Firefox/25.0"); //spoof using firefox so we dont get 403 forbidden error
            JArray parsedArray = JArray.Parse(client.DownloadString("https://api.github.com/repos/DisabledMallis/NKHook5/releases"));
            string downloadLink = "";
            JObject o = parsedArray.Children<JObject>().First();
            foreach (JProperty p in o.Properties())
            {
                string name = p.Name;
                if (name == "assets")
                {
                    JObject assets = p.Value.Children<JObject>().First();
                    foreach (JProperty np in assets.Properties())
                    {
                        string dlname = np.Name;
                        if (dlname == "browser_download_url")
                            downloadLink = np.Value.ToString();
                    }
                }
            }
            PrintToConsole("\nDownloading latest version of NKHook");
            client.DownloadFile(downloadLink, livePath + "\\NKHook5.exe");
            try
            {
                Process.Start(livePath + "\\NKHook5.exe");
                PrintToConsole("\nLaunching NKHook");
            }
            catch(System.ComponentModel.Win32Exception)
            {
                PrintToConsole("\nNKHook was cancelled...");
            }
        }
        private void ApplyFiles()
        {
            try
            {
                currentMod = ModsListBox.SelectedItem.ToString();
            }
            catch(System.NullReferenceException)
            {
                ModsListBox.SelectedIndex = 0;
            }
            PrintToConsole("\nYou chose to play with " + currentMod);
            PrintToConsole("\nApplying mod/plugins... This may take a few seconds...");
            if (currentMod != lastMod)
            {
                RestoreGame();
                if (ModsListBox.SelectedItem.ToString() != "No Mods")
                {
                    ZipFile zip = ZipFile.Read(livePath + "\\Mods\\" + ModsListBox.SelectedItem.ToString());
                    foreach (ZipEntry zipa in zip)
                    {
                        zipa.Extract(gamePath, ExtractExistingFileAction.OverwriteSilently);
                    }
                }
            }
            if (currentMod != "No Mods")
                PrintToConsole("\n" + currentMod + " has been applied to " + game);
            string[] selectedPlugins = PluginsListBox.SelectedItems.OfType<string>().ToArray();
            string[] loadedPlugins = Directory.GetFiles(livePath + "\\Plugins", "*.dll");

            //check if there are loaded plugins that arent selected for use and move them to Unused plugins
            foreach (string plugin in loadedPlugins)
            {
                string filename = Path.GetFileName(plugin);
                if (selectedPlugins.Contains(filename) == false)
                {
                    if (File.Exists(livePath + "\\Plugins\\Unloaded Plugins\\" + filename))
                        File.Delete(livePath + "\\Plugins\\Unloaded Plugins\\" + filename);

                    File.Copy(plugin, livePath + "\\Plugins\\Unloaded Plugins\\" + filename);
                    File.Delete(plugin);
                }
            }

            //Move any selected plugins that are not loaded to loaded plugins
            foreach (string plugin in selectedPlugins)
            {
                if (plugin != "No Plugins")
                {
                    File.Copy(livePath + "\\Plugins\\Unloaded Plugins\\" + plugin, livePath + "\\Plugins\\" + plugin);
                    File.Delete(livePath + "\\Plugins\\Unloaded Plugins\\" + plugin);
                    PrintToConsole("\n" + plugin + " applied");
                }
            }
        }
        private void RestoreGame()
        {
            try
            {
                PrintToConsole("\nReplacing game files with backup...");
                foreach (string dirPath in Directory.GetDirectories(livePath + "\\Game Backup", "*", SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(livePath + "\\Game Backup", gamePath));
                foreach (string gamePathFile in Directory.GetFiles(gamePath, "*.*", SearchOption.AllDirectories))
                    File.Delete(gamePathFile);
                foreach (string newPath in Directory.GetFiles(livePath + "\\Game Backup", "*.*", SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(livePath + "\\Game Backup", gamePath), true);
                PrintToConsole("\nFinished restoring game files to the backed up version.");
            }
            catch(System.IO.DirectoryNotFoundException)
            {
                PrintToConsole("\nYou don't have a backup to replace the original. Since you don't have a backup, it is recommended that you reinstall the game, so you can have an unmodded backup.");
            }
        }
        private void PopulateModListBox()
        {
            DirectoryInfo di =new DirectoryInfo(livePath + "\\Mods");
            FileInfo[] files = di.GetFiles("*.zip", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
                ModsListBox.Items.Add(file.Name);

            ModsListBox.SelectedItem = lastMod;
            if (lastMod == null)
                ModsListBox.SelectedIndex = 0;
        }
        private void PopulatePluginListBox()
        {
            DirectoryInfo di =new DirectoryInfo(livePath + "\\Plugins");
            FileInfo[] files = di.GetFiles("*.dll", SearchOption.AllDirectories);

            PluginsListBox.SelectedIndex = 0;
            foreach (FileInfo file in files)
                PluginsListBox.Items.Add(file.Name);
        }
        private void Main_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            seriealizeConfig();
        }
        private void PrintToConsole(string message)
        {
            Console.Invoke((MethodInvoker)delegate()
            {
                Console.AppendText(message);
                Console.SelectionStart = Console.Text.Length;
                Console.ScrollToCaret();
            });   
        }
        public bool IsGameRunning(string name)
        {
            foreach (Process clsProcess in Process.GetProcesses())
            {
                if (clsProcess.ProcessName.Contains(name))
                {
                    return true;
                }
            }
            return false;
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BackupGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            backupGame();
        }

        private void RestoreGameFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreGame();
        }
    }
}
