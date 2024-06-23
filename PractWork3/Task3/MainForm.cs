using Word = Microsoft.Office.Interop.Word;
namespace Task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void createWordButton_Click(object sender, EventArgs e)
        {
            var wordApp = new Word.Application();
            var workbook1 = wordApp.Documents.Add();
            wordApp.Visible = true;


        }
    }
}
