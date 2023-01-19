using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TinyMemFSApp.Forms;

namespace TinyMemFSApp
{
    public partial class TinyMemoryFS : Form
    {
        protected Form activeForm;
        private static TinyMemFS tinyMemFS;
        public static List<ListFileItem> itemsList;
        protected OpenFileDialog openFileDialog = new OpenFileDialog();
        private List<string> filesDataList;
        public static TinyMemoryFS self;
        public TinyMemoryFS()
        {
            InitializeComponent();
            tinyMemFS = new TinyMemFS();
            self = this;
            itemsList = new List<ListFileItem>();
        }

        internal void encryptFiles(string key)
        {
            if (!tinyMemFS.encrypt(key))
            {
                MessageBox.Show("Somthing went wrong!\nplease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("All files encrypted successfully!!", "Succede", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        internal void decryptFiles(string key)
        {
            if (!tinyMemFS.decrypt(key))
            {
                MessageBox.Show("Somthing went wrong!\nplease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("All files decrypted successfully!!", "Succede", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            AddFile addFile = new AddFile();
            addFile.Show();
        }

        internal void saveFile(string fileToSave, string locationPath)
        {
            if (!tinyMemFS.save(fileToSave, locationPath))
            {
                MessageBox.Show("Something went wrong!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayItemsList();
        }

        internal void removeFile(string fileNameToRemove)
        {
            if (!tinyMemFS.remove(fileNameToRemove))
            {
                MessageBox.Show("Something went wrong!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayItemsList();
        }

        internal void addFileToFS(object filePath, object fileName)
        {
            string fName = (string)fileName;
            string fPath = (string)filePath;
            if (!tinyMemFS.add(fName, fPath))
            {
                MessageBox.Show("Something went wrong!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                displayItemsList();
            }
        }

        private void displayItemsList()
        {
            if (flowLayoutPanelItems1.Controls.Count > 0)
                flowLayoutPanelItems1.Controls.Clear();
            if (flowLayoutPanelItems2.Controls.Count > 0)
                flowLayoutPanelItems2.Controls.Clear();
            bool firstTurn = true;
            filesDataList = tinyMemFS.listFiles();
            foreach(string f in filesDataList)
            {
                string[] data = f.Split(',');
                string fData = "Size: " + data[1] + ", \tCreated on: " + data[2];
                ListFileItem listFileItem = new ListFileItem(data[0], fData);
                listFileItem.myFileData = fData;
                listFileItem.myFileName = data[0];
                if (firstTurn)
                {
                    flowLayoutPanelItems1.Controls.Add(listFileItem);
                    firstTurn = false;
                }
                else
                {
                    flowLayoutPanelItems2.Controls.Add(listFileItem);
                    firstTurn = true;
                }
            }
        }

        private void buttonRemoveFile_Click(object sender, EventArgs e)
        {
            filesDataList = tinyMemFS.listFiles();
            if (filesDataList.Count == 0)
            {
                MessageBox.Show("No files to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                RemoveFile removeFile = new RemoveFile(filesDataList);
                removeFile.Show();
            }
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            List<string> filesDataList = tinyMemFS.listFiles();
            if (filesDataList.Count == 0)
            {
                MessageBox.Show("No files to save!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SaveFile saveFile = new SaveFile(filesDataList);
                saveFile.Show();
            }
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (filesDataList == null || filesDataList.Count == 0)
            {
                MessageBox.Show("No files to encrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                EncryptFiles encryptFiles = new EncryptFiles();
                encryptFiles.Show();
            }
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            if (filesDataList == null || filesDataList.Count == 0)
            {
                MessageBox.Show("No files to decrypt!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DecryptFiles decryptFiles = new DecryptFiles();
                decryptFiles.Show();
            }
        }
    }
}
