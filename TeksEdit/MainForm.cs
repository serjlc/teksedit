using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace TeksEdit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        // TOOLBAR ITEMS
        private void ToolbarNewFile_Click(object sender, EventArgs e)
        {
            RichTextBox.Clear();
            this.Text = "TeksEdit - Untitled";
        }

        private void ToolbarOpenFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            using OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string? filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                this.Text = openFileDialog.FileName;
                RichTextBox.Text = fileContent;
            }
        }

        private void ToolbarSaveFile_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.Title = "Save File";

            // Save the selected file

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using Stream data = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
                using StreamWriter writer = new(data);
                writer.Write(RichTextBox.Text);
                this.Text = saveFileDialog.FileName;
            }
        }

        private void ToolbarPrintFile_Click(object sender, EventArgs e)
        {
            //Printer Selection
            PrintDialog printDialog = new PrintDialog();

            //Create Document
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = this.Text;
            printDoc.PrintPage += PrintDoc_PrintPage;
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            //Call ShowDialog
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics!.DrawString(
                this.RichTextBox.Text,
                this.RichTextBox.Font,
                Brushes.Black,
                10,
                25
            );
        }

        private void ToolbarUndo_Click(object sender, EventArgs e)
        {
            RichTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void ToolbarRedo_Click(object sender, EventArgs e)
        {
            RichTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void ToolbarCut_Click(object sender, EventArgs e)
        {
            RichTextBox.Cut();
        }

        private void ToolbarCopy_Click(object sender, EventArgs e)
        {
            RichTextBox.Copy();
        }

        private void ToolbarPaste_Click(object sender, EventArgs e)
        {
            RichTextBox.Paste();
        }

        private void ToolbarSelectAll_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectAll();
        }

        private void ToolbarBold_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Bold);
        }

        private void ToolbarItalics_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Italic);
        }

        private void ToolbarUnderline_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Underline);
        }

        private void ToolbarStrikethrough_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Strikeout);
        }

        private void ToolbarRegular_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Regular);
        }

        private void ToolbarFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            RichTextBox.SelectionColor = colorDialog.Color;
        }

        private void ToolbarDateTime_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += " " + DateTime.Now;
        }

        private void ToolbarAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Version 1.0 2023",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        // MENU ITEMS
        private void MenuNew_Click(object sender, EventArgs e)
        {
            RichTextBox.Clear();
            this.Text = "TeksEdit - Untitled";
        }

        private void MenuOpen_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string? filePath = openFileDialog.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                this.Text = openFileDialog.FileName;
                RichTextBox.Text = fileContent;
            }
        }

        private void MenuSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog.Title = "Save File";

            // Save the selected file

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using Stream data = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
                using StreamWriter writer = new(data);
                writer.Write(RichTextBox.Text);
                this.Text = saveFileDialog.FileName;
            }
        }

        private void MenuSaveAs_Click(object sender, EventArgs e) { }

        private void MenuPrint_Click(object sender, EventArgs e)
        {
            //Printer Selection
            //Printer Selection
            PrintDialog printDialog = new PrintDialog();

            //Create Document
            PrintDocument printDoc = new PrintDocument();
            printDoc.DocumentName = this.Text;
            printDoc.PrintPage += PrintDoc_PrintPage;
            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;
            printDialog.AllowSomePages = true;

            //Call ShowDialog
            if (printDialog.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void MenuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuUndo_Click(object sender, EventArgs e)
        {
            RichTextBox.Undo();
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = true;
        }

        private void MenuRedo_Click(object sender, EventArgs e)
        {
            RichTextBox.Redo();
            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = false;
        }

        private void MenuCut_Click(object sender, EventArgs e)
        {
            RichTextBox.Cut();
        }

        private void MenuCopy_Click(object sender, EventArgs e)
        {
            RichTextBox.Copy();
        }

        private void MenuPaste_Click(object sender, EventArgs e)
        {
            RichTextBox.Paste();
        }

        private void MenuSelectAll_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectAll();
        }

        private void MenuBold_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Bold);
        }

        private void MenuItalics_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Italic);
        }

        private void MenuUnderline(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Underline);
        }

        private void MenuStrike_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Strikeout);
        }

        private void MenuRegular_Click(object sender, EventArgs e)
        {
            RichTextBox.SelectionFont = new Font(RichTextBox.Font, FontStyle.Regular);
        }

        private void MenuColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();

            RichTextBox.SelectionColor = colorDialog.Color;
        }

        private void MenuDateTime_Click(object sender, EventArgs e)
        {
            RichTextBox.Text += " " + DateTime.Now;
        }

        private void MenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Version 1.0 2023",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RichTextBox.Text.Length > 0)
            {
                undoToolStripMenuItem.Enabled = true;
                cutToolStripMenuItem.Enabled = true;
                copyToolStripMenuItem.Enabled = true;
                selectAllToolStripMenuItem.Enabled = true;
                boldToolStripMenuItem.Enabled = true;
                italicsToolStripMenuItem.Enabled = true;
                underlineToolStripMenuItem.Enabled = true;
                strikethroughToolStripMenuItem.Enabled = true;
                regularToolStripMenuItem.Enabled = true;

                undoToolbar.Enabled = true;
                cutToolbar.Enabled = true;
                copyToolbar.Enabled = true;

            }
            else
            {
                undoToolStripMenuItem.Enabled = false;
                redoToolStripMenuItem.Enabled = false;
                cutToolStripMenuItem.Enabled = false;
                copyToolStripMenuItem.Enabled = false;
                selectAllToolStripMenuItem.Enabled = false;
                boldToolStripMenuItem.Enabled = false;
                italicsToolStripMenuItem.Enabled = false;
                underlineToolStripMenuItem.Enabled = false;
                strikethroughToolStripMenuItem.Enabled = false;
                regularToolStripMenuItem.Enabled = false;

                undoToolbar.Enabled = false;
                redoToolbar.Enabled = true;
                cutToolbar.Enabled = false;
                copyToolbar.Enabled = false;
            }

            // Get the text from the RichTextBox control.
            string text = RichTextBox.Text;

            // Split the text into words.
            string[] words = text.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

            // Count the number of words.
            int wordCount = words.Length;
            WordCount.Text = "Words: " + wordCount.ToString();

        }

        private void OpenFileDialog_FileOk(
            object sender,
            System.ComponentModel.CancelEventArgs e
        )
        { }

        private void WordCount_Click(object sender, EventArgs e)
        {


        }
    }
}
