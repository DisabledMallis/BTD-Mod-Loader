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
        public string livePath = Environment.CurrentDirectory;
        internal string gamePath;
        internal string lastMod;
        internal string lastPlugin;
        internal static bool userUnderstands = false;
        string currentMod;
        string game;
        string profilePath = "\\Config\\profile.json";
        string serializeOutput;
        MainForm mainForm;

        public Main()
        {
            InitializeComponent();
            CreateExampleMod();
            try
            {
                string json = File.ReadAllText(livePath + profilePath);
                MainForm deserializedMainForm = JsonConvert.DeserializeObject<MainForm>(json);
                game = deserializedMainForm.Game;
                gamePath = deserializedMainForm.GameDir;
                lastMod = deserializedMainForm.LastMod;
                lastPlugin = deserializedMainForm.LastPlugin;
            }
            catch (FileNotFoundException)
            {
                firstTimeUsingProgram();
            }
            catch (DirectoryNotFoundException)
            {
                Directory.CreateDirectory(livePath + "\\Config");
                try
                {
                    string json = File.ReadAllText(livePath + profilePath);
                }
                catch (FileNotFoundException)
                {
                    firstTimeUsingProgram();
                }
            }
            if (gamePath == null || gamePath == "")
            {
                MessageBox.Show("Game Directory is invalid, please browse again");
                firstTimeUsingProgram();
            }

            if (game == "BTD5")
            {
                string file = Directory.GetFiles(livePath + "\\Game Backup", "BTD5-Win.exe").FirstOrDefault();
                if (file == null)
                {
                    Thread thread = new Thread(backupGame);
                    thread.Start();
                }
            }
            else if (game == "Battles")
            {
                string file = Directory.GetFiles(livePath + "\\Game Backup", "Battles-Win.exe").FirstOrDefault();
                if (file == null)
                {
                    Thread thread = new Thread(backupGame);
                    thread.Start();
                }
            }
            
            PopulateModListBox();
            PopulatePluginListBox();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            if (game == "BTD5")
            {
                label3.Text = "BTD5 Mod Loader";
                richTextBox2.SendToBack();
                richTextBox3.SendToBack();
            }
            if (game == "Battles")
            {
                label3.Text = "BTDB Mod Loader";
                richTextBox2.BringToFront();
                richTextBox3.SendToBack();
            }
            this.MaximizeBox = false;
        }
        private void firstTimeUsingProgram()
        {
            richTextBox3.BringToFront();
            label3.SendToBack();

            Directory.CreateDirectory(livePath + "\\Plugins");
            Directory.CreateDirectory(livePath + "\\Plugins\\Unloaded Plugins");
            Directory.CreateDirectory(livePath + "\\Mods");
            Directory.CreateDirectory(livePath + "\\Game Backup");
            File.Create(livePath + "\\Plugins\\PUT YOUR PLUGINS INSIDE 'UNLOADED PLUGINS' FOLDER.TXT").Close();

            this.Show();
            browseForBTD5Folder();
            seriealizeConfig();
            richTextBox3.SendToBack();
        }
        private void browseForBTD5Folder()
        {
            FolderBrowserDialog btd5FolderBrowse = new FolderBrowserDialog();
            if (btd5FolderBrowse.ShowDialog() == DialogResult.OK)
            {
                string tempGamePath = btd5FolderBrowse.SelectedPath;

                var file = Directory.GetFiles(tempGamePath, "*.exe").FirstOrDefault();
                string filename = Path.GetFileName(file);
                if (file == null)
                {
                    // Handle the file not being found
                    MessageBox.Show("wrong directory");
                    browseForBTD5Folder();
                }
                else
                {
                    gamePath = tempGamePath;

                    if (filename == "BTD5-Win.exe")
                    {
                        game = "BTD5";
                        richTextBox2.SendToBack();
                        label3.Text = "BTD5 Mod Loader";
                        label3.Refresh();
                    }
                    else if (filename == "Battles-Win.exe")
                    {
                        game = "Battles";
                        richTextBox2.BringToFront();
                        label3.Text = "BTDB Mod Loader";
                        label3.Refresh();
                    }
                        
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private void backupGame()
        {
            if (Directory.Exists(gamePath))
            {
                //Now Create all of the directories
                foreach (string dirPath in Directory.GetDirectories(gamePath, "*",
                    SearchOption.AllDirectories))
                    Directory.CreateDirectory(dirPath.Replace(gamePath, livePath + "\\Game Backup"));

                //Copy all the files
                foreach (string newPath in Directory.GetFiles(gamePath, "*.*",
                    SearchOption.AllDirectories))
                    File.Copy(newPath, newPath.Replace(gamePath, livePath + "\\Game Backup"), false);
            }
            else
            {
                MessageBox.Show("Game Directory is invalid, please select your BTD5 Directory again...");
                browseForBTD5Folder();
                seriealizeConfig();
            }
        }
        private void seriealizeConfig()
        {
            mainForm = new MainForm(game, gamePath, currentMod, lastPlugin);
            serializeOutput = JsonConvert.SerializeObject(mainForm);

            StreamWriter writeMainForm = new StreamWriter(livePath + profilePath, false);
            writeMainForm.Write(serializeOutput);
            writeMainForm.Close();
        }

        private void ModsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            currentMod = ModsListBox.SelectedItem.ToString();
        }

        private void PluginsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lastPlugin = PluginsListBox.SelectedItem.ToString();
            }
            catch(System.NullReferenceException)
            {
                PluginsListBox.SelectedIndex = 0;
                lastPlugin = PluginsListBox.SelectedItem.ToString();
            }
        }

        private void LaunchGame_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Applying mod/plugins... This will take a few seconds...";
            try
            {
                currentMod = ModsListBox.SelectedItem.ToString();
            }
            catch(System.NullReferenceException)
            {
                ModsListBox.SelectedIndex = 0;
            }
            try
            {
                lastPlugin = PluginsListBox.SelectedItem.ToString();
            }
            catch (System.NullReferenceException)
            {
                PluginsListBox.SelectedIndex = 0;
            }

            //Start injecting mod stuff
            if (currentMod != lastMod)
            {
                RestoreGame();
            }
            seriealizeConfig();

            if (ModsListBox.SelectedItem.ToString() != "No Mods")
            {
                ZipFile zip = ZipFile.Read(livePath + "\\Mods\\" + ModsListBox.SelectedItem.ToString());
                foreach (ZipEntry zipa in zip)
                {
                    zipa.Extract(gamePath, ExtractExistingFileAction.OverwriteSilently);
                }
            }

            //start injecting zip stuff
            string[] selectedPlugins = PluginsListBox.SelectedItems.OfType<string>().ToArray();
            string[] loadedPlugins = Directory.GetFiles(livePath + "\\Plugins", "*.dll");
            foreach (string plugin in loadedPlugins)
            {
                string filename = Path.GetFileName(plugin);
                if (selectedPlugins.Contains(filename) == false)
                {
                    if (File.Exists(livePath + "\\Plugins\\Unloaded Plugins\\" + filename))
                    {
                        File.Delete(livePath + "\\Plugins\\Unloaded Plugins\\" + filename);
                    }

                    File.Copy(plugin, livePath + "\\Plugins\\Unloaded Plugins\\" + filename);
                    File.Delete(plugin);
                }
            }

            foreach (string plugin in selectedPlugins)
            {
                if (plugin != "No Plugins")
                {
                    File.Copy(livePath + "\\Plugins\\Unloaded Plugins\\" + plugin, livePath + "\\Plugins\\" + plugin);
                    File.Delete(livePath + "\\Plugins\\Unloaded Plugins\\" + plugin);
                }
            }
            
            try
            {
                //Sleep for 2 seconds to help with program delete old mod
                //
                if (game == "BTD5")
                {
                    Thread thread = new Thread(launchNKHook);
                    thread.Start();
                }
                else if (game == "Battles")
                {
                    Thread thread = new Thread(launchBTDB);
                    thread.Start();
                }
                
            }
            catch(Win32Exception)
            {
                MessageBox.Show("NKHook5.exe not found! Please add NKhook5.exe to the main directory of this program");
            }
        }
        private void launchBTDB()
        {
            Thread.Sleep(3000);
            try
            {
                Process.Start(gamePath + "\\Battles-Win.exe");
            }
            catch (System.ComponentModel.Win32Exception)
            {
                
            }
            if (this.InvokeRequired)
                this.Invoke((MethodInvoker)delegate ()
                {
                    this.Close();
                }); 
        }
        private void launchNKHook()
        {
            Thread.Sleep(3000);
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
                        {
                            downloadLink = np.Value.ToString();
                        }
                    }
                }
            }
            client.DownloadFile(downloadLink, livePath + "\\NKHook5.exe");
            try
            {
                Process.Start(livePath + "\\NKHook5.exe");
            }
            catch(Win32Exception)
            {
                if (richTextBox1.InvokeRequired)
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        richTextBox1.Text = "NKHook cancelled or not found... If you didn't cancel the program please add NKHook5.exe to the main directory of this program";
                        richTextBox1.Refresh();
                        Thread.Sleep(2500);
                        richTextBox1.Text = "";
                    });
            }
        }
        private void RestoreGame()
        {
            if (richTextBox1.InvokeRequired)
                this.Invoke((MethodInvoker)delegate ()
                {
                    richTextBox1.Refresh();
                });
            foreach (string dirPath in Directory.GetDirectories(livePath + "\\Game Backup", "*", SearchOption.AllDirectories))
                Directory.CreateDirectory(dirPath.Replace(livePath + "\\Game Backup", gamePath));
            foreach(string gamePathFile in Directory.GetFiles(gamePath, "*.*", SearchOption.AllDirectories))
                File.Delete(gamePathFile);
            foreach (string newPath in Directory.GetFiles(livePath + "\\Game Backup", "*.*", SearchOption.AllDirectories))
                File.Copy(newPath, newPath.Replace(livePath + "\\Game Backup", gamePath), true);
        }
        private void PopulateModListBox()
        {
            DirectoryInfo di =new DirectoryInfo(livePath + "\\Mods");
            FileInfo[] files = di.GetFiles("*.zip", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                
                ModsListBox.Items.Add(file.Name);
            }
            try
            {
                ModsListBox.SelectedItem = lastMod;
            }
            catch
            {
                ModsListBox.SelectedIndex = 0;
            }
        }
        private void PopulatePluginListBox()
        {
            DirectoryInfo di =new DirectoryInfo(livePath + "\\Plugins");
            FileInfo[] files = di.GetFiles("*.dll", SearchOption.AllDirectories);

            foreach (FileInfo file in files)
            {
                
                PluginsListBox.Items.Add(file.Name);
            }
            try
            {
                PluginsListBox.SelectedItem = lastPlugin;
            }
            catch
            {
                PluginsListBox.SelectedIndex = 0;
            }
        }
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            seriealizeConfig();
        }
        private void CreateExampleMod()
        {
            string readme = "To properly use mods with this program, you need to have them in a .ZIP folder, WITH all of the necessary subdirectories. This program allows users to modify anything and save it, so you need to specify which folders your mods are from. For example, You have to have an 'Assets' folder in your .ZIP, and in your 'Assets' folder is your BTD5.Jet or Data.Jet. You don't need to make all of the folders, just the ones for the files that you edited.";

            Directory.CreateDirectory(livePath + "\\Mods\\Assets\\");
            Directory.CreateDirectory(livePath + "\\Mods\\Assets\\Audio");
            Directory.CreateDirectory(livePath + "\\Mods\\Assets\\Textures");
            Directory.CreateDirectory(livePath + "\\Mods\\Assets\\Textures\\Ultra");
            File.Create(livePath + "\\Mods\\Assets\\Example_BTD5.Jet");
            File.Create(livePath + "\\Mods\\Assets\\Audio\\EditedAudioFiles.txt");
            File.Create(livePath + "\\Mods\\Assets\\Textures\\Ultra\\EditedTexture.png");
            File.AppendAllText(livePath + "\\Mods\\README.txt", readme);

            DirectoryInfo di = new DirectoryInfo(livePath + "\\Mods");
            FileInfo[] filePaths = di.GetFiles("*", SearchOption.AllDirectories);

            //string[] filePaths = Directory.GetFiles(livePath + "\\Mods", SearchOption.AllDirectories);
            ZipFile exampleMod = new ZipFile();
            //foreach (string item in filePaths)
            foreach (FileInfo item in filePaths)
            {
                // If the item is a file
                if (File.Exists(item.ToString()))
                {
                    MessageBox.Show(item.ToString());
                    // Add the file in the root folder inside our zip file
                    exampleMod.AddFile(item.ToString(), "*");
                }
                // if the item is a folder    
                else if (Directory.Exists(item.ToString()))
                {
                    // Add the folder in our zip file with the folder name as its name
                    exampleMod.AddDirectory(item.ToString(), new DirectoryInfo(item.ToString()).Name);
                }
            }
            // Finally save the zip file to the destination we want
            exampleMod.Save(livePath + "\\Mods\\ExampleMod.zip");
        }
        private void test ()
        {

            //exampleMod.AddDirectory(livePath + "\\Mods");
            //exampleMod.Name = livePath + "\\Mods\\ExampleMod.zip";
            //exampleMod.Save();
            //exampleMod.AddFiles(livePath + "\\Mods", false, "");



            // Loop through all the items.
            
        }
    }
}
