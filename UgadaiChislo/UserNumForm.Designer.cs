namespace UgadaiChislo
{
    partial class UserNumForm
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
            this.textBoxUserNum = new System.Windows.Forms.TextBox();
            this.buttonSendUserNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxUserNum
            // 
            this.textBoxUserNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxUserNum.Location = new System.Drawing.Point(26, 23);
            this.textBoxUserNum.Name = "textBoxUserNum";
            this.textBoxUserNum.Size = new System.Drawing.Size(119, 31);
            this.textBoxUserNum.TabIndex = 0;
            this.textBoxUserNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUserNum_KeyPress);
            // 
            // buttonSendUserNum
            // 
            this.buttonSendUserNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSendUserNum.Location = new System.Drawing.Point(166, 23);
            this.buttonSendUserNum.Name = "buttonSendUserNum";
            this.buttonSendUserNum.Size = new System.Drawing.Size(161, 30);
            this.buttonSendUserNum.TabIndex = 1;
            this.buttonSendUserNum.Text = "Угадать";
            this.buttonSendUserNum.UseVisualStyleBackColor = true;
            this.buttonSendUserNum.Click += new System.EventHandler(this.buttonSendUserNum_Click);
            // 
            // UserNumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 77);
            this.Controls.Add(this.buttonSendUserNum);
            this.Controls.Add(this.textBoxUserNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserNumForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Введи число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserNum;
        private System.Windows.Forms.Button buttonSendUserNum;
    }
}