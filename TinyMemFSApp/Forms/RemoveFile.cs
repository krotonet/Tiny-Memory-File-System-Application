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
    public partial class RemoveFile : Form
    {
        private string fileNameToRemove;

        public RemoveFile(List<string> files)
        {
            InitializeComponent();
            foreach (string fileData in files)
            {
                comboBoxFiles.Items.Add(fileData);

            }
            comboBoxFiles.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void buttonRemoveFile_Click(object sender, EventArgs e)
        {
            fileNameToRemove = comboBoxFiles.SelectedItem.ToString();
            if (fileNameToRemove == null || fileNameToRemove.Length == 0)
            {
                MessageBox.Show("You didn't choose file to remove!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            TinyMemoryFS.self.removeFile(fileNameToRemove.Substring(0,fileNameToRemove.IndexOf(',')));
            this.Close();
        }
    }
}
