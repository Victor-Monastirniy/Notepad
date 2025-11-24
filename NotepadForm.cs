using System.Drawing.Printing;
using System.IO;
using System.Reflection.Metadata;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                CapsToolStripStatusLabel.Text = "CAPS ON";
            }
            else
            {
                CapsToolStripStatusLabel.Text = "CAPS OFF";
            }
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
            MessageToolStripStatusLabel.Text = "New file (unsaved)";
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

                MessageToolStripStatusLabel.Text = "File opened";
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

            MessageToolStripStatusLabel.Text = "Changes saved.";
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

                MessageToolStripStatusLabel.Text = "File saved.";
            }
        }

        private void MainRichTextBox_TextChanged(object sender, EventArgs e)
        {
            isCurrentFileDirty = true;
            undoToolStripMenuItem.Enabled = true;
            MessageToolStripStatusLabel.Text = "File editing...";
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

        private void MainRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                CapsToolStripStatusLabel.Text = "CAPS ON";
            }
            else
            {
                CapsToolStripStatusLabel.Text = "CAPS OFF";
            }
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(sender, e);
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem_Click(sender, e);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem_Click(sender, e);
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem_Click(sender, e);
        }

        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem_Click(sender, e);
        }

        private void underlineToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            underlineToolStripMenuItem_Click(sender, e);
        }

        private void strikethroughToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            strikethroughToolStripMenuItem_Click(sender, e);
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainRichTextBox.Paste();
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            PrintDocument documentToPrint = new PrintDocument();
            documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
            printPreviewDialog.Document = documentToPrint;
            printPreviewDialog.ShowDialog();
        }


        private void DocumentToPrint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            StringReader reader = new StringReader(MainRichTextBox.Text);
            float LinesPerPage = 0;
            float YPosition = 0;
            int Count = 0;
            float LeftMargin = e.MarginBounds.Left;
            float TopMargin = e.MarginBounds.Top;
            string Line = null;
            Font PrintFont = this.MainRichTextBox.Font;
            SolidBrush PrintBrush = new SolidBrush(Color.Black);

            LinesPerPage = e.MarginBounds.Height / PrintFont.GetHeight(e.Graphics);

            while (Count < LinesPerPage && ((Line = reader.ReadLine()) != null))
            {
                YPosition = TopMargin + (Count * PrintFont.GetHeight(e.Graphics));
                e.Graphics.DrawString(Line, PrintFont, PrintBrush, LeftMargin, YPosition, new StringFormat());
                Count++;
            }

            if (Line != null)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
            PrintBrush.Dispose();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument documentToPrint = new PrintDocument();
            printDialog.Document = documentToPrint;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                documentToPrint.PrintPage += new PrintPageEventHandler(DocumentToPrint_PrintPage);
                documentToPrint.Print();
            }
        }

        private void developerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Developed by Viktor Monastyrnyi (on 24.11.2025)", "Developer Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void encodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainRichTextBox.Text))
            {
                MessageBox.Show("Current file is empty. Please enter text to encode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userInput = Interaction.InputBox("Enter shift value (integer):", "Caesar Cipher Encode", "3");

            if (string.IsNullOrEmpty(userInput))
            {
                return; // User cancelled
            }
            if (int.TryParse(userInput, out int shift) && shift > 0)
            {
                string encodedText = Encoders.CaesarCipher.Encode(MainRichTextBox.Text, shift, Encoders.CaesarCipher.Alphabet);
                MainRichTextBox.Text = encodedText;
                MessageToolStripStatusLabel.Text = "Text encoded with Caesar Cipher.";
            }
            else
            {
                MessageBox.Show("Invalid shift value. Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageToolStripStatusLabel.Text = "Encoding failed.";
            }

        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainRichTextBox.Text))
            {
                MessageBox.Show("Current file is empty. Please enter text to decode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string userInput = Interaction.InputBox("Enter shift value (integer):", "Caesar Cipher Decode", "3");

            if (string.IsNullOrEmpty(userInput))
            {
                return; // User cancelled
            }
            if (int.TryParse(userInput, out int shift) && shift > 0)
            {
                string decodedText = Encoders.CaesarCipher.Decode(MainRichTextBox.Text, shift, Encoders.CaesarCipher.Alphabet);
                MainRichTextBox.Text = decodedText;
                MessageToolStripStatusLabel.Text = "Text decoded with Caesar Cipher.";
            }
            else
            {
                MessageBox.Show("Invalid shift value. Please enter a valid positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageToolStripStatusLabel.Text = "Decoding failed.";
            }
        }

        private void encodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainRichTextBox.Text))
            {
                MessageBox.Show("Current file is empty. Please enter text to encode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GammaCipherEncode gammaCipher = new GammaCipherEncode(MainRichTextBox.Text);
            DialogResult result = gammaCipher.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(gammaCipher.gamma))
            {
                MainRichTextBox.Text = Encoders.GammaCipher.Encode(MainRichTextBox.Text, gammaCipher.gamma, Encoders.GammaCipher.Alphabet);
                MessageToolStripStatusLabel.Text = "Text encoded with Gamma Cipher.";
            }
            else
            {
                MessageToolStripStatusLabel.Text = "Text encryption with Gamma cancelled";
            }
        }

        private void decodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MainRichTextBox.Text))
            {
                MessageBox.Show("Current file is empty. Please enter text to decode.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            GammaCipherDecode gammaCipher = new GammaCipherDecode(MainRichTextBox.Text);
            DialogResult result = gammaCipher.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrEmpty(gammaCipher.gamma))
            {
                MainRichTextBox.Text = Encoders.GammaCipher.Decode(MainRichTextBox.Text, gammaCipher.gamma, Encoders.GammaCipher.Alphabet);
                MessageToolStripStatusLabel.Text = "Text decoded with Gamma Cipher.";
            }
            else
            {
                MessageToolStripStatusLabel.Text = "Text decryption with Gamma cancelled";
            }
        }
    }
}
