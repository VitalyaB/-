namespace Goroskop
{
    partial class Show_goro
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
            this.components = new System.ComponentModel.Container();
            this.vvod_znaka = new System.Windows.Forms.ComboBox();
            this.daylb = new System.Windows.Forms.Label();
            this.BackMenu = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.прочееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // vvod_znaka
            // 
            this.vvod_znaka.FormattingEnabled = true;
            this.vvod_znaka.Items.AddRange(new object[] {
            "Овен",
            "Телец",
            "Близнецы",
            "Рак",
            "Лев",
            "Дева",
            "Весы",
            "Скорпион",
            "Стрелец",
            "Козерог",
            "Водолей",
            "Рыбы"});
            this.vvod_znaka.Location = new System.Drawing.Point(12, 70);
            this.vvod_znaka.Name = "vvod_znaka";
            this.vvod_znaka.Size = new System.Drawing.Size(219, 21);
            this.vvod_znaka.TabIndex = 0;
            this.vvod_znaka.SelectedIndexChanged += new System.EventHandler(this.vvod_znaka_SelectedIndexChanged);
            // 
            // daylb
            // 
            this.daylb.AutoSize = true;
            this.daylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daylb.ForeColor = System.Drawing.Color.Black;
            this.daylb.Location = new System.Drawing.Point(12, 50);
            this.daylb.Name = "daylb";
            this.daylb.Size = new System.Drawing.Size(128, 15);
            this.daylb.TabIndex = 3;
            this.daylb.Text = "Выберите свой знак:";
            // 
            // BackMenu
            // 
            this.BackMenu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackMenu.ForeColor = System.Drawing.Color.Black;
            this.BackMenu.Location = new System.Drawing.Point(237, 35);
            this.BackMenu.Name = "BackMenu";
            this.BackMenu.Size = new System.Drawing.Size(199, 56);
            this.BackMenu.TabIndex = 5;
            this.BackMenu.Text = "Вернуться\r\nв меню";
            this.BackMenu.UseVisualStyleBackColor = false;
            this.BackMenu.Click += new System.EventHandler(this.BackMenu_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 106);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(424, 293);
            this.webBrowser1.TabIndex = 7;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прочееToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(448, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // прочееToolStripMenuItem
            // 
            this.прочееToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.авторToolStripMenuItem});
            this.прочееToolStripMenuItem.Name = "прочееToolStripMenuItem";
            this.прочееToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.прочееToolStripMenuItem.Text = "Прочее";
            // 
            // авторToolStripMenuItem
            // 
            this.авторToolStripMenuItem.Name = "авторToolStripMenuItem";
            this.авторToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.авторToolStripMenuItem.Text = "Автор";
            this.авторToolStripMenuItem.Click += new System.EventHandler(this.авторToolStripMenuItem_Click);
            // 
            // Show_goro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(448, 411);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.BackMenu);
            this.Controls.Add(this.daylb);
            this.Controls.Add(this.vvod_znaka);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Show_goro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Узнай свою судьбу :)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vvod_znaka;
        private System.Windows.Forms.Label daylb;
        private System.Windows.Forms.Button BackMenu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem прочееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авторToolStripMenuItem;
    }
}