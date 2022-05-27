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
    public partial class MainForm : Form
    {
        public static Random random = new Random();
        public static int computerNumber;

        public MainForm()
        {
            Program.f1 = this;
            InitializeComponent();
            NewGame();
        }

        public static void NewGame()
        {
            computerNumber = random.Next(50);
            Program.f1.labelCompNum.Text = "";
        }


        private void buttonUserNum_Click(object sender, EventArgs e)
        {
            Form frm = new UserNumForm();
            frm.ShowDialog();
        }
    }
}
