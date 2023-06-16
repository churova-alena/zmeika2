namespace игра_змейка
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
            this.components = new System.ComponentModel.Container();
            this.стартButton = new System.Windows.Forms.Button();
            this.скринButton = new System.Windows.Forms.Button();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.txtбалл = new System.Windows.Forms.Label();
            this.txtвысшбалл = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // стартButton
            // 
            this.стартButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.стартButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.стартButton.Location = new System.Drawing.Point(612, 23);
            this.стартButton.Name = "стартButton";
            this.стартButton.Size = new System.Drawing.Size(98, 54);
            this.стартButton.TabIndex = 0;
            this.стартButton.Text = "старт";
            this.стартButton.UseVisualStyleBackColor = false;
            this.стартButton.Click += new System.EventHandler(this.SrartGame);
            // 
            // скринButton
            // 
            this.скринButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.скринButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.скринButton.Location = new System.Drawing.Point(612, 98);
            this.скринButton.Name = "скринButton";
            this.скринButton.Size = new System.Drawing.Size(98, 54);
            this.скринButton.TabIndex = 0;
            this.скринButton.Text = "сохр. результата";
            this.скринButton.UseVisualStyleBackColor = false;
            this.скринButton.Click += new System.EventHandler(this.TakeSnapShot);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.picCanvas.Location = new System.Drawing.Point(12, 12);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(580, 680);
            this.picCanvas.TabIndex = 1;
            this.picCanvas.TabStop = false;
            this.picCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.UpdatePictureBoxGraphics);
            // 
            // txtбалл
            // 
            this.txtбалл.AutoSize = true;
            this.txtбалл.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtбалл.Location = new System.Drawing.Point(598, 180);
            this.txtбалл.Name = "txtбалл";
            this.txtбалл.Size = new System.Drawing.Size(64, 20);
            this.txtбалл.TabIndex = 2;
            this.txtбалл.Text = "балл: 0";
            // 
            // txtвысшбалл
            // 
            this.txtвысшбалл.AutoSize = true;
            this.txtвысшбалл.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtвысшбалл.Location = new System.Drawing.Point(598, 219);
            this.txtвысшбалл.Name = "txtвысшбалл";
            this.txtвысшбалл.Size = new System.Drawing.Size(109, 20);
            this.txtвысшбалл.TabIndex = 2;
            this.txtвысшбалл.Text = "высш.балл: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 40;
            this.gameTimer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(748, 725);
            this.Controls.Add(this.txtвысшбалл);
            this.Controls.Add(this.txtбалл);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.скринButton);
            this.Controls.Add(this.стартButton);
            this.Name = "Form1";
            this.Text = "змейка";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button стартButton;
        private System.Windows.Forms.Button скринButton;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Label txtбалл;
        private System.Windows.Forms.Label txtвысшбалл;
        private System.Windows.Forms.Timer gameTimer;
    }
}

