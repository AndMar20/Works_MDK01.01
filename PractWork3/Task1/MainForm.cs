using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Task1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateDocumentButton_Click(object sender, EventArgs e)
        {
            var app = new Word.Application();
            var document = app.Documents.Add(Path.Combine(Environment.CurrentDirectory, "״אבכמם.docx"));
            app.Visible = true;

            //document.Content.Find.Execute(FindText: "ׂוךסעָחֿמכÿֲגמהא", ReplaceWith: textBox.Text, Replace: Word.WdReplace.wdReplaceAll);

            var range = document.Paragraphs[5].Range;
            range.Text = textBox.Text;

            for (int i = 0; i < numericUpDown.Value - 1; i++)
            {
                document.Tables[1].Rows.Add(document.Tables[1].Rows[i + 2]);

                range = document.Tables[1].Cell(i + 2, 1).Range; // ÿקויךא
                range.Text = (i + 1).ToString();
            }
            range = document.Tables[1].Cell((int)numericUpDown.Value + 1, 1).Range; // ÿקויךא
            range.Text = (numericUpDown.Value).ToString();

            document.Content.Find.Execute(FindText: "הה.לל.דדדד קק:לל", ReplaceWith: DateTime.Now, Replace: Word.WdReplace.wdReplaceAll);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "word files (*.docx)|*.docx| (*.pdf)|*.pdf";
            document.SaveAs(Path.Combine(Environment.CurrentDirectory, dialog.Filter), Word.WdSaveFormat.wdFormatPDF);
        }
    }
}
