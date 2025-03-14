using System;
using System.IO;
using System.Windows.Forms;

namespace YourNamespace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            try
            {
                InitializeComponent();
                Console.WriteLine("Form1 Initialized");
                this.Load += (sender, e) => 
                {
                    Console.WriteLine("Form1 is loading");
                    Console.WriteLine($"RichTextBox Visible: {richTextBox1.Visible}");
                    Console.WriteLine($"RichTextBox Size: {richTextBox1.Size}");
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
                toolStripStatusLabel1.Text = "Opened: " + openFileDialog.FileName;
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, richTextBox1.Text);
                toolStripStatusLabel1.Text = "Saved: " + saveFileDialog.FileName;
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void insertDateTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText(DateTime.Now.ToString("g"));
        }

        private void searchAndReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string searchText = Microsoft.VisualBasic.Interaction.InputBox("Enter text to search", "Search Text", "");
            string replaceText = Microsoft.VisualBasic.Interaction.InputBox("Enter text to replace", "Replace Text", "");
            richTextBox1.Text = richTextBox1.Text.Replace(searchText, replaceText);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectedText = "";
        }

        private void SimpleButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked!");
        }
    }
}