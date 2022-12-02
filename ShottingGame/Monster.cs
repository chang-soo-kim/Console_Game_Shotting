using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShottingGame
{
    internal class Monster
    {
        int Monster_x;
        int Monster_y;
        public int Getmonster_x()
        {
            return Monster_x;
        }
        public int Getmonster_y()
        {
            return Monster_y;
        }

        Random random = new Random();
        public void lnit()
        {
            Monster_x = random.Next(1, 30);
            Monster_y = 4;
        }

        public void Update()
        {

            if (Monster_x > 0 && Monster_x < 30)
            {
                Monster_x += random.Next(-1, 2);
                if (Monster_x < 1)
                {
                    Monster_x = 1;
                }
                if (Monster_x > 28)
                {
                    Monster_x = 27;
                }
            }
        }

        public void Render()
        {

            Console.SetCursorPosition(Monster_x, Monster_y);
            Console.ForegroundColor = ConsoleColor.DarkRed; // 글씨 색상변경
            Console.Write('★');
            Console.ResetColor();//글씨색상 초기화

        }
    }
}
