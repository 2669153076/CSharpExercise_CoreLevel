using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson1;
using 实践_贪吃蛇.Lesson3;
using 实践_贪吃蛇.Lesson6;

namespace 实践_贪吃蛇.Lesson4
{
    class Food : GameObject
    {
        public Food(Snake snake)
        {
            RandomPos(snake);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("¤");
        }

        public void RandomPos(Snake snake)
        {
            do
            {
                int x = r.Next(2, (Game.w / 2 - 1) * 2);
                int y = r.Next(1, Game.h - 2);
                if (x % 2 != 0)
                {
                    ++x;
                }
                pos = new Position(x, y);

                
            } while (snake.CheckSamePos(pos));

            //if(snake.CheckSamePos(pos))
            //{
            //    RandomPos(snake);
            //}

        }

        private Random r = new Random();
    }
}
