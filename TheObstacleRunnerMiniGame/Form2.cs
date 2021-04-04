using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheObstacleRunnerMiniGame
{
    public partial class Form2 : Form
    {
        private int score;
      
        public Form2(int score)
        {
            
            InitializeComponent();
            this.score = score;
            gameOver.Visible = true;
            finalScore.Text = "Score: " + this.score;
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
