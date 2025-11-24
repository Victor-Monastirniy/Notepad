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
    public partial class GammaCipherDecode : Form
    {

        public string textToEncode;
        public string gamma = String.Empty;


        public GammaCipherDecode(string textToEncode)
        {
            InitializeComponent();
            this.textToEncode = textToEncode;
        }

        private void decryptText_Click(object sender, EventArgs e)
        {
            gamma = gammaTextBoxDecode.Text;
        }

        private void pasteGamma_Click(object sender, EventArgs e)
        {
            gammaTextBoxDecode.Paste();
        }

        private void gammaTextBoxDecode_TextChanged(object sender, EventArgs e)
        {
            if(gammaTextBoxDecode.Text.Length > 0)
            {
                decryptText.Enabled = true;
            }
            else
            {
                decryptText.Enabled = false;
            }
        }
    }
}
