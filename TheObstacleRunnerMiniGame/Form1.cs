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
    public partial class Form1 : Form
    {

        int obstacleSpeed = 25;
        int gravity = 25;
        int score = -1;


        public Form1()
        {
            InitializeComponent();

            //birds.Visible = false;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            hero.Top += gravity;
            pillar.Left -= obstacleSpeed;
            birds.Left -= obstacleSpeed;
            plane.Left -= obstacleSpeed;
            scoreText.Text = "Score: " + score;


            if (pillar.Left < -50)
            {
                pillar.Left = 2400;
                score++;
            }

            if (birds.Left < -220)
            {
                birds.Left = 2000;
                score++;
            }

            if (plane.Left < -1000)
            {
                plane.Left = 3200;
                score++;
            }

            if (hero.Bounds.IntersectsWith(pillar.Bounds) ||
                hero.Bounds.IntersectsWith(birds.Bounds) ||
                hero.Bounds.IntersectsWith(plane.Bounds) ||
                hero.Bounds.IntersectsWith(ground.Bounds)
                )
            {
                endGame();
            }

            if(score > 3)
            {
                obstacleSpeed = 40;
            }

            if (score > 6)
            {
                obstacleSpeed = 55;
            }

            if (score > 9)
            {
                obstacleSpeed = 70;
            }

            if (score > 12)
            {
                obstacleSpeed = 85;
            }

            if (hero.Top < -25)
            {
                endGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = -25;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 25;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();
            
            Form2 f2 = new Form2(this.score);
            f2.ShowDialog();

            Application.Exit();
        }
        
    }
}
