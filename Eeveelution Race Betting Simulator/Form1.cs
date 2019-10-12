using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eeveelution_Race_Betting_Simulator
{
    public partial class Form1 : Form
    {

        bool gameRunning = false;
        int minBet = 5;
        int timeLeft = 100;

        Eeveelution[] eeveeArray = new Eeveelution[4];

        DJs[] djArray = new DJs[3];
    

        public Form1()
        {
            InitializeComponent();

            Random MyRandomizer = new Random();

            djArray[0] = new DJs() { name = "Axwel", Cash = 50,
                MyLabel = axwelBetInfoLabel, MyRadioButton = axwelRadioButton};
            djArray[1] = new DJs() { name = "Ingrosso", Cash = 75,
                MyLabel = ingrossoBetInfoLabel, MyRadioButton = ingrossoRadioButton};
            djArray[2] = new DJs() { name = "Angello", Cash = 45,
                MyLabel = angellosBetInfoLabel, MyRadioButton = angelloRadioButton};

            minimumBetLabel.Text = "Minimum bet: " + minBet + " dollars";

            axwelBetInfoLabel.Text = "Axwell hasn't placed a bet yet";
            ingrossoBetInfoLabel.Text = "Ingrosso hasn't placed a bet yet";
            angellosBetInfoLabel.Text = "Angello hasn't placed a bet yet";

            axwelRadioButton.Text = "Axwel has " + djArray[0].Cash + " dollars";
            ingrossoRadioButton.Text = "Ingrosso has " + djArray[1].Cash + " dollars";
            angelloRadioButton.Text = "Angello has " + djArray[2].Cash +" dollars";

            bottomNameLabel.Text = "Axwell";


            domainUpDown1.Items.Add("Espeon");
            domainUpDown1.Items.Add("Flareon");
            domainUpDown1.Items.Add("Leafeon");
            domainUpDown1.Items.Add("Umbreon");
            domainUpDown1.SelectedIndex = 0;



            eeveeArray[0] = new Eeveelution()
            {
                name = "Espeon",
                MyPictureBox = espeonPictureBox,
                StartingPosition = espeonPictureBox.Left,
                Randomizer = MyRandomizer,
                RacetrackLength = racetrackPictureBox.Width - espeonPictureBox.Width

            };

            eeveeArray[1] = new Eeveelution()
            {
                name = "Flareon",
                MyPictureBox = flareonPictureBox,
                StartingPosition = flareonPictureBox.Left,
                Randomizer = MyRandomizer,
                RacetrackLength = racetrackPictureBox.Width - flareonPictureBox.Width

            };

            eeveeArray[2] = new Eeveelution()
            {
                name = "Leafeon",
                MyPictureBox = leafeonPictureBox,
                StartingPosition = leafeonPictureBox.Left,
                Randomizer = MyRandomizer,
                RacetrackLength = racetrackPictureBox.Width - leafeonPictureBox.Width

            };

            eeveeArray[3] = new Eeveelution()
            {
                name = "Umbreon",
                MyPictureBox = umbreonPictureBox,
                StartingPosition = umbreonPictureBox.Left,
                Randomizer = MyRandomizer,
                RacetrackLength = racetrackPictureBox.Width - umbreonPictureBox.Width

            };
            
        }

        
        



        private void button1_Click(object sender, EventArgs e)
        {
            timeLeft = 0;         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!gameRunning && timeLeft > 0)
            {
                timeLeft--;
                timerUpdate.Text = timeLeft + " Remaining Until Next Race!";
                groupBox1.Enabled = true;
            }
            else
            {
                gameRunning = true;
                timerUpdate.Text = "RACE IN PROGRESS!!!";
                timer2.Enabled = true;
                groupBox1.Enabled = false;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < eeveeArray.Length; i++)
            {
                eeveeArray[i].Run();

                if (eeveeArray[i].MyPictureBox.Left >= 564)
                { 
                // turn off game timer and stop the game from running
                    timer2.Enabled = false;
                    gameRunning = false;

                    //reset the timer until the next race
                    timeLeft = 100;

                    // alert the user who won
                    MessageBox.Show(eeveeArray[i].name + " has won the race!!!");

                    //payout/ collect money from their bets
                    djArray[0].Collect(eeveeArray[i].name);
                    djArray[1].Collect(eeveeArray[i].name);
                    djArray[2].Collect(eeveeArray[i].name);

                    //reset Eeveelutions to starting positions
                    eeveeArray[0].TakeStartingPosition();
                    eeveeArray[1].TakeStartingPosition();
                    eeveeArray[2].TakeStartingPosition();
                    eeveeArray[3].TakeStartingPosition();
                    break;
                }
            }
        }

        private void betConfirmButton_Click(object sender, EventArgs e)
        {
            if (axwelRadioButton.Checked)
            { 
            // create a new instance of bet for Axwel
                djArray[0].bet = new Bet() { Bettor = djArray[0]};

                // change Axwell's bet instance to the amount selected on the form
                djArray[0].PlaceBet(Convert.ToInt32(betValueNumericUpDown.Value), domainUpDown1.Items[domainUpDown1.SelectedIndex].ToString());

                // update the labels for the bet that was placed
                djArray[0].UpdateLabels();
                
            }
            else if (ingrossoRadioButton.Checked)
            {
            // create a new instance of bet for Axwel
                djArray[1].bet = new Bet() { Bettor = djArray[1]};

                // change Axwell's bet instance to the amount selected on the form
                djArray[1].PlaceBet(Convert.ToInt32(betValueNumericUpDown.Value), domainUpDown1.Items[domainUpDown1.SelectedIndex].ToString());

                // update the labels for the bet that was placed
                djArray[1].UpdateLabels();
            }
            else
            {
            // create a new instance of bet for Axwel
                djArray[2].bet = new Bet() { Bettor = djArray[2]};

                // change Axwell's bet instance to the amount selected on the form
                djArray[2].PlaceBet(Convert.ToInt32(betValueNumericUpDown.Value), domainUpDown1.Items[domainUpDown1.SelectedIndex].ToString());

                // update the labels for the bet that was placed
                djArray[2].UpdateLabels();
            }

        }

        private void axwelRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (axwelRadioButton.Checked)
            { bottomNameLabel.Text = "Axwell"; }
        }

        private void ingrossoRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ingrossoRadioButton.Checked)
            { bottomNameLabel.Text = "Ingrosso"; }
        }

        private void angelloRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (angelloRadioButton.Checked)
            { bottomNameLabel.Text = "Angello"; }

        }
    }
}
