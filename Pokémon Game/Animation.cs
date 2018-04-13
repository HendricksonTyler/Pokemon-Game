using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pokémon_Game
{
    public partial class Animation
    {
        Timer AnimationTimer = new Timer();
        PictureBox imgMewtwo;
        int leftRight;

        public Animation()
        {
            
        }

        public void ShakeAnimation(System.Windows.Forms.PictureBox mewtwo)
        {
            imgMewtwo = mewtwo;

            leftRight = 1;
            AnimationTimer.Tick += new EventHandler(timer_Tick);
            AnimationTimer.Interval = (1000) * (1);
            AnimationTimer.Enabled = true;
            AnimationTimer.Start();
        }
            
        void timer_Tick(object sender, EventArgs e)
        {
            if (leftRight == 1)
            {
                imgMewtwo.Location = new Point(139, 56);
                leftRight++;
            }

            else if (leftRight == 2)
            {
                imgMewtwo.Location = new Point(140, 56);
                leftRight++;
            }

            else if (leftRight == 3)
            {
                imgMewtwo.Location = new Point(141, 56);
                leftRight++;
            }

            else if (leftRight == 4)
            {
                imgMewtwo.Location = new Point(140, 56);
                leftRight++;
            }

            else if (leftRight == 5)
            {
                AnimationTimer.Stop();
            }
        }
        

        
    }

    

}