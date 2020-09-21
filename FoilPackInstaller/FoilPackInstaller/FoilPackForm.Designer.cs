using System;
using System.Windows.Forms;

namespace FoilPackInstaller
{
    partial class FoilPackForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoilPackForm));
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtModSauce = new System.Windows.Forms.RichTextBox();
            this.lblDivider2 = new System.Windows.Forms.Label();
            this.lblModDescription = new System.Windows.Forms.Label();
            this.lblDivider1 = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.panelModList = new System.Windows.Forms.Panel();
            this.panelInstaller = new System.Windows.Forms.Panel();
            this.panelInstallerSettings = new System.Windows.Forms.Panel();
            this.lblComingSoon = new System.Windows.Forms.Label();
            this.btnBackupMods = new System.Windows.Forms.Button();
            this.btnInstallForge = new System.Windows.Forms.Button();
            this.btnGuessDirectory = new System.Windows.Forms.Button();
            this.lblDivider4 = new System.Windows.Forms.Label();
            this.lblInstallerSettings = new System.Windows.Forms.Label();
            this.lblDivider3 = new System.Windows.Forms.Label();
            this.lblDirectory = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.btnDownloadSelected = new System.Windows.Forms.Button();
            this.lblModTitle = new System.Windows.Forms.Label();
            this.lblInfoTitle = new System.Windows.Forms.Label();
            this.lblInstallerTitle = new System.Windows.Forms.Label();
            this.btnDownload = new System.Windows.Forms.Button();
            this.panelSelectedList = new System.Windows.Forms.Panel();
            this.txtEventLog = new System.Windows.Forms.TextBox();
            this.panelInfo.SuspendLayout();
            this.panelInstaller.SuspendLayout();
            this.panelInstallerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelInfo.AutoScroll = true;
            this.panelInfo.BackColor = System.Drawing.Color.Gray;
            this.panelInfo.Controls.Add(this.txtModSauce);
            this.panelInfo.Controls.Add(this.lblDivider2);
            this.panelInfo.Controls.Add(this.lblModDescription);
            this.panelInfo.Controls.Add(this.lblDivider1);
            this.panelInfo.Controls.Add(this.lblModName);
            this.panelInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelInfo.ForeColor = System.Drawing.Color.Black;
            this.panelInfo.Location = new System.Drawing.Point(157, 62);
            this.panelInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(287, 381);
            this.panelInfo.TabIndex = 1;
            // 
            // txtModSauce
            // 
            this.txtModSauce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtModSauce.BackColor = System.Drawing.Color.Gray;
            this.txtModSauce.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModSauce.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtModSauce.Location = new System.Drawing.Point(30, 308);
            this.txtModSauce.Margin = new System.Windows.Forms.Padding(30, 6, 30, 6);
            this.txtModSauce.Name = "txtModSauce";
            this.txtModSauce.ReadOnly = true;
            this.txtModSauce.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtModSauce.Size = new System.Drawing.Size(227, 67);
            this.txtModSauce.TabIndex = 0;
            this.txtModSauce.Text = "Sauces";
            this.txtModSauce.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.openLink);
            // 
            // lblDivider2
            // 
            this.lblDivider2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDivider2.BackColor = System.Drawing.Color.Gray;
            this.lblDivider2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivider2.Location = new System.Drawing.Point(0, 294);
            this.lblDivider2.Margin = new System.Windows.Forms.Padding(6);
            this.lblDivider2.Name = "lblDivider2";
            this.lblDivider2.Size = new System.Drawing.Size(287, 2);
            this.lblDivider2.TabIndex = 3;
            // 
            // lblModDescription
            // 
            this.lblModDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModDescription.BackColor = System.Drawing.Color.Gray;
            this.lblModDescription.Location = new System.Drawing.Point(30, 38);
            this.lblModDescription.Margin = new System.Windows.Forms.Padding(30, 30, 30, 6);
            this.lblModDescription.Name = "lblModDescription";
            this.lblModDescription.Size = new System.Drawing.Size(227, 244);
            this.lblModDescription.TabIndex = 2;
            this.lblModDescription.Text = "Hover over a mod to see its description.";
            // 
            // lblDivider1
            // 
            this.lblDivider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider1.BackColor = System.Drawing.Color.Gray;
            this.lblDivider1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivider1.Location = new System.Drawing.Point(0, 30);
            this.lblDivider1.Margin = new System.Windows.Forms.Padding(0);
            this.lblDivider1.Name = "lblDivider1";
            this.lblDivider1.Size = new System.Drawing.Size(287, 2);
            this.lblDivider1.TabIndex = 1;
            // 
            // lblModName
            // 
            this.lblModName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblModName.BackColor = System.Drawing.Color.Gray;
            this.lblModName.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblModName.ForeColor = System.Drawing.Color.Black;
            this.lblModName.Location = new System.Drawing.Point(0, 0);
            this.lblModName.Margin = new System.Windows.Forms.Padding(0);
            this.lblModName.Name = "lblModName";
            this.lblModName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblModName.Size = new System.Drawing.Size(287, 30);
            this.lblModName.TabIndex = 0;
            this.lblModName.Text = "FoilPack Installer";
            this.lblModName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelModList
            // 
            this.panelModList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelModList.AutoScroll = true;
            this.panelModList.BackColor = System.Drawing.Color.Gray;
            this.panelModList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelModList.ForeColor = System.Drawing.Color.Black;
            this.panelModList.Location = new System.Drawing.Point(11, 62);
            this.panelModList.Margin = new System.Windows.Forms.Padding(2);
            this.panelModList.Name = "panelModList";
            this.panelModList.Size = new System.Drawing.Size(142, 381);
            this.panelModList.TabIndex = 2;
            // 
            // panelInstaller
            // 
            this.panelInstaller.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInstaller.AutoScroll = true;
            this.panelInstaller.BackColor = System.Drawing.Color.Gray;
            this.panelInstaller.Controls.Add(this.panelInstallerSettings);
            this.panelInstaller.Controls.Add(this.btnGuessDirectory);
            this.panelInstaller.Controls.Add(this.lblDivider4);
            this.panelInstaller.Controls.Add(this.lblInstallerSettings);
            this.panelInstaller.Controls.Add(this.lblDivider3);
            this.panelInstaller.Controls.Add(this.lblDirectory);
            this.panelInstaller.Controls.Add(this.txtDirectory);
            this.panelInstaller.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelInstaller.ForeColor = System.Drawing.Color.Black;
            this.panelInstaller.Location = new System.Drawing.Point(594, 62);
            this.panelInstaller.Margin = new System.Windows.Forms.Padding(2);
            this.panelInstaller.Name = "panelInstaller";
            this.panelInstaller.Size = new System.Drawing.Size(334, 330);
            this.panelInstaller.TabIndex = 2;
            this.panelInstaller.Tag = "";
            // 
            // panelInstallerSettings
            // 
            this.panelInstallerSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelInstallerSettings.BackColor = System.Drawing.Color.Gray;
            this.panelInstallerSettings.Controls.Add(this.lblComingSoon);
            this.panelInstallerSettings.Controls.Add(this.btnBackupMods);
            this.panelInstallerSettings.Controls.Add(this.btnInstallForge);
            this.panelInstallerSettings.Location = new System.Drawing.Point(3, 93);
            this.panelInstallerSettings.Name = "panelInstallerSettings";
            this.panelInstallerSettings.Size = new System.Drawing.Size(328, 234);
            this.panelInstallerSettings.TabIndex = 15;
            // 
            // lblComingSoon
            // 
            this.lblComingSoon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComingSoon.BackColor = System.Drawing.Color.Gray;
            this.lblComingSoon.Location = new System.Drawing.Point(0, 60);
            this.lblComingSoon.Name = "lblComingSoon";
            this.lblComingSoon.Size = new System.Drawing.Size(328, 30);
            this.lblComingSoon.TabIndex = 16;
            this.lblComingSoon.Text = "More Features Coming Soon";
            this.lblComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBackupMods
            // 
            this.btnBackupMods.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBackupMods.BackColor = System.Drawing.Color.Gray;
            this.btnBackupMods.FlatAppearance.BorderSize = 0;
            this.btnBackupMods.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackupMods.Location = new System.Drawing.Point(0, 30);
            this.btnBackupMods.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackupMods.Name = "btnBackupMods";
            this.btnBackupMods.Size = new System.Drawing.Size(328, 30);
            this.btnBackupMods.TabIndex = 11;
            this.btnBackupMods.Text = "Backup Mods Folder";
            this.btnBackupMods.UseVisualStyleBackColor = false;
            this.btnBackupMods.Click += new System.EventHandler(this.backUpAllMods);
            // 
            // btnInstallForge
            // 
            this.btnInstallForge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInstallForge.BackColor = System.Drawing.Color.Gray;
            this.btnInstallForge.FlatAppearance.BorderSize = 0;
            this.btnInstallForge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallForge.Location = new System.Drawing.Point(0, 0);
            this.btnInstallForge.Margin = new System.Windows.Forms.Padding(0);
            this.btnInstallForge.Name = "btnInstallForge";
            this.btnInstallForge.Size = new System.Drawing.Size(328, 30);
            this.btnInstallForge.TabIndex = 10;
            this.btnInstallForge.Text = "Install Forge";
            this.btnInstallForge.UseVisualStyleBackColor = false;
            this.btnInstallForge.Click += new System.EventHandler(this.installForge);
            // 
            // btnGuessDirectory
            // 
            this.btnGuessDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuessDirectory.BackColor = System.Drawing.Color.Gray;
            this.btnGuessDirectory.FlatAppearance.BorderSize = 0;
            this.btnGuessDirectory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuessDirectory.Location = new System.Drawing.Point(253, 32);
            this.btnGuessDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnGuessDirectory.Name = "btnGuessDirectory";
            this.btnGuessDirectory.Size = new System.Drawing.Size(79, 26);
            this.btnGuessDirectory.TabIndex = 11;
            this.btnGuessDirectory.Text = "Guess";
            this.btnGuessDirectory.UseVisualStyleBackColor = false;
            this.btnGuessDirectory.Click += new System.EventHandler(this.guessMinecraftDirectory);
            // 
            // lblDivider4
            // 
            this.lblDivider4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivider4.Location = new System.Drawing.Point(0, 88);
            this.lblDivider4.Margin = new System.Windows.Forms.Padding(0);
            this.lblDivider4.Name = "lblDivider4";
            this.lblDivider4.Size = new System.Drawing.Size(334, 2);
            this.lblDivider4.TabIndex = 6;
            // 
            // lblInstallerSettings
            // 
            this.lblInstallerSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstallerSettings.BackColor = System.Drawing.Color.Gray;
            this.lblInstallerSettings.Location = new System.Drawing.Point(0, 60);
            this.lblInstallerSettings.Name = "lblInstallerSettings";
            this.lblInstallerSettings.Size = new System.Drawing.Size(334, 30);
            this.lblInstallerSettings.TabIndex = 5;
            this.lblInstallerSettings.Text = "Installer Settings";
            this.lblInstallerSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDivider3
            // 
            this.lblDivider3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDivider3.BackColor = System.Drawing.Color.Gray;
            this.lblDivider3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDivider3.Location = new System.Drawing.Point(0, 30);
            this.lblDivider3.Margin = new System.Windows.Forms.Padding(0);
            this.lblDivider3.Name = "lblDivider3";
            this.lblDivider3.Size = new System.Drawing.Size(334, 2);
            this.lblDivider3.TabIndex = 4;
            // 
            // lblDirectory
            // 
            this.lblDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDirectory.BackColor = System.Drawing.Color.Gray;
            this.lblDirectory.Location = new System.Drawing.Point(0, 0);
            this.lblDirectory.Name = "lblDirectory";
            this.lblDirectory.Size = new System.Drawing.Size(334, 30);
            this.lblDirectory.TabIndex = 1;
            this.lblDirectory.Text = "Minecraft Directory";
            this.lblDirectory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDirectory
            // 
            this.txtDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDirectory.BackColor = System.Drawing.Color.Gray;
            this.txtDirectory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDirectory.Location = new System.Drawing.Point(8, 37);
            this.txtDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.ReadOnly = true;
            this.txtDirectory.Size = new System.Drawing.Size(241, 16);
            this.txtDirectory.TabIndex = 0;
            this.txtDirectory.Text = "Click here to change directory";
            this.txtDirectory.Click += new System.EventHandler(this.browseAndSetDirectory);
            // 
            // btnDownloadSelected
            // 
            this.btnDownloadSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDownloadSelected.BackColor = System.Drawing.Color.Gray;
            this.btnDownloadSelected.FlatAppearance.BorderSize = 0;
            this.btnDownloadSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownloadSelected.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnDownloadSelected.Location = new System.Drawing.Point(448, 396);
            this.btnDownloadSelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownloadSelected.Name = "btnDownloadSelected";
            this.btnDownloadSelected.Size = new System.Drawing.Size(142, 47);
            this.btnDownloadSelected.TabIndex = 5;
            this.btnDownloadSelected.Text = "Download/Update Selected Mods";
            this.btnDownloadSelected.UseVisualStyleBackColor = false;
            this.btnDownloadSelected.Click += new System.EventHandler(this.downloadSelectedMods);
            // 
            // lblModTitle
            // 
            this.lblModTitle.BackColor = System.Drawing.Color.Gray;
            this.lblModTitle.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblModTitle.ForeColor = System.Drawing.Color.Black;
            this.lblModTitle.Location = new System.Drawing.Point(11, 11);
            this.lblModTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblModTitle.Name = "lblModTitle";
            this.lblModTitle.Size = new System.Drawing.Size(142, 47);
            this.lblModTitle.TabIndex = 1;
            this.lblModTitle.Text = "FoilPack Mods";
            this.lblModTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfoTitle
            // 
            this.lblInfoTitle.BackColor = System.Drawing.Color.Gray;
            this.lblInfoTitle.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblInfoTitle.ForeColor = System.Drawing.Color.Black;
            this.lblInfoTitle.Location = new System.Drawing.Point(157, 11);
            this.lblInfoTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblInfoTitle.Name = "lblInfoTitle";
            this.lblInfoTitle.Size = new System.Drawing.Size(287, 47);
            this.lblInfoTitle.TabIndex = 3;
            this.lblInfoTitle.Text = "Mod Information";
            this.lblInfoTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInstallerTitle
            // 
            this.lblInstallerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInstallerTitle.BackColor = System.Drawing.Color.Gray;
            this.lblInstallerTitle.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.lblInstallerTitle.ForeColor = System.Drawing.Color.Black;
            this.lblInstallerTitle.Location = new System.Drawing.Point(448, 11);
            this.lblInstallerTitle.Margin = new System.Windows.Forms.Padding(2);
            this.lblInstallerTitle.Name = "lblInstallerTitle";
            this.lblInstallerTitle.Size = new System.Drawing.Size(480, 47);
            this.lblInstallerTitle.TabIndex = 4;
            this.lblInstallerTitle.Text = "FoilPack Installer";
            this.lblInstallerTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDownload.BackColor = System.Drawing.Color.Gray;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Bahnschrift", 10F);
            this.btnDownload.Location = new System.Drawing.Point(594, 396);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(334, 47);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download/Update All Mods";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.downloadAllMods);
            // 
            // panelSelectedList
            // 
            this.panelSelectedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSelectedList.AutoScroll = true;
            this.panelSelectedList.BackColor = System.Drawing.Color.Gray;
            this.panelSelectedList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panelSelectedList.ForeColor = System.Drawing.Color.Black;
            this.panelSelectedList.Location = new System.Drawing.Point(448, 62);
            this.panelSelectedList.Margin = new System.Windows.Forms.Padding(2);
            this.panelSelectedList.Name = "panelSelectedList";
            this.panelSelectedList.Size = new System.Drawing.Size(142, 330);
            this.panelSelectedList.TabIndex = 3;
            // 
            // txtEventLog
            // 
            this.txtEventLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEventLog.BackColor = System.Drawing.Color.Gray;
            this.txtEventLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEventLog.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtEventLog.Location = new System.Drawing.Point(11, 447);
            this.txtEventLog.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventLog.Multiline = true;
            this.txtEventLog.Name = "txtEventLog";
            this.txtEventLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEventLog.Size = new System.Drawing.Size(917, 57);
            this.txtEventLog.TabIndex = 6;
            this.txtEventLog.TextChanged += new System.EventHandler(this.eventLogTextChange);
            // 
            // FoilPackForm
            // 
            this.AccessibleDescription = "Installs all mods from the best modpack ever made.";
            this.AccessibleName = "FoilPack Installer";
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(939, 515);
            this.Controls.Add(this.txtEventLog);
            this.Controls.Add(this.btnDownloadSelected);
            this.Controls.Add(this.panelSelectedList);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.lblInstallerTitle);
            this.Controls.Add(this.lblInfoTitle);
            this.Controls.Add(this.lblModTitle);
            this.Controls.Add(this.panelModList);
            this.Controls.Add(this.panelInstaller);
            this.Controls.Add(this.panelInfo);
            this.Font = new System.Drawing.Font("Bahnschrift", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(16, 290);
            this.Name = "FoilPackForm";
            this.Text = "FoilPack Installer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelInfo.ResumeLayout(false);
            this.panelInstaller.ResumeLayout(false);
            this.panelInstaller.PerformLayout();
            this.panelInstallerSettings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion
        private System.Windows.Forms.Panel panelInfo;
        private Panel panelModList;
        private Panel panelInstaller;
        private Label lblModTitle;
        private Label lblInfoTitle;
        private Label lblInstallerTitle;
        private Label lblDivider1;
        private Button btnDownload;
        private Label lblModDescription;
        private Label lblDivider2;
        private RichTextBox txtModSauce;
        private Button btnDownloadSelected;
        private Panel panelSelectedList;
        private Label lblModName;
        private Label lblDirectory;
        private TextBox txtDirectory;
        private Label lblDivider3;
        private Label lblInstallerSettings;
        private Label lblDivider4;
        private Button btnInstallForge;
        private Button btnGuessDirectory;
        private Panel panelInstallerSettings;
        private TextBox txtEventLog;
        private Button btnBackupMods;
        private Label lblComingSoon;
    }
}

