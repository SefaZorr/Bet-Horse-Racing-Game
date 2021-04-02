using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horse_Race
{
    public partial class Form1 : Form
    {
        Horse[] horses = new Horse[4];//obje dizisi oluşturuldu.
        Guy[] guys = new Guy[3];//obje dizisi oluşturuldu.
        public Form1()
        {
            InitializeComponent();
            SetUpRaceTrack();//Yarış Pisti Kuruluyor.
        }

        public void SetUpRaceTrack()
        {
            MinimumBet.Text = string.Format("Minimum Bet: {0:c}", (int)BetAmount.Minimum);
            int startingPosition = pictureBoxAt1.Right - racetrack.Left;
            int raceTrackLength = racetrack.Size.Width - 58;


            horses[0] = new Horse()
            {
                MyPictureBox = pictureBoxAt1,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            horses[1] = new Horse()
            {
                MyPictureBox = pictureBoxAt2,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            horses[2] = new Horse()
            {
                MyPictureBox = pictureBoxAt3,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };
            horses[3] = new Horse()
            {
                MyPictureBox = pictureBoxAt4,
                RacetrackLength = raceTrackLength,
                StartingPosition = startingPosition
            };

            guys[0] = new Guy("Joe", null, 100, joeButton, joeBet);
            guys[1] = new Guy("Bob", null, 100, bobButton, bobBet);
            guys[2] = new Guy("Al", null, 100, alButton, alBet);

            foreach (var guy in guys)
            {
                guy.UpdateLabels();
            }




        }

        private void joeButton_CheckedChanged(object sender, EventArgs e)
        {
            BettorName.Text = "Joe";
        }

        private void bobButton_CheckedChanged(object sender, EventArgs e)
        {
            BettorName.Text = "Bob";
        }

        private void alButton_CheckedChanged(object sender, EventArgs e)
        {
            BettorName.Text = "Al";
        }

        

        private void Bets_Click(object sender, EventArgs e)
        {
            int GuyNumber = 0;

            if (joeButton.Checked)
                GuyNumber = 0;
            if (bobButton.Checked)
                GuyNumber = 1;
            if (alButton.Checked)
                GuyNumber = 2;

            guys[GuyNumber].PlaceBet((int)BetAmount.Value, (int)HorseNumber.Value);
            guys[GuyNumber].UpdateLabels();
        }

        private void race_Click(object sender, EventArgs e)
        {
            bool NoWinner = true;
            int winningHorse;
            race.Enabled = false;
            pictureBoxGreenLight.Visible = true;
            pictureBoxRedLight.Visible = false;

            while (NoWinner)
            {
                Application.DoEvents();
                for (int i = 0; i < horses.Length; i++)
                {
                    if (horses[i].Run())
                    {
                        winningHorse = i + 1;
                        NoWinner = false;
                        MessageBox.Show("We have a winner - dog #" + winningHorse);
                        foreach (Guy guy in guys)
                        {
                            if (guy.MyBet != null)
                            {
                                guy.Collect(winningHorse);
                                guy.MyBet = null;
                                guy.UpdateLabels();
                            }
                        }
                        foreach (Horse horse in horses)
                        {
                            horse.TakeStartingPosition();
                            pictureBoxGreenLight.Visible = false;
                            pictureBoxRedLight.Visible = true;
                        }
                        break;
                    }
                }
            }
            race.Enabled = true;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
