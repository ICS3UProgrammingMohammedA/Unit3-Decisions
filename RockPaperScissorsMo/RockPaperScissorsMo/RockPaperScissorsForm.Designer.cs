namespace RockPaperScissorsMo
{
    partial class frmRockPaperScissors
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
            this.radRock = new System.Windows.Forms.RadioButton();
            this.radPaper = new System.Windows.Forms.RadioButton();
            this.radScissors = new System.Windows.Forms.RadioButton();
            this.grbPlayer = new System.Windows.Forms.GroupBox();
            this.radRockComp = new System.Windows.Forms.RadioButton();
            this.radPaperComp = new System.Windows.Forms.RadioButton();
            this.radScissorsComp = new System.Windows.Forms.RadioButton();
            this.grbComputersChoice = new System.Windows.Forms.GroupBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.grbPlayer.SuspendLayout();
            this.grbComputersChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // radRock
            // 
            this.radRock.AutoSize = true;
            this.radRock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRock.Location = new System.Drawing.Point(6, 30);
            this.radRock.Name = "radRock";
            this.radRock.Size = new System.Drawing.Size(64, 24);
            this.radRock.TabIndex = 0;
            this.radRock.TabStop = true;
            this.radRock.Text = "Rock";
            this.radRock.UseVisualStyleBackColor = true;
            // 
            // radPaper
            // 
            this.radPaper.AutoSize = true;
            this.radPaper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaper.Location = new System.Drawing.Point(6, 60);
            this.radPaper.Name = "radPaper";
            this.radPaper.Size = new System.Drawing.Size(69, 24);
            this.radPaper.TabIndex = 1;
            this.radPaper.TabStop = true;
            this.radPaper.Text = "Paper";
            this.radPaper.UseVisualStyleBackColor = true;
            // 
            // radScissors
            // 
            this.radScissors.AutoSize = true;
            this.radScissors.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissors.Location = new System.Drawing.Point(6, 90);
            this.radScissors.Name = "radScissors";
            this.radScissors.Size = new System.Drawing.Size(87, 24);
            this.radScissors.TabIndex = 2;
            this.radScissors.TabStop = true;
            this.radScissors.Text = "Scissors";
            this.radScissors.UseVisualStyleBackColor = true;
            // 
            // grbPlayer
            // 
            this.grbPlayer.Controls.Add(this.radRock);
            this.grbPlayer.Controls.Add(this.radScissors);
            this.grbPlayer.Controls.Add(this.radPaper);
            this.grbPlayer.Location = new System.Drawing.Point(36, 63);
            this.grbPlayer.Name = "grbPlayer";
            this.grbPlayer.Size = new System.Drawing.Size(133, 141);
            this.grbPlayer.TabIndex = 3;
            this.grbPlayer.TabStop = false;
            this.grbPlayer.Text = "Players Choice";
            // 
            // radRockComp
            // 
            this.radRockComp.AutoSize = true;
            this.radRockComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRockComp.Location = new System.Drawing.Point(6, 19);
            this.radRockComp.Name = "radRockComp";
            this.radRockComp.Size = new System.Drawing.Size(64, 24);
            this.radRockComp.TabIndex = 3;
            this.radRockComp.TabStop = true;
            this.radRockComp.Text = "Rock";
            this.radRockComp.UseVisualStyleBackColor = true;
            // 
            // radPaperComp
            // 
            this.radPaperComp.AutoSize = true;
            this.radPaperComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPaperComp.Location = new System.Drawing.Point(6, 49);
            this.radPaperComp.Name = "radPaperComp";
            this.radPaperComp.Size = new System.Drawing.Size(69, 24);
            this.radPaperComp.TabIndex = 4;
            this.radPaperComp.TabStop = true;
            this.radPaperComp.Text = "Paper";
            this.radPaperComp.UseVisualStyleBackColor = true;
            // 
            // radScissorsComp
            // 
            this.radScissorsComp.AutoSize = true;
            this.radScissorsComp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radScissorsComp.Location = new System.Drawing.Point(6, 79);
            this.radScissorsComp.Name = "radScissorsComp";
            this.radScissorsComp.Size = new System.Drawing.Size(87, 24);
            this.radScissorsComp.TabIndex = 5;
            this.radScissorsComp.TabStop = true;
            this.radScissorsComp.Text = "Scissors";
            this.radScissorsComp.UseVisualStyleBackColor = true;
            // 
            // grbComputersChoice
            // 
            this.grbComputersChoice.Controls.Add(this.radRockComp);
            this.grbComputersChoice.Controls.Add(this.radScissorsComp);
            this.grbComputersChoice.Controls.Add(this.radPaperComp);
            this.grbComputersChoice.Location = new System.Drawing.Point(415, 66);
            this.grbComputersChoice.Name = "grbComputersChoice";
            this.grbComputersChoice.Size = new System.Drawing.Size(134, 138);
            this.grbComputersChoice.TabIndex = 6;
            this.grbComputersChoice.TabStop = false;
            this.grbComputersChoice.Text = "Computers Choice";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(259, 113);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(80, 43);
            this.btnPlay.TabIndex = 6;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(200, 259);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(187, 37);
            this.lblScore.TabIndex = 7;
            this.lblScore.Text = "Player Wins";
            // 
            // frmRockPaperScissors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(651, 344);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.grbComputersChoice);
            this.Controls.Add(this.grbPlayer);
            this.Name = "frmRockPaperScissors";
            this.Text = "Rock, Paper, Scissors By Mohammed";
            this.Load += new System.EventHandler(this.frmRockPaperScissors_Load);
            this.grbPlayer.ResumeLayout(false);
            this.grbPlayer.PerformLayout();
            this.grbComputersChoice.ResumeLayout(false);
            this.grbComputersChoice.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radRock;
        private System.Windows.Forms.RadioButton radPaper;
        private System.Windows.Forms.RadioButton radScissors;
        private System.Windows.Forms.GroupBox grbPlayer;
        private System.Windows.Forms.RadioButton radRockComp;
        private System.Windows.Forms.RadioButton radPaperComp;
        private System.Windows.Forms.RadioButton radScissorsComp;
        private System.Windows.Forms.GroupBox grbComputersChoice;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblScore;
    }
}

