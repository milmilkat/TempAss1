using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TempAss1
{
    public partial class Form1 : Form
    {
        Logic LogicClass = new Logic();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicClass.Load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogicClass.Spin();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LogicClass.Shoot();
            SoundPlayer Sound = new SoundPlayer(Properties.Resources.GunSound);
            Sound.Play();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LogicClass.ShootAway();
        }
    }
}
