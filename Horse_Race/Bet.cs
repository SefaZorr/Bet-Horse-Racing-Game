using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Horse_Race
{
    public class Bet
    {
        public int Amount;
        public int Horse;
        public Guy Bettor;

        public Bet(int Amount, int Horse, Guy Bettor)
        {
            this.Amount = Amount;
            this.Bettor = Bettor;
            this.Horse = Horse;
        }

        public string GetDescription()
        {
            string description = "";

            if (Amount > 0)
            {
                description = String.Format("{0} bets {1} on horse {2} bucks", Bettor.Name, Horse, Amount);
            }
            else
            {
                description = String.Format("hasn't placed any bets", Bettor.Name, Horse);
            }
            return description;
        }

        public int PayOut(int Winner)
        {
            if (Winner == Horse)
                return Amount;
            else return -Amount;
        }

    }
}
