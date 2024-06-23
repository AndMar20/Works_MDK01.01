namespace Task1
{
    partial class MainForm
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
            textBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            createDocumentButton = new Button();
            numericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown).BeginInit();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.Location = new Point(12, 75);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(759, 260);
            textBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 57);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 2;
            label1.Text = "Ввод текста:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 13);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 3;
            label2.Text = "Количество заданий:";
            // 
            // createDocumentButton
            // 
            createDocumentButton.Location = new Point(12, 341);
            createDocumentButton.Name = "createDocumentButton";
            createDocumentButton.Size = new Size(207, 23);
            createDocumentButton.TabIndex = 4;
            createDocumentButton.Text = "Создать документ по шаблону";
            createDocumentButton.UseVisualStyleBackColor = true;
            createDocumentButton.Click += CreateDocumentButton_Click;
            // 
            // numericUpDown
            // 
            numericUpDown.Location = new Point(14, 31);
            numericUpDown.Name = "numericUpDown";
            numericUpDown.Size = new Size(120, 23);
            numericUpDown.TabIndex = 6;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 375);
            Controls.Add(numericUpDown);
            Controls.Add(createDocumentButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox);
            Name = "MainForm";
            Text = "Создание документа Word";
            ((System.ComponentModel.ISupportInitialize)numericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Label label1;
        private Label label2;
        private Button createDocumentButton;
        private NumericUpDown numericUpDown;
    }
}
