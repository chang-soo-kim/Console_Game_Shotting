using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShottingGame
{
    internal class Player
    {

        int player_x;
        int player_y;
        

        public int GetPlayer_x()
        {
            return player_x;
        }
        public int GetPlayer_y()
        {
            return player_y;
        }
        public void lnit()
        {
            player_x = 15;
            player_y = 35;
        }

        public void Move_Left()
        {
            --player_x;
            if (player_x < 0)
            {
                player_x = 0;
            }
        }


        public void Move_Right()
        {
            ++player_x;
            if (player_x > 28)
            {
                player_x = 27;
            }
        }


        public void Update()
        {

        }

        public void Render()
        {

            Console.SetCursorPosition(player_x, player_y);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write('●');
            Console.ResetColor();//글씨색상 초기화

        }



    }
}
