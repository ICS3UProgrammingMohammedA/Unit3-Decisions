namespace ChocolateBoxesMo
{
    partial class frmChocolateBoxes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChocolateBoxes));
            this.lblEnter = new System.Windows.Forms.Label();
            this.txtNumberBoxes = new System.Windows.Forms.TextBox();
            this.btnGetReward = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnter
            // 
            this.lblEnter.AutoSize = true;
            this.lblEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnter.Location = new System.Drawing.Point(12, 74);
            this.lblEnter.Name = "lblEnter";
            this.lblEnter.Size = new System.Drawing.Size(274, 24);
            this.lblEnter.TabIndex = 0;
            this.lblEnter.Text = "Enter the number of boxes sold";
            // 
            // txtNumberBoxes
            // 
            this.txtNumberBoxes.Location = new System.Drawing.Point(330, 78);
            this.txtNumberBoxes.Name = "txtNumberBoxes";
            this.txtNumberBoxes.Size = new System.Drawing.Size(100, 20);
            this.txtNumberBoxes.TabIndex = 1;
            // 
            // btnGetReward
            // 
            this.btnGetReward.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetReward.Location = new System.Drawing.Point(330, 176);
            this.btnGetReward.Name = "btnGetReward";
            this.btnGetReward.Size = new System.Drawing.Size(100, 34);
            this.btnGetReward.TabIndex = 2;
            this.btnGetReward.Text = "Get Reward";
            this.btnGetReward.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 288);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmChocolateBoxes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 301);
            this.Controls.Add(this.txtNumberBoxes);
            this.Controls.Add(this.btnGetReward);
            this.Controls.Add(this.lblEnter);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmChocolateBoxes";
            this.Text = "Chocolate Boxes By Mohammed";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnter;
        private System.Windows.Forms.TextBox txtNumberBoxes;
        private System.Windows.Forms.Button btnGetReward;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

