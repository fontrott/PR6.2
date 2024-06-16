namespace _6._2
{
    partial class ResearchForm
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
            this.txt_VirusName1 = new System.Windows.Forms.TextBox();
            this.lbl_VirusName = new System.Windows.Forms.Label();
            this.lbl_VirusInfectionCount = new System.Windows.Forms.Label();
            this.txt_VirusInfectionCount = new System.Windows.Forms.TextBox();
            this.btn_ContinueResearch = new System.Windows.Forms.Button();
            this.btn_StopResearch2 = new System.Windows.Forms.Button();
            this.lbl_RateInfectrion = new System.Windows.Forms.Label();
            this.txt_RateInfection = new System.Windows.Forms.TextBox();
            this.btn_ContinueResearch2 = new System.Windows.Forms.Button();
            this.txt_VirusType = new System.Windows.Forms.TextBox();
            this.btn_Experiment = new System.Windows.Forms.Button();
            this.btn_StopResearch3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Vaccine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_VirusName1
            // 
            this.txt_VirusName1.Location = new System.Drawing.Point(87, 38);
            this.txt_VirusName1.Name = "txt_VirusName1";
            this.txt_VirusName1.Size = new System.Drawing.Size(247, 20);
            this.txt_VirusName1.TabIndex = 0;
            this.txt_VirusName1.TextChanged += new System.EventHandler(this.virusName2_TextChanged);
            // 
            // lbl_VirusName
            // 
            this.lbl_VirusName.AutoSize = true;
            this.lbl_VirusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_VirusName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_VirusName.Location = new System.Drawing.Point(84, 20);
            this.lbl_VirusName.Name = "lbl_VirusName";
            this.lbl_VirusName.Size = new System.Drawing.Size(125, 15);
            this.lbl_VirusName.TabIndex = 2;
            this.lbl_VirusName.Text = "Название вируса:";
            this.lbl_VirusName.Click += new System.EventHandler(this.lbl_VirusName_Click);
            // 
            // lbl_VirusInfectionCount
            // 
            this.lbl_VirusInfectionCount.AutoSize = true;
            this.lbl_VirusInfectionCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_VirusInfectionCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_VirusInfectionCount.Location = new System.Drawing.Point(84, 68);
            this.lbl_VirusInfectionCount.Name = "lbl_VirusInfectionCount";
            this.lbl_VirusInfectionCount.Size = new System.Drawing.Size(167, 15);
            this.lbl_VirusInfectionCount.TabIndex = 3;
            this.lbl_VirusInfectionCount.Text = "Количество заражений:";
            // 
            // txt_VirusInfectionCount
            // 
            this.txt_VirusInfectionCount.Location = new System.Drawing.Point(87, 86);
            this.txt_VirusInfectionCount.Name = "txt_VirusInfectionCount";
            this.txt_VirusInfectionCount.Size = new System.Drawing.Size(247, 20);
            this.txt_VirusInfectionCount.TabIndex = 4;
            // 
            // btn_ContinueResearch
            // 
            this.btn_ContinueResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ContinueResearch.Location = new System.Drawing.Point(118, 243);
            this.btn_ContinueResearch.Name = "btn_ContinueResearch";
            this.btn_ContinueResearch.Size = new System.Drawing.Size(185, 23);
            this.btn_ContinueResearch.TabIndex = 5;
            this.btn_ContinueResearch.Text = "Продолжаем исследование!";
            this.btn_ContinueResearch.UseVisualStyleBackColor = true;
            this.btn_ContinueResearch.Click += new System.EventHandler(this.btn_ContinueResearch_Click);
            // 
            // btn_StopResearch2
            // 
            this.btn_StopResearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StopResearch2.Location = new System.Drawing.Point(118, 282);
            this.btn_StopResearch2.Name = "btn_StopResearch2";
            this.btn_StopResearch2.Size = new System.Drawing.Size(185, 23);
            this.btn_StopResearch2.TabIndex = 6;
            this.btn_StopResearch2.Text = "Закончить исследование";
            this.btn_StopResearch2.UseVisualStyleBackColor = true;
            this.btn_StopResearch2.Click += new System.EventHandler(this.btn_StopResearch2_Click);
            // 
            // lbl_RateInfectrion
            // 
            this.lbl_RateInfectrion.AutoSize = true;
            this.lbl_RateInfectrion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RateInfectrion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_RateInfectrion.Location = new System.Drawing.Point(84, 119);
            this.lbl_RateInfectrion.Name = "lbl_RateInfectrion";
            this.lbl_RateInfectrion.Size = new System.Drawing.Size(209, 15);
            this.lbl_RateInfectrion.TabIndex = 7;
            this.lbl_RateInfectrion.Text = "Скорость заражения (в день):";
            this.lbl_RateInfectrion.Visible = false;
            // 
            // txt_RateInfection
            // 
            this.txt_RateInfection.Location = new System.Drawing.Point(87, 137);
            this.txt_RateInfection.Name = "txt_RateInfection";
            this.txt_RateInfection.Size = new System.Drawing.Size(247, 20);
            this.txt_RateInfection.TabIndex = 8;
            this.txt_RateInfection.Visible = false;
            // 
            // btn_ContinueResearch2
            // 
            this.btn_ContinueResearch2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ContinueResearch2.Location = new System.Drawing.Point(118, 243);
            this.btn_ContinueResearch2.Name = "btn_ContinueResearch2";
            this.btn_ContinueResearch2.Size = new System.Drawing.Size(185, 23);
            this.btn_ContinueResearch2.TabIndex = 9;
            this.btn_ContinueResearch2.Text = "Продолжаем исследование!";
            this.btn_ContinueResearch2.UseVisualStyleBackColor = true;
            this.btn_ContinueResearch2.Visible = false;
            this.btn_ContinueResearch2.Click += new System.EventHandler(this.btn_ContinueResearch2_Click);
            // 
            // txt_VirusType
            // 
            this.txt_VirusType.Location = new System.Drawing.Point(87, 39);
            this.txt_VirusType.Multiline = true;
            this.txt_VirusType.Name = "txt_VirusType";
            this.txt_VirusType.ReadOnly = true;
            this.txt_VirusType.Size = new System.Drawing.Size(247, 44);
            this.txt_VirusType.TabIndex = 10;
            this.txt_VirusType.Visible = false;
            // 
            // btn_Experiment
            // 
            this.btn_Experiment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Experiment.Location = new System.Drawing.Point(118, 243);
            this.btn_Experiment.Name = "btn_Experiment";
            this.btn_Experiment.Size = new System.Drawing.Size(185, 23);
            this.btn_Experiment.TabIndex = 11;
            this.btn_Experiment.Text = "Провести эксперимент!";
            this.btn_Experiment.UseVisualStyleBackColor = true;
            this.btn_Experiment.Visible = false;
            this.btn_Experiment.Click += new System.EventHandler(this.btn_Experiment_Click);
            // 
            // btn_StopResearch3
            // 
            this.btn_StopResearch3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_StopResearch3.Location = new System.Drawing.Point(118, 282);
            this.btn_StopResearch3.Name = "btn_StopResearch3";
            this.btn_StopResearch3.Size = new System.Drawing.Size(185, 23);
            this.btn_StopResearch3.TabIndex = 12;
            this.btn_StopResearch3.Text = "Закончить исследование";
            this.btn_StopResearch3.UseVisualStyleBackColor = true;
            this.btn_StopResearch3.Visible = false;
            this.btn_StopResearch3.Click += new System.EventHandler(this.btn_StopResearch3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_6._2.Properties.Resources._1613686710_11_p_fon_dlya_prezentatsii_virusi_13;
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(427, 318);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Vaccine
            // 
            this.txt_Vaccine.Location = new System.Drawing.Point(87, 101);
            this.txt_Vaccine.Multiline = true;
            this.txt_Vaccine.Name = "txt_Vaccine";
            this.txt_Vaccine.ReadOnly = true;
            this.txt_Vaccine.Size = new System.Drawing.Size(247, 44);
            this.txt_Vaccine.TabIndex = 13;
            this.txt_Vaccine.Visible = false;
            // 
            // ResearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 317);
            this.Controls.Add(this.txt_Vaccine);
            this.Controls.Add(this.btn_StopResearch3);
            this.Controls.Add(this.btn_Experiment);
            this.Controls.Add(this.txt_VirusType);
            this.Controls.Add(this.btn_ContinueResearch2);
            this.Controls.Add(this.txt_RateInfection);
            this.Controls.Add(this.lbl_RateInfectrion);
            this.Controls.Add(this.btn_StopResearch2);
            this.Controls.Add(this.btn_ContinueResearch);
            this.Controls.Add(this.txt_VirusInfectionCount);
            this.Controls.Add(this.lbl_VirusInfectionCount);
            this.Controls.Add(this.lbl_VirusName);
            this.Controls.Add(this.txt_VirusName1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ResearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исследование";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_VirusName1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_VirusName;
        private System.Windows.Forms.Label lbl_VirusInfectionCount;
        private System.Windows.Forms.TextBox txt_VirusInfectionCount;
        private System.Windows.Forms.Button btn_ContinueResearch;
        private System.Windows.Forms.Button btn_StopResearch2;
        private System.Windows.Forms.Label lbl_RateInfectrion;
        private System.Windows.Forms.TextBox txt_RateInfection;
        private System.Windows.Forms.Button btn_ContinueResearch2;
        private System.Windows.Forms.TextBox txt_VirusType;
        private System.Windows.Forms.Button btn_Experiment;
        private System.Windows.Forms.Button btn_StopResearch3;
        private System.Windows.Forms.TextBox txt_Vaccine;
    }
}