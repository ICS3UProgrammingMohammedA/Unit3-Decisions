namespace GuessGameMoA
{
    partial class GuessGameForm
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.txtGuessNumber = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblCorrectGuess = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 77);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(335, 25);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "Guess integer between 10 and 25";
            // 
            // txtGuessNumber
            // 
            this.txtGuessNumber.Location = new System.Drawing.Point(376, 82);
            this.txtGuessNumber.Name = "txtGuessNumber";
            this.txtGuessNumber.Size = new System.Drawing.Size(103, 20);
            this.txtGuessNumber.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(32, 143);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(114, 46);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "Check Guess";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblCorrectGuess
            // 
            this.lblCorrectGuess.AutoSize = true;
            this.lblCorrectGuess.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrectGuess.Location = new System.Drawing.Point(152, 149);
            this.lblCorrectGuess.Name = "lblCorrectGuess";
            this.lblCorrectGuess.Size = new System.Drawing.Size(93, 29);
            this.lblCorrectGuess.TabIndex = 3;
            this.lblCorrectGuess.Text = "Answer";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(417, 270);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(76, 38);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // GuessGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(505, 320);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblCorrectGuess);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.txtGuessNumber);
            this.Controls.Add(this.lblQuestion);
            this.Name = "GuessGameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Number Guessing Game Mo";
            this.Load += new System.EventHandler(this.GuessGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.TextBox txtGuessNumber;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblCorrectGuess;
        private System.Windows.Forms.Button btnRefresh;
    }
}

