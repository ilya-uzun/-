namespace tets2
{
    partial class Lab3
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
        }        //#region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_openWord = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_readWord4 = new System.Windows.Forms.Button();
            this.button_writeWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 52);
            this.button1.TabIndex = 0;
            this.button1.Tag = "1";
            this.button1.Text = "Открыть Excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(174, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 52);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "Записать в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 52);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "Прочитать из Excel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(328, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 5;
            // 
            // button_openWord
            // 
            this.button_openWord.Location = new System.Drawing.Point(37, 252);
            this.button_openWord.Name = "button_openWord";
            this.button_openWord.Size = new System.Drawing.Size(119, 52);
            this.button_openWord.TabIndex = 6;
            this.button_openWord.Tag = "1";
            this.button_openWord.Text = "Открыть Word";
            this.button_openWord.UseVisualStyleBackColor = true;
            this.button_openWord.Click += new System.EventHandler(this.button_openWord_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(328, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 9;
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button_readWord4
            // 
            this.button_readWord4.Location = new System.Drawing.Point(324, 252);
            this.button_readWord4.Name = "button_readWord4";
            this.button_readWord4.Size = new System.Drawing.Size(130, 52);
            this.button_readWord4.TabIndex = 11;
            this.button_readWord4.Tag = "3";
            this.button_readWord4.Text = "Прочитать из Excel";
            this.button_readWord4.UseVisualStyleBackColor = true;
            this.button_readWord4.Click += new System.EventHandler(this.button_readWord4_Click);
            // 
            // button_writeWord
            // 
            this.button_writeWord.Location = new System.Drawing.Point(174, 252);
            this.button_writeWord.Name = "button_writeWord";
            this.button_writeWord.Size = new System.Drawing.Size(129, 52);
            this.button_writeWord.TabIndex = 10;
            this.button_writeWord.Tag = "2";
            this.button_writeWord.Text = "Записать в Word";
            this.button_writeWord.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button_writeWord.UseVisualStyleBackColor = true;
            this.button_writeWord.Click += new System.EventHandler(this.button_writeWord_Click);
            // 
            // Lab3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 353);
            this.Controls.Add(this.button_readWord4);
            this.Controls.Add(this.button_writeWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_openWord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Lab3";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        //#endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_openWord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_readWord4;
        private System.Windows.Forms.Button button_writeWord;
    }
}

