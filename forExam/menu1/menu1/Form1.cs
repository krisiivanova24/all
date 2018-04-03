using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu1
{
    public partial class Form1 : Form
    {
        string pathFile = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ti natisna New");
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            opendlg.Filter = "Vsichki failove| *.*|Textovei Failove| *.txt| Formatirani failove|*.rtf";
            opendlg.FilterIndex = 2;
            DialogResult answer=opendlg.ShowDialog();
            if (answer == DialogResult.OK)
            {
                RTB.LoadFile(opendlg.FileName, RichTextBoxStreamType.RichText);
            }
            }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            savedlg.Filter = "Vsichki failove| *.*|Textovei Failove| *.txt| Formatirani failove|*.rtf";
            DialogResult answer = savedlg.ShowDialog();
            if (answer == DialogResult.OK)
            {
                RTB.SaveFile(savedlg.FileName, RichTextBoxStreamType.RichText);
                pathFile = savedlg.FileName;
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            if (pathFile=="")
            {
                saveAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                RTB.SaveFile(savedlg.FileName, RichTextBoxStreamType.RichText);
            }
            pathFile = opendlg.FileName;
        }
    }
}
