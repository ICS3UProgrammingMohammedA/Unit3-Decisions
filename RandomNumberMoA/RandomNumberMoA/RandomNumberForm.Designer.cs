namespace RandomNumberMoA
{
    partial class frmRandomNumber
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
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.lblRandomAnswer = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(12, 56);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(618, 31);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Click the button to get a number between 1 and 10";
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(12, 152);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(223, 33);
            this.lblAnswer.TabIndex = 1;
            this.lblAnswer.Text = "The Number is :";
            // 
            // lblRandomAnswer
            // 
            this.lblRandomAnswer.AutoSize = true;
            this.lblRandomAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRandomAnswer.Location = new System.Drawing.Point(285, 152);
            this.lblRandomAnswer.Name = "lblRandomAnswer";
            this.lblRandomAnswer.Size = new System.Drawing.Size(31, 33);
            this.lblRandomAnswer.TabIndex = 2;
            this.lblRandomAnswer.Text = "?";
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRandom.Location = new System.Drawing.Point(476, 133);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(166, 79);
            this.btnRandom.TabIndex = 3;
            this.btnRandom.Text = "Generate Random Number";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // frmRandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RandomNumberMoA.Properties.Resources._38705297_272592686857330_7647323604220116992_n__1_;
            this.ClientSize = new System.Drawing.Size(981, 461);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.lblRandomAnswer);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblNumber);
            this.Name = "frmRandomNumber";
            this.Text = "Random Number By Mohammed";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Label lblRandomAnswer;
        private System.Windows.Forms.Button btnRandom;
    }
}

