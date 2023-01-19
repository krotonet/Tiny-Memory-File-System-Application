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
    public partial class DecryptFiles : Form
    {
        public DecryptFiles()
        {
            InitializeComponent();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text;
            if (key == null || key.Length == 0)
            {
                MessageBox.Show("You didn't choose key for decryption!\nPlease try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            TinyMemoryFS.self.decryptFiles(key);
            this.Close();
        }
    }
}
