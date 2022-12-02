using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShottingGame
{
    internal class Score
    {
        int score_x = 0;
        int score_y = 0;
        int score = 0;

        public void Setscore(int Plusscore = 500)
        {
            score += Plusscore;
        }


        public void Render()
        {
            Console.SetCursorPosition(score_x, score_y);
            Console.ForegroundColor = ConsoleColor.Green; // 글씨 색상변경
            Console.Write($"Sconer : {score}");
            Console.ResetColor();//글씨색상 초기화
        }

    }
}
