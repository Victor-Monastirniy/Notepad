namespace Notepad
{
    partial class NotepadForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            MainMenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            exitApplicationToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            dateTimeToolStripMenuItem = new ToolStripMenuItem();
            formatToolStripMenuItem = new ToolStripMenuItem();
            formatFontToolStripMenuItem = new ToolStripMenuItem();
            changeTextColorToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            normalToolStripMenuItem = new ToolStripMenuItem();
            boldToolStripMenuItem = new ToolStripMenuItem();
            italicToolStripMenuItem = new ToolStripMenuItem();
            underlineToolStripMenuItem = new ToolStripMenuItem();
            strikethroughToolStripMenuItem = new ToolStripMenuItem();
            ciphersToolStripMenuItem = new ToolStripMenuItem();
            caesarCipherToolStripMenuItem = new ToolStripMenuItem();
            encodeToolStripMenuItem = new ToolStripMenuItem();
            decodeToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutNotepadToolStripMenuItem = new ToolStripMenuItem();
            developerToolStripMenuItem = new ToolStripMenuItem();
            MainRichTextBox = new RichTextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            undoToolStripMenuItem1 = new ToolStripMenuItem();
            redoToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem6 = new ToolStripSeparator();
            normalToolStripMenuItem1 = new ToolStripMenuItem();
            boldToolStripMenuItem1 = new ToolStripMenuItem();
            italicToolStripMenuItem1 = new ToolStripMenuItem();
            underlineToolStripMenuItem1 = new ToolStripMenuItem();
            strikethroughToolStripMenuItem1 = new ToolStripMenuItem();
            toolStripContainer1 = new ToolStripContainer();
            statusStrip1 = new StatusStrip();
            MessageToolStripStatusLabel = new ToolStripStatusLabel();
            CapsToolStripStatusLabel = new ToolStripStatusLabel();
            toolStrip1 = new ToolStrip();
            MainMenuStrip.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, ciphersToolStripMenuItem, helpToolStripMenuItem });
            MainMenuStrip.Location = new Point(0, 0);
            MainMenuStrip.Name = "MainMenuStrip";
            MainMenuStrip.Size = new Size(800, 28);
            MainMenuStrip.TabIndex = 0;
            MainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripMenuItem1, openToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem2, printPreviewToolStripMenuItem, printToolStripMenuItem, exitApplicationToolStripMenuItem, fileToolStripMenuItem1 });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(197, 26);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(194, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(197, 26);
            openToolStripMenuItem.Text = "&Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(197, 26);
            saveToolStripMenuItem.Text = "&Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(197, 26);
            saveAsToolStripMenuItem.Text = "Sa&ve As";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(194, 6);
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(197, 26);
            printPreviewToolStripMenuItem.Text = "&Print Preview";
            printPreviewToolStripMenuItem.Click += printPreviewToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(197, 26);
            printToolStripMenuItem.Text = "P&rint";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // exitApplicationToolStripMenuItem
            // 
            exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            exitApplicationToolStripMenuItem.Size = new Size(197, 26);
            exitApplicationToolStripMenuItem.Text = "E&xit Application";
            exitApplicationToolStripMenuItem.Click += exitApplicationToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(197, 26);
            fileToolStripMenuItem1.Text = "&File";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem3, selectAllToolStripMenuItem, dateTimeToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Enabled = false;
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(179, 26);
            undoToolStripMenuItem.Text = "&Undo";
            undoToolStripMenuItem.Click += undoToolStripMenuItem_Click;
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(179, 26);
            redoToolStripMenuItem.Text = "&Redo";
            redoToolStripMenuItem.Click += redoToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(176, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(179, 26);
            selectAllToolStripMenuItem.Text = "&Select All";
            selectAllToolStripMenuItem.Click += selectAllToolStripMenuItem_Click;
            // 
            // dateTimeToolStripMenuItem
            // 
            dateTimeToolStripMenuItem.Name = "dateTimeToolStripMenuItem";
            dateTimeToolStripMenuItem.Size = new Size(179, 26);
            dateTimeToolStripMenuItem.Text = "Date/Time";
            dateTimeToolStripMenuItem.Click += dateTimeToolStripMenuItem_Click;
            // 
            // formatToolStripMenuItem
            // 
            formatToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formatFontToolStripMenuItem, changeTextColorToolStripMenuItem, toolStripMenuItem4, normalToolStripMenuItem, boldToolStripMenuItem, italicToolStripMenuItem, underlineToolStripMenuItem, strikethroughToolStripMenuItem });
            formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            formatToolStripMenuItem.Size = new Size(70, 24);
            formatToolStripMenuItem.Text = "F&ormat";
            // 
            // formatFontToolStripMenuItem
            // 
            formatFontToolStripMenuItem.Name = "formatFontToolStripMenuItem";
            formatFontToolStripMenuItem.Size = new Size(213, 26);
            formatFontToolStripMenuItem.Text = "Format Font";
            formatFontToolStripMenuItem.Click += formatFontToolStripMenuItem_Click;
            // 
            // changeTextColorToolStripMenuItem
            // 
            changeTextColorToolStripMenuItem.Name = "changeTextColorToolStripMenuItem";
            changeTextColorToolStripMenuItem.Size = new Size(213, 26);
            changeTextColorToolStripMenuItem.Text = "Change Text Color";
            changeTextColorToolStripMenuItem.Click += changeTextColorToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(210, 6);
            // 
            // normalToolStripMenuItem
            // 
            normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            normalToolStripMenuItem.Size = new Size(213, 26);
            normalToolStripMenuItem.Text = "Normal";
            normalToolStripMenuItem.Click += normalToolStripMenuItem_Click;
            // 
            // boldToolStripMenuItem
            // 
            boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            boldToolStripMenuItem.Size = new Size(213, 26);
            boldToolStripMenuItem.Text = "Bold";
            boldToolStripMenuItem.Click += boldToolStripMenuItem_Click;
            // 
            // italicToolStripMenuItem
            // 
            italicToolStripMenuItem.Name = "italicToolStripMenuItem";
            italicToolStripMenuItem.Size = new Size(213, 26);
            italicToolStripMenuItem.Text = "Italic";
            italicToolStripMenuItem.Click += italicToolStripMenuItem_Click;
            // 
            // underlineToolStripMenuItem
            // 
            underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            underlineToolStripMenuItem.Size = new Size(213, 26);
            underlineToolStripMenuItem.Text = "&Underline";
            underlineToolStripMenuItem.Click += underlineToolStripMenuItem_Click;
            // 
            // strikethroughToolStripMenuItem
            // 
            strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            strikethroughToolStripMenuItem.Size = new Size(213, 26);
            strikethroughToolStripMenuItem.Text = "Strikethrough";
            strikethroughToolStripMenuItem.Click += strikethroughToolStripMenuItem_Click;
            // 
            // ciphersToolStripMenuItem
            // 
            ciphersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { caesarCipherToolStripMenuItem });
            ciphersToolStripMenuItem.Name = "ciphersToolStripMenuItem";
            ciphersToolStripMenuItem.Size = new Size(72, 24);
            ciphersToolStripMenuItem.Text = "Ciphers";
            // 
            // caesarCipherToolStripMenuItem
            // 
            caesarCipherToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { encodeToolStripMenuItem, decodeToolStripMenuItem });
            caesarCipherToolStripMenuItem.Name = "caesarCipherToolStripMenuItem";
            caesarCipherToolStripMenuItem.Size = new Size(224, 26);
            caesarCipherToolStripMenuItem.Text = "Caesar Cipher";
            // 
            // encodeToolStripMenuItem
            // 
            encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            encodeToolStripMenuItem.Size = new Size(224, 26);
            encodeToolStripMenuItem.Text = "Encode";
            encodeToolStripMenuItem.Click += encodeToolStripMenuItem_Click;
            // 
            // decodeToolStripMenuItem
            // 
            decodeToolStripMenuItem.Name = "decodeToolStripMenuItem";
            decodeToolStripMenuItem.Size = new Size(224, 26);
            decodeToolStripMenuItem.Text = "Decode";
            decodeToolStripMenuItem.Click += decodeToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutNotepadToolStripMenuItem, developerToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(55, 24);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutNotepadToolStripMenuItem
            // 
            aboutNotepadToolStripMenuItem.Name = "aboutNotepadToolStripMenuItem";
            aboutNotepadToolStripMenuItem.Size = new Size(196, 26);
            aboutNotepadToolStripMenuItem.Text = "&About Notepad";
            aboutNotepadToolStripMenuItem.Click += aboutNotepadToolStripMenuItem_Click;
            // 
            // developerToolStripMenuItem
            // 
            developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            developerToolStripMenuItem.Size = new Size(196, 26);
            developerToolStripMenuItem.Text = "Developer";
            developerToolStripMenuItem.Click += developerToolStripMenuItem_Click;
            // 
            // MainRichTextBox
            // 
            MainRichTextBox.ContextMenuStrip = contextMenuStrip1;
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.Font = new Font("Segoe UI", 12F);
            MainRichTextBox.Location = new Point(0, 0);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            MainRichTextBox.Size = new Size(800, 331);
            MainRichTextBox.TabIndex = 1;
            MainRichTextBox.Text = "";
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            MainRichTextBox.KeyDown += MainRichTextBox_KeyDown;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { undoToolStripMenuItem1, redoToolStripMenuItem1, toolStripMenuItem5, cutToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripMenuItem6, normalToolStripMenuItem1, boldToolStripMenuItem1, italicToolStripMenuItem1, underlineToolStripMenuItem1, strikethroughToolStripMenuItem1 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(168, 256);
            // 
            // undoToolStripMenuItem1
            // 
            undoToolStripMenuItem1.Name = "undoToolStripMenuItem1";
            undoToolStripMenuItem1.Size = new Size(167, 24);
            undoToolStripMenuItem1.Text = "Undo";
            undoToolStripMenuItem1.Click += undoToolStripMenuItem1_Click;
            // 
            // redoToolStripMenuItem1
            // 
            redoToolStripMenuItem1.Name = "redoToolStripMenuItem1";
            redoToolStripMenuItem1.Size = new Size(167, 24);
            redoToolStripMenuItem1.Text = "Redo";
            redoToolStripMenuItem1.Click += redoToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(164, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.Size = new Size(167, 24);
            cutToolStripMenuItem.Text = "Cut";
            cutToolStripMenuItem.Click += cutToolStripMenuItem_Click;
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(167, 24);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(167, 24);
            pasteToolStripMenuItem.Text = "Paste";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // toolStripMenuItem6
            // 
            toolStripMenuItem6.Name = "toolStripMenuItem6";
            toolStripMenuItem6.Size = new Size(164, 6);
            // 
            // normalToolStripMenuItem1
            // 
            normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            normalToolStripMenuItem1.Size = new Size(167, 24);
            normalToolStripMenuItem1.Text = "&Normal";
            normalToolStripMenuItem1.Click += normalToolStripMenuItem1_Click;
            // 
            // boldToolStripMenuItem1
            // 
            boldToolStripMenuItem1.Name = "boldToolStripMenuItem1";
            boldToolStripMenuItem1.Size = new Size(167, 24);
            boldToolStripMenuItem1.Text = "Bold";
            boldToolStripMenuItem1.Click += boldToolStripMenuItem1_Click;
            // 
            // italicToolStripMenuItem1
            // 
            italicToolStripMenuItem1.Name = "italicToolStripMenuItem1";
            italicToolStripMenuItem1.Size = new Size(167, 24);
            italicToolStripMenuItem1.Text = "Italic";
            italicToolStripMenuItem1.Click += italicToolStripMenuItem1_Click;
            // 
            // underlineToolStripMenuItem1
            // 
            underlineToolStripMenuItem1.Name = "underlineToolStripMenuItem1";
            underlineToolStripMenuItem1.Size = new Size(167, 24);
            underlineToolStripMenuItem1.Text = "Underline";
            underlineToolStripMenuItem1.Click += underlineToolStripMenuItem1_Click;
            // 
            // strikethroughToolStripMenuItem1
            // 
            strikethroughToolStripMenuItem1.Name = "strikethroughToolStripMenuItem1";
            strikethroughToolStripMenuItem1.Size = new Size(167, 24);
            strikethroughToolStripMenuItem1.Text = "Strikethrough";
            strikethroughToolStripMenuItem1.Click += strikethroughToolStripMenuItem1_Click;
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip1);
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(MainRichTextBox);
            toolStripContainer1.ContentPanel.Size = new Size(800, 331);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.LeftToolStripPanelVisible = false;
            toolStripContainer1.Location = new Point(0, 28);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.RightToolStripPanelVisible = false;
            toolStripContainer1.Size = new Size(800, 361);
            toolStripContainer1.TabIndex = 2;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
            toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.Dock = DockStyle.None;
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { MessageToolStripStatusLabel, CapsToolStripStatusLabel });
            statusStrip1.Location = new Point(0, 0);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 30);
            statusStrip1.TabIndex = 0;
            // 
            // MessageToolStripStatusLabel
            // 
            MessageToolStripStatusLabel.AutoSize = false;
            MessageToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            MessageToolStripStatusLabel.BorderStyle = Border3DStyle.Sunken;
            MessageToolStripStatusLabel.Name = "MessageToolStripStatusLabel";
            MessageToolStripStatusLabel.Size = new Size(350, 24);
            MessageToolStripStatusLabel.Text = "New File (unsaved)";
            // 
            // CapsToolStripStatusLabel
            // 
            CapsToolStripStatusLabel.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
            CapsToolStripStatusLabel.BorderStyle = Border3DStyle.Sunken;
            CapsToolStripStatusLabel.Name = "CapsToolStripStatusLabel";
            CapsToolStripStatusLabel.Size = new Size(74, 24);
            CapsToolStripStatusLabel.Text = "CAPS ON";
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.None;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Location = new Point(4, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(112, 25);
            toolStrip1.TabIndex = 0;
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 389);
            Controls.Add(toolStripContainer1);
            Controls.Add(MainMenuStrip);
            Name = "NotepadForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Untitled - Notepad";
            Load += NotepadForm_Load;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            toolStripContainer1.BottomToolStripPanel.PerformLayout();
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip MainMenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutNotepadToolStripMenuItem;
        private ToolStripMenuItem exitApplicationToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private RichTextBox MainRichTextBox;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem dateTimeToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem formatFontToolStripMenuItem;
        private ToolStripMenuItem changeTextColorToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikethroughToolStripMenuItem;
        private ToolStripMenuItem normalToolStripMenuItem;
        private ToolStripContainer toolStripContainer1;
        private ToolStrip toolStrip1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel MessageToolStripStatusLabel;
        private ToolStripStatusLabel CapsToolStripStatusLabel;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem undoToolStripMenuItem1;
        private ToolStripMenuItem redoToolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem normalToolStripMenuItem1;
        private ToolStripMenuItem boldToolStripMenuItem1;
        private ToolStripMenuItem italicToolStripMenuItem1;
        private ToolStripMenuItem underlineToolStripMenuItem1;
        private ToolStripMenuItem strikethroughToolStripMenuItem1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem developerToolStripMenuItem;
        private ToolStripMenuItem ciphersToolStripMenuItem;
        private ToolStripMenuItem caesarCipherToolStripMenuItem;
        private ToolStripMenuItem encodeToolStripMenuItem;
        private ToolStripMenuItem decodeToolStripMenuItem;
    }
}
