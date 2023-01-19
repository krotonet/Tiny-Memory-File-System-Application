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
    public partial class ListFileItem : UserControl
    {
                
        private string fileName;
        private string fileData ;
        private Image myItemImage;

        public ListFileItem(string fileName, string fileData)
        {
            InitializeComponent();
            this.fileData = fileData;
            this.fileName = fileName;
        }

        [Category("Custom Props")]
        public string myFileName
        {
            get { return fileName; }
            set { fileName = value; labelFileName.Text = value; }
        }

        [Category("Custom Props")]
        public string myFileData
        {
            get { return fileData; }
            set { fileData = value; labelFileData.Text = value; }
        }



        [Category("Custom Props")]
        public Image itemImage
        {
            get { return myItemImage; }
            set { myItemImage = value; pictureBox1.Image = value; }
        }
    }
}
