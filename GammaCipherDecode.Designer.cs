namespace Notepad
{
    partial class GammaCipherDecode
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
            decryptText = new Button();
            pasteGamma = new Button();
            gammaTextBoxDecode = new TextBox();
            Cancel = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // decryptText
            // 
            decryptText.DialogResult = DialogResult.OK;
            decryptText.Enabled = false;
            decryptText.Location = new Point(12, 129);
            decryptText.Name = "decryptText";
            decryptText.Size = new Size(299, 29);
            decryptText.TabIndex = 4;
            decryptText.Text = "Decrypt Text";
            decryptText.UseVisualStyleBackColor = true;
            decryptText.Click += decryptText_Click;
            // 
            // pasteGamma
            // 
            pasteGamma.Location = new Point(217, 48);
            pasteGamma.Name = "pasteGamma";
            pasteGamma.Size = new Size(94, 29);
            pasteGamma.TabIndex = 5;
            pasteGamma.Text = "Paste";
            pasteGamma.UseVisualStyleBackColor = true;
            pasteGamma.Click += pasteGamma_Click;
            // 
            // gammaTextBoxDecode
            // 
            gammaTextBoxDecode.Location = new Point(12, 48);
            gammaTextBoxDecode.Name = "gammaTextBoxDecode";
            gammaTextBoxDecode.Size = new Size(181, 27);
            gammaTextBoxDecode.TabIndex = 6;
            gammaTextBoxDecode.TextChanged += gammaTextBoxDecode_TextChanged;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(217, 175);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 7;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 8;
            label1.Text = "Gamma:";
            // 
            // GammaCipherDecode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(323, 216);
            Controls.Add(label1);
            Controls.Add(Cancel);
            Controls.Add(gammaTextBoxDecode);
            Controls.Add(pasteGamma);
            Controls.Add(decryptText);
            Name = "GammaCipherDecode";
            Text = "Gamma Cipher Decode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button decryptText;
        private Button pasteGamma;
        private TextBox gammaTextBoxDecode;
        private Button Cancel;
        private Label label1;
    }
}