using System;
using System.Windows.Forms;

namespace Spindle.Forms
{
    /// <summary>
    /// THe main entry form
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class frmMain : Form
    {
        /// <summary>
        /// Gets or sets the file to edit.
        /// </summary>
        public string FileToEdit { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="frmMain"/> class.
        /// </summary>
        public frmMain()
        {
            InitializeComponent();
        }

        #region Event Handlers

        /// <summary>
        /// Handles the Click event of the btnEditFileSelect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEditFileSelect_Click(object sender, EventArgs e)
        {
            if (dlgEditFile.ShowDialog() == DialogResult.OK)
            {
                this.FileToEdit = dlgEditFile.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnEditFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnEditFile_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.FileToEdit) || !this.FileToEdit.EndsWith(".thread"))
            {
                MessageBox.Show("You must select a valid file to edit", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Handles the Click event of the btnNewFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btnNewFile_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
