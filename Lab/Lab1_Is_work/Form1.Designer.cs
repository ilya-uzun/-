namespace Lab1_Is_work
{
    partial class Lab1
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
            this.cube = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cube)).BeginInit();
            this.SuspendLayout();
            // 
            // cube
            // 
            this.cube.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cube.Location = new System.Drawing.Point(262, 200);
            this.cube.Name = "cube";
            this.cube.Size = new System.Drawing.Size(60, 59);
            this.cube.TabIndex = 0;
            this.cube.TabStop = false;
            // 
            // Lab1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.cube);
            this.Name = "Lab1";
            this.Text = "Lab1";
            ((System.ComponentModel.ISupportInitialize)(this.cube)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox cube;
        private System.Windows.Forms.Timer timer;
    }
}

