namespace Сalculator_calor
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
            this.Gender_label = new System.Windows.Forms.Label();
            this.Height_label = new System.Windows.Forms.Label();
            this.Height_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Weight_label = new System.Windows.Forms.Label();
            this.Weight_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Year_label = new System.Windows.Forms.Label();
            this.Year_numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Activity_label = new System.Windows.Forms.Label();
            this.Activity_comboBox = new System.Windows.Forms.ComboBox();
            this.Male_radioButton = new System.Windows.Forms.RadioButton();
            this.Woman_radioButton = new System.Windows.Forms.RadioButton();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.Resultat_richTextBox = new System.Windows.Forms.RichTextBox();
            this.Clear_button = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.таблицаИМТПоВОЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нагрузкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Height_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numericUpDown)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gender_label
            // 
            this.Gender_label.AutoSize = true;
            this.Gender_label.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Gender_label.Location = new System.Drawing.Point(11, 45);
            this.Gender_label.Name = "Gender_label";
            this.Gender_label.Size = new System.Drawing.Size(58, 28);
            this.Gender_label.TabIndex = 2;
            this.Gender_label.Text = "Пол";
            // 
            // Height_label
            // 
            this.Height_label.AutoSize = true;
            this.Height_label.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height_label.Location = new System.Drawing.Point(11, 92);
            this.Height_label.Name = "Height_label";
            this.Height_label.Size = new System.Drawing.Size(103, 28);
            this.Height_label.TabIndex = 3;
            this.Height_label.Text = "Рост, см";
            // 
            // Height_numericUpDown
            // 
            this.Height_numericUpDown.DecimalPlaces = 1;
            this.Height_numericUpDown.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Height_numericUpDown.Location = new System.Drawing.Point(129, 90);
            this.Height_numericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.Height_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Height_numericUpDown.Name = "Height_numericUpDown";
            this.Height_numericUpDown.Size = new System.Drawing.Size(120, 36);
            this.Height_numericUpDown.TabIndex = 4;
            this.Height_numericUpDown.Value = new decimal(new int[] {
            180,
            0,
            0,
            0});
            // 
            // Weight_label
            // 
            this.Weight_label.AutoSize = true;
            this.Weight_label.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight_label.Location = new System.Drawing.Point(11, 151);
            this.Weight_label.Name = "Weight_label";
            this.Weight_label.Size = new System.Drawing.Size(86, 28);
            this.Weight_label.TabIndex = 5;
            this.Weight_label.Text = "Вес, кг";
            // 
            // Weight_numericUpDown
            // 
            this.Weight_numericUpDown.DecimalPlaces = 1;
            this.Weight_numericUpDown.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Weight_numericUpDown.Location = new System.Drawing.Point(129, 149);
            this.Weight_numericUpDown.Maximum = new decimal(new int[] {
            800,
            0,
            0,
            0});
            this.Weight_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.Weight_numericUpDown.Name = "Weight_numericUpDown";
            this.Weight_numericUpDown.Size = new System.Drawing.Size(120, 36);
            this.Weight_numericUpDown.TabIndex = 6;
            this.Weight_numericUpDown.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // Year_label
            // 
            this.Year_label.AutoSize = true;
            this.Year_label.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year_label.Location = new System.Drawing.Point(283, 92);
            this.Year_label.Name = "Year_label";
            this.Year_label.Size = new System.Drawing.Size(122, 28);
            this.Year_label.TabIndex = 7;
            this.Year_label.Text = "Возраст, г";
            // 
            // Year_numericUpDown
            // 
            this.Year_numericUpDown.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year_numericUpDown.Location = new System.Drawing.Point(450, 90);
            this.Year_numericUpDown.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.Year_numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Year_numericUpDown.Name = "Year_numericUpDown";
            this.Year_numericUpDown.Size = new System.Drawing.Size(120, 36);
            this.Year_numericUpDown.TabIndex = 8;
            this.Year_numericUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // Activity_label
            // 
            this.Activity_label.AutoSize = true;
            this.Activity_label.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Activity_label.Location = new System.Drawing.Point(283, 151);
            this.Activity_label.Name = "Activity_label";
            this.Activity_label.Size = new System.Drawing.Size(146, 28);
            this.Activity_label.TabIndex = 9;
            this.Activity_label.Text = "Активность";
            // 
            // Activity_comboBox
            // 
            this.Activity_comboBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Activity_comboBox.FormattingEnabled = true;
            this.Activity_comboBox.Items.AddRange(new object[] {
            "Минимальная",
            "Легкая",
            "Средняя",
            "Высокая",
            "Экстремальная"});
            this.Activity_comboBox.Location = new System.Drawing.Point(450, 148);
            this.Activity_comboBox.Name = "Activity_comboBox";
            this.Activity_comboBox.Size = new System.Drawing.Size(200, 36);
            this.Activity_comboBox.TabIndex = 10;
            // 
            // Male_radioButton
            // 
            this.Male_radioButton.AutoSize = true;
            this.Male_radioButton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Male_radioButton.Location = new System.Drawing.Point(89, 43);
            this.Male_radioButton.Name = "Male_radioButton";
            this.Male_radioButton.Size = new System.Drawing.Size(143, 32);
            this.Male_radioButton.TabIndex = 13;
            this.Male_radioButton.Text = "Мужчина";
            this.Male_radioButton.UseVisualStyleBackColor = true;
            this.Male_radioButton.CheckedChanged += new System.EventHandler(this.Male_radioButton_CheckedChanged);
            // 
            // Woman_radioButton
            // 
            this.Woman_radioButton.AutoSize = true;
            this.Woman_radioButton.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Woman_radioButton.Location = new System.Drawing.Point(251, 43);
            this.Woman_radioButton.Name = "Woman_radioButton";
            this.Woman_radioButton.Size = new System.Drawing.Size(147, 32);
            this.Woman_radioButton.TabIndex = 14;
            this.Woman_radioButton.Text = "Женщина";
            this.Woman_radioButton.UseVisualStyleBackColor = true;
            this.Woman_radioButton.CheckedChanged += new System.EventHandler(this.Woman_radioButton_CheckedChanged);
            // 
            // Calculate_button
            // 
            this.Calculate_button.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Calculate_button.Location = new System.Drawing.Point(184, 202);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(161, 49);
            this.Calculate_button.TabIndex = 15;
            this.Calculate_button.Text = "Рассчитать";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Resultat_richTextBox
            // 
            this.Resultat_richTextBox.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Resultat_richTextBox.Location = new System.Drawing.Point(12, 268);
            this.Resultat_richTextBox.Name = "Resultat_richTextBox";
            this.Resultat_richTextBox.ReadOnly = true;
            this.Resultat_richTextBox.Size = new System.Drawing.Size(810, 249);
            this.Resultat_richTextBox.TabIndex = 16;
            this.Resultat_richTextBox.Text = "";
            // 
            // Clear_button
            // 
            this.Clear_button.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Clear_button.Location = new System.Drawing.Point(409, 202);
            this.Clear_button.Name = "Clear_button";
            this.Clear_button.Size = new System.Drawing.Size(161, 49);
            this.Clear_button.TabIndex = 17;
            this.Clear_button.Text = "Сброс";
            this.Clear_button.UseVisualStyleBackColor = true;
            this.Clear_button.Click += new System.EventHandler(this.Clear_button_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.таблицаИМТПоВОЗToolStripMenuItem,
            this.нагрузкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(835, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // таблицаИМТПоВОЗToolStripMenuItem
            // 
            this.таблицаИМТПоВОЗToolStripMenuItem.Name = "таблицаИМТПоВОЗToolStripMenuItem";
            this.таблицаИМТПоВОЗToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.таблицаИМТПоВОЗToolStripMenuItem.Text = "Таблица ИМТ по ВОЗ";
            this.таблицаИМТПоВОЗToolStripMenuItem.Click += new System.EventHandler(this.таблицаИМТПоВОЗToolStripMenuItem_Click);
            // 
            // нагрузкиToolStripMenuItem
            // 
            this.нагрузкиToolStripMenuItem.Name = "нагрузкиToolStripMenuItem";
            this.нагрузкиToolStripMenuItem.Size = new System.Drawing.Size(170, 24);
            this.нагрузкиToolStripMenuItem.Text = "Физические нагрузки";
            this.нагрузкиToolStripMenuItem.Click += new System.EventHandler(this.нагрузкиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 536);
            this.Controls.Add(this.Clear_button);
            this.Controls.Add(this.Resultat_richTextBox);
            this.Controls.Add(this.Calculate_button);
            this.Controls.Add(this.Woman_radioButton);
            this.Controls.Add(this.Male_radioButton);
            this.Controls.Add(this.Activity_comboBox);
            this.Controls.Add(this.Activity_label);
            this.Controls.Add(this.Year_numericUpDown);
            this.Controls.Add(this.Year_label);
            this.Controls.Add(this.Weight_numericUpDown);
            this.Controls.Add(this.Weight_label);
            this.Controls.Add(this.Height_numericUpDown);
            this.Controls.Add(this.Height_label);
            this.Controls.Add(this.Gender_label);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Height_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Weight_numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year_numericUpDown)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Gender_label;
        private System.Windows.Forms.Label Height_label;
        private System.Windows.Forms.NumericUpDown Height_numericUpDown;
        private System.Windows.Forms.Label Weight_label;
        private System.Windows.Forms.NumericUpDown Weight_numericUpDown;
        private System.Windows.Forms.Label Year_label;
        private System.Windows.Forms.NumericUpDown Year_numericUpDown;
        private System.Windows.Forms.Label Activity_label;
        private System.Windows.Forms.ComboBox Activity_comboBox;
        private System.Windows.Forms.RadioButton Male_radioButton;
        private System.Windows.Forms.RadioButton Woman_radioButton;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.RichTextBox Resultat_richTextBox;
        private System.Windows.Forms.Button Clear_button;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem таблицаИМТПоВОЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нагрузкиToolStripMenuItem;
    }
}

