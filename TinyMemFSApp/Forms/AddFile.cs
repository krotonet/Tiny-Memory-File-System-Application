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
    public partial class AddFile : Form
    {
        public string filePath;
        public string fileName;
        public AddFile()
        {
            InitializeComponent();
        }

        private void browseFilePath_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.filePath = openFileDialog.FileName;
                pathTextBox.Text = filePath;
            }
        }

        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {
            this.fileName = textBoxFileName.Text;
        }

        private void buttonAddFile_Click(object sender, EventArgs e)
        {
            this.fileName = textBoxFileName.Text;
            if ((fileName == null || fileName.Length == 0) || (filePath == null || filePath.Length == 0)) 
            {
                MessageBox.Show("Something went wrong\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            TinyMemoryFS.self.addFileToFS(filePath, fileName);
            this.Close();
        }

    }
}
