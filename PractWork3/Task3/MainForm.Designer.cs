namespace Task3
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
            label = new Label();
            textBox = new TextBox();
            createWordButton = new Button();
            SuspendLayout();
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 9);
            label.Name = "label";
            label.Size = new Size(73, 15);
            label.TabIndex = 0;
            label.Text = "Поле ввода:";
            // 
            // textBox
            // 
            textBox.Location = new Point(3, 27);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(759, 269);
            textBox.TabIndex = 1;
            // 
            // createWordButton
            // 
            createWordButton.Location = new Point(299, 321);
            createWordButton.Name = "createWordButton";
            createWordButton.Size = new Size(159, 23);
            createWordButton.TabIndex = 2;
            createWordButton.Text = "Создать новый докумет";
            createWordButton.UseVisualStyleBackColor = true;
            createWordButton.Click += this.createWordButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 357);
            Controls.Add(createWordButton);
            Controls.Add(textBox);
            Controls.Add(label);
            Name = "MainForm";
            Text = "Создание документа word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label;
        private TextBox textBox;
        private Button createWordButton;
    }
}
