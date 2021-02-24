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
            this.Exercise_lable = new System.Windows.Forms.Label();
            this.Exercise_TextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Exercise_lable
            // 
            this.Exercise_lable.AutoSize = true;
            this.Exercise_lable.Font = new System.Drawing.Font("Book Antiqua", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_lable.Location = new System.Drawing.Point(9, 13);
            this.Exercise_lable.Name = "Exercise_lable";
            this.Exercise_lable.Size = new System.Drawing.Size(517, 28);
            this.Exercise_lable.TabIndex = 0;
            this.Exercise_lable.Text = "Пять степеней физических нагрузок в сутки";
            // 
            // Exercise_TextBox
            // 
            this.Exercise_TextBox.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exercise_TextBox.Location = new System.Drawing.Point(14, 45);
            this.Exercise_TextBox.Name = "Exercise_TextBox";
            this.Exercise_TextBox.ReadOnly = true;
            this.Exercise_TextBox.Size = new System.Drawing.Size(989, 366);
            this.Exercise_TextBox.TabIndex = 2;
            this.Exercise_TextBox.Text = resources.GetString("Exercise_TextBox.Text");
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 422);
            this.Controls.Add(this.Exercise_TextBox);
            this.Controls.Add(this.Exercise_lable);
            this.Name = "Exercise";
            this.Text = "Exercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Exercise_lable;
        private System.Windows.Forms.RichTextBox Exercise_TextBox;
    }
}