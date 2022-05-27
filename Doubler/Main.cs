using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doubler
{
    public partial class Main : Form
    {
        private Random random = new Random();
        private int computerNumber;
        private int userNumber;
        private int userSteps = -1;
        private int maxSteps;
        List<int> list = new List<int>(); //коллекция для операций и последующей их отмены 1 - прибавление 1, 2 - умножение на 2

        public Main()
        {
            InitializeComponent();

            UpdateGameState(userNumber, random.Next(20));
        }

        private void UpdateGameState(int userNumber)
        {
            userSteps++;
            maxSteps = (computerNumber / 2) + 2; //максмильное число ходов    
            labelUserNubmer.Text = $"Текущее число: {userNumber}";
            labelUserSteps.Text = $"Число ходов: {userSteps}"; //считаем число ходов
            labelMaxSteps.Text = $"Максимум ходов: {maxSteps}";
        }

        private void UpdateGameState(int userNumber, int computerNumber)
        {
            this.computerNumber = computerNumber;
            UpdateGameState(userNumber);                    
            labelComputerNumber.Text = $"Получите число: {computerNumber}";          
            
        }

        private void ResetGame() //новая игра
        {
            userNumber = 0;
            userSteps = -1; //обнуляем число ходов
            list.Clear(); // очищаем историю ходов
            UpdateGameState(userNumber, random.Next(20));
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            UpdateGameState(userNumber *= 2);
            list.Add(2);
            CheckWin();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            UpdateGameState(++userNumber);
            list.Add(1);
            CheckWin();
        }

        private void CheckWin()
        {

            if (maxSteps < userSteps)
            {
                MessageBox.Show("Вы проиграли!", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Close();
                }
            }

            if (userNumber == computerNumber)
            {
                MessageBox.Show("Вы успешно завершили игру!", "Удвоитель",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (MessageBox.Show("Желаете сыграть еще раз?", "Удвоитель", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ResetGame();
                }
                else
                {
                    Close();
                }
            }

            
        }

        private void toolNewGame_Click(object sender, EventArgs e)
        {
            ResetGame();
            MessageBox.Show($"Для победы вы должны получить число \"{computerNumber}\" не более чем за {maxSteps} ходов", "Удвоитель",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void toolClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (list.Count > 0)
            {
                if (list[list.Count - 1] == 1)
                {
                    UpdateGameState(userNumber -= 1);
                    list.RemoveAt(list.Count - 1);
                    CheckWin();
                }
                else
                {
                    UpdateGameState(userNumber /= 2);
                    list.RemoveAt(list.Count - 1);
                    CheckWin();
                }
            }
            
        }
    }
}
