
namespace ProgrammersDictionary
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.WordslistBox = new System.Windows.Forms.ListBox();
            this.AddWordTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // WordslistBox
            // 
            this.WordslistBox.FormattingEnabled = true;
            this.WordslistBox.ItemHeight = 16;
            this.WordslistBox.Location = new System.Drawing.Point(12, 107);
            this.WordslistBox.Name = "WordslistBox";
            this.WordslistBox.Size = new System.Drawing.Size(496, 548);
            this.WordslistBox.TabIndex = 0;
            // 
            // AddWordTextBox
            // 
            this.AddWordTextBox.Location = new System.Drawing.Point(12, 67);
            this.AddWordTextBox.Name = "AddWordTextBox";
            this.AddWordTextBox.Size = new System.Drawing.Size(397, 22);
            this.AddWordTextBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(425, 66);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 667);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.AddWordTextBox);
            this.Controls.Add(this.WordslistBox);
            this.Name = "MainForm";
            this.Text = "Словарь программиста";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox WordslistBox;
        private System.Windows.Forms.TextBox AddWordTextBox;
        private System.Windows.Forms.Button AddButton;
    }
}

