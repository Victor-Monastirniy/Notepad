using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class NotepadForm : Form
    {
        #region fields
        private bool isCurrentFileSaved = false;
        private bool isCurrentFileDirty = false; // true if there are unsaved changes
        private String currentFileName = String.Empty;
        #endregion

        public NotepadForm()
        {
            InitializeComponent();
        }

        private void NotepadForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// About Notepad
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutNotepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("All rights reserved. Notepad Application Version 1.0", "About Notepad", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isCurrentFileDirty)
            {
                DialogResult result = MessageBox.Show("Do you want to save changes to your document?", "File Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch (result)
                {
                    case DialogResult.Yes:
                        SaveFile();
                        break;

                    case DialogResult.No:
                        break;
                }

            }

            MainRichTextBox.Clear();
            isCurrentFileDirty = false;
            isCurrentFileSaved = false;
            currentFileName = String.Empty;
            this.Text = "Untitled - Notepad";
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String extension = Path.GetExtension(openFileDialog.FileName);
                if (extension.Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                    MainRichTextBox.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

                this.Text = Path.GetFileName(openFileDialog.FileName) + " - Notepad";

                isCurrentFileSaved = true;
                isCurrentFileDirty = false;
                currentFileName = openFileDialog.FileName;

                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveMenuAsFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        // Save
        private void SaveFile()
        {
            if (!isCurrentFileSaved || String.IsNullOrEmpty(currentFileName))
            {
                SaveMenuAsFile();
            }
            else
            {
                String extension = Path.GetExtension(currentFileName);
                if (extension.Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    MainRichTextBox.SaveFile(currentFileName, RichTextBoxStreamType.RichText);
                }
                else
                    MainRichTextBox.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);

                isCurrentFileSaved = true;
                isCurrentFileDirty = false;
            }
        }

        // Save As
        private void SaveMenuAsFile()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|Rich Text Format (*.rtf)|*.rtf|All Files (*.*)|*.*";

            DialogResult result = saveFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                String extension = Path.GetExtension(saveFileDialog.FileName);
                if (extension.Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    MainRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                else
                    MainRichTextBox.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);

                this.Text = Path.GetFileName(saveFileDialog.FileName) + " - Notepad";


                isCurrentFileSaved = true;
                isCurrentFileDirty = false;
                currentFileName = saveFileDialog.FileName;
            }
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            isCurrentFileDirty = true;
            undoToolStripMenuItem.Enabled = true;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Undo();
            redoToolStripMenuItem.Enabled = true;
            undoToolStripMenuItem.Enabled = MainRichTextBox.CanUndo;
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Redo();
            redoToolStripMenuItem.Enabled = MainRichTextBox.CanRedo;
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectAll();
        }

        private void dateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Text += "Now is:\n" + DateTime.Now.ToString() + "\n";
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Italic);
        }

        private void underlineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Underline);
        }

        private void strikethroughToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Strikeout);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.SelectionFont = new Font(MainRichTextBox.Font, FontStyle.Regular);
        }

        private void formatFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            DialogResult result = fontDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                MainRichTextBox.SelectionFont = fontDialog.Font;
                MainRichTextBox.SelectionColor = fontDialog.Color;
            }
        }

        private void changeTextColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                MainRichTextBox.SelectionColor = colorDialog.Color;
            }
        }
    }
}
