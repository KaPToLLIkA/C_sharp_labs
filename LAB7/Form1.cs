using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI;
using W = Microsoft.Office.Interop.Word;

namespace LAB7
{
    public partial class Form1 : Form
    {
        private string path = "";
        private List<Pair> pairs = new List<Pair>();

        public Form1()
        {
            InitializeComponent();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = "Doc files (*.doc)|*.doc|Docx files (*.docx)|*.docx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    this.fileNameBox.Text = openFileDialog.FileName;
                    this.path = openFileDialog.FileName;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (this.replaceable.Text.Length == 0 || this.replacement.Text.Length == 0)
            {
                return;
            }

            pairs.Add(new Pair(this.replaceable.Text, this.replacement.Text));
            this.pairsBox.Items.Add(this.replaceable.Text + "->" + this.replacement.Text);

        }

        private void clear_Click(object sender, EventArgs e)
        {
            pairs.Clear();
            this.pairsBox.Items.Clear();
        }

        private void execute_Click(object sender, EventArgs e)
        {
            W.Application app = new W.Application();
            Object fName = path;
            Object missing = Type.Missing;

            app.Documents.Open(ref fName);
            W.Find finder = app.Selection.Find;

            foreach (Pair p in pairs)
            {
                finder.Text = p.First as string;
                finder.Replacement.Text = p.Second as string;


                Object wrap = W.WdFindWrap.wdFindContinue;
                Object replace = W.WdReplace.wdReplaceAll;
                finder.Execute(FindText: Type.Missing,
                    MatchCase: false,
                    MatchWholeWord: false,
                    MatchWildcards: false,
                    MatchSoundsLike: missing,
                    MatchAllWordForms: false,
                    Forward: true,
                    Wrap: wrap,
                    Format: false,
                    ReplaceWith: missing, Replace: replace);

            }


            app.ActiveDocument.Save();
            app.ActiveDocument.Close();
            app.Quit();

            MessageBox.Show("Executed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
