namespace Task1
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        FileInfo[] GetFiles(string directoryName)
        {
            DirectoryInfo directory = new DirectoryInfo(directoryName);
            return directory.GetFiles("*", SearchOption.AllDirectories);
        }

        private void Task1Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new { file.Name, file.DirectoryName, file.Length, file.CreationTime })
                .OrderBy(file => file.Name)
                .ThenByDescending(file => file.CreationTime);
            dataGridView.DataSource = files.ToList();
        }

        private void Task2Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new { file.Extension })
                .Distinct();
            dataGridView.DataSource = files.ToList();
        }

        private void Task3Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
               .GroupBy(file => file.Extension)
               .Select(group => new
               {
                   Extention = group.Key,
                   Count = group.Count()
               });
            dataGridView.DataSource = files.ToList();
        }

        private void Task4Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
               .Where(file => file.Name.Contains(nameTextBox.Text));
            dataGridView.DataSource = files.ToList();
        }

        private void Task5Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
               .Where(file => file.CreationTime.Day == DateTime.Today.Day)
               .OrderByDescending(file => file.CreationTime)
               .Take(5);
            dataGridView.DataSource = files.ToList();
        }

        private void Task6Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new
                {
                    Count = GetFiles(directoryTextBox.Text).Count(),
                    Value = GetFiles(directoryTextBox.Text).Sum(file => file.Length) / (1024 ^ 2)
                })
                .Distinct();

            dataGridView.DataSource = files.ToList();
        }

        private void Task7Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                    .Select(file => new
                    {
                        file.Name,
                        file.Extension,
                        Length = (file.Length < (1 << 10)) ? $"{file.Length} ม" :
                                 (file.Length < (1 << 20)) ? $"{file.Length / 1024} สม" : $"{file.Length / 1024 ^ 2} ฬม"
                    });
            dataGridView.DataSource = files.ToList();
        }

        private void Task8Button_Click(object sender, EventArgs e)
        {
            var files = GetFiles(directoryTextBox.Text)
                .Select(file => new
                {
                    Count = GetFiles(directoryTextBox.Text)
                    .Count(file => file.Name == nameTextBox.Text)
                })
                .Distinct();
            dataGridView.DataSource = files.ToList();
        }
    }
}
