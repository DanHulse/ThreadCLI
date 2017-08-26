namespace Spindle.Forms
{
    partial class frmSceneEditor
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
            this.components = new System.ComponentModel.Container();
            this.splitSelectData = new System.Windows.Forms.SplitContainer();
            this.splitSceneChapter = new System.Windows.Forms.SplitContainer();
            this.dgvChapters = new System.Windows.Forms.DataGridView();
            this.dgvScenes = new System.Windows.Forms.DataGridView();
            this.lblScenes = new System.Windows.Forms.Label();
            this.lblChapters = new System.Windows.Forms.Label();
            this.menuEditor = new System.Windows.Forms.MenuStrip();
            this.addChapterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitSceneData = new System.Windows.Forms.SplitContainer();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblActions = new System.Windows.Forms.Label();
            this.dgvActions = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblScript = new System.Windows.Forms.Label();
            this.txtSceneName = new System.Windows.Forms.TextBox();
            this.lblSceneName = new System.Windows.Forms.Label();
            this.txtSceneNumber = new System.Windows.Forms.TextBox();
            this.lblSceneNumber = new System.Windows.Forms.Label();
            this.chkEndScene = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.chapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.chapterNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chapterNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sceneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sceneNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scriptDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endingSceneDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitSelectData)).BeginInit();
            this.splitSelectData.Panel1.SuspendLayout();
            this.splitSelectData.Panel2.SuspendLayout();
            this.splitSelectData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSceneChapter)).BeginInit();
            this.splitSceneChapter.Panel1.SuspendLayout();
            this.splitSceneChapter.Panel2.SuspendLayout();
            this.splitSceneChapter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScenes)).BeginInit();
            this.menuEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitSceneData)).BeginInit();
            this.splitSceneData.Panel1.SuspendLayout();
            this.splitSceneData.Panel2.SuspendLayout();
            this.splitSceneData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitSelectData
            // 
            this.splitSelectData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitSelectData.Location = new System.Drawing.Point(0, 27);
            this.splitSelectData.Name = "splitSelectData";
            // 
            // splitSelectData.Panel1
            // 
            this.splitSelectData.Panel1.Controls.Add(this.splitSceneChapter);
            // 
            // splitSelectData.Panel2
            // 
            this.splitSelectData.Panel2.Controls.Add(this.splitSceneData);
            this.splitSelectData.Size = new System.Drawing.Size(786, 555);
            this.splitSelectData.SplitterDistance = 262;
            this.splitSelectData.TabIndex = 2;
            // 
            // splitSceneChapter
            // 
            this.splitSceneChapter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSceneChapter.Location = new System.Drawing.Point(0, 0);
            this.splitSceneChapter.Name = "splitSceneChapter";
            this.splitSceneChapter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSceneChapter.Panel1
            // 
            this.splitSceneChapter.Panel1.Controls.Add(this.lblChapters);
            this.splitSceneChapter.Panel1.Controls.Add(this.dgvChapters);
            // 
            // splitSceneChapter.Panel2
            // 
            this.splitSceneChapter.Panel2.Controls.Add(this.lblScenes);
            this.splitSceneChapter.Panel2.Controls.Add(this.dgvScenes);
            this.splitSceneChapter.Size = new System.Drawing.Size(262, 555);
            this.splitSceneChapter.SplitterDistance = 191;
            this.splitSceneChapter.TabIndex = 0;
            // 
            // dgvChapters
            // 
            this.dgvChapters.AllowUserToAddRows = false;
            this.dgvChapters.AllowUserToDeleteRows = false;
            this.dgvChapters.AutoGenerateColumns = false;
            this.dgvChapters.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChapters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChapters.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chapterNumberDataGridViewTextBoxColumn,
            this.chapterNameDataGridViewTextBoxColumn});
            this.dgvChapters.DataSource = this.chapterBindingSource;
            this.dgvChapters.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvChapters.Location = new System.Drawing.Point(0, 26);
            this.dgvChapters.MultiSelect = false;
            this.dgvChapters.Name = "dgvChapters";
            this.dgvChapters.RowHeadersVisible = false;
            this.dgvChapters.Size = new System.Drawing.Size(262, 165);
            this.dgvChapters.TabIndex = 0;
            // 
            // dgvScenes
            // 
            this.dgvScenes.AutoGenerateColumns = false;
            this.dgvScenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScenes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sceneNumberDataGridViewTextBoxColumn,
            this.sceneNameDataGridViewTextBoxColumn,
            this.scriptDataGridViewTextBoxColumn,
            this.endingSceneDataGridViewCheckBoxColumn});
            this.dgvScenes.DataSource = this.sceneBindingSource;
            this.dgvScenes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvScenes.Location = new System.Drawing.Point(0, 26);
            this.dgvScenes.Name = "dgvScenes";
            this.dgvScenes.Size = new System.Drawing.Size(262, 334);
            this.dgvScenes.TabIndex = 0;
            this.dgvScenes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvScenes_CellContentClick);
            // 
            // lblScenes
            // 
            this.lblScenes.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblScenes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScenes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScenes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblScenes.Location = new System.Drawing.Point(0, 0);
            this.lblScenes.Name = "lblScenes";
            this.lblScenes.Size = new System.Drawing.Size(262, 23);
            this.lblScenes.TabIndex = 1;
            this.lblScenes.Text = "Scenes";
            this.lblScenes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblChapters
            // 
            this.lblChapters.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblChapters.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblChapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChapters.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblChapters.Location = new System.Drawing.Point(0, 0);
            this.lblChapters.Name = "lblChapters";
            this.lblChapters.Size = new System.Drawing.Size(262, 23);
            this.lblChapters.TabIndex = 2;
            this.lblChapters.Text = "Chapters";
            this.lblChapters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuEditor
            // 
            this.menuEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addChapterMenuItem,
            this.addSceneToolStripMenuItem});
            this.menuEditor.Location = new System.Drawing.Point(0, 0);
            this.menuEditor.Name = "menuEditor";
            this.menuEditor.Size = new System.Drawing.Size(786, 24);
            this.menuEditor.TabIndex = 0;
            this.menuEditor.Text = "EditorMenuStrip";
            // 
            // addChapterMenuItem
            // 
            this.addChapterMenuItem.Name = "addChapterMenuItem";
            this.addChapterMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addChapterMenuItem.Text = "Add Chapter";
            // 
            // addSceneToolStripMenuItem
            // 
            this.addSceneToolStripMenuItem.Name = "addSceneToolStripMenuItem";
            this.addSceneToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.addSceneToolStripMenuItem.Text = "Add Scene";
            // 
            // splitSceneData
            // 
            this.splitSceneData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitSceneData.Location = new System.Drawing.Point(0, 0);
            this.splitSceneData.Name = "splitSceneData";
            this.splitSceneData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitSceneData.Panel1
            // 
            this.splitSceneData.Panel1.Controls.Add(this.btnDelete);
            this.splitSceneData.Panel1.Controls.Add(this.btnSave);
            this.splitSceneData.Panel1.Controls.Add(this.chkEndScene);
            this.splitSceneData.Panel1.Controls.Add(this.lblSceneNumber);
            this.splitSceneData.Panel1.Controls.Add(this.txtSceneNumber);
            this.splitSceneData.Panel1.Controls.Add(this.lblSceneName);
            this.splitSceneData.Panel1.Controls.Add(this.txtSceneName);
            this.splitSceneData.Panel1.Controls.Add(this.lblScript);
            this.splitSceneData.Panel1.Controls.Add(this.textBox1);
            this.splitSceneData.Panel1.Controls.Add(this.lblHeader);
            // 
            // splitSceneData.Panel2
            // 
            this.splitSceneData.Panel2.Controls.Add(this.dgvActions);
            this.splitSceneData.Panel2.Controls.Add(this.lblActions);
            this.splitSceneData.Size = new System.Drawing.Size(520, 555);
            this.splitSceneData.SplitterDistance = 285;
            this.splitSceneData.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(520, 23);
            this.lblHeader.TabIndex = 3;
            this.lblHeader.Text = "Scene Header";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActions
            // 
            this.lblActions.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActions.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblActions.Location = new System.Drawing.Point(0, 0);
            this.lblActions.Name = "lblActions";
            this.lblActions.Size = new System.Drawing.Size(520, 23);
            this.lblActions.TabIndex = 3;
            this.lblActions.Text = "Scene Actions";
            this.lblActions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvActions
            // 
            this.dgvActions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvActions.Location = new System.Drawing.Point(0, 26);
            this.dgvActions.Name = "dgvActions";
            this.dgvActions.Size = new System.Drawing.Size(520, 240);
            this.dgvActions.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 83);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(455, 144);
            this.textBox1.TabIndex = 4;
            // 
            // lblScript
            // 
            this.lblScript.AutoSize = true;
            this.lblScript.Location = new System.Drawing.Point(29, 64);
            this.lblScript.Name = "lblScript";
            this.lblScript.Size = new System.Drawing.Size(34, 13);
            this.lblScript.TabIndex = 5;
            this.lblScript.Text = "Script";
            // 
            // txtSceneName
            // 
            this.txtSceneName.Location = new System.Drawing.Point(261, 35);
            this.txtSceneName.Name = "txtSceneName";
            this.txtSceneName.Size = new System.Drawing.Size(100, 20);
            this.txtSceneName.TabIndex = 6;
            // 
            // lblSceneName
            // 
            this.lblSceneName.AutoSize = true;
            this.lblSceneName.Location = new System.Drawing.Point(186, 38);
            this.lblSceneName.Name = "lblSceneName";
            this.lblSceneName.Size = new System.Drawing.Size(69, 13);
            this.lblSceneName.TabIndex = 7;
            this.lblSceneName.Text = "Scene Name";
            // 
            // txtSceneNumber
            // 
            this.txtSceneNumber.Location = new System.Drawing.Point(113, 35);
            this.txtSceneNumber.Name = "txtSceneNumber";
            this.txtSceneNumber.Size = new System.Drawing.Size(48, 20);
            this.txtSceneNumber.TabIndex = 8;
            // 
            // lblSceneNumber
            // 
            this.lblSceneNumber.AutoSize = true;
            this.lblSceneNumber.Location = new System.Drawing.Point(29, 38);
            this.lblSceneNumber.Name = "lblSceneNumber";
            this.lblSceneNumber.Size = new System.Drawing.Size(78, 13);
            this.lblSceneNumber.TabIndex = 9;
            this.lblSceneNumber.Text = "Scene Number";
            // 
            // chkEndScene
            // 
            this.chkEndScene.AutoSize = true;
            this.chkEndScene.Location = new System.Drawing.Point(29, 244);
            this.chkEndScene.Name = "chkEndScene";
            this.chkEndScene.Size = new System.Drawing.Size(99, 17);
            this.chkEndScene.TabIndex = 10;
            this.chkEndScene.Text = "Ending Scene?";
            this.chkEndScene.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(408, 244);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(408, 33);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // chapterBindingSource
            // 
            this.chapterBindingSource.DataSource = typeof(Spindle.Models.Chapter);
            // 
            // chapterNumberDataGridViewTextBoxColumn
            // 
            this.chapterNumberDataGridViewTextBoxColumn.DataPropertyName = "ChapterNumber";
            this.chapterNumberDataGridViewTextBoxColumn.FillWeight = 50F;
            this.chapterNumberDataGridViewTextBoxColumn.HeaderText = "ChapterNumber";
            this.chapterNumberDataGridViewTextBoxColumn.Name = "chapterNumberDataGridViewTextBoxColumn";
            this.chapterNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // chapterNameDataGridViewTextBoxColumn
            // 
            this.chapterNameDataGridViewTextBoxColumn.DataPropertyName = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.HeaderText = "ChapterName";
            this.chapterNameDataGridViewTextBoxColumn.Name = "chapterNameDataGridViewTextBoxColumn";
            // 
            // sceneBindingSource
            // 
            this.sceneBindingSource.DataSource = typeof(Spindle.Models.Scene);
            // 
            // sceneNumberDataGridViewTextBoxColumn
            // 
            this.sceneNumberDataGridViewTextBoxColumn.DataPropertyName = "SceneNumber";
            this.sceneNumberDataGridViewTextBoxColumn.HeaderText = "SceneNumber";
            this.sceneNumberDataGridViewTextBoxColumn.Name = "sceneNumberDataGridViewTextBoxColumn";
            // 
            // sceneNameDataGridViewTextBoxColumn
            // 
            this.sceneNameDataGridViewTextBoxColumn.DataPropertyName = "SceneName";
            this.sceneNameDataGridViewTextBoxColumn.HeaderText = "SceneName";
            this.sceneNameDataGridViewTextBoxColumn.Name = "sceneNameDataGridViewTextBoxColumn";
            // 
            // scriptDataGridViewTextBoxColumn
            // 
            this.scriptDataGridViewTextBoxColumn.DataPropertyName = "Script";
            this.scriptDataGridViewTextBoxColumn.HeaderText = "Script";
            this.scriptDataGridViewTextBoxColumn.Name = "scriptDataGridViewTextBoxColumn";
            // 
            // endingSceneDataGridViewCheckBoxColumn
            // 
            this.endingSceneDataGridViewCheckBoxColumn.DataPropertyName = "EndingScene";
            this.endingSceneDataGridViewCheckBoxColumn.HeaderText = "EndingScene";
            this.endingSceneDataGridViewCheckBoxColumn.Name = "endingSceneDataGridViewCheckBoxColumn";
            // 
            // frmSceneEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 582);
            this.Controls.Add(this.menuEditor);
            this.Controls.Add(this.splitSelectData);
            this.MainMenuStrip = this.menuEditor;
            this.Name = "frmSceneEditor";
            this.Text = "frmSceneEditor";
            this.splitSelectData.Panel1.ResumeLayout(false);
            this.splitSelectData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSelectData)).EndInit();
            this.splitSelectData.ResumeLayout(false);
            this.splitSceneChapter.Panel1.ResumeLayout(false);
            this.splitSceneChapter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSceneChapter)).EndInit();
            this.splitSceneChapter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChapters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScenes)).EndInit();
            this.menuEditor.ResumeLayout(false);
            this.menuEditor.PerformLayout();
            this.splitSceneData.Panel1.ResumeLayout(false);
            this.splitSceneData.Panel1.PerformLayout();
            this.splitSceneData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitSceneData)).EndInit();
            this.splitSceneData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chapterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sceneBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitSelectData;
        private System.Windows.Forms.SplitContainer splitSceneChapter;
        private System.Windows.Forms.Label lblChapters;
        private System.Windows.Forms.DataGridView dgvChapters;
        private System.Windows.Forms.Label lblScenes;
        private System.Windows.Forms.DataGridView dgvScenes;
        private System.Windows.Forms.MenuStrip menuEditor;
        private System.Windows.Forms.ToolStripMenuItem addChapterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSceneToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitSceneData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkEndScene;
        private System.Windows.Forms.Label lblSceneNumber;
        private System.Windows.Forms.TextBox txtSceneNumber;
        private System.Windows.Forms.Label lblSceneName;
        private System.Windows.Forms.TextBox txtSceneName;
        private System.Windows.Forms.Label lblScript;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvActions;
        private System.Windows.Forms.Label lblActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn chapterNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource chapterBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sceneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sceneNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scriptDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn endingSceneDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource sceneBindingSource;
    }
}