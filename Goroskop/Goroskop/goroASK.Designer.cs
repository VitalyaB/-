namespace Goroskop
{
    partial class goroASK
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
            this.mounth = new System.Windows.Forms.ListBox();
            this.day = new System.Windows.Forms.TextBox();
            this.daylb = new System.Windows.Forms.Label();
            this.mounthlb = new System.Windows.Forms.Label();
            this.urGoro = new System.Windows.Forms.Label();
            this.thatUrGoro = new System.Windows.Forms.Label();
            this.showZnak = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.Menu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mounth
            // 
            this.mounth.BackColor = System.Drawing.Color.GhostWhite;
            this.mounth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mounth.ForeColor = System.Drawing.SystemColors.WindowText;
            this.mounth.FormattingEnabled = true;
            this.mounth.ItemHeight = 15;
            this.mounth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Октябрь",
            "Ноябрь",
            "Декабрь"});
            this.mounth.Location = new System.Drawing.Point(47, 91);
            this.mounth.Name = "mounth";
            this.mounth.Size = new System.Drawing.Size(100, 94);
            this.mounth.TabIndex = 0;
            this.toolTip1.SetToolTip(this.mounth, "Выберите месяц вашего рождения");
            this.mounth.SelectedIndexChanged += new System.EventHandler(this.mounth_SelectedIndexChanged);
            // 
            // day
            // 
            this.day.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.day.Location = new System.Drawing.Point(46, 42);
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(100, 20);
            this.day.TabIndex = 1;
            this.toolTip1.SetToolTip(this.day, "(Введите число)");
            this.day.TextChanged += new System.EventHandler(this.day_TextChanged);
            this.day.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.day_KeyPress);
            // 
            // daylb
            // 
            this.daylb.AutoSize = true;
            this.daylb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.daylb.ForeColor = System.Drawing.Color.Black;
            this.daylb.Location = new System.Drawing.Point(43, 24);
            this.daylb.Name = "daylb";
            this.daylb.Size = new System.Drawing.Size(40, 15);
            this.daylb.TabIndex = 2;
            this.daylb.Text = "День:";
            // 
            // mounthlb
            // 
            this.mounthlb.AutoSize = true;
            this.mounthlb.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mounthlb.ForeColor = System.Drawing.Color.Black;
            this.mounthlb.Location = new System.Drawing.Point(43, 73);
            this.mounthlb.Name = "mounthlb";
            this.mounthlb.Size = new System.Drawing.Size(48, 15);
            this.mounthlb.TabIndex = 3;
            this.mounthlb.Text = "Месяц:";
            // 
            // urGoro
            // 
            this.urGoro.AutoSize = true;
            this.urGoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.urGoro.ForeColor = System.Drawing.Color.Black;
            this.urGoro.Location = new System.Drawing.Point(12, 206);
            this.urGoro.Name = "urGoro";
            this.urGoro.Size = new System.Drawing.Size(63, 15);
            this.urGoro.TabIndex = 9;
            this.urGoro.Text = "Ваш знак:";
            // 
            // thatUrGoro
            // 
            this.thatUrGoro.AutoSize = true;
            this.thatUrGoro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thatUrGoro.ForeColor = System.Drawing.Color.Black;
            this.thatUrGoro.Location = new System.Drawing.Point(83, 206);
            this.thatUrGoro.Name = "thatUrGoro";
            this.thatUrGoro.Size = new System.Drawing.Size(0, 15);
            this.thatUrGoro.TabIndex = 10;
            // 
            // showZnak
            // 
            this.showZnak.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showZnak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showZnak.ForeColor = System.Drawing.Color.Black;
            this.showZnak.Location = new System.Drawing.Point(27, 233);
            this.showZnak.Name = "showZnak";
            this.showZnak.Size = new System.Drawing.Size(147, 59);
            this.showZnak.TabIndex = 11;
            this.showZnak.Text = "Узнать свой\r\nзнак";
            this.showZnak.UseVisualStyleBackColor = false;
            this.showZnak.Click += new System.EventHandler(this.showZnak_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Menu.ForeColor = System.Drawing.Color.Black;
            this.Menu.Location = new System.Drawing.Point(27, 298);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(147, 37);
            this.Menu.TabIndex = 12;
            this.Menu.Text = "Меню";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // goroASK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(198, 350);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.showZnak);
            this.Controls.Add(this.thatUrGoro);
            this.Controls.Add(this.urGoro);
            this.Controls.Add(this.mounthlb);
            this.Controls.Add(this.daylb);
            this.Controls.Add(this.day);
            this.Controls.Add(this.mounth);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "goroASK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Знак гороскопа";
            this.Load += new System.EventHandler(this.goroASK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox mounth;
        private System.Windows.Forms.TextBox day;
        private System.Windows.Forms.Label daylb;
        private System.Windows.Forms.Label mounthlb;
        private System.Windows.Forms.Label urGoro;
        private System.Windows.Forms.Label thatUrGoro;
        private System.Windows.Forms.Button showZnak;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button Menu;
    }
}