namespace Сalculator_calor
{
    partial class Exercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise));
            this.label1 = new System.Windows.Forms.Label();
            this.Exercise_richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(517, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пять степеней физических нагрузок в сутки";
            // 
            // Exercise_richTextBox
            // 
            this.Exercise_richTextBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_richTextBox.Location = new System.Drawing.Point(14, 45);
            this.Exercise_richTextBox.Name = "Exercise_richTextBox";
            this.Exercise_richTextBox.ReadOnly = true;
            this.Exercise_richTextBox.Size = new System.Drawing.Size(989, 366);
            this.Exercise_richTextBox.TabIndex = 2;
            this.Exercise_richTextBox.Text = resources.GetString("Exercise_richTextBox.Text");
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 422);
            this.Controls.Add(this.Exercise_richTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Exercise";
            this.Text = "Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox Exercise_richTextBox;
    }
}