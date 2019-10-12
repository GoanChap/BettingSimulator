using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eeveelution_Race_Betting_Simulator
{
    public class Eeveelution
    {
        public string name;
        public int StartingPosition, RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randomizer;

        public void WhoAmI()
        {
            MessageBox.Show("I am  " + name);
        }

        public void Run()
        { 
        
            // Move forward 1, 2, 3 or 4 spaces at Random
            int randomNum = Randomizer.Next(0,5);

            MyPictureBox.Left += randomNum;
            

 //           MyPictureBox.Left = StartingPosition + this.Location;
//
//            if (Location != RacetrackLength)
//            {
//                return false;
//            }
//            else { return true; }

        }

        public void TakeStartingPosition()
        {
            this.Location = 0;
            this.StartingPosition = 0;
            MyPictureBox.Left = 26;        
        }

    }
}
