namespace TinyMemFSApp
{
    partial class TinyMemoryFS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TinyMemoryFS));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.buttonRemoveFile = new System.Windows.Forms.Button();
            this.buttonAddFile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanelItems1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanelItems2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonDecrypt);
            this.panelMenu.Controls.Add(this.buttonEncrypt);
            this.panelMenu.Controls.Add(this.buttonSaveFile);
            this.panelMenu.Controls.Add(this.buttonRemoveFile);
            this.panelMenu.Controls.Add(this.buttonAddFile);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(229, 561);
            this.panelMenu.TabIndex = 3;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDecrypt.FlatAppearance.BorderSize = 0;
            this.buttonDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonDecrypt.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDecrypt.Image = ((System.Drawing.Image)(resources.GetObject("buttonDecrypt.Image")));
            this.buttonDecrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDecrypt.Location = new System.Drawing.Point(0, 361);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(229, 68);
            this.buttonDecrypt.TabIndex = 8;
            this.buttonDecrypt.Text = "Decrypt Files";
            this.buttonDecrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEncrypt.FlatAppearance.BorderSize = 0;
            this.buttonEncrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonEncrypt.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEncrypt.Image = ((System.Drawing.Image)(resources.GetObject("buttonEncrypt.Image")));
            this.buttonEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEncrypt.Location = new System.Drawing.Point(0, 293);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(229, 68);
            this.buttonEncrypt.TabIndex = 7;
            this.buttonEncrypt.Text = "Encrypt Files";
            this.buttonEncrypt.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSaveFile.FlatAppearance.BorderSize = 0;
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonSaveFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSaveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonSaveFile.Image")));
            this.buttonSaveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSaveFile.Location = new System.Drawing.Point(0, 225);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(229, 68);
            this.buttonSaveFile.TabIndex = 6;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSaveFile.UseVisualStyleBackColor = true;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // buttonRemoveFile
            // 
            this.buttonRemoveFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRemoveFile.FlatAppearance.BorderSize = 0;
            this.buttonRemoveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRemoveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonRemoveFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRemoveFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemoveFile.Image")));
            this.buttonRemoveFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveFile.Location = new System.Drawing.Point(0, 157);
            this.buttonRemoveFile.Name = "buttonRemoveFile";
            this.buttonRemoveFile.Size = new System.Drawing.Size(229, 68);
            this.buttonRemoveFile.TabIndex = 5;
            this.buttonRemoveFile.Text = "Remove File";
            this.buttonRemoveFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRemoveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRemoveFile.UseVisualStyleBackColor = true;
            this.buttonRemoveFile.Click += new System.EventHandler(this.buttonRemoveFile_Click);
            // 
            // buttonAddFile
            // 
            this.buttonAddFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddFile.FlatAppearance.BorderSize = 0;
            this.buttonAddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonAddFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAddFile.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddFile.Image")));
            this.buttonAddFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAddFile.Location = new System.Drawing.Point(0, 89);
            this.buttonAddFile.Name = "buttonAddFile";
            this.buttonAddFile.Size = new System.Drawing.Size(229, 68);
            this.buttonAddFile.TabIndex = 4;
            this.buttonAddFile.Text = " Add File";
            this.buttonAddFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonAddFile.UseCompatibleTextRendering = true;
            this.buttonAddFile.UseVisualStyleBackColor = true;
            this.buttonAddFile.Click += new System.EventHandler(this.buttonAddFile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(90)))));
            this.panelLogo.Controls.Add(this.label2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Font = new System.Drawing.Font("Rod", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(229, 89);
            this.panelLogo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Tempus Sans ITC", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 89);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Files";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(229, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1036, 89);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(172)))), ((int)(((byte)(234)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 89);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tiny Memory Files System ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelItems1
            // 
            this.flowLayoutPanelItems1.AutoScroll = true;
            this.flowLayoutPanelItems1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelItems1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelItems1.Location = new System.Drawing.Point(229, 89);
            this.flowLayoutPanelItems1.Name = "flowLayoutPanelItems1";
            this.flowLayoutPanelItems1.Size = new System.Drawing.Size(517, 472);
            this.flowLayoutPanelItems1.TabIndex = 7;
            // 
            // flowLayoutPanelItems2
            // 
            this.flowLayoutPanelItems2.AutoScroll = true;
            this.flowLayoutPanelItems2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelItems2.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelItems2.Location = new System.Drawing.Point(745, 89);
            this.flowLayoutPanelItems2.Name = "flowLayoutPanelItems2";
            this.flowLayoutPanelItems2.Size = new System.Drawing.Size(520, 472);
            this.flowLayoutPanelItems2.TabIndex = 8;
            // 
            // TinyMemoryFS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1265, 561);
            this.Controls.Add(this.flowLayoutPanelItems2);
            this.Controls.Add(this.flowLayoutPanelItems1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Name = "TinyMemoryFS";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAddFile;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonSaveFile;
        private System.Windows.Forms.Button buttonRemoveFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelItems2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

