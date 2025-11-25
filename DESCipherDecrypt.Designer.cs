namespace Notepad
{
    partial class DESCipherDecrypt
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
            CancelButton = new Button();
            DecryptButton = new Button();
            label3 = new Label();
            PasteIVButton = new Button();
            label4 = new Label();
            DESIVTextBox = new TextBox();
            PasteDESKeyButton = new Button();
            label2 = new Label();
            CipherModeComboBox = new ComboBox();
            DESKeyTextBox = new TextBox();
            label1 = new Label();
            ClearKeyButton = new Button();
            ClearIVButton = new Button();
            SuspendLayout();
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(399, 409);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 28;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // DecryptButton
            // 
            DecryptButton.DialogResult = DialogResult.OK;
            DecryptButton.Location = new Point(15, 363);
            DecryptButton.Name = "DecryptButton";
            DecryptButton.Size = new Size(478, 29);
            DecryptButton.TabIndex = 27;
            DecryptButton.Text = "Decrypt";
            DecryptButton.UseVisualStyleBackColor = true;
            DecryptButton.Click += DecryptButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(40, 281);
            label3.Name = "label3";
            label3.Size = new Size(230, 23);
            label3.TabIndex = 26;
            label3.Text = "Choose DES Crypto Method:";
            // 
            // PasteIVButton
            // 
            PasteIVButton.Location = new Point(268, 205);
            PasteIVButton.Name = "PasteIVButton";
            PasteIVButton.Size = new Size(94, 29);
            PasteIVButton.TabIndex = 25;
            PasteIVButton.Text = "Paste IV";
            PasteIVButton.UseVisualStyleBackColor = true;
            PasteIVButton.Click += PasteIVButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(40, 176);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 23;
            label4.Text = "DES Chipher IV:";
            // 
            // DESIVTextBox
            // 
            DESIVTextBox.Location = new Point(188, 172);
            DESIVTextBox.Name = "DESIVTextBox";
            DESIVTextBox.Size = new Size(274, 27);
            DESIVTextBox.TabIndex = 22;
            // 
            // PasteDESKeyButton
            // 
            PasteDESKeyButton.Location = new Point(268, 101);
            PasteDESKeyButton.Name = "PasteDESKeyButton";
            PasteDESKeyButton.Size = new Size(94, 29);
            PasteDESKeyButton.TabIndex = 21;
            PasteDESKeyButton.Text = "Paste Key";
            PasteDESKeyButton.UseVisualStyleBackColor = true;
            PasteDESKeyButton.Click += PasteDESKeyButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 72);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 19;
            label2.Text = "DES Chipher Key:";
            // 
            // CipherModeComboBox
            // 
            CipherModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CipherModeComboBox.FormattingEnabled = true;
            CipherModeComboBox.Items.AddRange(new object[] { "CBC", "CFB", "CTS", "ECB" });
            CipherModeComboBox.Location = new Point(311, 276);
            CipherModeComboBox.Name = "CipherModeComboBox";
            CipherModeComboBox.Size = new Size(151, 28);
            CipherModeComboBox.TabIndex = 18;
            // 
            // DESKeyTextBox
            // 
            DESKeyTextBox.Location = new Point(188, 68);
            DESKeyTextBox.Name = "DESKeyTextBox";
            DESKeyTextBox.Size = new Size(274, 27);
            DESKeyTextBox.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(15, 9);
            label1.Name = "label1";
            label1.Size = new Size(305, 38);
            label1.TabIndex = 16;
            label1.Text = "Cypher Decrypt Menu";
            // 
            // ClearKeyButton
            // 
            ClearKeyButton.Location = new Point(368, 101);
            ClearKeyButton.Name = "ClearKeyButton";
            ClearKeyButton.Size = new Size(94, 29);
            ClearKeyButton.TabIndex = 29;
            ClearKeyButton.Text = "Clear Key";
            ClearKeyButton.UseVisualStyleBackColor = true;
            ClearKeyButton.Click += ClearKeyButton_Click;
            // 
            // ClearIVButton
            // 
            ClearIVButton.Location = new Point(368, 205);
            ClearIVButton.Name = "ClearIVButton";
            ClearIVButton.Size = new Size(94, 29);
            ClearIVButton.TabIndex = 30;
            ClearIVButton.Text = "Clear IV";
            ClearIVButton.UseVisualStyleBackColor = true;
            ClearIVButton.Click += ClearIVButton_Click;
            // 
            // DESCipherDecrypt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(ClearIVButton);
            Controls.Add(ClearKeyButton);
            Controls.Add(CancelButton);
            Controls.Add(DecryptButton);
            Controls.Add(label3);
            Controls.Add(PasteIVButton);
            Controls.Add(label4);
            Controls.Add(DESIVTextBox);
            Controls.Add(PasteDESKeyButton);
            Controls.Add(label2);
            Controls.Add(CipherModeComboBox);
            Controls.Add(DESKeyTextBox);
            Controls.Add(label1);
            Name = "DESCipherDecrypt";
            Text = "DES Cipher Decrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CancelButton;
        private Button DecryptButton;
        private Label label3;
        private Button PasteIVButton;
        private Label label4;
        private TextBox DESIVTextBox;
        private Button PasteDESKeyButton;
        private Label label2;
        private ComboBox CipherModeComboBox;
        private TextBox DESKeyTextBox;
        private Label label1;
        private Button ClearKeyButton;
        private Button ClearIVButton;
    }
}