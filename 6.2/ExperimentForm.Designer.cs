namespace _6._2
{
    partial class ExperimentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExperimentForm));
            this.btn_Rat = new System.Windows.Forms.Button();
            this.btn_Rabbit = new System.Windows.Forms.Button();
            this.btn_Pig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_StopExperiment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Rat
            // 
            this.btn_Rat.Location = new System.Drawing.Point(32, 88);
            this.btn_Rat.Name = "btn_Rat";
            this.btn_Rat.Size = new System.Drawing.Size(75, 23);
            this.btn_Rat.TabIndex = 0;
            this.btn_Rat.Text = "Крыса";
            this.btn_Rat.UseVisualStyleBackColor = true;
            this.btn_Rat.Click += new System.EventHandler(this.btn_Rat_Click);
            // 
            // btn_Rabbit
            // 
            this.btn_Rabbit.Location = new System.Drawing.Point(187, 88);
            this.btn_Rabbit.Name = "btn_Rabbit";
            this.btn_Rabbit.Size = new System.Drawing.Size(75, 23);
            this.btn_Rabbit.TabIndex = 1;
            this.btn_Rabbit.Text = "Кролик";
            this.btn_Rabbit.UseVisualStyleBackColor = true;
            this.btn_Rabbit.Click += new System.EventHandler(this.btn_Rabbit_Click);
            // 
            // btn_Pig
            // 
            this.btn_Pig.Location = new System.Drawing.Point(337, 88);
            this.btn_Pig.Name = "btn_Pig";
            this.btn_Pig.Size = new System.Drawing.Size(75, 23);
            this.btn_Pig.TabIndex = 2;
            this.btn_Pig.Text = "Свинья";
            this.btn_Pig.UseVisualStyleBackColor = true;
            this.btn_Pig.Click += new System.EventHandler(this.btn_Pig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(56, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "На каком животном будем ставить опыты?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 145);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(156, 145);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(129, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(315, 145);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btn_StopExperiment
            // 
            this.btn_StopExperiment.Location = new System.Drawing.Point(145, 255);
            this.btn_StopExperiment.Name = "btn_StopExperiment";
            this.btn_StopExperiment.Size = new System.Drawing.Size(154, 23);
            this.btn_StopExperiment.TabIndex = 7;
            this.btn_StopExperiment.Text = "Завершить исследование!";
            this.btn_StopExperiment.UseVisualStyleBackColor = true;
            this.btn_StopExperiment.Click += new System.EventHandler(this.btn_StopExperiment_Click);
            // 
            // ExperimentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 290);
            this.Controls.Add(this.btn_StopExperiment);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Pig);
            this.Controls.Add(this.btn_Rabbit);
            this.Controls.Add(this.btn_Rat);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExperimentForm";
            this.Text = "Эксперимент";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Rat;
        private System.Windows.Forms.Button btn_Rabbit;
        private System.Windows.Forms.Button btn_Pig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btn_StopExperiment;
    }
}