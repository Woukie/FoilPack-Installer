using FoilPackInstaller.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace FoilPackInstaller
{
    public partial class FoilPackForm : Form
    {
        private ModDataSet modDataSet = new ModDataSet();
        private int previewModID = 0;
        private List<string> selectedModsNames = new List<string>();
        private List<string> dependanciesToDownload = new List<string>();
        private bool downloadingFile = false;

        public FoilPackForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDataSet();
            updateDesignerItems();
            updateModsList();
            //client.Headers.Add("user-agent", " Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:74.0) Gecko/20100101 Firefox/74.0");

            txtEventLog.Text = ":) Loaded launcher";
        }

        //will update some elemets in the main form to look nicer
        private void updateDesignerItems()
        {
            lblDivider1.Width = panelInfo.Width;
            lblDivider2.Width = panelInfo.Width;
            lblDivider3.Width = panelInstaller.Width;
            lblDivider4.Width = panelInstaller.Width;
            panelModList.MouseWheel += scrollModList;
            panelModList.AutoScroll = false;
        }

        //fills dataset with values from the database
        //should implement live updating of the database
        private void fillDataSet()
        {
            try
            {
                //Adapters used to fill the modDataSet
                ModDataSetTableAdapters.ModsTableAdapter modDataAdapter = new ModDataSetTableAdapters.ModsTableAdapter();
                ModDataSetTableAdapters.DependanciesTableAdapter dependanciesDataAdapter = new ModDataSetTableAdapters.DependanciesTableAdapter();

                //fill modDataSet
                modDataAdapter.Fill(modDataSet.Mods);
                dependanciesDataAdapter.Fill(modDataSet.Dependancies);
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not get data from database, try again soon.";
            }
        }

        //clears, then adds all mods from database as buttons. Sets up events as well. 
        private void updateModsList()
        {
            panelModList.Controls.Clear();
            int y = 0;
            for (int i = 0; i < modDataSet.Mods.Rows.Count; i++)
            {
                Button butt = new Button();
                butt.Location = new Point(0, y);
                butt.Name = "btn" + i;
                butt.Size = new Size(panelModList.Width, 30);
                butt.TabIndex = modDataSet.Mods.Rows[i].Field<int>("ID");
                butt.Text = modDataSet.Mods.Rows[i].Field<string>("ModName");
                butt.BackColor = Color.Gray;
                butt.FlatStyle = FlatStyle.Flat;
                butt.FlatAppearance.BorderSize = 0;
                butt.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);

                butt.Click += new EventHandler(clickMod);
                butt.MouseEnter += new EventHandler(hoverOverMod);

                panelModList.Controls.Add(butt);
                y += 30;
            }
        }

        //will update description panel when called
        private void updateDescriptionPanel()
        {
            try
            {
                lblModName.Text = modDataSet.Mods.Rows[previewModID - 1].Field<string>("ModName");
                lblModDescription.Text = modDataSet.Mods.Rows[previewModID - 1].Field<string>("Description").Replace("_", "\r\n");
                txtModSauce.Text = "Link to download page: " + modDataSet.Mods.Rows[previewModID - 1].Field<string>("ModPage").Replace("#", "") + "\r\n" + "\r\n" + "Link to direct download: " + modDataSet.Mods.Rows[previewModID - 1].Field<string>("Download").Replace("#", "");
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not update mod description, possible database issue.";
            }
        }

        //handles displaying information when hovering over an item
        private void hoverOverMod(object sender, EventArgs e)
        {
            try
            {
                string nameOfMod = sender.ToString().Remove(0, 35);

                foreach (DataRow dataRow in modDataSet.Mods)
                {
                    if (dataRow.Field<string>("ModName") == nameOfMod)
                    {
                        previewModID = dataRow.Field<int>("ID");
                        updateDescriptionPanel();
                        return;
                    }
                }
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Unexpected error, possible database issue.";
            }
        }

        //get around for making scrollbars invisible
        private void scrollModList(object sender, MouseEventArgs e)
        {
            panelModList.AutoScrollPosition = new Point(0, -e.Delta / 4 - panelModList.AutoScrollPosition.Y);
        }

        //handles opening links in rich text boxes
        private void openLink(object sender, LinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not open link.";
            }
        }

        //manages adding and removing buttons from selected mods list
        private void clickMod(object sender, EventArgs e)
        {
            string nameOfMod = sender.ToString().Remove(0, 35);

            if (selectedModsNames.Contains(nameOfMod))
            {
                updateListSelected(false, nameOfMod);
            }
            else
            {
                updateListSelected(true, nameOfMod);
            }
        }

        //specify wether to add or remove a button from selected list and what button it is.
        //can optimise remove section by not clearing entire panel but just item being removed.
        private void updateListSelected(bool add, string nameOfMod)
        {
            try
            {
                if (add)
                {
                    txtEventLog.Text += "\r\n:) Added " + nameOfMod + " to selected mods list";
                    selectedModsNames.Add(nameOfMod);
                    Button butt = new Button();

                    butt.Location = new Point(0, 30 * selectedModsNames.IndexOf(nameOfMod));
                    butt.Name = "btnSelected" + nameOfMod.Replace(" ", "");
                    butt.Size = new Size(panelSelectedList.Width, 30);
                    butt.TabIndex = 0;
                    butt.Text = nameOfMod;
                    butt.BackColor = Color.Gray;
                    butt.FlatStyle = FlatStyle.Flat;
                    butt.FlatAppearance.BorderSize = 0;
                    butt.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);

                    butt.Click += new EventHandler(clickMod);
                    butt.MouseEnter += new EventHandler(hoverOverMod);

                    panelSelectedList.Controls.Add(butt);
                }
                else if (!add)
                {
                    txtEventLog.Text += "\r\n:) Removed " + nameOfMod + " from selected mods list";
                    selectedModsNames.Remove(nameOfMod);
                    panelSelectedList.Controls.Clear();
                    foreach (string modNameInList in selectedModsNames)
                    {
                        Button butt = new Button();

                        butt.Location = new Point(0, 30 * selectedModsNames.IndexOf(modNameInList));
                        butt.Name = "btnSelected" + modNameInList.Replace(" ", "");
                        butt.Size = new Size(panelSelectedList.Width, 30);
                        butt.TabIndex = 0;
                        butt.Text = modNameInList;
                        butt.BackColor = Color.Gray;
                        butt.FlatStyle = FlatStyle.Flat;
                        butt.FlatAppearance.BorderSize = 0;
                        butt.Font = new Font("Bahnschrift", 10F, FontStyle.Regular, GraphicsUnit.Point);

                        butt.Click += new EventHandler(clickMod);
                        butt.MouseEnter += new EventHandler(hoverOverMod);

                        panelSelectedList.Controls.Add(butt);
                    }
                }
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not update selected items, possible database issue.";
            }
        }


        //give it an ID and it will download that mod. Used to download anything that isnt forge.
        //handles moving mods as well as downloading them
        private void downloadByID(int modID)
        {
            try
            {
                Directory.CreateDirectory(txtDirectory.Text + @"\mods\1.12.2");

                string link = modDataSet.Mods.Rows[modID].Field<string>("Download").Replace("#", "");
                string acctualModName = link.Remove(0, link.LastIndexOf(@"/") + 1);
                string downloadLocation = txtDirectory.Text + @"\mods\1.12.2\" + acctualModName;

                bool modExistsModDir = File.Exists(txtDirectory.Text + @"\mods\" + acctualModName);
                bool modExistsVersionDir = File.Exists(txtDirectory.Text + @"\mods\1.12.2\" + acctualModName);

                if (modExistsModDir && modExistsVersionDir) File.Delete(txtDirectory.Text + @"\mods\" + acctualModName);
                if (modExistsModDir && !modExistsVersionDir) File.Move(txtDirectory.Text + @"\mods\" + acctualModName, downloadLocation);
                if (!modExistsModDir && !modExistsVersionDir)
                {
                    txtEventLog.Text += "\r\n:) Started Download: " + modDataSet.Mods.Rows[modID].Field<string>("ModName");

                    WebClient client = new WebClient();
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(CompletedDownload);
                    client.DownloadFileTaskAsync(link, downloadLocation);

                    while (downloadingFile)
                    {
                        Application.DoEvents();
                    }

                    downloadingFile = true;
                    txtEventLog.Text += "\r\n:) Finnished Downloading: " + modDataSet.Mods.Rows[modID].Field<string>("ModName");
                }
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not download mod, ensure Minecraft isn't running.";
            }

        }

        void CompletedDownload(object sender, AsyncCompletedEventArgs e)
        {
            downloadingFile = false;
        }

        private void downloadDependancies()
        {
            try
            {
                if (checkForMinecraftDir())
                {
                    foreach (string potentialMod in Directory.GetFiles(txtDirectory.Text + @"\mods\").Concat(Directory.GetFiles(txtDirectory.Text + @"\mods\1.12.2")))
                    {
                        string fileNameAndExt = potentialMod.Remove(0, potentialMod.LastIndexOf(@"\") + 1);
                        string fileName = fileNameAndExt.Remove(fileNameAndExt.LastIndexOf("."), fileNameAndExt.Length - fileNameAndExt.LastIndexOf("."));
                        for (int i = 0; i < modDataSet.Mods.Rows.Count; i++)
                        {
                            //checks if this item in the dataset has been downloaded
                            if (modDataSet.Mods.Rows[i].Field<string>("Download").Contains(fileName))
                            {
                                if (modDataSet.Mods.Rows[i].Field<string>("Dependancies") != null)
                                    dependanciesToDownload.Add(modDataSet.Mods.Rows[i].Field<string>("Dependancies"));
                            }
                        }
                    }

                    dependanciesToDownload = dependanciesToDownload.Distinct().ToList();
                    txtEventLog.Text += "\r\n:) " + dependanciesToDownload.Count + " dependancies found.";

                    foreach (string dependancyName in dependanciesToDownload.ToArray())
                    {
                        string link = "";
                        string acctualDependancyName = "";

                        for (int i = 0; i < modDataSet.Dependancies.Rows.Count; i++)
                        {
                            if (modDataSet.Dependancies.Rows[i].Field<string>("ModName") == dependancyName)
                            {
                                link = modDataSet.Dependancies.Rows[i].Field<string>("Download").Replace("#", "");
                                acctualDependancyName = link.Remove(0, link.LastIndexOf(@"/") + 1);
                            }
                        }

                        bool fileInMods = File.Exists(txtDirectory.Text + @"\mods\" + acctualDependancyName);
                        bool fileInModsVersion = File.Exists(txtDirectory.Text + @"\mods\1.12.2\" + acctualDependancyName);

                        if (fileInModsVersion && fileInMods) File.Delete(txtDirectory.Text + @"\mods\" + acctualDependancyName);
                        if (!fileInModsVersion && fileInMods) File.Move(txtDirectory.Text + @"\mods\" + acctualDependancyName, txtDirectory.Text + @"\mods\1.12.2\" + acctualDependancyName);

                        if (!fileInModsVersion && !fileInMods)
                        {
                            txtEventLog.Text += "\r\n:) Downloading: " + dependancyName;
                            string downloadLocation = txtDirectory.Text + @"\mods\1.12.2\" + acctualDependancyName;
                            WebClient client = new WebClient();
                            client.DownloadFile(link, downloadLocation);
                            txtEventLog.Text += "\r\n:) Finnished downloading: " + dependancyName;
                        }
                    }
                    dependanciesToDownload.Clear();
                    txtEventLog.Text += "\r\n:) All dependancies successfully downloaded.";
                }
                else
                {
                    txtEventLog.Text += "\r\n:/ Minecraft directory wasn't found.";
                }
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not download dependancies, possible database issue.";
            }
        }

        //opens a dialoge for user to select directory. Calls to check if forge is installed if version folder exists. 
        //can be cleaned up
        private void browseAndSetDirectory(object sender, EventArgs e)
        {
            FolderBrowserDialog browseToMinecraft = new FolderBrowserDialog();
            browseToMinecraft.Description = "Navigate to the '.minecraft' folder";

            if (browseToMinecraft.ShowDialog() == DialogResult.OK)
            {
                txtDirectory.Text = browseToMinecraft.SelectedPath;
                if (Directory.Exists(browseToMinecraft.SelectedPath + @"\versions"))
                {
                    checkForgeInstalled();
                }
                else
                {
                    txtEventLog.Text += "\r\n:/ Could not find versions folder, make sure you have the right directory.";
                }
            }
        }

        //searches every mod in the dataset for the mod name, downloads it if its one of the mods in selectedModsNames
        //optimise by using a hashmap or better method for searching dataset
        //optimise by merging with downloadAllMods
        private void downloadSelectedMods(object sender, EventArgs e)
        {
            try
            {
                if (checkForMinecraftDir())
                {
                    for (int i = 0; i < modDataSet.Mods.Rows.Count; i++)
                    {
                        string modName = modDataSet.Mods.Rows[i].Field<string>("ModName");
                        if (selectedModsNames.Contains(modName))
                        {
                            downloadByID(i);
                        }
                    }
                    downloadDependancies();
                    txtEventLog.Text += "\r\n:) Downloaded selected mods";
                }
                else
                {
                    txtEventLog.Text += "\r\n:/ Can't find Minecraft directory.";
                }
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not download selected mods, possible database error.";
            }
        }

        //installs all new mods
        private void downloadAllMods(object sender, EventArgs e)
        {
            if (checkForMinecraftDir())
            {
                for (int i = 0; i < modDataSet.Mods.Rows.Count; i++)
                {
                    downloadByID(i);
                }
                downloadDependancies();
                txtEventLog.Text += "\r\n:) All mods successfully downloaded.";
            }
            else
            {
                txtEventLog.Text += "\r\n:/ Minecraft directory wasn't found.";
            }
        }

        //downloads forge to the temp folder, launches, waits and deletes itself
        private void installForge(object sender, EventArgs e)
        {
            string path = Path.GetTempFileName();
            string newPath = path.Replace(".tmp", ".jar");

            WebClient client = new WebClient();
            client.DownloadFile(Settings.Default["LatestForgeLink"].ToString(), newPath);

            System.Diagnostics.Process process = System.Diagnostics.Process.Start(newPath);
            process.WaitForExit();

            File.Delete(newPath);
            File.Delete(path);
        }

        //guesses minecraft directory by going through typical insitlation locations
        private void guessMinecraftDirectory(object sender, EventArgs e)
        {
            for (int i = 0; i < DriveInfo.GetDrives().Length; i++)
            {
                string possibleDirectory = DriveInfo.GetDrives()[i].ToString() + @"Users\" + Environment.UserName + @"\AppData\Roaming\.minecraft";
                if (Directory.Exists(possibleDirectory))
                {
                    txtDirectory.Text = possibleDirectory;
                    checkForgeInstalled();
                    txtEventLog.Text += "\r\n:) Minecraft directory found.";
                    return;
                }
            }
            txtEventLog.Text += "\r\n:/ Could not find minecraft directory";
        }

        //checks if correct version is installed for forge. Ensure to only call when minecraft directory is known
        private void checkForgeInstalled()
        {
            string link = Settings.Default["LatestForgeLink"].ToString();

            string forgeVersionDirectory = txtDirectory.Text.ToString() + @"\versions\" + "1.12.2-forge1.12.2-" + link.Split('-')[3];
            if (!Directory.Exists(forgeVersionDirectory))
            {
                txtEventLog.Text += "\r\n:/ Please remember to check 'Install Forge' before downloading the mods.";
            }
            else
            {
                txtEventLog.Text += "\r\n:) The right version of forge is installed on your device.";
            }
        }

        private void backUpAllMods(object sender, EventArgs e)
        {
            try
            {
                if (checkForMinecraftDir())
                {
                    string oldModsDirectory = txtDirectory.Text + @"\mods\Old";
                    Directory.CreateDirectory(oldModsDirectory + @"\1.12.2");
                    List<string> fileToMove = new List<string>();

                    //check all files in root mods folder
                    foreach (string potentialMod in Directory.GetFiles(txtDirectory.Text + @"\mods"))
                        fileToMove.Add(potentialMod);
                    //check all folders in mod folder
                    //...

                    if (Directory.Exists(txtDirectory.Text + @"\mods\1.12.2"))
                    {
                        //check all files in version folder
                        foreach (string potentialMod in Directory.GetFiles(txtDirectory.Text + @"\mods\1.12.2"))
                            fileToMove.Add(potentialMod);

                        //check all folders in version folder
                        //...
                    }

                    //Find ideal backup location. 
                    //If it exists in the backup directory, insert a (copy). 
                    //Move file
                    //add support for moving folders as well as files
                    foreach (string modToBackup in fileToMove.ToArray())
                    {
                        string backupLocation = "";
                        if (modToBackup.Contains("1.12.2"))
                        {
                            backupLocation = oldModsDirectory + @"\1.12.2" + modToBackup.Remove(0, modToBackup.LastIndexOf(@"\"));
                        }
                        else
                        {
                            backupLocation = oldModsDirectory + modToBackup.Remove(0, modToBackup.LastIndexOf(@"\"));
                        }

                        while (File.Exists(backupLocation))
                        {
                            backupLocation = backupLocation.Insert(backupLocation.LastIndexOf("."), "(Copy)");
                        }
                        Directory.Move(modToBackup, backupLocation);
                        txtEventLog.Text += "\r\n:) Backed up " + modToBackup.Remove(0, modToBackup.LastIndexOf(@"\") + 1);
                    }

                    txtEventLog.Text += "\r\n:) All mods have been backed up.";
                }
                else
                {
                    txtEventLog.Text += "\r\n:/ Minecraft directory not found.";
                }
            }
            catch
            {
                txtEventLog.Text += "\r\n:/ Could not backup all mods, ensure Minecraft is not open, possible database error";
            }
        }

        private bool checkForMinecraftDir()
        {
            if (txtDirectory.Text.Contains(@"\"))
                if (txtDirectory.Text.Remove(0, txtDirectory.Text.LastIndexOf(@"\") + 1).Equals(".minecraft"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            else return false;
        }

        private void eventLogTextChange(object sender, EventArgs e)
        {
            txtEventLog.SelectionStart = txtEventLog.TextLength;
            txtEventLog.ScrollToCaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}