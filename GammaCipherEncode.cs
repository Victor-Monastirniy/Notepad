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
    public partial class GammaCipherEncode : Form
    {

        public string textToEncode;
        public string gamma = String.Empty;

        public GammaCipherEncode(string textToEncode)
        {
            InitializeComponent();
            this.textToEncode = textToEncode;
        }

        private void generateGamma_Click(object sender, EventArgs e)
        {
            gamma = Encoders.GammaCipher.GenerateGammaKey(textToEncode.Length, Encoders.GammaCipher.Alphabet);
            GammaTextBox.Text = gamma;
            copyGamma.Enabled = true;
            encryptText.Enabled = true;
        }

        private void copyGamma_Click(object sender, EventArgs e)
        {
            GammaTextBox.SelectAll();
            GammaTextBox.Copy();
        }
    }
}
