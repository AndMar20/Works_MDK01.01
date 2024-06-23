namespace Task1
{
    partial class DataForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            task1Button = new Button();
            task2Button = new Button();
            task3Button = new Button();
            task4Button = new Button();
            task5Button = new Button();
            directoryTextBox = new TextBox();
            nameTextBox = new TextBox();
            task6Button = new Button();
            task7Button = new Button();
            task8Button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(17, 95);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(641, 402);
            dataGridView.TabIndex = 0;
            // 
            // task1Button
            // 
            task1Button.Location = new Point(17, 8);
            task1Button.Name = "task1Button";
            task1Button.Size = new Size(75, 23);
            task1Button.TabIndex = 1;
            task1Button.Text = "Задание 1";
            task1Button.UseVisualStyleBackColor = true;
            task1Button.Click += Task1Button_Click;
            // 
            // task2Button
            // 
            task2Button.Location = new Point(98, 8);
            task2Button.Name = "task2Button";
            task2Button.Size = new Size(75, 23);
            task2Button.TabIndex = 2;
            task2Button.Text = "Задание 2";
            task2Button.UseVisualStyleBackColor = true;
            task2Button.Click += Task2Button_Click;
            // 
            // task3Button
            // 
            task3Button.Location = new Point(179, 8);
            task3Button.Name = "task3Button";
            task3Button.Size = new Size(75, 23);
            task3Button.TabIndex = 3;
            task3Button.Text = "Задание 3";
            task3Button.UseVisualStyleBackColor = true;
            task3Button.Click += Task3Button_Click;
            // 
            // task4Button
            // 
            task4Button.Location = new Point(260, 8);
            task4Button.Name = "task4Button";
            task4Button.Size = new Size(75, 23);
            task4Button.TabIndex = 4;
            task4Button.Text = "Задание 4";
            task4Button.UseVisualStyleBackColor = true;
            task4Button.Click += Task4Button_Click;
            // 
            // task5Button
            // 
            task5Button.Location = new Point(341, 8);
            task5Button.Name = "task5Button";
            task5Button.Size = new Size(75, 23);
            task5Button.TabIndex = 5;
            task5Button.Text = "Задание 5";
            task5Button.UseVisualStyleBackColor = true;
            task5Button.Click += Task5Button_Click;
            // 
            // directoryTextBox
            // 
            directoryTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            directoryTextBox.Location = new Point(17, 37);
            directoryTextBox.Name = "directoryTextBox";
            directoryTextBox.Size = new Size(641, 23);
            directoryTextBox.TabIndex = 6;
            directoryTextBox.Text = "F:\\РПМ\\Доделать";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.Location = new Point(17, 66);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(641, 23);
            nameTextBox.TabIndex = 7;
            nameTextBox.Text = "Program.cs";
            // 
            // task6Button
            // 
            task6Button.Location = new Point(422, 8);
            task6Button.Name = "task6Button";
            task6Button.Size = new Size(75, 23);
            task6Button.TabIndex = 8;
            task6Button.Text = "Задание 6";
            task6Button.UseVisualStyleBackColor = true;
            task6Button.Click += Task6Button_Click;
            // 
            // task7Button
            // 
            task7Button.Location = new Point(503, 8);
            task7Button.Name = "task7Button";
            task7Button.Size = new Size(75, 23);
            task7Button.TabIndex = 9;
            task7Button.Text = "Задание 7";
            task7Button.UseVisualStyleBackColor = true;
            task7Button.Click += Task7Button_Click;
            // 
            // task8Button
            // 
            task8Button.Location = new Point(584, 8);
            task8Button.Name = "task8Button";
            task8Button.Size = new Size(75, 23);
            task8Button.TabIndex = 10;
            task8Button.Text = "Задание 8";
            task8Button.UseVisualStyleBackColor = true;
            task8Button.Click += Task8Button_Click;
            // 
            // DataForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(670, 509);
            Controls.Add(task8Button);
            Controls.Add(task7Button);
            Controls.Add(task6Button);
            Controls.Add(nameTextBox);
            Controls.Add(directoryTextBox);
            Controls.Add(task5Button);
            Controls.Add(task4Button);
            Controls.Add(task3Button);
            Controls.Add(task2Button);
            Controls.Add(task1Button);
            Controls.Add(dataGridView);
            Name = "DataForm";
            Text = "Данные";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView;
        private Button task1Button;
        private Button task2Button;
        private Button task3Button;
        private Button task4Button;
        private Button task5Button;
        private TextBox directoryTextBox;
        private TextBox nameTextBox;
        private Button task6Button;
        private Button task7Button;
        private Button task8Button;
    }
}
