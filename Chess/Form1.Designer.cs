namespace Chess
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.START_BUTTON = new System.Windows.Forms.Button();
            this.EXIT_BUTTON = new System.Windows.Forms.Button();
            this.stopgame_button = new System.Windows.Forms.Button();
            this.xod_partii = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // START_BUTTON
            // 
            this.START_BUTTON.Location = new System.Drawing.Point(658, 629);
            this.START_BUTTON.Name = "START_BUTTON";
            this.START_BUTTON.Size = new System.Drawing.Size(86, 23);
            this.START_BUTTON.TabIndex = 1;
            this.START_BUTTON.Text = "Начать игру";
            this.START_BUTTON.UseVisualStyleBackColor = true;
            this.START_BUTTON.Click += new System.EventHandler(this.START_BUTTON_Click);
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.Location = new System.Drawing.Point(852, 629);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(75, 23);
            this.EXIT_BUTTON.TabIndex = 2;
            this.EXIT_BUTTON.Text = "АЛТ+Ф4";
            this.EXIT_BUTTON.UseVisualStyleBackColor = true;
            this.EXIT_BUTTON.Click += new System.EventHandler(this.EXIT_BUTTON_Click);
            // 
            // stopgame_button
            // 
            this.stopgame_button.Location = new System.Drawing.Point(750, 629);
            this.stopgame_button.Name = "stopgame_button";
            this.stopgame_button.Size = new System.Drawing.Size(96, 23);
            this.stopgame_button.TabIndex = 4;
            this.stopgame_button.Text = "Дезертировать";
            this.stopgame_button.UseVisualStyleBackColor = true;
            this.stopgame_button.Click += new System.EventHandler(this.stopgame_button_Click);
            // 
            // xod_partii
            // 
            this.xod_partii.Location = new System.Drawing.Point(664, 28);
            this.xod_partii.Name = "xod_partii";
            this.xod_partii.ReadOnly = true;
            this.xod_partii.Size = new System.Drawing.Size(263, 131);
            this.xod_partii.TabIndex = 5;
            this.xod_partii.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(664, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ход партии";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 659);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.xod_partii);
            this.Controls.Add(this.stopgame_button);
            this.Controls.Add(this.EXIT_BUTTON);
            this.Controls.Add(this.START_BUTTON);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ШОХМАТЫ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EXIT_BUTTON;
        public System.Windows.Forms.Button START_BUTTON;
        private System.Windows.Forms.Button stopgame_button;
        private System.Windows.Forms.RichTextBox xod_partii;
        private System.Windows.Forms.Label label2;
    }
}

