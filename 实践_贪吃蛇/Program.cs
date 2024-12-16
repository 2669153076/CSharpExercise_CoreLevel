using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson1;

namespace 实践_贪吃蛇
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Init();
            game.Start();
        }
    }
}
