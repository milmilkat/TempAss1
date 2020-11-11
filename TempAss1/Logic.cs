using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempAss1
{
    public class Logic
    {
        int Bullet;
        int Chances = 2;
        public int Scores = 0;

        public void Load()
        {
            Bullet = 0;
        }

        public void Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
        }

        public void Shoot()
        {
            if(Bullet == 5)
            {
                MessageBox.Show("You are dead my friend");
                Scores -= 5;
            }
            else
            {
                Bullet++;
            }
        }

        public int ShootAway()
        {
            //If there are chances!
            if (Chances > 0)
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("You are saved my friend");
                    Scores += 10;
                }
                else
                {
                    Bullet++;
                    Chances--;
                }
            }
            //We ran out of chances
            else
            {
                MessageBox.Show("You are dead my friend");
            }

            return Chances;
        }
    }
}
