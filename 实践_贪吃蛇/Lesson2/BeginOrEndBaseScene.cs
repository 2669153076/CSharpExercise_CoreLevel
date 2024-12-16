using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson1;

namespace 实践_贪吃蛇.Lesson2
{
    abstract class BeginOrEndBaseScene : ISceneUpdate
    {
        public void Update()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(Game.w / 2 - strTitle.Length, Game.h / 2 - 4);
            Console.Write(strTitle);

            Console.SetCursorPosition(Game.w / 2 - strOne.Length, Game.h / 2 + 2);
            Console.ForegroundColor = currentSelIndex == 0 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write(strOne);
            Console.SetCursorPosition(Game.w / 2 - 4, Game.h / 2 + 4);
            Console.ForegroundColor = currentSelIndex == 1 ? ConsoleColor.Red : ConsoleColor.White;
            Console.Write("结束游戏");

            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.W:
                    --currentSelIndex;
                    if (currentSelIndex < 0)
                    {
                        currentSelIndex = 0;
                    }
                    break;
                case ConsoleKey.S:
                    ++currentSelIndex;
                    if (currentSelIndex > 1)
                    {
                        currentSelIndex = 1;
                    }
                    break;
                case ConsoleKey.J:
                    EnterJDoSomthing();
                    break;
            }
        }

        public abstract void EnterJDoSomthing();

        protected string strTitle;
        protected string strOne;
        protected int currentSelIndex = 0;
    }
}
