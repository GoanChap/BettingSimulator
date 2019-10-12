using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eeveelution_Race_Betting_Simulator
{
    public class DJs
    {

        public string name;
        public Bet bet;
        public int Cash;

        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels() {

            this.MyLabel.Text = bet.GetDescription();
            this.MyRadioButton.Text = this.name + " has " + Cash + " dollars";
        
        }

        public void ClearBet() {
            bet.Amount = 0;
        }

        public void PlaceBet(int BetAmount, string EeveeToWin)
        { 
        // Place a new bet and store it in the Bet field
            // Return true if the guy had enough money to bet

            if (BetAmount <= this.Cash)
            {
                this.bet.Amount = BetAmount;
                this.bet.NumberAssignedToTheEevee = EeveeToWin;
   //             return true;
            }
            else
            {
     //           return false;
                MessageBox.Show("Please Try again with a lower value!", "Not enough funds");
            }
        }

        public void Collect(string Winner) { 
        // Ask my bet to pay out, clear my bet, and update my labels
            this.Cash += this.bet.PayOut(Winner);
            this.ClearBet();
            this.UpdateLabels();
        }
    }
}
