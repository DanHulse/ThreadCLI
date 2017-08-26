namespace Spindle.Forms
{
    partial class frmMain
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
            this.dlgEditFile = new System.Windows.Forms.OpenFileDialog();
            this.lblEditFileName = new System.Windows.Forms.Label();
            this.btnEditFile = new System.Windows.Forms.Button();
            this.btnEditFileSelect = new System.Windows.Forms.Button();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dlgEditFile
            // 
            this.dlgEditFile.FileName = "openFileDialog1";
            // 
            // lblEditFileName
            // 
            this.lblEditFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEditFileName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblEditFileName.Location = new System.Drawing.Point(102, 167);
            this.lblEditFileName.Name = "lblEditFileName";
            this.lblEditFileName.Size = new System.Drawing.Size(133, 23);
            this.lblEditFileName.TabIndex = 0;
            this.lblEditFileName.Text = "Select file to edit";
            this.lblEditFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEditFile
            // 
            this.btnEditFile.Location = new System.Drawing.Point(21, 167);
            this.btnEditFile.Name = "btnEditFile";
            this.btnEditFile.Size = new System.Drawing.Size(75, 23);
            this.btnEditFile.TabIndex = 1;
            this.btnEditFile.Text = "Edit";
            this.btnEditFile.UseVisualStyleBackColor = true;
            this.btnEditFile.Click += new System.EventHandler(this.btnEditFile_Click);
            // 
            // btnEditFileSelect
            // 
            this.btnEditFileSelect.Location = new System.Drawing.Point(241, 167);
            this.btnEditFileSelect.Name = "btnEditFileSelect";
            this.btnEditFileSelect.Size = new System.Drawing.Size(27, 23);
            this.btnEditFileSelect.TabIndex = 2;
            this.btnEditFileSelect.Text = "...";
            this.btnEditFileSelect.UseVisualStyleBackColor = true;
            this.btnEditFileSelect.Click += new System.EventHandler(this.btnEditFileSelect_Click);
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(21, 138);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(75, 23);
            this.btnNewFile.TabIndex = 3;
            this.btnNewFile.Text = "New";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 111);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 206);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.btnEditFileSelect);
            this.Controls.Add(this.btnEditFile);
            this.Controls.Add(this.lblEditFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.Text = "frmMain";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog dlgEditFile;
        private System.Windows.Forms.Label lblEditFileName;
        private System.Windows.Forms.Button btnEditFile;
        private System.Windows.Forms.Button btnEditFileSelect;
        private System.Windows.Forms.Button btnNewFile;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}