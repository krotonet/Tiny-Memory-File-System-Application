namespace TinyMemFSApp.Forms
{
    partial class SaveFile
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
            this.comboBoxFiles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.browseLocationToSave = new System.Windows.Forms.Button();
            this.TextBoxLocation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxFiles
            // 
            this.comboBoxFiles.FormattingEnabled = true;
            this.comboBoxFiles.Location = new System.Drawing.Point(123, 63);
            this.comboBoxFiles.Name = "comboBoxFiles";
            this.comboBoxFiles.Size = new System.Drawing.Size(274, 21);
            this.comboBoxFiles.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose File to Save:";
            // 
            // browseLocationToSave
            // 
            this.browseLocationToSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.browseLocationToSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseLocationToSave.ForeColor = System.Drawing.SystemColors.Window;
            this.browseLocationToSave.Location = new System.Drawing.Point(403, 37);
            this.browseLocationToSave.Name = "browseLocationToSave";
            this.browseLocationToSave.Size = new System.Drawing.Size(161, 21);
            this.browseLocationToSave.TabIndex = 9;
            this.browseLocationToSave.Text = "Browse";
            this.browseLocationToSave.UseVisualStyleBackColor = false;
            this.browseLocationToSave.Click += new System.EventHandler(this.browseLocationToSave_Click);
            // 
            // TextBoxLocation
            // 
            this.TextBoxLocation.Location = new System.Drawing.Point(123, 37);
            this.TextBoxLocation.Name = "TextBoxLocation";
            this.TextBoxLocation.Size = new System.Drawing.Size(274, 20);
            this.TextBoxLocation.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Choose Location:";
            // 
            // buttonSaveFile
            // 
            this.buttonSaveFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveFile.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSaveFile.Location = new System.Drawing.Point(230, 90);
            this.buttonSaveFile.Name = "buttonSaveFile";
            this.buttonSaveFile.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveFile.TabIndex = 6;
            this.buttonSaveFile.Text = "Save File";
            this.buttonSaveFile.UseVisualStyleBackColor = false;
            this.buttonSaveFile.Click += new System.EventHandler(this.buttonSaveFile_Click);
            // 
            // SaveFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 133);
            this.Controls.Add(this.browseLocationToSave);
            this.Controls.Add(this.TextBoxLocation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonSaveFile);
            this.Controls.Add(this.comboBoxFiles);
            this.Controls.Add(this.label1);
            this.Name = "SaveFile";
            this.Text = "SaveFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseLocationToSave;
        private System.Windows.Forms.TextBox TextBoxLocation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSaveFile;
    }
}