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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Random_button = new System.Windows.Forms.RadioButton();
            this.White_button = new System.Windows.Forms.RadioButton();
            this.black_button = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(640, 640);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // START_BUTTON
            // 
            this.START_BUTTON.Location = new System.Drawing.Point(658, 629);
            this.START_BUTTON.Name = "START_BUTTON";
            this.START_BUTTON.Size = new System.Drawing.Size(134, 23);
            this.START_BUTTON.TabIndex = 1;
            this.START_BUTTON.Text = "Начать игру";
            this.START_BUTTON.UseVisualStyleBackColor = true;
            // 
            // EXIT_BUTTON
            // 
            this.EXIT_BUTTON.Location = new System.Drawing.Point(798, 629);
            this.EXIT_BUTTON.Name = "EXIT_BUTTON";
            this.EXIT_BUTTON.Size = new System.Drawing.Size(129, 23);
            this.EXIT_BUTTON.TabIndex = 2;
            this.EXIT_BUTTON.Text = "АЛТ+Ф4";
            this.EXIT_BUTTON.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Random_button);
            this.groupBox1.Controls.Add(this.White_button);
            this.groupBox1.Controls.Add(this.black_button);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(658, 458);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 165);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки игры";
            // 
            // Random_button
            // 
            this.Random_button.AutoSize = true;
            this.Random_button.Location = new System.Drawing.Point(6, 78);
            this.Random_button.Name = "Random_button";
            this.Random_button.Size = new System.Drawing.Size(64, 17);
            this.Random_button.TabIndex = 3;
            this.Random_button.TabStop = true;
            this.Random_button.Text = "Рандом";
            this.Random_button.UseVisualStyleBackColor = true;
            // 
            // White_button
            // 
            this.White_button.AutoSize = true;
            this.White_button.Location = new System.Drawing.Point(6, 55);
            this.White_button.Name = "White_button";
            this.White_button.Size = new System.Drawing.Size(58, 17);
            this.White_button.TabIndex = 2;
            this.White_button.TabStop = true;
            this.White_button.Text = "Белые";
            this.White_button.UseVisualStyleBackColor = true;
            // 
            // black_button
            // 
            this.black_button.AutoSize = true;
            this.black_button.Location = new System.Drawing.Point(6, 32);
            this.black_button.Name = "black_button";
            this.black_button.Size = new System.Drawing.Size(65, 17);
            this.black_button.TabIndex = 1;
            this.black_button.TabStop = true;
            this.black_button.Text = "Чёрные";
            this.black_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сторона:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 659);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.EXIT_BUTTON);
            this.Controls.Add(this.START_BUTTON);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ШОХМАТЫ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button EXIT_BUTTON;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton Random_button;
        private System.Windows.Forms.RadioButton White_button;
        private System.Windows.Forms.RadioButton black_button;
        public System.Windows.Forms.Button START_BUTTON;
    }
}

