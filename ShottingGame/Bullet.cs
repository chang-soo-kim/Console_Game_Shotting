using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShottingGame
{
    internal class Bullet
    {
        bool Alive = false;
        public bool GetAlive()
        {
            return Alive;
        }
        public void SetAlive(bool alive)
        {
            Alive = alive;
        }


        int bullet_x;
        int bullet_y;
        public void Setbullet_x(int bulletX)
        {
            bullet_x = bulletX;
        }
        public void Setbullet_y(int bulletY)
        {
            bullet_y = bulletY;
        }
        public int Getbullet_x()
        {
            return bullet_x;
        }
        public int Getbullet_y()
        {
            return bullet_y;
        }


        public void Update()
        {
            if (Alive == false)
            {
                return;
            }
            --bullet_y;
            if (bullet_y < 1)
            {
                bullet_y = 1;
                Alive = false;
            }


        }

        public void Render()
        {
            if (Alive == true)
            {
                Console.SetCursorPosition(bullet_x, bullet_y);
                Console.ForegroundColor = ConsoleColor.Blue; // 글씨 색상변경
                Console.Write('|');
                Console.ResetColor();//글씨색상 초기화
            }
            else
            {
                return;
            }
        }

    }
}
