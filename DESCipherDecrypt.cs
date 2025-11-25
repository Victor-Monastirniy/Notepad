using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad
{
    public partial class DESCipherDecrypt : Form
    {
        public string key = String.Empty;
        public string iv = String.Empty;
        public string mode = String.Empty;

        public DESCipherDecrypt()
        {
            InitializeComponent();
            CipherModeComboBox.SelectedIndex = 0;
        }

        private void PasteDESKeyButton_Click(object sender, EventArgs e)
        {
            DESKeyTextBox.Text = Clipboard.GetText();
        }

        private void PasteIVButton_Click(object sender, EventArgs e)
        {
            DESIVTextBox.Text = Clipboard.GetText();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            if (DESKeyTextBox.TextLength != 8 || DESIVTextBox.TextLength != 8)
            {
                MessageBox.Show("Key and IV must be exactly 8 characters long for DES encryption.", "Invalid Key/IV Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                DialogResult = DialogResult.None;
                return;
            }
            key = DESKeyTextBox.Text;
            iv = DESIVTextBox.Text;
            mode = CipherModeComboBox?.SelectedItem?.ToString() ?? "CBC";
        }

        private void ClearKeyButton_Click(object sender, EventArgs e)
        {
            DESKeyTextBox.Clear();
        }

        private void ClearIVButton_Click(object sender, EventArgs e)
        {
            DESIVTextBox.Clear();
        }
    }
}
