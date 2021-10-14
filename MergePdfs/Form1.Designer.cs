
namespace MergePdfs
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnChooseFiles = new System.Windows.Forms.Button();
            this.txtFiles = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnMergeFiles = new System.Windows.Forms.Button();
            this.txtOutputFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChooseFiles
            // 
            resources.ApplyResources(this.btnChooseFiles, "btnChooseFiles");
            this.btnChooseFiles.Name = "btnChooseFiles";
            this.btnChooseFiles.UseVisualStyleBackColor = true;
            this.btnChooseFiles.Click += new System.EventHandler(this.btnChooseFiles_Click);
            // 
            // txtFiles
            // 
            resources.ApplyResources(this.txtFiles, "txtFiles");
            this.txtFiles.Name = "txtFiles";
            this.txtFiles.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnMergeFiles
            // 
            resources.ApplyResources(this.btnMergeFiles, "btnMergeFiles");
            this.btnMergeFiles.Name = "btnMergeFiles";
            this.btnMergeFiles.UseVisualStyleBackColor = true;
            this.btnMergeFiles.Click += new System.EventHandler(this.btnMergeFiles_Click);
            // 
            // txtOutputFileName
            // 
            resources.ApplyResources(this.txtOutputFileName, "txtOutputFileName");
            this.txtOutputFileName.Name = "txtOutputFileName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOutputFileName);
            this.Controls.Add(this.btnMergeFiles);
            this.Controls.Add(this.txtFiles);
            this.Controls.Add(this.btnChooseFiles);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChooseFiles;
        private System.Windows.Forms.TextBox txtFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnMergeFiles;
        private System.Windows.Forms.TextBox txtOutputFileName;
        private System.Windows.Forms.Label label1;
    }
}

