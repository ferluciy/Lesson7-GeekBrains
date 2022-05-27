using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UgadaiChislo
{
    public partial class UserNumForm : Form
    {
        public UserNumForm()
        {
            
            InitializeComponent();
        }

        private void textBoxUserNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void buttonSendUserNum_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBoxUserNum.Text) == MainForm.computerNumber)
            {
                Program.f1.labelCompNum.Text = "" + MainForm.computerNumber;
                MessageBox.Show("Вы успешно завершили игру!", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);                
                if (MessageBox.Show("Желаете сыграть еще раз?", "Угадай число", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MainForm.NewGame();
                    this.Close();
                }
                else
                {
                    Application.Exit();
                }
            } else if (int.Parse(textBoxUserNum.Text) < MainForm.computerNumber)
            {
                MessageBox.Show("Загаданное число больше!", "Угадай число",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Загаданное число меньше!", "Угадай число",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            }
    }
}
