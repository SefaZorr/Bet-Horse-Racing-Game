using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Horse_Race
{
    class Horse
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random MyRandom;

        public bool Run()
        {
            MyRandom = new Random();
            int Distance = MyRandom.Next(1, 8);

            MoveMyPictureBox(Distance);

            Location += Distance;

            if (Location >= RacetrackLength - StartingPosition)
                return true;
            return false;

        }

        public void TakeStartingPosition()
        {
            MoveMyPictureBox(-Location);
            Location = 0;
            
        }

        public void MoveMyPictureBox(int distance)
        {
            Point p = MyPictureBox.Location;
            p.X += distance;
            MyPictureBox.Location = p;
            System.Threading.Thread.Sleep(5);//Geciktirme Yapıyor.
        }
    }
}
