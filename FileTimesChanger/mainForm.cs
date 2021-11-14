using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileTimesChanger
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void MenuItemHelp_Click(object sender, EventArgs e)
        {

        }

        private void MenuItemHelpAbout_Click(object sender, EventArgs e)
        {
            // Instantiate window
            AboutBox dlg = new AboutBox();

            // Show window modally
            // NOTE: Returns only when window is closed
            dlg.ShowDialog();
        }

        private void MenuItemFileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuItemFileOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFile();
		}


		/// <summary>
		/// Count of the number of files/directories that have been set
		/// </summary>
		private int itemsSetCount;

		/// <summary>
		/// Count of the number of system or hidden files skipped
		/// </summary>
		private int itemsSkippedCount;

		/// <summary>
		/// Count of the number of files/directories that have errors seting the date/time
		/// </summary>
		private int itemsErrorsCount;

		/// <summary>
		/// Display the Folder Browser Dialog and then display the selected
		/// file path and the directories and files in the folder.
		/// </summary>
		private void OpenFile()
		{
			FolderBrowserDialog openFile = new FolderBrowserDialog();
			openFile.ShowNewFolderButton = false;
			try
			{
				if (tbFilePath.Text != "")
				{
					// Dislay the previous path in the dialog if one 
					// was selected
					openFile.SelectedPath = tbFilePath.Text;
				}
				// Open the folder browser dialog
				openFile.Description = "Select the folder with the files you want to view/change the file times";
				if (openFile.ShowDialog() == DialogResult.OK)
				{
					// Display the folder path
					string directoryName = openFile.SelectedPath;
					tbFilePath.Text = directoryName;
					DisplayFilesList(directoryName);
				}
			}
			catch (Exception ex)
			{
				// if we have an error then clear the window
				tbFilePath.Text = "";
				listViewFiles.Items.Clear();
				tbCurrentCreationDate.Text = "";
				tbCurrentAccessDate.Text = "";
				tbCurrentLastWriteDate.Text = "";
				// display an error message
				MessageBox.Show("Error selecting file: \r\n\r\n" + ex.Message,
					"Open File Error", MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
			finally
			{
				// In testing there we a few times where we seemed to need this
				openFile.Dispose();
			}
		}

		/// <summary>
		/// Display file and directories in the list box
		/// </summary>
		/// <param name="DirectoryName">Path to the directory</param>
		private void DisplayFilesList(string DirectoryName)
		{
			listViewFiles.Items.Clear();
			// Display all the sub directories using the folder icon
			foreach (string subDirectory in Directory.GetDirectories(DirectoryName))
			{
				// The method used below to reset the last access date/time of files does not appear to 
				// work with directories. Hence the last access date/time gets updated to when the 
				// FolderBrowser looked at the directory.
				// JB listViewFiles.Items.Add(Path.GetFileName(subDirectory), (int)ListViewIcon.Directory);
				listViewFiles.Items.Add(Path.GetFileName(subDirectory), 0);
				
			}
			// Display all of the files using the file icon
			foreach (string file in Directory.GetFiles(DirectoryName))
			{
				if (!((File.GetAttributes(file) & FileAttributes.Hidden) == FileAttributes.Hidden))
				{
					// When Path.GetFileName is called the last access date/time is updated on the file. 
					// Hence we save the last access date/time and the reset it to the old last.
					// access date/time after the call.
					DateTime accessTime = File.GetLastAccessTime(file);
					//JB listViewFiles.Items.Add(Path.GetFileName(file), (int)ListViewIcon.File);
					listViewFiles.Items.Add(Path.GetFileName(file), 1);
					try
					{
						File.SetLastAccessTime(file, accessTime);
					}
					catch { } // Do nothing
				}
			}
		}

		/// <summary>
		/// The ListView selection has changed
		/// </summary>
		/// <param name="sender">listView_Files</param>
		/// <param name="e">EventArgs</param>
		private void listViewFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
			UpdateButtonEnable();
			UpdateDisplayFileDateTime();


		}

		/// <summary>
		/// Only enable the update button if something is selected
		/// </summary>
		private void UpdateButtonEnable()
		{
			btnUpdateFileDate.Enabled = ((listViewFiles.SelectedItems.Count > 0) &
				(cbSetCreationDate.Checked | cbSetLastAccessDate.Checked |cbSetLastWriteDate.Checked));
		}

        private void btnUpdateFileDate_Click(object sender, EventArgs e)
        {
			UpdateDateTime();
		}

		/// <summary>
		/// Display the date and time of the selected file
		/// (Also works on directories)
		/// </summary>
		private void UpdateDisplayFileDateTime()
		{
			if (listViewFiles.SelectedItems.Count == 1)
			{
				// If we have one file/directory selected display its date/time
				string fileName = tbFilePath.Text + "\\" + listViewFiles.SelectedItems[0].Text;
				tbCurrentCreationDate.Text = File.GetCreationTime(fileName).ToString();
				tbCurrentAccessDate.Text = File.GetLastAccessTime(fileName).ToString();
				tbCurrentLastWriteDate.Text = File.GetLastWriteTime(fileName).ToString();
			}
			else
			{
				// Either no file/directory is selected
				// or more than one file/directory is selected.
				// In these cases it would be confusing to display the date/time.
				tbCurrentCreationDate.Text = "";
				tbCurrentAccessDate.Text = "";
				tbCurrentLastWriteDate.Text = "";

				
			}
		}

		/// <summary>
		/// Update all the files selected in the list box 
		/// </summary>
		private void UpdateDateTime()
		{

			//DateTime fileDateTime = DateTime.Parse(dateTimePicker_Date.Value.Date.ToString() +
			//					" " + dateTimePicker_Hour.Value.Hour + ":" +
			//	dateTimePicker_Minutes.Value.Minute + ":" +
			//	dateTimePicker_Seconds.Value.Second);
			DateTime fileDateTime = dateTimePickerDate.Value.Date;

			fileDateTime = fileDateTime.AddHours(dateTimePickerTime.Value.Hour);
			fileDateTime = fileDateTime.AddMinutes(dateTimePickerTime.Value.Minute);
			fileDateTime = fileDateTime.AddSeconds(dateTimePickerTime.Value.Second);

			itemsSetCount = 0;
			itemsSkippedCount = 0;
			itemsErrorsCount = 0;
			foreach (ListViewItem file in listViewFiles.SelectedItems)
			{
				string fileName;
				fileName = Path.Combine(tbFilePath.Text, file.Text);
				//if ((file.ImageIndex == (int)ListViewIcon.Directory) & checkBox_Recurse.Checked)
				if ((file.ImageIndex == 1) & cbRecurseSubDirectories.Checked)
				{
					// If the item is a directory (flaged by the image index) 
					// and recurse subdirectories is selected
					RecurseSubDirectory(fileName, fileDateTime);
				}
				//SetFileDateTime(fileName, fileDateTime, (file.ImageIndex == (int)ListViewIcon.Directory)); 
				SetFileDateTime(fileName, fileDateTime, (file.ImageIndex == 1));
			}
			string message = itemsSetCount.ToString() + " file(s)/directorie(s) have had there date/time set";
			if (itemsErrorsCount > 0)
			{
				message += "\r\n\r\n There were " + itemsErrorsCount.ToString() + " error(s)";
			}
			if (itemsSkippedCount > 0)
			{
				message += "\r\n\r\n There were " + itemsSkippedCount.ToString() + " system or hidded files/directories skipped.";
			}
			MessageBox.Show(message, "Date/Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
			// Set file display date/time
			tbCurrentCreationDate.Text = fileDateTime.ToString();
			tbCurrentAccessDate.Text = fileDateTime.ToString();
			tbCurrentLastWriteDate.Text = fileDateTime.ToString();
		}

		/// <summary>
		/// Set the date/time to all files is a sub directory
		/// </summary>
		/// <param name="DirectoryPath">Full path to the directory</param>
		/// <param name="FileTime">File Date/Time</param>
		private void RecurseSubDirectory(string DirectoryPath, DateTime FileTime)
		{
			// Set the date/time for each sub directory
			foreach (string subDirectory in Directory.GetDirectories(DirectoryPath))
			{
				// Loop through each sub-sub directory
				RecurseSubDirectory(subDirectory, FileTime);
				// Set the date/time for the sub directory
				SetFileDateTime(subDirectory, FileTime, true);
			}
			// Set the date/time for each file
			foreach (string file in Directory.GetFiles(DirectoryPath))
			{
				SetFileDateTime(file, FileTime, false);
			}
		}

		/// <summary>
		/// Set the date/time for a given file/directory
		/// (This works on files and directories)
		/// </summary>
		/// <param name="FilePath">Full path to the file/directory</param>
		/// <param name="FileTime">Date/Time to set the file/directory</param>
		/// <param name="IsDirectory">This path is a directory</param>
		private void SetFileDateTime(string FilePath, DateTime FileTime, bool IsDirectory)
		{
			try
			{
				FileAttributes fileAttributes = File.GetAttributes(FilePath);
				if ((fileAttributes & FileAttributes.Hidden) == FileAttributes.Hidden)
				{
					// Skip hidden files and directories 
					++itemsSkippedCount;
				}
				else if ((fileAttributes & FileAttributes.System) == FileAttributes.System)
				{
					// Skip system files and directories
					++itemsSkippedCount;
				}
				else if ((fileAttributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					MessageBox.Show("The file/directory '" + FilePath + "' is read only",
						"Date/Time", MessageBoxButtons.OK,
						MessageBoxIcon.Information);
				}
				else
				{
					// Set file creation date/time if selected
					if ( cbSetCreationDate.Checked)
					{
						if (IsDirectory)
						{
							Directory.SetCreationTime(FilePath, FileTime);
						}
						else
						{
							File.SetCreationTime(FilePath, FileTime);
						}
					}
					// Set the last write date/time is selected					
					if ( cbSetLastWriteDate.Checked)
					{
						if (IsDirectory)
						{
							Directory.SetLastWriteTime(FilePath, FileTime);
						}
						else
						{
							File.SetLastWriteTime(FilePath, FileTime);
						}
					}
					// Set the last access time if selected
					// (Should be the last one we write to if not the
					// last access date/time will update to now)
					if ( cbSetLastAccessDate.Checked)
					{
						if (IsDirectory)
						{
							Directory.SetLastAccessTime(FilePath, FileTime);
						}
						else
						{
							File.SetLastAccessTime(FilePath, FileTime);
						}
					}
					++itemsSetCount;
				}
			}
			catch (Exception ex)
			{
				++itemsErrorsCount;
				MessageBox.Show("Error in setting date/time on '" + FilePath + "': \r\n\r\n" + ex.Message,
					"Date/Time Error " + itemsErrorsCount.ToString(), MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation);
			}
		}



	}
}
