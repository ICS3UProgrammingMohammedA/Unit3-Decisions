namespace PerfectSquaresMo
{
    partial class frmPerfectSquares
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
            this.btnStart = new System.Windows.Forms.Button();
            this.nudNumbers = new System.Windows.Forms.NumericUpDown();
            this.lstPerfectSquares = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(205, 45);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(80, 39);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // nudNumbers
            // 
            this.nudNumbers.Location = new System.Drawing.Point(185, 118);
            this.nudNumbers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudNumbers.Name = "nudNumbers";
            this.nudNumbers.Size = new System.Drawing.Size(120, 20);
            this.nudNumbers.TabIndex = 1;
            this.nudNumbers.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lstPerfectSquares
            // 
            this.lstPerfectSquares.FormattingEnabled = true;
            this.lstPerfectSquares.Location = new System.Drawing.Point(149, 164);
            this.lstPerfectSquares.Name = "lstPerfectSquares";
            this.lstPerfectSquares.Size = new System.Drawing.Size(195, 108);
            this.lstPerfectSquares.TabIndex = 2;
            // 
            // frmPerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 302);
            this.Controls.Add(this.lstPerfectSquares);
            this.Controls.Add(this.nudNumbers);
            this.Controls.Add(this.btnStart);
            this.Name = "frmPerfectSquares";
            this.Text = "Perfect Squares By Mohammed";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumbers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.NumericUpDown nudNumbers;
        private System.Windows.Forms.ListBox lstPerfectSquares;
    }
}

