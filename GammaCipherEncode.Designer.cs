namespace Notepad
{
    partial class GammaCipherEncode
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
            generateGamma = new Button();
            GammaTextBox = new TextBox();
            copyGamma = new Button();
            encryptText = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // generateGamma
            // 
            generateGamma.Location = new Point(12, 87);
            generateGamma.Name = "generateGamma";
            generateGamma.Size = new Size(171, 29);
            generateGamma.TabIndex = 0;
            generateGamma.Text = "Generate Gamma";
            generateGamma.UseVisualStyleBackColor = true;
            generateGamma.Click += generateGamma_Click;
            // 
            // GammaTextBox
            // 
            GammaTextBox.Location = new Point(12, 43);
            GammaTextBox.Name = "GammaTextBox";
            GammaTextBox.ReadOnly = true;
            GammaTextBox.Size = new Size(337, 27);
            GammaTextBox.TabIndex = 1;
            // 
            // copyGamma
            // 
            copyGamma.Enabled = false;
            copyGamma.Location = new Point(204, 87);
            copyGamma.Name = "copyGamma";
            copyGamma.Size = new Size(145, 29);
            copyGamma.TabIndex = 2;
            copyGamma.Text = "Copy Gamma";
            copyGamma.UseVisualStyleBackColor = true;
            copyGamma.Click += copyGamma_Click;
            // 
            // encryptText
            // 
            encryptText.DialogResult = DialogResult.OK;
            encryptText.Enabled = false;
            encryptText.Location = new Point(12, 180);
            encryptText.Name = "encryptText";
            encryptText.Size = new Size(337, 29);
            encryptText.TabIndex = 3;
            encryptText.Text = "Encrypt Text";
            encryptText.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(234, 231);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(94, 29);
            Cancel.TabIndex = 4;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // GammaCipherEncode
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 272);
            Controls.Add(Cancel);
            Controls.Add(encryptText);
            Controls.Add(copyGamma);
            Controls.Add(GammaTextBox);
            Controls.Add(generateGamma);
            Name = "GammaCipherEncode";
            Text = "Gamma Cipher Encode";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button generateGamma;
        private TextBox GammaTextBox;
        private Button copyGamma;
        private Button encryptText;
        private Button Cancel;
    }
}