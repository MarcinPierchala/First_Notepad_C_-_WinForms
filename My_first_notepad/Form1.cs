using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_first_notepad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "open";
            ofd.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
                richTextBox1.LoadFile(ofd.FileName, RichTextBoxStreamType.PlainText);
            this.Text = ofd.FileName;
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "save";
            sfd.Filter = "Text Document (*.txt)|*.txt|All Files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
                richTextBox1.SaveFile(sfd.FileName, RichTextBoxStreamType.PlainText);
            this.Text = sfd.FileName;
        }

        private void wyjścieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void oMnieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutMe am = new AboutMe();
            am.Show();
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
