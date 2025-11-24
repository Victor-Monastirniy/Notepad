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
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutNotepadToolStripMenuItem = new ToolStripMenuItem();
            MainRichTextBox = new RichTextBox();
            MainMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // MainMenuStrip
            // 
            MainMenuStrip.ImageScalingSize = new Size(20, 20);
            MainMenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, formatToolStripMenuItem, helpToolStripMenuItem });
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
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(197, 26);
            printToolStripMenuItem.Text = "P&rint";
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
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutNotepadToolStripMenuItem });
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
            // MainRichTextBox
            // 
            MainRichTextBox.Dock = DockStyle.Fill;
            MainRichTextBox.Font = new Font("Segoe UI", 12F);
            MainRichTextBox.Location = new Point(0, 28);
            MainRichTextBox.Name = "MainRichTextBox";
            MainRichTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            MainRichTextBox.Size = new Size(800, 422);
            MainRichTextBox.TabIndex = 1;
            MainRichTextBox.Text = "";
            MainRichTextBox.TextChanged += MainRichTextBox_TextChanged;
            // 
            // NotepadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainRichTextBox);
            Controls.Add(MainMenuStrip);
            Name = "NotepadForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Untitled - Notepad";
            Load += NotepadForm_Load;
            MainMenuStrip.ResumeLayout(false);
            MainMenuStrip.PerformLayout();
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
    }
}
