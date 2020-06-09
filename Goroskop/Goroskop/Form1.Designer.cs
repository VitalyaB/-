namespace Goroskop
{
    partial class GoroskopForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lb1 = new System.Windows.Forms.Label();
            this.Fox = new System.Windows.Forms.PictureBox();
            this.goro = new System.Windows.Forms.Button();
            this.goroASK = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Fox)).BeginInit();
            this.SuspendLayout();
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Black;
            this.lb1.Location = new System.Drawing.Point(17, 21);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(338, 39);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "Узнай свою судьбу";
            // 
            // Fox
            // 
            this.Fox.ErrorImage = global::Goroskop.Properties.Resources.Маг;
            this.Fox.Image = global::Goroskop.Properties.Resources.imgonline_com_ua_Resize_LnuWm0U6rL;
            this.Fox.InitialImage = global::Goroskop.Properties.Resources.Маг;
            this.Fox.Location = new System.Drawing.Point(12, 80);
            this.Fox.Name = "Fox";
            this.Fox.Size = new System.Drawing.Size(201, 138);
            this.Fox.TabIndex = 1;
            this.Fox.TabStop = false;
            // 
            // goro
            // 
            this.goro.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goro.ForeColor = System.Drawing.Color.Black;
            this.goro.Location = new System.Drawing.Point(232, 80);
            this.goro.Name = "goro";
            this.goro.Size = new System.Drawing.Size(123, 32);
            this.goro.TabIndex = 2;
            this.goro.Text = "Гороскоп";
            this.toolTip1.SetToolTip(this.goro, "Сдесь ты можешь посмотреть свой гороскоп");
            this.goro.UseVisualStyleBackColor = false;
            this.goro.Click += new System.EventHandler(this.goro_Click);
            // 
            // goroASK
            // 
            this.goroASK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.goroASK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goroASK.ForeColor = System.Drawing.Color.Black;
            this.goroASK.Location = new System.Drawing.Point(232, 132);
            this.goroASK.Name = "goroASK";
            this.goroASK.Size = new System.Drawing.Size(123, 32);
            this.goroASK.TabIndex = 3;
            this.goroASK.Text = "Узнай свой знак";
            this.toolTip1.SetToolTip(this.goroASK, "Сдесь ты смоежшь узнать\r\nсвой знак зодиака");
            this.goroASK.UseVisualStyleBackColor = false;
            this.goroASK.Click += new System.EventHandler(this.goroASK_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(232, 186);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(123, 32);
            this.exit.TabIndex = 4;
            this.exit.Text = "Выход";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // GoroskopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(367, 264);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.goroASK);
            this.Controls.Add(this.goro);
            this.Controls.Add(this.Fox);
            this.Controls.Add(this.lb1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GoroskopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Гороскоп";
            ((System.ComponentModel.ISupportInitialize)(this.Fox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.PictureBox Fox;
        private System.Windows.Forms.Button goro;
        private System.Windows.Forms.Button goroASK;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

