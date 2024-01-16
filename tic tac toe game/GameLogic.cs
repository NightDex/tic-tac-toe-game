using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_game
{
    class GameLogic
    {        
        private string b1;
        private string b2;
        private string b3;
        private string b4;
        private string b5;
        private string b6;
        private string b7;
        private string b8;
        private string b9;
        public string winnerMark;

        public GameLogic()
        {
            
        }

        public void GetMark(string button, string mark)
        {
            if (button == "b1")
            {
                this.b1 = mark;
            }
            else if (button == "b2")
            {
                this.b2 = mark;
            }
            else if (button == "b3")
            {
                this.b3 = mark;
            }
            else if (button == "b4")
            {
                this.b4 = mark;
            }
            else if (button == "b5")
            {
                this.b5 = mark;
            }
            else if (button == "b6")
            {
                this.b6 = mark;
            }
            else if (button == "b7")
            {
                this.b7 = mark;
            }
            else if (button == "b8")
            {
                this.b8 = mark;
            }
            else if (button == "b9")
            {
                this.b9 = mark;
            }
            else
            {
                return;
            }
        }

        public bool IfWonGame()
        {

            // horizontal combos
            if(this.b1 == this.b2 && this.b1 == this.b3 && !string.IsNullOrEmpty(this.b1))
            {
                this.winnerMark = this.b1;
                return true;
            }
            else if (this.b4 == this.b5 && this.b4 == this.b6 && !string.IsNullOrEmpty(this.b4))
            {
                this.winnerMark = this.b4;
                return true;
            }
            else if (this.b7 == this.b8 && this.b7 == this.b9 && !string.IsNullOrEmpty(this.b7))
            {
                this.winnerMark = this.b7;
                return true;
            }
            // vertical combos
            else if (this.b1 == this.b4 && this.b1 == this.b7 && !string.IsNullOrEmpty(this.b1))
            {
                this.winnerMark = this.b1;
                return true;
            }
            else if (this.b2 == this.b5 && this.b2 == this.b8 && !string.IsNullOrEmpty(this.b2))
            {
                this.winnerMark = this.b2;
                return true;
            }
            else if (this.b3 == this.b6 && this.b3 == this.b9 && !string.IsNullOrEmpty(this.b3))
            {
                this.winnerMark = this.b3;
                return true;
            }
            // diogonal combos
            else if (this.b1 == this.b5 && this.b1 == this.b9 && !string.IsNullOrEmpty(this.b1))
            {
                this.winnerMark = this.b1;
                return true;
            }
            else if (this.b3 == this.b5 && this.b3 == this.b7 && !string.IsNullOrEmpty(this.b3))
            {
                this.winnerMark = this.b3;
                return true;
            }
            // nobody won combo
            else if (!string.IsNullOrEmpty(this.b1) && !string.IsNullOrEmpty(this.b2) && !string.IsNullOrEmpty(this.b3) && !string.IsNullOrEmpty(this.b4) && !string.IsNullOrEmpty(this.b5) && !string.IsNullOrEmpty(this.b6) && !string.IsNullOrEmpty(this.b7) && !string.IsNullOrEmpty(this.b8) && !string.IsNullOrEmpty(this.b9))
            {
                this.winnerMark = "nobody";
                return true;
            }

            else
            {
                return false;
            }            
        }

        
        //if won method
        //if start over method
    }
}
