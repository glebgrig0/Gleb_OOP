﻿namespace Bckground_task_Windows_Forms_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(50, 179);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(88, 75);
            this.A.TabIndex = 0;
            this.A.Text = "A";
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.Button1_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(464, 179);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(86, 75);
            this.B.TabIndex = 1;
            this.B.Text = "B";
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.B_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(578, 544);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Чудо-кнопки";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
    }
}

