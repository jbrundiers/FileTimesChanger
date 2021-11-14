
namespace FileTimesChanger
{
    partial class mainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.tbCurrentCreationDate = new System.Windows.Forms.TextBox();
            this.tbCurrentAccessDate = new System.Windows.Forms.TextBox();
            this.tbCurrentLastWriteDate = new System.Windows.Forms.TextBox();
            this.lblCurrentCreationDate = new System.Windows.Forms.Label();
            this.lblCurrentAccessDate = new System.Windows.Forms.Label();
            this.lblCurrentLastWriteDate = new System.Windows.Forms.Label();
            this.cbSetCreationDate = new System.Windows.Forms.CheckBox();
            this.cbRecurseSubDirectories = new System.Windows.Forms.CheckBox();
            this.cbSetLastWriteDate = new System.Windows.Forms.CheckBox();
            this.cbSetLastAccessDate = new System.Windows.Forms.CheckBox();
            this.gbCurrentValues = new System.Windows.Forms.GroupBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTime = new System.Windows.Forms.DateTimePicker();
            this.listViewFiles = new System.Windows.Forms.ListView();
            this.columnHeaderFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.btnUpdateFileDate = new System.Windows.Forms.Button();
            this.gbFilepath = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSetoptions = new System.Windows.Forms.GroupBox();
            this.menuStrip.SuspendLayout();
            this.gbCurrentValues.SuspendLayout();
            this.gbFilepath.SuspendLayout();
            this.gbSetoptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemHelp});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(718, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileOpen,
            this.toolStripSeparator1,
            this.MenuItemFileExit});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "&File";
            // 
            // MenuItemFileOpen
            // 
            this.MenuItemFileOpen.Name = "MenuItemFileOpen";
            this.MenuItemFileOpen.Size = new System.Drawing.Size(115, 22);
            this.MenuItemFileOpen.Text = "&Open ...";
            this.MenuItemFileOpen.Click += new System.EventHandler(this.MenuItemFileOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
            // 
            // MenuItemFileExit
            // 
            this.MenuItemFileExit.Name = "MenuItemFileExit";
            this.MenuItemFileExit.Size = new System.Drawing.Size(115, 22);
            this.MenuItemFileExit.Text = "E&xit";
            this.MenuItemFileExit.Click += new System.EventHandler(this.MenuItemFileExit_Click);
            // 
            // MenuItemHelp
            // 
            this.MenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemHelpAbout});
            this.MenuItemHelp.Name = "MenuItemHelp";
            this.MenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuItemHelp.Text = "&Help";
            // 
            // MenuItemHelpAbout
            // 
            this.MenuItemHelpAbout.Name = "MenuItemHelpAbout";
            this.MenuItemHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.MenuItemHelpAbout.Text = "&About";
            this.MenuItemHelpAbout.Click += new System.EventHandler(this.MenuItemHelpAbout_Click);
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(69, 18);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(360, 20);
            this.tbFilePath.TabIndex = 1;
            this.tbFilePath.Leave += new System.EventHandler(this.tbFilePath_Leave);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(0, 16);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(63, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse ...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // tbCurrentCreationDate
            // 
            this.tbCurrentCreationDate.Location = new System.Drawing.Point(94, 19);
            this.tbCurrentCreationDate.Name = "tbCurrentCreationDate";
            this.tbCurrentCreationDate.ReadOnly = true;
            this.tbCurrentCreationDate.Size = new System.Drawing.Size(131, 20);
            this.tbCurrentCreationDate.TabIndex = 4;
            this.tbCurrentCreationDate.TabStop = false;
            // 
            // tbCurrentAccessDate
            // 
            this.tbCurrentAccessDate.Location = new System.Drawing.Point(94, 45);
            this.tbCurrentAccessDate.Name = "tbCurrentAccessDate";
            this.tbCurrentAccessDate.ReadOnly = true;
            this.tbCurrentAccessDate.Size = new System.Drawing.Size(131, 20);
            this.tbCurrentAccessDate.TabIndex = 5;
            this.tbCurrentAccessDate.TabStop = false;
            // 
            // tbCurrentLastWriteDate
            // 
            this.tbCurrentLastWriteDate.Location = new System.Drawing.Point(94, 71);
            this.tbCurrentLastWriteDate.Name = "tbCurrentLastWriteDate";
            this.tbCurrentLastWriteDate.ReadOnly = true;
            this.tbCurrentLastWriteDate.Size = new System.Drawing.Size(131, 20);
            this.tbCurrentLastWriteDate.TabIndex = 6;
            this.tbCurrentLastWriteDate.TabStop = false;
            // 
            // lblCurrentCreationDate
            // 
            this.lblCurrentCreationDate.AutoSize = true;
            this.lblCurrentCreationDate.Location = new System.Drawing.Point(6, 22);
            this.lblCurrentCreationDate.Name = "lblCurrentCreationDate";
            this.lblCurrentCreationDate.Size = new System.Drawing.Size(73, 13);
            this.lblCurrentCreationDate.TabIndex = 7;
            this.lblCurrentCreationDate.Text = "Creation date:";
            // 
            // lblCurrentAccessDate
            // 
            this.lblCurrentAccessDate.AutoSize = true;
            this.lblCurrentAccessDate.Location = new System.Drawing.Point(6, 48);
            this.lblCurrentAccessDate.Name = "lblCurrentAccessDate";
            this.lblCurrentAccessDate.Size = new System.Drawing.Size(69, 13);
            this.lblCurrentAccessDate.TabIndex = 8;
            this.lblCurrentAccessDate.Text = "Access date:";
            // 
            // lblCurrentLastWriteDate
            // 
            this.lblCurrentLastWriteDate.AutoSize = true;
            this.lblCurrentLastWriteDate.Location = new System.Drawing.Point(6, 74);
            this.lblCurrentLastWriteDate.Name = "lblCurrentLastWriteDate";
            this.lblCurrentLastWriteDate.Size = new System.Drawing.Size(82, 13);
            this.lblCurrentLastWriteDate.TabIndex = 9;
            this.lblCurrentLastWriteDate.Text = "Last Write date:";
            // 
            // cbSetCreationDate
            // 
            this.cbSetCreationDate.AutoSize = true;
            this.cbSetCreationDate.Location = new System.Drawing.Point(15, 19);
            this.cbSetCreationDate.Name = "cbSetCreationDate";
            this.cbSetCreationDate.Size = new System.Drawing.Size(110, 17);
            this.cbSetCreationDate.TabIndex = 10;
            this.cbSetCreationDate.Text = "Set Creation Date";
            this.cbSetCreationDate.UseVisualStyleBackColor = true;
            // 
            // cbRecurseSubDirectories
            // 
            this.cbRecurseSubDirectories.AutoSize = true;
            this.cbRecurseSubDirectories.Location = new System.Drawing.Point(15, 85);
            this.cbRecurseSubDirectories.Name = "cbRecurseSubDirectories";
            this.cbRecurseSubDirectories.Size = new System.Drawing.Size(141, 17);
            this.cbRecurseSubDirectories.TabIndex = 11;
            this.cbRecurseSubDirectories.Text = "Recurse Sub-Directories";
            this.cbRecurseSubDirectories.UseVisualStyleBackColor = true;
            // 
            // cbSetLastWriteDate
            // 
            this.cbSetLastWriteDate.AutoSize = true;
            this.cbSetLastWriteDate.Location = new System.Drawing.Point(15, 62);
            this.cbSetLastWriteDate.Name = "cbSetLastWriteDate";
            this.cbSetLastWriteDate.Size = new System.Drawing.Size(119, 17);
            this.cbSetLastWriteDate.TabIndex = 12;
            this.cbSetLastWriteDate.Text = "Set Last Write Date";
            this.cbSetLastWriteDate.UseVisualStyleBackColor = true;
            // 
            // cbSetLastAccessDate
            // 
            this.cbSetLastAccessDate.AutoSize = true;
            this.cbSetLastAccessDate.Location = new System.Drawing.Point(15, 39);
            this.cbSetLastAccessDate.Name = "cbSetLastAccessDate";
            this.cbSetLastAccessDate.Size = new System.Drawing.Size(129, 17);
            this.cbSetLastAccessDate.TabIndex = 13;
            this.cbSetLastAccessDate.Text = "Set Last Access Date";
            this.cbSetLastAccessDate.UseVisualStyleBackColor = true;
            // 
            // gbCurrentValues
            // 
            this.gbCurrentValues.Controls.Add(this.tbCurrentCreationDate);
            this.gbCurrentValues.Controls.Add(this.tbCurrentAccessDate);
            this.gbCurrentValues.Controls.Add(this.tbCurrentLastWriteDate);
            this.gbCurrentValues.Controls.Add(this.lblCurrentCreationDate);
            this.gbCurrentValues.Controls.Add(this.lblCurrentAccessDate);
            this.gbCurrentValues.Controls.Add(this.lblCurrentLastWriteDate);
            this.gbCurrentValues.Location = new System.Drawing.Point(467, 27);
            this.gbCurrentValues.Name = "gbCurrentValues";
            this.gbCurrentValues.Size = new System.Drawing.Size(235, 100);
            this.gbCurrentValues.TabIndex = 14;
            this.gbCurrentValues.TabStop = false;
            this.gbCurrentValues.Text = "Current values:";
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.Location = new System.Drawing.Point(192, 376);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.ShowUpDown = true;
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 15;
            // 
            // dateTimePickerTime
            // 
            this.dateTimePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerTime.Location = new System.Drawing.Point(398, 376);
            this.dateTimePickerTime.Name = "dateTimePickerTime";
            this.dateTimePickerTime.ShowUpDown = true;
            this.dateTimePickerTime.Size = new System.Drawing.Size(71, 20);
            this.dateTimePickerTime.TabIndex = 16;
            // 
            // listViewFiles
            // 
            this.listViewFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFilename,
            this.columnHeaderType});
            this.listViewFiles.FullRowSelect = true;
            this.listViewFiles.HideSelection = false;
            this.listViewFiles.LabelWrap = false;
            this.listViewFiles.LargeImageList = this.imageList;
            this.listViewFiles.Location = new System.Drawing.Point(6, 44);
            this.listViewFiles.Name = "listViewFiles";
            this.listViewFiles.Size = new System.Drawing.Size(423, 260);
            this.listViewFiles.SmallImageList = this.imageList;
            this.listViewFiles.TabIndex = 17;
            this.listViewFiles.UseCompatibleStateImageBehavior = false;
            this.listViewFiles.View = System.Windows.Forms.View.List;
            this.listViewFiles.SelectedIndexChanged += new System.EventHandler(this.listViewFiles_SelectedIndexChanged);
            // 
            // columnHeaderFilename
            // 
            this.columnHeaderFilename.Text = "Filename";
            this.columnHeaderFilename.Width = 250;
            // 
            // columnHeaderType
            // 
            this.columnHeaderType.Width = 5;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "FOLDER.ICO");
            this.imageList.Images.SetKeyName(1, "File.ico");
            // 
            // btnUpdateFileDate
            // 
            this.btnUpdateFileDate.Location = new System.Drawing.Point(280, 411);
            this.btnUpdateFileDate.Name = "btnUpdateFileDate";
            this.btnUpdateFileDate.Size = new System.Drawing.Size(171, 23);
            this.btnUpdateFileDate.TabIndex = 18;
            this.btnUpdateFileDate.Text = "Update File Dates";
            this.btnUpdateFileDate.UseMnemonic = false;
            this.btnUpdateFileDate.UseVisualStyleBackColor = true;
            this.btnUpdateFileDate.Click += new System.EventHandler(this.btnUpdateFileDate_Click);
            // 
            // gbFilepath
            // 
            this.gbFilepath.Controls.Add(this.label1);
            this.gbFilepath.Controls.Add(this.btnBrowse);
            this.gbFilepath.Controls.Add(this.tbFilePath);
            this.gbFilepath.Controls.Add(this.listViewFiles);
            this.gbFilepath.Location = new System.Drawing.Point(12, 27);
            this.gbFilepath.Name = "gbFilepath";
            this.gbFilepath.Size = new System.Drawing.Size(439, 329);
            this.gbFilepath.TabIndex = 19;
            this.gbFilepath.TabStop = false;
            this.gbFilepath.Text = "File path:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Select files and/or directories to change.";
            // 
            // gbSetoptions
            // 
            this.gbSetoptions.Controls.Add(this.cbRecurseSubDirectories);
            this.gbSetoptions.Controls.Add(this.cbSetLastWriteDate);
            this.gbSetoptions.Controls.Add(this.cbSetLastAccessDate);
            this.gbSetoptions.Controls.Add(this.cbSetCreationDate);
            this.gbSetoptions.Location = new System.Drawing.Point(467, 239);
            this.gbSetoptions.Name = "gbSetoptions";
            this.gbSetoptions.Size = new System.Drawing.Size(235, 105);
            this.gbSetoptions.TabIndex = 20;
            this.gbSetoptions.TabStop = false;
            this.gbSetoptions.Text = "Options";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 445);
            this.Controls.Add(this.gbSetoptions);
            this.Controls.Add(this.gbFilepath);
            this.Controls.Add(this.btnUpdateFileDate);
            this.Controls.Add(this.dateTimePickerTime);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.gbCurrentValues);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "mainForm";
            this.Text = "File Dates Changer";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.gbCurrentValues.ResumeLayout(false);
            this.gbCurrentValues.PerformLayout();
            this.gbFilepath.ResumeLayout(false);
            this.gbFilepath.PerformLayout();
            this.gbSetoptions.ResumeLayout(false);
            this.gbSetoptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemFileExit;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHelpAbout;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox tbCurrentCreationDate;
        private System.Windows.Forms.TextBox tbCurrentAccessDate;
        private System.Windows.Forms.Label lblCurrentCreationDate;
        private System.Windows.Forms.Label lblCurrentAccessDate;
        private System.Windows.Forms.Label lblCurrentLastWriteDate;
        private System.Windows.Forms.CheckBox cbSetCreationDate;
        private System.Windows.Forms.CheckBox cbRecurseSubDirectories;
        private System.Windows.Forms.CheckBox cbSetLastWriteDate;
        private System.Windows.Forms.CheckBox cbSetLastAccessDate;
        private System.Windows.Forms.GroupBox gbCurrentValues;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerTime;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.ColumnHeader columnHeaderFilename;
        private System.Windows.Forms.ColumnHeader columnHeaderType;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Button btnUpdateFileDate;
        private System.Windows.Forms.GroupBox gbFilepath;
        private System.Windows.Forms.GroupBox gbSetoptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCurrentLastWriteDate;
    }
}

