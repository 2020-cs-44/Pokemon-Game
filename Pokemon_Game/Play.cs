using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemon_Game
{
    public partial class Play : Form
    {
        bool jump;
        int gravity = 20;
        int force;
        int speed = 10;
        bool ember = false;
        int CharmanderHealth = 100;
        int BulbasaurHealth = 100;
        int emberSpeed = 8;
        public Play()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            if (CharmanderHealth > 1)
            {
                HealthBar.Value = CharmanderHealth;
            }
            else
            {
                Timer.Stop();
                MessageBox.Show("Game Over!!!  You Lost the Round");
                this.Close();
            }
            if (BulbasaurHealth < 1)
            {
                Timer.Stop();
                MessageBox.Show("You Win");
                this.Close();
            }
            if (jump == true)
            {
                Charmander.Top -= force;
                force = force-2;
            }
            if (Charmander.Top + Charmander.Height >= gameArea.Height)
            {
                Charmander.Top = gameArea.Height - Charmander.Height;
                jump = false;
            }
            razorLeaf.Left -= speed;
            if (razorLeaf.Left < 0)
            {
                razorLeaf.Left = 558;
            }
        }
        private void keyIsDown(object sender, KeyEventArgs e)
        {
            if (jump != true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    jump = true;
                    force = gravity;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                useEmber();
                Ember.Left += emberSpeed;
                ember = true;
            }
            if (Ember.Bounds.IntersectsWith(Bulbasaur.Bounds))
            {
                BulbasaurHealth = BulbasaurHealth - 5;
            }
            if (razorLeaf.Bounds.IntersectsWith(Charmander.Bounds))
            {
                CharmanderHealth = CharmanderHealth - 2;
            }
            
        }
        private void keyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                
            }
            if (e.KeyCode == Keys.Space)
            {

               
            }
         
        }
        private void useEmber()
        {
            PictureBox Ember = new PictureBox();
            Ember.Left = Charmander.Left + Charmander.Width;   //ember will place infront of player object
            Ember.Top = Charmander.Top + Charmander.Height / 2;//ember will be middle of player object
            this.Controls.Add(Ember);

        }
                  
    }
}
