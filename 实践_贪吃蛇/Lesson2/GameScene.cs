using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson1;
using 实践_贪吃蛇.Lesson4;
using 实践_贪吃蛇.Lesson5;
using 实践_贪吃蛇.Lesson6;

namespace 实践_贪吃蛇.Lesson2
{
    class GameScene : ISceneUpdate
    {
        public GameScene()
        {
            map = new Map();
            snake = new Snake(40,10);
            food = new Food(snake);
        }

        public void Update()
        {
            
            if (updateTimer % 8000 == 0)
            {
                map.Draw();
                food.Draw();

                snake.Move();
                snake.Draw();

                if (snake.CheckEnd(map))
                {
                    Game.ChangeScene(E_SceneType.End);
                }

                snake.CheckEatFood(food);

                updateTimer = 0;

            }
            ++updateTimer;

            //在控制台中 检测玩家输入 让程序不被检测卡住
            //Console.KeyAvailable  判断  是否有键盘输入 如果有 则为true
            if (Console.KeyAvailable)
            {
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        snake.ChangeDir(E_MoveDir.Up);
                        break;
                    case ConsoleKey.S:
                        snake.ChangeDir(E_MoveDir.Down);
                        break;
                    case ConsoleKey.A:
                        snake.ChangeDir(E_MoveDir.Left);
                        break;
                    case ConsoleKey.D:
                        snake.ChangeDir(E_MoveDir.Right);
                        break;
                }
            }
        }

        Map map;
        Snake snake;
        Food food;

        int updateTimer = 0;
    }
}
