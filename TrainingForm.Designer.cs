
namespace ProgrammersDictionary
{
    partial class TrainingForm
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
            this.labelWord = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.labelScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNumberWords = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWord
            // 
            this.labelWord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWord.AutoSize = true;
            this.labelWord.Location = new System.Drawing.Point(13, 78);
            this.labelWord.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWord.Name = "labelWord";
            this.labelWord.Size = new System.Drawing.Size(42, 20);
            this.labelWord.TabIndex = 0;
            this.labelWord.Text = "label";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxAnswer.Location = new System.Drawing.Point(12, 108);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(485, 26);
            this.textBoxAnswer.TabIndex = 1;
            this.textBoxAnswer.TextChanged += new System.EventHandler(this.textBoxAnswer_TextChanged);
            // 
            // labelScore
            // 
            this.labelScore.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(179, 20);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(18, 20);
            this.labelScore.TabIndex = 2;
            this.labelScore.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(217, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            // 
            // labelNumberWords
            // 
            this.labelNumberWords.AutoSize = true;
            this.labelNumberWords.Location = new System.Drawing.Point(236, 20);
            this.labelNumberWords.Name = "labelNumberWords";
            this.labelNumberWords.Size = new System.Drawing.Size(18, 20);
            this.labelNumberWords.TabIndex = 4;
            this.labelNumberWords.Text = "0";
            // 
            // TrainingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 213);
            this.Controls.Add(this.labelNumberWords);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.labelWord);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TrainingForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrainingForm";
            this.Load += new System.EventHandler(this.TrainingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWord;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNumberWords;
    }
}