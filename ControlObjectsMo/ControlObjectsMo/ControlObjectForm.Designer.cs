namespace ControlObjectsMo
{
    partial class frmControlObject
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
            this.btnRed = new System.Windows.Forms.Button();
            this.lblBlack = new System.Windows.Forms.Label();
            this.btnGreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRed
            // 
            this.btnRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRed.Location = new System.Drawing.Point(57, 94);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(231, 38);
            this.btnRed.TabIndex = 0;
            this.btnRed.Text = "Click here to change the color";
            this.btnRed.UseVisualStyleBackColor = true;
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlack.Location = new System.Drawing.Point(97, 151);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(165, 20);
            this.lblBlack.TabIndex = 1;
            this.lblBlack.Text = "Click To Change Color";
            // 
            // btnGreen
            // 
            this.btnGreen.AutoSize = true;
            this.btnGreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGreen.Location = new System.Drawing.Point(80, 191);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(182, 20);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.Text = "Click to change the color";
            // 
            // frmControlObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 323);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.btnRed);
            this.Name = "frmControlObject";
            this.Text = "Control Object By Mohammed";
            this.Load += new System.EventHandler(this.frmControlObject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label btnGreen;
    }
}

