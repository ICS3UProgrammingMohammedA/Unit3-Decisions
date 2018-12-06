namespace RunningAverageMo
{
    partial class frmRunningAverage
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
            this.btnGetAverage = new System.Windows.Forms.Button();
            this.lstMarks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnGetAverage
            // 
            this.btnGetAverage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetAverage.Location = new System.Drawing.Point(185, 35);
            this.btnGetAverage.Name = "btnGetAverage";
            this.btnGetAverage.Size = new System.Drawing.Size(96, 39);
            this.btnGetAverage.TabIndex = 0;
            this.btnGetAverage.Text = "Get Average";
            this.btnGetAverage.UseVisualStyleBackColor = true;
            // 
            // lstMarks
            // 
            this.lstMarks.FormattingEnabled = true;
            this.lstMarks.Location = new System.Drawing.Point(129, 116);
            this.lstMarks.Name = "lstMarks";
            this.lstMarks.Size = new System.Drawing.Size(203, 147);
            this.lstMarks.TabIndex = 1;
            // 
            // frmRunningAverage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 356);
            this.Controls.Add(this.lstMarks);
            this.Controls.Add(this.btnGetAverage);
            this.Name = "frmRunningAverage";
            this.Text = "Running Average By Mohammed";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGetAverage;
        private System.Windows.Forms.ListBox lstMarks;
    }
}

