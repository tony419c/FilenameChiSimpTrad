
namespace FilenameChiSimpTrad
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MF_tb_FolderPath = new TextBox();
            MF_btn_BrowseFolder = new Button();
            SuspendLayout();
            // 
            // MF_tb_FolderPath
            // 
            MF_tb_FolderPath.Location = new Point(41, 38);
            MF_tb_FolderPath.Name = "MF_tb_FolderPath";
            MF_tb_FolderPath.Size = new Size(432, 23);
            MF_tb_FolderPath.TabIndex = 0;
            // 
            // MF_btn_BrowseFolder
            // 
            MF_btn_BrowseFolder.Location = new Point(543, 38);
            MF_btn_BrowseFolder.Name = "MF_btn_BrowseFolder";
            MF_btn_BrowseFolder.Size = new Size(112, 23);
            MF_btn_BrowseFolder.TabIndex = 1;
            MF_btn_BrowseFolder.Text = "Browse Folder";
            MF_btn_BrowseFolder.UseVisualStyleBackColor = true;
            MF_btn_BrowseFolder.Click += this.MF_btn_BrowseFolder_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MF_btn_BrowseFolder);
            Controls.Add(MF_tb_FolderPath);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox MF_tb_FolderPath;
        private Button MF_btn_BrowseFolder;
    }
}
