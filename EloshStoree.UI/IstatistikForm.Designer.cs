﻿namespace EloshStoree.UI
{
    partial class IstatistikForm
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
            btnBestSallers = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // btnBestSallers
            // 
            btnBestSallers.Location = new Point(64, 96);
            btnBestSallers.Name = "btnBestSallers";
            btnBestSallers.Size = new Size(124, 34);
            btnBestSallers.TabIndex = 0;
            btnBestSallers.Text = "Çok Satanlar";
            btnBestSallers.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(232, 96);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 1;
            button1.Text = "Ciro";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(395, 96);
            button2.Name = "button2";
            button2.Size = new Size(124, 34);
            button2.TabIndex = 2;
            button2.Text = "Önerilen Satış Fiyatı";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(64, 172);
            button3.Name = "button3";
            button3.Size = new Size(124, 34);
            button3.TabIndex = 3;
            button3.Text = "Son Satılanlar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(232, 172);
            button4.Name = "button4";
            button4.Size = new Size(124, 34);
            button4.TabIndex = 4;
            button4.Text = "İade Edilme Sıklığı";
            button4.UseVisualStyleBackColor = true;
            // 
            // IstatistikForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnBestSallers);
            Name = "IstatistikForm";
            Text = "IstatistikForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnBestSallers;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}