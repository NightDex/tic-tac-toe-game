using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_game
{
    class Player_order
    {
        public string P1;
        public string P2;
        private string lastTurn = "none";

        public Player_order(string P1, string P2)
        {
            this.P1 = P1;
            this.P2 = P2;
        }

        public string PlayerMark()
        {
            if (lastTurn == "none")
            {
                lastTurn = this.P1;
                return this.P1;
                
            }
            else
            {
                if (lastTurn == this.P1)
                {
                    lastTurn = this.P2;
                    return this.P2;
                }
                else
                {
                    lastTurn = this.P1;
                    return this.P1;
                }

            }
        }

        
    }
}
