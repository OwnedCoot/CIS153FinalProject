namespace CIS153_ConnectFour_Group7
{
    partial class Statistics
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
            this.btn_quit2 = new System.Windows.Forms.Button();
            this.statsTitle = new System.Windows.Forms.Label();
            this.PlayerLabel = new System.Windows.Forms.Label();
            this.ComputerLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_playerWins = new System.Windows.Forms.Label();
            this.lbl_computerWins = new System.Windows.Forms.Label();
            this.lbl_playerWinPercent = new System.Windows.Forms.Label();
            this.lbl_computerWinPercent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_ties = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_gamesPlayed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_quit2
            // 
            this.btn_quit2.BackColor = System.Drawing.Color.Red;
            this.btn_quit2.Font = new System.Drawing.Font("MS Reference Specialty", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit2.Location = new System.Drawing.Point(713, 406);
            this.btn_quit2.Name = "btn_quit2";
            this.btn_quit2.Size = new System.Drawing.Size(75, 32);
            this.btn_quit2.TabIndex = 51;
            this.btn_quit2.Text = "Quit";
            this.btn_quit2.UseVisualStyleBackColor = false;
            this.btn_quit2.Click += new System.EventHandler(this.btn_quit2_Click);
            // 
            // statsTitle
            // 
            this.statsTitle.AutoSize = true;
            this.statsTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statsTitle.Font = new System.Drawing.Font("Mongolian Baiti", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statsTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statsTitle.Location = new System.Drawing.Point(227, 9);
            this.statsTitle.Name = "statsTitle";
            this.statsTitle.Size = new System.Drawing.Size(329, 60);
            this.statsTitle.TabIndex = 52;
            this.statsTitle.Text = "STATISTICS";
            // 
            // PlayerLabel
            // 
            this.PlayerLabel.AutoSize = true;
            this.PlayerLabel.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.PlayerLabel.Location = new System.Drawing.Point(129, 123);
            this.PlayerLabel.Name = "PlayerLabel";
            this.PlayerLabel.Size = new System.Drawing.Size(126, 41);
            this.PlayerLabel.TabIndex = 53;
            this.PlayerLabel.Text = "Player";
            // 
            // ComputerLabel
            // 
            this.ComputerLabel.AutoSize = true;
            this.ComputerLabel.Font = new System.Drawing.Font("Modern No. 20", 30F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerLabel.ForeColor = System.Drawing.Color.Crimson;
            this.ComputerLabel.Location = new System.Drawing.Point(558, 123);
            this.ComputerLabel.Name = "ComputerLabel";
            this.ComputerLabel.Size = new System.Drawing.Size(172, 41);
            this.ComputerLabel.TabIndex = 54;
            this.ComputerLabel.Text = "Computer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 56;
            this.label1.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 31);
            this.label2.TabIndex = 58;
            this.label2.Text = "Win Percent:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 31);
            this.label3.TabIndex = 60;
            this.label3.Text = "Win Percent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(102, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 59;
            this.label4.Text = "Wins:";
            // 
            // lbl_playerWins
            // 
            this.lbl_playerWins.AutoSize = true;
            this.lbl_playerWins.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWins.Location = new System.Drawing.Point(194, 193);
            this.lbl_playerWins.Name = "lbl_playerWins";
            this.lbl_playerWins.Size = new System.Drawing.Size(28, 31);
            this.lbl_playerWins.TabIndex = 61;
            this.lbl_playerWins.Text = "0";
            // 
            // lbl_computerWins
            // 
            this.lbl_computerWins.AutoSize = true;
            this.lbl_computerWins.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computerWins.Location = new System.Drawing.Point(640, 193);
            this.lbl_computerWins.Name = "lbl_computerWins";
            this.lbl_computerWins.Size = new System.Drawing.Size(28, 31);
            this.lbl_computerWins.TabIndex = 62;
            this.lbl_computerWins.Text = "0";
            // 
            // lbl_playerWinPercent
            // 
            this.lbl_playerWinPercent.AutoSize = true;
            this.lbl_playerWinPercent.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_playerWinPercent.Location = new System.Drawing.Point(194, 234);
            this.lbl_playerWinPercent.Name = "lbl_playerWinPercent";
            this.lbl_playerWinPercent.Size = new System.Drawing.Size(28, 31);
            this.lbl_playerWinPercent.TabIndex = 63;
            this.lbl_playerWinPercent.Text = "0";
            // 
            // lbl_computerWinPercent
            // 
            this.lbl_computerWinPercent.AutoSize = true;
            this.lbl_computerWinPercent.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_computerWinPercent.Location = new System.Drawing.Point(640, 234);
            this.lbl_computerWinPercent.Name = "lbl_computerWinPercent";
            this.lbl_computerWinPercent.Size = new System.Drawing.Size(28, 31);
            this.lbl_computerWinPercent.TabIndex = 64;
            this.lbl_computerWinPercent.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 31);
            this.label5.TabIndex = 65;
            this.label5.Text = "Ties:";
            // 
            // lbl_ties
            // 
            this.lbl_ties.AutoSize = true;
            this.lbl_ties.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ties.Location = new System.Drawing.Point(403, 334);
            this.lbl_ties.Name = "lbl_ties";
            this.lbl_ties.Size = new System.Drawing.Size(28, 31);
            this.lbl_ties.TabIndex = 66;
            this.lbl_ties.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 365);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 31);
            this.label6.TabIndex = 67;
            this.label6.Text = "Games Played:";
            // 
            // lbl_gamesPlayed
            // 
            this.lbl_gamesPlayed.AutoSize = true;
            this.lbl_gamesPlayed.Font = new System.Drawing.Font("Modern No. 20", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gamesPlayed.Location = new System.Drawing.Point(403, 365);
            this.lbl_gamesPlayed.Name = "lbl_gamesPlayed";
            this.lbl_gamesPlayed.Size = new System.Drawing.Size(28, 31);
            this.lbl_gamesPlayed.TabIndex = 68;
            this.lbl_gamesPlayed.Text = "0";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_gamesPlayed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_ties);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_computerWinPercent);
            this.Controls.Add(this.lbl_playerWinPercent);
            this.Controls.Add(this.lbl_computerWins);
            this.Controls.Add(this.lbl_playerWins);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComputerLabel);
            this.Controls.Add(this.PlayerLabel);
            this.Controls.Add(this.statsTitle);
            this.Controls.Add(this.btn_quit2);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_quit2;
        private System.Windows.Forms.Label statsTitle;
        private System.Windows.Forms.Label PlayerLabel;
        private System.Windows.Forms.Label ComputerLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_playerWins;
        private System.Windows.Forms.Label lbl_computerWins;
        private System.Windows.Forms.Label lbl_playerWinPercent;
        private System.Windows.Forms.Label lbl_computerWinPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_ties;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_gamesPlayed;
    }
}