namespace CIS153_ConnectFour_Group7
{
    partial class form_TitleScreen
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
            this.lbl_title_Title = new System.Windows.Forms.Label();
            this.btn_title_OnePlayer = new System.Windows.Forms.Button();
            this.btn_title_TwoPlayer = new System.Windows.Forms.Button();
            this.btn_title_Statistics = new System.Windows.Forms.Button();
            this.btn_title_Quit = new System.Windows.Forms.Button();
            this.lbl_title_Credits = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_title_Title
            // 
            this.lbl_title_Title.AutoSize = true;
            this.lbl_title_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_Title.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_title_Title.Location = new System.Drawing.Point(68, 9);
            this.lbl_title_Title.Name = "lbl_title_Title";
            this.lbl_title_Title.Size = new System.Drawing.Size(345, 46);
            this.lbl_title_Title.TabIndex = 0;
            this.lbl_title_Title.Text = "Connect Four.CS";
            // 
            // btn_title_OnePlayer
            // 
            this.btn_title_OnePlayer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_title_OnePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_title_OnePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_title_OnePlayer.Location = new System.Drawing.Point(28, 201);
            this.btn_title_OnePlayer.Name = "btn_title_OnePlayer";
            this.btn_title_OnePlayer.Size = new System.Drawing.Size(204, 47);
            this.btn_title_OnePlayer.TabIndex = 1;
            this.btn_title_OnePlayer.Text = "One Player";
            this.btn_title_OnePlayer.UseVisualStyleBackColor = false;
            this.btn_title_OnePlayer.Click += new System.EventHandler(this.btn_title_OnePlayer_Click);
            // 
            // btn_title_TwoPlayer
            // 
            this.btn_title_TwoPlayer.BackColor = System.Drawing.Color.LightCoral;
            this.btn_title_TwoPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_title_TwoPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_title_TwoPlayer.Location = new System.Drawing.Point(261, 201);
            this.btn_title_TwoPlayer.Name = "btn_title_TwoPlayer";
            this.btn_title_TwoPlayer.Size = new System.Drawing.Size(204, 47);
            this.btn_title_TwoPlayer.TabIndex = 1;
            this.btn_title_TwoPlayer.Text = "Two Player";
            this.btn_title_TwoPlayer.UseVisualStyleBackColor = false;
            this.btn_title_TwoPlayer.Click += new System.EventHandler(this.btn_title_TwoPlayer_Click);
            // 
            // btn_title_Statistics
            // 
            this.btn_title_Statistics.BackColor = System.Drawing.Color.Silver;
            this.btn_title_Statistics.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_title_Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_title_Statistics.Location = new System.Drawing.Point(28, 254);
            this.btn_title_Statistics.Name = "btn_title_Statistics";
            this.btn_title_Statistics.Size = new System.Drawing.Size(204, 47);
            this.btn_title_Statistics.TabIndex = 1;
            this.btn_title_Statistics.Text = "Statistics";
            this.btn_title_Statistics.UseVisualStyleBackColor = false;
            this.btn_title_Statistics.Click += new System.EventHandler(this.btn_title_Statistics_Click);
            // 
            // btn_title_Quit
            // 
            this.btn_title_Quit.BackColor = System.Drawing.Color.DimGray;
            this.btn_title_Quit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_title_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_title_Quit.ForeColor = System.Drawing.Color.White;
            this.btn_title_Quit.Location = new System.Drawing.Point(261, 254);
            this.btn_title_Quit.Name = "btn_title_Quit";
            this.btn_title_Quit.Size = new System.Drawing.Size(204, 47);
            this.btn_title_Quit.TabIndex = 1;
            this.btn_title_Quit.Text = "Quit Game";
            this.btn_title_Quit.UseVisualStyleBackColor = false;
            this.btn_title_Quit.Click += new System.EventHandler(this.btn_title_Quit_Click);
            // 
            // lbl_title_Credits
            // 
            this.lbl_title_Credits.AutoSize = true;
            this.lbl_title_Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title_Credits.Location = new System.Drawing.Point(88, 55);
            this.lbl_title_Credits.Name = "lbl_title_Credits";
            this.lbl_title_Credits.Size = new System.Drawing.Size(300, 17);
            this.lbl_title_Credits.TabIndex = 2;
            this.lbl_title_Credits.Text = "A C# game made by Andrew, Cody, and Drake";
            // 
            // form_TitleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(492, 329);
            this.Controls.Add(this.lbl_title_Credits);
            this.Controls.Add(this.btn_title_Quit);
            this.Controls.Add(this.btn_title_Statistics);
            this.Controls.Add(this.btn_title_TwoPlayer);
            this.Controls.Add(this.btn_title_OnePlayer);
            this.Controls.Add(this.lbl_title_Title);
            this.Name = "form_TitleScreen";
            this.Text = "Connect Four | Main Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title_Title;
        private System.Windows.Forms.Button btn_title_OnePlayer;
        private System.Windows.Forms.Button btn_title_TwoPlayer;
        private System.Windows.Forms.Button btn_title_Statistics;
        private System.Windows.Forms.Button btn_title_Quit;
        private System.Windows.Forms.Label lbl_title_Credits;
    }
}

