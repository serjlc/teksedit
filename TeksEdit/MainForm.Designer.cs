namespace TeksEdit
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewFile = new System.Windows.Forms.ToolStripButton();
            this.OpenFile = new System.Windows.Forms.ToolStripButton();
            this.SaveFile = new System.Windows.Forms.ToolStripButton();
            this.PrintFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.undoToolbar = new System.Windows.Forms.ToolStripButton();
            this.redoToolbar = new System.Windows.Forms.ToolStripButton();
            this.cutToolbar = new System.Windows.Forms.ToolStripButton();
            this.copyToolbar = new System.Windows.Forms.ToolStripButton();
            this.Paste = new System.Windows.Forms.ToolStripButton();
            this.SelectAll = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Bold = new System.Windows.Forms.ToolStripButton();
            this.Italics = new System.Windows.Forms.ToolStripButton();
            this.Underline = new System.Windows.Forms.ToolStripButton();
            this.Strikethrough = new System.Windows.Forms.ToolStripButton();
            this.Regular = new System.Windows.Forms.ToolStripButton();
            this.FontColor = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DateAndTime = new System.Windows.Forms.ToolStripButton();
            this.About = new System.Windows.Forms.ToolStripButton();
            this.WordCount = new System.Windows.Forms.ToolStripLabel();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.italicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.underlineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strikethroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.ToolStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // RichTextBox
            // 
            this.RichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox.Location = new System.Drawing.Point(0, 24);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(800, 401);
            this.RichTextBox.TabIndex = 0;
            this.RichTextBox.Text = "";
            this.RichTextBox.TextChanged += new System.EventHandler(this.RichTextBox_TextChanged);
            // 
            // ToolStrip
            // 
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewFile,
            this.OpenFile,
            this.SaveFile,
            this.PrintFile,
            this.toolStripSeparator1,
            this.undoToolbar,
            this.redoToolbar,
            this.cutToolbar,
            this.copyToolbar,
            this.Paste,
            this.SelectAll,
            this.toolStripSeparator3,
            this.Bold,
            this.Italics,
            this.Underline,
            this.Strikethrough,
            this.Regular,
            this.FontColor,
            this.toolStripSeparator2,
            this.DateAndTime,
            this.About,
            this.WordCount});
            this.ToolStrip.Location = new System.Drawing.Point(0, 425);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Size = new System.Drawing.Size(800, 25);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // NewFile
            // 
            this.NewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewFile.Image = global::TeksEdit.Properties.Resources.new_document;
            this.NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewFile.Name = "NewFile";
            this.NewFile.Size = new System.Drawing.Size(23, 22);
            this.NewFile.Text = "New File";
            this.NewFile.Click += new System.EventHandler(this.ToolbarNewFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenFile.Image = global::TeksEdit.Properties.Resources.folder;
            this.OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(23, 22);
            this.OpenFile.Text = "Open File";
            this.OpenFile.Click += new System.EventHandler(this.ToolbarOpenFile_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveFile.Image = global::TeksEdit.Properties.Resources.floppy_disk;
            this.SaveFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(23, 22);
            this.SaveFile.Text = "Save";
            this.SaveFile.Click += new System.EventHandler(this.ToolbarSaveFile_Click);
            // 
            // PrintFile
            // 
            this.PrintFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PrintFile.Image = global::TeksEdit.Properties.Resources.printer;
            this.PrintFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrintFile.Name = "PrintFile";
            this.PrintFile.Size = new System.Drawing.Size(23, 22);
            this.PrintFile.Text = "Print";
            this.PrintFile.Click += new System.EventHandler(this.ToolbarPrintFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // undoToolbar
            // 
            this.undoToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.undoToolbar.Enabled = false;
            this.undoToolbar.Image = global::TeksEdit.Properties.Resources.undo;
            this.undoToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.undoToolbar.Name = "undoToolbar";
            this.undoToolbar.Size = new System.Drawing.Size(23, 22);
            this.undoToolbar.Text = "Undo";
            this.undoToolbar.Click += new System.EventHandler(this.ToolbarUndo_Click);
            // 
            // redoToolbar
            // 
            this.redoToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.redoToolbar.Enabled = false;
            this.redoToolbar.Image = global::TeksEdit.Properties.Resources.redo;
            this.redoToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.redoToolbar.Name = "redoToolbar";
            this.redoToolbar.Size = new System.Drawing.Size(23, 22);
            this.redoToolbar.Text = "Redo";
            this.redoToolbar.Click += new System.EventHandler(this.ToolbarRedo_Click);
            // 
            // cutToolbar
            // 
            this.cutToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolbar.Enabled = false;
            this.cutToolbar.Image = global::TeksEdit.Properties.Resources.scissors;
            this.cutToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolbar.Name = "cutToolbar";
            this.cutToolbar.Size = new System.Drawing.Size(23, 22);
            this.cutToolbar.Text = "Cut";
            this.cutToolbar.Click += new System.EventHandler(this.ToolbarCut_Click);
            // 
            // copyToolbar
            // 
            this.copyToolbar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolbar.Enabled = false;
            this.copyToolbar.Image = global::TeksEdit.Properties.Resources.copy;
            this.copyToolbar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolbar.Name = "copyToolbar";
            this.copyToolbar.Size = new System.Drawing.Size(23, 22);
            this.copyToolbar.Text = "Copy";
            this.copyToolbar.Click += new System.EventHandler(this.ToolbarCopy_Click);
            // 
            // Paste
            // 
            this.Paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Paste.Image = global::TeksEdit.Properties.Resources.medicine;
            this.Paste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(23, 22);
            this.Paste.Text = "Paste";
            this.Paste.Click += new System.EventHandler(this.ToolbarPaste_Click);
            // 
            // SelectAll
            // 
            this.SelectAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SelectAll.Image = global::TeksEdit.Properties.Resources.selection;
            this.SelectAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.Size = new System.Drawing.Size(23, 22);
            this.SelectAll.Text = "Select All";
            this.SelectAll.Click += new System.EventHandler(this.ToolbarSelectAll_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Bold
            // 
            this.Bold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Bold.Image = global::TeksEdit.Properties.Resources.bold;
            this.Bold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Bold.Name = "Bold";
            this.Bold.Size = new System.Drawing.Size(23, 22);
            this.Bold.Text = "Bold";
            this.Bold.Click += new System.EventHandler(this.ToolbarBold_Click);
            // 
            // Italics
            // 
            this.Italics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Italics.Image = global::TeksEdit.Properties.Resources.italic_font;
            this.Italics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Italics.Name = "Italics";
            this.Italics.Size = new System.Drawing.Size(23, 22);
            this.Italics.Text = "Italics";
            this.Italics.Click += new System.EventHandler(this.ToolbarItalics_Click);
            // 
            // Underline
            // 
            this.Underline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Underline.Image = global::TeksEdit.Properties.Resources.underline1;
            this.Underline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Underline.Name = "Underline";
            this.Underline.Size = new System.Drawing.Size(23, 22);
            this.Underline.Text = "Underline";
            this.Underline.Click += new System.EventHandler(this.ToolbarUnderline_Click);
            // 
            // Strikethrough
            // 
            this.Strikethrough.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Strikethrough.Image = global::TeksEdit.Properties.Resources.strikethrough_font_variant;
            this.Strikethrough.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Strikethrough.Name = "Strikethrough";
            this.Strikethrough.Size = new System.Drawing.Size(23, 22);
            this.Strikethrough.Text = "Strikethrough";
            this.Strikethrough.Click += new System.EventHandler(this.ToolbarStrikethrough_Click);
            // 
            // Regular
            // 
            this.Regular.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Regular.Image = global::TeksEdit.Properties.Resources.texto;
            this.Regular.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Regular.Name = "Regular";
            this.Regular.Size = new System.Drawing.Size(23, 22);
            this.Regular.Text = "Regular";
            this.Regular.Click += new System.EventHandler(this.ToolbarRegular_Click);
            // 
            // FontColor
            // 
            this.FontColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FontColor.Image = global::TeksEdit.Properties.Resources.color_palette;
            this.FontColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontColor.Name = "FontColor";
            this.FontColor.Size = new System.Drawing.Size(23, 22);
            this.FontColor.Text = "Font Color";
            this.FontColor.Click += new System.EventHandler(this.ToolbarFontColor_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DateAndTime
            // 
            this.DateAndTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DateAndTime.Image = global::TeksEdit.Properties.Resources.clock;
            this.DateAndTime.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DateAndTime.Name = "DateAndTime";
            this.DateAndTime.Size = new System.Drawing.Size(23, 22);
            this.DateAndTime.Text = "Date and Time";
            this.DateAndTime.Click += new System.EventHandler(this.ToolbarDateTime_Click);
            // 
            // About
            // 
            this.About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.About.Image = global::TeksEdit.Properties.Resources.information;
            this.About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(23, 22);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.ToolbarAbout_Click);
            // 
            // WordCount
            // 
            this.WordCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.WordCount.Name = "WordCount";
            this.WordCount.Size = new System.Drawing.Size(47, 22);
            this.WordCount.Text = "Words: ";
            this.WordCount.Click += new System.EventHandler(this.WordCount_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(800, 24);
            this.MenuStrip.TabIndex = 2;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.printToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.MenuNew_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.MenuOpen_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.MenuSave_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.MenuSaveAs_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.MenuPrint_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.MenuExit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.MenuUndo_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.MenuRedo_Click);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Enabled = false;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.MenuCut_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Enabled = false;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.MenuCopy_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.MenuPaste_Click);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.MenuSelectAll_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boldToolStripMenuItem,
            this.italicsToolStripMenuItem,
            this.underlineToolStripMenuItem,
            this.strikethroughToolStripMenuItem,
            this.regularToolStripMenuItem,
            this.toolStripMenuItem1,
            this.colorToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // boldToolStripMenuItem
            // 
            this.boldToolStripMenuItem.Enabled = false;
            this.boldToolStripMenuItem.Name = "boldToolStripMenuItem";
            this.boldToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.boldToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.boldToolStripMenuItem.Text = "Bold";
            this.boldToolStripMenuItem.Click += new System.EventHandler(this.MenuBold_Click);
            // 
            // italicsToolStripMenuItem
            // 
            this.italicsToolStripMenuItem.Enabled = false;
            this.italicsToolStripMenuItem.Name = "italicsToolStripMenuItem";
            this.italicsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.italicsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.italicsToolStripMenuItem.Text = "Italics";
            this.italicsToolStripMenuItem.Click += new System.EventHandler(this.MenuItalics_Click);
            // 
            // underlineToolStripMenuItem
            // 
            this.underlineToolStripMenuItem.Enabled = false;
            this.underlineToolStripMenuItem.Name = "underlineToolStripMenuItem";
            this.underlineToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.underlineToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.underlineToolStripMenuItem.Text = "Underline";
            this.underlineToolStripMenuItem.Click += new System.EventHandler(this.MenuUnderline);
            // 
            // strikethroughToolStripMenuItem
            // 
            this.strikethroughToolStripMenuItem.Enabled = false;
            this.strikethroughToolStripMenuItem.Name = "strikethroughToolStripMenuItem";
            this.strikethroughToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.X)));
            this.strikethroughToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.strikethroughToolStripMenuItem.Text = "Strikethrough";
            this.strikethroughToolStripMenuItem.Click += new System.EventHandler(this.MenuStrike_Click);
            // 
            // regularToolStripMenuItem
            // 
            this.regularToolStripMenuItem.Enabled = false;
            this.regularToolStripMenuItem.Name = "regularToolStripMenuItem";
            this.regularToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.regularToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.regularToolStripMenuItem.Text = "Regular";
            this.regularToolStripMenuItem.Click += new System.EventHandler(this.MenuRegular_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 6);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.colorToolStripMenuItem.Text = "Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.MenuColor_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateAndTimeToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // dateAndTimeToolStripMenuItem
            // 
            this.dateAndTimeToolStripMenuItem.Name = "dateAndTimeToolStripMenuItem";
            this.dateAndTimeToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.dateAndTimeToolStripMenuItem.Text = "Date and Time";
            this.dateAndTimeToolStripMenuItem.Click += new System.EventHandler(this.MenuDateTime_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.MenuAbout_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            this.OpenFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog_FileOk);
            // 
            // SaveFileDialog
            // 
            this.SaveFileDialog.DefaultExt = "txt";
            this.SaveFileDialog.Filter = "txt files (*.txt)|*.txt";
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "MainForm";
            this.Text = "TeksEdit - Untitled";
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox RichTextBox;
        private ToolStrip ToolStrip;
        private ToolStripButton OpenFile;
        private ToolStripButton SaveFile;
        private ToolStripButton PrintFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton undoToolbar;
        private ToolStripButton redoToolbar;
        private ToolStripButton cutToolbar;
        private ToolStripButton copyToolbar;
        private ToolStripButton Paste;
        private ToolStripButton SelectAll;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton Bold;
        private ToolStripButton Italics;
        private ToolStripButton Underline;
        private ToolStripButton Strikethrough;
        private ToolStripButton Regular;
        private ToolStripButton FontColor;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton DateAndTime;
        private ToolStripButton About;
        private ToolStripButton NewFile;
        private MenuStrip MenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fontToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem boldToolStripMenuItem;
        private ToolStripMenuItem italicsToolStripMenuItem;
        private ToolStripMenuItem underlineToolStripMenuItem;
        private ToolStripMenuItem strikethroughToolStripMenuItem;
        private ToolStripMenuItem regularToolStripMenuItem;
        private ToolStripMenuItem colorToolStripMenuItem;
        private ToolStripMenuItem dateAndTimeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private OpenFileDialog OpenFileDialog;
        private SaveFileDialog SaveFileDialog;
        private PrintDialog PrintDialog;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private ColorDialog ColorDialog;
        private ToolStripLabel WordCount;
    }
}