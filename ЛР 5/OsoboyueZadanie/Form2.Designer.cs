namespace Особое_задание
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // label1
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 130);
            this.label1.TabIndex = 0;
            this.label1.Text = "Условие:\n\nВвести символьную строку из слов, которые разделены пробелами.\nНеобхо" +
                                 "димо: определить количество слов,\nсамое короткое слово и его номер,\nсколько раз" +
                                 " в каждом слове встречается буква «А».";

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 211);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Условие задачи";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}