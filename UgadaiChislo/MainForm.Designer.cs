﻿namespace UgadaiChislo
{
    partial class MainForm
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
            this.labelCompNum = new System.Windows.Forms.Label();
            this.buttonUserNum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCompNum
            // 
            this.labelCompNum.AutoSize = true;
            this.labelCompNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCompNum.ForeColor = System.Drawing.Color.SeaGreen;
            this.labelCompNum.Location = new System.Drawing.Point(304, 76);
            this.labelCompNum.Name = "labelCompNum";
            this.labelCompNum.Size = new System.Drawing.Size(40, 42);
            this.labelCompNum.TabIndex = 0;
            this.labelCompNum.Text = "0";
            this.labelCompNum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonUserNum
            // 
            this.buttonUserNum.BackColor = System.Drawing.Color.IndianRed;
            this.buttonUserNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUserNum.ForeColor = System.Drawing.Color.White;
            this.buttonUserNum.Location = new System.Drawing.Point(154, 295);
            this.buttonUserNum.Name = "buttonUserNum";
            this.buttonUserNum.Size = new System.Drawing.Size(343, 114);
            this.buttonUserNum.TabIndex = 1;
            this.buttonUserNum.Text = "Ввод";
            this.buttonUserNum.UseVisualStyleBackColor = false;
            this.buttonUserNum.Click += new System.EventHandler(this.buttonUserNum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(216, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Загаданное число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "by Моисеев Игорь";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(664, 473);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUserNum);
            this.Controls.Add(this.labelCompNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Угадай число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonUserNum;
        public System.Windows.Forms.Label labelCompNum;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

