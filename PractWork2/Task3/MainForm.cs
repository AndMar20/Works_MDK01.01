using Excel = Microsoft.Office.Interop.Excel;

namespace Task3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void CreateTableButton_Click(object sender, EventArgs e)
        {
            var app = new Excel.Application();
            app.Visible = true;

            var workbook = app.Workbooks.Add();
            var worksheet = workbook.Worksheets[1];
            worksheet.Name = "Умножение";

            for (int i = 0; i < 8; i++)
            {
                worksheet.Cells[i + 2][1] = i + 2;
                worksheet.Cells[1][i + 2] = i + 2;
                for (int j = 0; j < 8; j++)
                {
                    worksheet.Cells[i + 2][j + 2] = (i + 2) * (j + 2);
                }
            }

            //Task4
            Excel.Range range = (Excel.Range)worksheet.Cells[1][1];
            range.EntireRow.Insert();

            range = worksheet.range(worksheet.Cells[1][1], worksheet.Cells[9][1]);
            worksheet.Cells[1][1] = "Таблица умножения";
            worksheet.
            range.Merge();


        }
    }
}
