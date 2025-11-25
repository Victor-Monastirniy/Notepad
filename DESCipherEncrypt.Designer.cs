namespace Notepad
{
    partial class DESCipherEncrypt
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
            label1 = new Label();
            DESKeyTextBox = new TextBox();
            CipherModeComboBox = new ComboBox();
            label2 = new Label();
            GenerateDESKeyButton = new Button();
            CopyDESKeyButton = new Button();
            CopyIVButton = new Button();
            GenerateIVButton = new Button();
            label4 = new Label();
            DESIVTextBox = new TextBox();
            label3 = new Label();
            EncryptButton = new Button();
            CancelButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(277, 38);
            label1.TabIndex = 0;
            label1.Text = "Cypher Setup Menu";
            // 
            // DESKeyTextBox
            // 
            DESKeyTextBox.Location = new Point(186, 66);
            DESKeyTextBox.Name = "DESKeyTextBox";
            DESKeyTextBox.Size = new Size(274, 27);
            DESKeyTextBox.TabIndex = 1;
            DESKeyTextBox.TextChanged += DESKeyTextBox_TextChanged;
            // 
            // CipherModeComboBox
            // 
            CipherModeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CipherModeComboBox.FormattingEnabled = true;
            CipherModeComboBox.Items.AddRange(new object[] { "CBC", "CFB", "CTS", "ECB" });
            CipherModeComboBox.Location = new Point(276, 307);
            CipherModeComboBox.Name = "CipherModeComboBox";
            CipherModeComboBox.Size = new Size(151, 28);
            CipherModeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(38, 70);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 5;
            label2.Text = "DES Chipher Key:";
            // 
            // GenerateDESKeyButton
            // 
            GenerateDESKeyButton.Location = new Point(93, 108);
            GenerateDESKeyButton.Name = "GenerateDESKeyButton";
            GenerateDESKeyButton.Size = new Size(161, 29);
            GenerateDESKeyButton.TabIndex = 7;
            GenerateDESKeyButton.Text = "Generate Key";
            GenerateDESKeyButton.UseVisualStyleBackColor = true;
            GenerateDESKeyButton.Click += GenerateDESKeyButton_Click;
            // 
            // CopyDESKeyButton
            // 
            CopyDESKeyButton.Enabled = false;
            CopyDESKeyButton.Location = new Point(292, 108);
            CopyDESKeyButton.Name = "CopyDESKeyButton";
            CopyDESKeyButton.Size = new Size(94, 29);
            CopyDESKeyButton.TabIndex = 8;
            CopyDESKeyButton.Text = "Copy Key";
            CopyDESKeyButton.UseVisualStyleBackColor = true;
            CopyDESKeyButton.Click += CopyDESKeyButton_Click;
            // 
            // CopyIVButton
            // 
            CopyIVButton.Enabled = false;
            CopyIVButton.Location = new Point(292, 226);
            CopyIVButton.Name = "CopyIVButton";
            CopyIVButton.Size = new Size(94, 29);
            CopyIVButton.TabIndex = 12;
            CopyIVButton.Text = "Copy IV";
            CopyIVButton.UseVisualStyleBackColor = true;
            CopyIVButton.Click += CopyIVButton_Click;
            // 
            // GenerateIVButton
            // 
            GenerateIVButton.Location = new Point(93, 226);
            GenerateIVButton.Name = "GenerateIVButton";
            GenerateIVButton.Size = new Size(161, 29);
            GenerateIVButton.TabIndex = 11;
            GenerateIVButton.Text = "Generate IV";
            GenerateIVButton.UseVisualStyleBackColor = true;
            GenerateIVButton.Click += GenerateIVButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(38, 188);
            label4.Name = "label4";
            label4.Size = new Size(130, 23);
            label4.TabIndex = 10;
            label4.Text = "DES Chipher IV:";
            // 
            // DESIVTextBox
            // 
            DESIVTextBox.Location = new Point(186, 184);
            DESIVTextBox.Name = "DESIVTextBox";
            DESIVTextBox.Size = new Size(274, 27);
            DESIVTextBox.TabIndex = 9;
            DESIVTextBox.TextChanged += DESIVTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(24, 308);
            label3.Name = "label3";
            label3.Size = new Size(230, 23);
            label3.TabIndex = 13;
            label3.Text = "Choose DES Crypto Method:";
            // 
            // EncryptButton
            // 
            EncryptButton.DialogResult = DialogResult.OK;
            EncryptButton.Enabled = false;
            EncryptButton.Location = new Point(12, 365);
            EncryptButton.Name = "EncryptButton";
            EncryptButton.Size = new Size(478, 29);
            EncryptButton.TabIndex = 14;
            EncryptButton.Text = "Encrypt";
            EncryptButton.UseVisualStyleBackColor = true;
            EncryptButton.Click += EncryptButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.DialogResult = DialogResult.Cancel;
            CancelButton.Location = new Point(378, 409);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(94, 29);
            CancelButton.TabIndex = 15;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            // 
            // DESCipherEncrypt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(502, 450);
            Controls.Add(CancelButton);
            Controls.Add(EncryptButton);
            Controls.Add(label3);
            Controls.Add(CopyIVButton);
            Controls.Add(GenerateIVButton);
            Controls.Add(label4);
            Controls.Add(DESIVTextBox);
            Controls.Add(CopyDESKeyButton);
            Controls.Add(GenerateDESKeyButton);
            Controls.Add(label2);
            Controls.Add(CipherModeComboBox);
            Controls.Add(DESKeyTextBox);
            Controls.Add(label1);
            Name = "DESCipherEncrypt";
            Text = "DES Cipher Encrypt";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox DESKeyTextBox;
        private ComboBox CipherModeComboBox;
        private Label label2;
        private Button GenerateDESKeyButton;
        private Button CopyDESKeyButton;
        private Button CopyIVButton;
        private Button GenerateIVButton;
        private Label label4;
        private TextBox DESIVTextBox;
        private Label label3;
        private Button EncryptButton;
        private Button CancelButton;
    }
}