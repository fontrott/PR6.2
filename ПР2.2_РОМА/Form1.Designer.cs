namespace ПР2._2_РОМА
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
            System.Windows.Forms.Button close_1;
            this.CreateDictionaryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Расчеты = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.calculation_button_1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.InputTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.меню = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculate = new System.Windows.Forms.ToolStripMenuItem();
            this.calculation_button_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.close_2 = new System.Windows.Forms.ToolStripMenuItem();
            this.reference = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            close_1 = new System.Windows.Forms.Button();
            this.Расчеты.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.меню.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // close_1
            // 
            close_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            close_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            close_1.Location = new System.Drawing.Point(90, 182);
            close_1.Name = "close_1";
            close_1.Size = new System.Drawing.Size(148, 26);
            close_1.TabIndex = 8;
            close_1.Text = "Выход";
            close_1.UseVisualStyleBackColor = false;
            close_1.Click += new System.EventHandler(this.close_1_Click);
            // 
            // CreateDictionaryButton
            // 
            this.CreateDictionaryButton.Location = new System.Drawing.Point(359, 355);
            this.CreateDictionaryButton.Name = "CreateDictionaryButton";
            this.CreateDictionaryButton.Size = new System.Drawing.Size(75, 23);
            this.CreateDictionaryButton.TabIndex = 2;
            this.CreateDictionaryButton.Text = "button1";
            this.CreateDictionaryButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Расчеты
            // 
            this.Расчеты.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.Расчеты.Controls.Add(this.tabPage1);
            this.Расчеты.ItemSize = new System.Drawing.Size(0, 1);
            this.Расчеты.Location = new System.Drawing.Point(0, 27);
            this.Расчеты.Name = "Расчеты";
            this.Расчеты.SelectedIndex = 0;
            this.Расчеты.Size = new System.Drawing.Size(921, 365);
            this.Расчеты.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Расчеты.TabIndex = 7;
            this.Расчеты.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(913, 356);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Расчеты";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightPink;
            this.groupBox3.Controls.Add(this.ResultTextBox);
            this.groupBox3.Controls.Add(close_1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(293, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 266);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результат:";
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(23, 56);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(286, 20);
            this.ResultTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Подсчитанные буквы:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightPink;
            this.groupBox2.Controls.Add(this.calculation_button_1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.InputTextBox);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 220);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Исходные данные:";
            // 
            // calculation_button_1
            // 
            this.calculation_button_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.calculation_button_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.calculation_button_1.Location = new System.Drawing.Point(60, 181);
            this.calculation_button_1.Name = "calculation_button_1";
            this.calculation_button_1.Size = new System.Drawing.Size(148, 26);
            this.calculation_button_1.TabIndex = 7;
            this.calculation_button_1.Text = "Подсчитать буквы!";
            this.calculation_button_1.UseVisualStyleBackColor = false;
            this.calculation_button_1.Click += new System.EventHandler(this.calculation_button_1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Введите слово/набор букв в строку:";
            // 
            // InputTextBox
            // 
            this.InputTextBox.Location = new System.Drawing.Point(19, 55);
            this.InputTextBox.Name = "InputTextBox";
            this.InputTextBox.Size = new System.Drawing.Size(244, 20);
            this.InputTextBox.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 71);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.GhostWhite;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(552, 34);
            this.label4.TabIndex = 0;
            this.label4.Text = "                                                        Здравствуйте! \r\n  В этой " +
    "программе вы сможете подсчитать количество  букв, введенных в строку!\r\n";
            // 
            // меню
            // 
            this.меню.BackColor = System.Drawing.Color.GhostWhite;
            this.меню.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.reference});
            this.меню.Location = new System.Drawing.Point(0, 0);
            this.меню.Name = "меню";
            this.меню.Size = new System.Drawing.Size(628, 24);
            this.меню.TabIndex = 8;
            this.меню.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculate,
            this.clear,
            this.close_2});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // calculate
            // 
            this.calculate.BackColor = System.Drawing.Color.GhostWhite;
            this.calculate.Checked = true;
            this.calculate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.calculate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculation_button_2});
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(135, 22);
            this.calculate.Text = "Вычислить";
            // 
            // calculation_button_2
            // 
            this.calculation_button_2.BackColor = System.Drawing.Color.GhostWhite;
            this.calculation_button_2.Name = "calculation_button_2";
            this.calculation_button_2.Size = new System.Drawing.Size(178, 22);
            this.calculation_button_2.Text = "Подсчитать буквы!";
            this.calculation_button_2.Click += new System.EventHandler(this.calculation_button_2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.GhostWhite;
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(135, 22);
            this.clear.Text = "Очистить";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // close_2
            // 
            this.close_2.BackColor = System.Drawing.Color.GhostWhite;
            this.close_2.Name = "close_2";
            this.close_2.Size = new System.Drawing.Size(135, 22);
            this.close_2.Text = "Выход";
            this.close_2.Click += new System.EventHandler(this.close_2_Click);
            // 
            // reference
            // 
            this.reference.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheProgram});
            this.reference.Name = "reference";
            this.reference.Size = new System.Drawing.Size(65, 20);
            this.reference.Text = "Справка";
            // 
            // aboutTheProgram
            // 
            this.aboutTheProgram.BackColor = System.Drawing.Color.GhostWhite;
            this.aboutTheProgram.Name = "aboutTheProgram";
            this.aboutTheProgram.Size = new System.Drawing.Size(149, 22);
            this.aboutTheProgram.Text = "О программе";
            this.aboutTheProgram.Click += new System.EventHandler(this.aboutTheProgram_Click);
            // 
            // Form1
            // 
            this.AccessibleName = "Моя программа";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 332);
            this.Controls.Add(this.Расчеты);
            this.Controls.Add(this.меню);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateDictionaryButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Моя программа";
            this.Расчеты.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.меню.ResumeLayout(false);
            this.меню.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button CreateDictionaryButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Расчеты;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button calculation_button_1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox InputTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MenuStrip меню;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculate;
        private System.Windows.Forms.ToolStripMenuItem calculation_button_2;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ToolStripMenuItem close_2;
        private System.Windows.Forms.ToolStripMenuItem reference;
        private System.Windows.Forms.ToolStripMenuItem aboutTheProgram;
    }
}

