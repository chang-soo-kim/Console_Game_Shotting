using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShottingGame
{
    internal class GameLoop
    {

        Player player;
        Monster monster;
        Bullet[] bullet;
        Score score;
        int oldTime;
        bool Needrefresh = false;

        public void Awake()
        {

            Console.BufferWidth = Console.WindowWidth = 30;
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.CursorVisible = false;
            player = new Player();
            monster = new Monster();

            bullet = new Bullet[10];

            for (int i = 0; i < 10; i++)
            {
                bullet[i] = new Bullet();
            }
            score = new Score();

        }



        public void Start()
        {
            player.lnit();
            monster.lnit();
        }

        public void Update()
        {


            //충돌체크
            for (int i = 0; i < 10; i++)
            {
                if (bullet[i].Getbullet_x() == monster.Getmonster_x() && bullet[i].Getbullet_y() == monster.Getmonster_y())
                {
                    score.Setscore();
                    bullet[i].SetAlive(false);
                    monster.lnit();
                }

            }

            //몬스터의 움직임 속도, 총알의 속도
            int curTime = Environment.TickCount & Int32.MaxValue;
            if (curTime - oldTime > 1000 / 20)
            {
                oldTime = curTime;
                monster.Update();
                
                //총알의 움직임
                for (int i = 0; i < bullet.Length; i++)
                {
                    bullet[i].Update();
                    Needrefresh = true;
                }

            }



            for (int i = 0; i < 10; i++)
            {
                //플레이어 조종
                if (Console.KeyAvailable)
                {

                    ConsoleKeyInfo key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.LeftArrow:
                            {

                                player.Move_Left();
                                break;
                            }
                        case ConsoleKey.RightArrow:
                            {

                                player.Move_Right();
                                break;
                            }
                        case ConsoleKey.Spacebar:
                            {
                                //만약에 count가 bullet탄창수 이상이면 다시 0
                                //카운트 하나 해서
                                //bullet[count] alive 켜주고
                                //count 증가
                                if (bullet[i].GetAlive() == false)
                                {

                                    bullet[i].Setbullet_x(player.GetPlayer_x());
                                    bullet[i].Setbullet_y(player.GetPlayer_y());
                                    bullet[i].SetAlive(true);
                                }

                            }
                            break;
                    }

                }
            }



        }
        public void Render()
        {
            if (Needrefresh == false)
            {
                return;
            }
            else
            {
                Console.Clear();
                player.Render();
                monster.Render();
                score.Render();
                for (int i = 0; i < 10; i++)
                {
                    bullet[i].Render();
                }
                Needrefresh = false;
            }
        }

    }
}
