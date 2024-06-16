namespace _6._2
{
    partial class StartResearchForm
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
            this.btn_StartResearch1 = new System.Windows.Forms.Button();
            this.btn_StopResearch1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_StartResearch1
            // 
            this.btn_StartResearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StartResearch1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_StartResearch1.Location = new System.Drawing.Point(86, 109);
            this.btn_StartResearch1.Name = "btn_StartResearch1";
            this.btn_StartResearch1.Size = new System.Drawing.Size(127, 23);
            this.btn_StartResearch1.TabIndex = 2;
            this.btn_StartResearch1.Text = "Начать исследование";
            this.btn_StartResearch1.UseVisualStyleBackColor = true;
            this.btn_StartResearch1.Click += new System.EventHandler(this.btn_StartResearch1_Click);
            // 
            // btn_StopResearch1
            // 
            this.btn_StopResearch1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_StopResearch1.Location = new System.Drawing.Point(33, 153);
            this.btn_StopResearch1.Name = "btn_StopResearch1";
            this.btn_StopResearch1.Size = new System.Drawing.Size(231, 23);
            this.btn_StopResearch1.TabIndex = 3;
            this.btn_StopResearch1.Text = "Закончить исследование, даже не начав...";
            this.btn_StopResearch1.UseVisualStyleBackColor = true;
            this.btn_StopResearch1.Click += new System.EventHandler(this.btn_StopResearch1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::_6._2.Properties.Resources.Kuy2BxY7zB8G8qhvEdI14uabH4Eh80rzInJhBNumtBL9JJONe3OaWrdoAfIA4QG5zc0D_FQmUCBz2lRKmNFOhq6Y;
            this.pictureBox1.Location = new System.Drawing.Point(-78, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(459, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // StartResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 286);
            this.Controls.Add(this.btn_StopResearch1);
            this.Controls.Add(this.btn_StartResearch1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartResearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Закрытый исследовательский центр";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_StartResearch1;
        private System.Windows.Forms.Button btn_StopResearch1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

