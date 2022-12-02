using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShottingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameLoop gameloop = new GameLoop(); //클래스 새로만들고 객체선언?
            // 0. 생성단계
            gameloop.Awake();
            // 1. 초기화
            gameloop.Start();
            while (true)
            {
                gameloop.Update();
                gameloop.Render();
            }

        }
    }
}
    