namespace CIS153_ConnectFour_Group7
{
    partial class OnePlayer
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
            this.btn_quit3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_quit3
            // 
            this.btn_quit3.BackColor = System.Drawing.Color.Red;
            this.btn_quit3.Font = new System.Drawing.Font("MS Reference Specialty", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit3.Location = new System.Drawing.Point(713, 406);
            this.btn_quit3.Name = "btn_quit3";
            this.btn_quit3.Size = new System.Drawing.Size(75, 32);
            this.btn_quit3.TabIndex = 51;
            this.btn_quit3.Text = "Quit";
            this.btn_quit3.UseVisualStyleBackColor = false;
            this.btn_quit3.Click += new System.EventHandler(this.btn_quit3_Click);
            // 
            // OnePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_quit3);
            this.Name = "OnePlayer";
            this.Text = "OnePlayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_quit3;
    }
}