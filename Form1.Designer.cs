using System;
using System.Windows.Forms;

namespace YourNamespace  // Ensure this matches the namespace in Form1.cs
{
    public partial class Form1 : Form
    {
        private System.ComponentModel.IContainer components = null;
        private Button simpleButton;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem formatToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.simpleButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();

            this.simpleButton.Location = new System.Drawing.Point(70, 50);
            this.simpleButton.Size = new System.Drawing.Size(150, 50);
            this.simpleButton.Text = "Click Me";
            this.simpleButton.UseVisualStyleBackColor = true;
            this.simpleButton.Click += new EventHandler(this.SimpleButton_Click);

            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.fileToolStripMenuItem,
                this.editToolStripMenuItem,
                this.formatToolStripMenuItem,
                this.helpToolStripMenuItem
            });

            this.fileToolStripMenuItem.Text = "File";
            this.editToolStripMenuItem.Text = "Edit";
            this.formatToolStripMenuItem.Text = "Format";
            this.helpToolStripMenuItem.Text = "Help";

            ToolStripMenuItem openFileMenuItem = new ToolStripMenuItem("Open");
            ToolStripMenuItem saveFileMenuItem = new ToolStripMenuItem("Save");
            ToolStripMenuItem exitMenuItem = new ToolStripMenuItem("Exit");
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                openFileMenuItem,
                saveFileMenuItem,
                exitMenuItem
            });

            ToolStripMenuItem cutMenuItem = new ToolStripMenuItem("Cut");
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Copy");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Paste");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Delete");
            ToolStripMenuItem insertDateTimeMenuItem = new ToolStripMenuItem("Insert Date and Time");
            ToolStripMenuItem searchReplaceMenuItem = new ToolStripMenuItem("Search and Replace");
            this.editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                cutMenuItem,
                copyMenuItem,
                pasteMenuItem,
                deleteMenuItem,
                insertDateTimeMenuItem,
                searchReplaceMenuItem
            });

            ToolStripMenuItem fontMenuItem = new ToolStripMenuItem("Font");
            this.formatToolStripMenuItem.DropDownItems.Add(fontMenuItem);

            ToolStripMenuItem aboutMenuItem = new ToolStripMenuItem("About");
            this.helpToolStripMenuItem.DropDownItems.Add(aboutMenuItem);

            openFileMenuItem.Click += new EventHandler(this.openFileToolStripMenuItem_Click);
            saveFileMenuItem.Click += new EventHandler(this.saveToolStripMenuItem_Click);
            exitMenuItem.Click += new EventHandler(this.exitToolStripMenuItem_Click);

            cutMenuItem.Click += new EventHandler(this.cutToolStripMenuItem_Click);
            copyMenuItem.Click += new EventHandler(this.copyToolStripMenuItem_Click);
            pasteMenuItem.Click += new EventHandler(this.pasteToolStripMenuItem_Click);

            deleteMenuItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
            insertDateTimeMenuItem.Click += new EventHandler(this.insertDateTimeToolStripMenuItem_Click);
            searchReplaceMenuItem.Click += new EventHandler(this.searchAndReplaceToolStripMenuItem_Click);

            fontMenuItem.Click += new EventHandler(this.formatToolStripMenuItem_Click);
            aboutMenuItem.Click += new EventHandler(this.aboutToolStripMenuItem_Click);

            ToolStripMenuItem contextMenuDeleteItem = new ToolStripMenuItem("Delete");
            ToolStripMenuItem contextMenuInsertDateTimeItem = new ToolStripMenuItem("Insert Date and Time");
            ToolStripMenuItem contextMenuSearchReplaceItem = new ToolStripMenuItem("Search and Replace");

            this.contextMenuStrip1.Items.AddRange(new ToolStripItem[] {
                cutToolStripMenuItem,
                copyToolStripMenuItem,
                pasteToolStripMenuItem,
                contextMenuDeleteItem,
                contextMenuInsertDateTimeItem,
                contextMenuSearchReplaceItem
            });

            contextMenuDeleteItem.Click += new EventHandler(this.deleteToolStripMenuItem_Click);
            contextMenuInsertDateTimeItem.Click += new EventHandler(this.insertDateTimeToolStripMenuItem_Click);
            contextMenuSearchReplaceItem.Click += new EventHandler(this.searchAndReplaceToolStripMenuItem_Click);

            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabel1
            });

            this.toolStripStatusLabel1.Text = "Ready";

            this.richTextBox1.Location = new System.Drawing.Point(10, 27);
            this.richTextBox1.Size = new System.Drawing.Size(280, 150);
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                                       | System.Windows.Forms.AnchorStyles.Left) 
                                       | System.Windows.Forms.AnchorStyles.Right)));

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 300); 
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.simpleButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Text Editor";
            this.ResumeLayout(false);

            this.richTextBox1.BringToFront();
        }

        public System.Windows.Forms.RichTextBox richTextBox1; 

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog.Font;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor\nVersion 1.0\nWritten by: Boyan Iliev - fakulteten nomer 05 ", "About Text Editor");
        }
    }
} 