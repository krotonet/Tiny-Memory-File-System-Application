using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinyMemFSApp.Forms
{
    public partial class SaveFile : Form
    {
        private string locationPath;

        public SaveFile(List<string> files)
        {
            InitializeComponent();
            foreach (string fileData in files)
            {
                comboBoxFiles.Items.Add(fileData);
            }
            comboBoxFiles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            string fileNameToSave = comboBoxFiles.Text;
            if (fileNameToSave == null || fileNameToSave.Length == 0)
            {
                MessageBox.Show("Please choose file to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); 
                return;
            }
            TinyMemoryFS.self.saveFile(fileNameToSave.Substring(0, fileNameToSave.IndexOf(',')), locationPath);
            this.Close();
        }

        private void browseLocationToSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.locationPath = saveFileDialog.FileName;
                TextBoxLocation.Text = locationPath;
            }
        }
    }
}
