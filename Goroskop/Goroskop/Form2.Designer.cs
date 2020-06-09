namespace Goroskop
{
    partial class Admin
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
            this.BackMenu2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.daylb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BackMenu2
            // 
            this.BackMenu2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackMenu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackMenu2.ForeColor = System.Drawing.Color.Black;
            this.BackMenu2.Location = new System.Drawing.Point(13, 300);
            this.BackMenu2.Name = "BackMenu2";
            this.BackMenu2.Size = new System.Drawing.Size(286, 56);
            this.BackMenu2.TabIndex = 6;
            this.BackMenu2.Text = "Вернуться\r\nв меню";
            this.BackMenu2.UseVisualStyleBackColor = false;
            this.BackMenu2.Click += new System.EventHandler(this.BackMenu2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Goroskop.Properties.Resources.imgonline_com_ua_Resize_zat5Ya8csE6Q5;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(286, 198);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // daylb
            // 
            this.daylb.AutoSize = true;
            this.daylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daylb.ForeColor = System.Drawing.Color.Black;
            this.daylb.Location = new System.Drawing.Point(25, 232);
            this.daylb.Name = "daylb";
            this.daylb.Size = new System.Drawing.Size(269, 36);
            this.daylb.TabIndex = 8;
            this.daylb.Text = "Работу выполнил: Букланов Виталий\r\nГруппа: ИСиП - 22";
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(311, 372);
            this.Controls.Add(this.daylb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackMenu2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автор";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackMenu2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label daylb;
    }
}