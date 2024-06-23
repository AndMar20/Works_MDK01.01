namespace Task3
{
    partial class SearchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            replaceTextBox = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(101, 9);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(633, 23);
            searchTextBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 13);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 3;
            label1.Text = "Найти:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 42);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 4;
            label2.Text = "Заменить на:";
            // 
            // replaceTextBox
            // 
            replaceTextBox.Location = new Point(101, 38);
            replaceTextBox.Name = "replaceTextBox";
            replaceTextBox.Size = new Size(633, 23);
            replaceTextBox.TabIndex = 0;
            replaceTextBox.TextChanged += replaceTextBox_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(23, 81);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 5;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 115);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(searchTextBox);
            Controls.Add(replaceTextBox);
            Name = "SearchForm";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox searchTextBox;
        private Label label1;
        private Label label2;
        private TextBox replaceTextBox;
        private Button button2;
    }
}