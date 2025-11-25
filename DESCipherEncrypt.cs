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
    public partial class DESCipherEncrypt : Form
    {
        public string key = String.Empty;
        public string iv = String.Empty;
        public string mode = String.Empty;

        public DESCipherEncrypt()
        {
            InitializeComponent();
            CipherModeComboBox.SelectedIndex = 0;
        }

        private void DESKeyTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DESKeyTextBox.TextLength > 0)
            {
                CopyDESKeyButton.Enabled = true;
                EncryptButton.Enabled = DESIVTextBox.TextLength > 0;
            }
            else
            {
                CopyDESKeyButton.Enabled = false;
                EncryptButton.Enabled = false;
            }
        }

        private void DESIVTextBox_TextChanged(object sender, EventArgs e)
        {
            if (DESIVTextBox.TextLength > 0)
            {
                CopyIVButton.Enabled = true;
                EncryptButton.Enabled = DESKeyTextBox.TextLength > 0;
            }
            else
            {
                CopyIVButton.Enabled = false;
                EncryptButton.Enabled = false;
            }
        }

        private void GenerateDESKeyButton_Click(object sender, EventArgs e)
        {
            DESKeyTextBox.Text = Encoders.CryptoProvider.GenerateKey();
        }

        private void GenerateIVButton_Click(object sender, EventArgs e)
        {
            DESIVTextBox.Text = Encoders.CryptoProvider.GenerateIV();
        }

        private void CopyDESKeyButton_Click(object sender, EventArgs e)
        {
            DESKeyTextBox.SelectAll();
            DESKeyTextBox.Copy();
        }

        private void CopyIVButton_Click(object sender, EventArgs e)
        {
            DESIVTextBox.SelectAll();
            DESIVTextBox.Copy();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            if (DESKeyTextBox.TextLength != 8 || DESIVTextBox.TextLength != 8)
            {
                MessageBox.Show("Key and IV must be exactly 8 characters long for DES encryption.", "Invalid Key/IV Length", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                EncryptButton.Enabled = false;
                DialogResult = DialogResult.None;
                return;
            }
            key = DESKeyTextBox.Text;
            iv = DESIVTextBox.Text;
            mode = CipherModeComboBox?.SelectedItem?.ToString() ?? "CBC";
        }
    }
}
