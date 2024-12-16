using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson3;

namespace 实践_贪吃蛇.Lesson4
{
    enum E_SnakeBodyType
    {
        Head,
        Body
    }

    class SnakeBody : GameObject
    {
        public SnakeBody(E_SnakeBodyType type,int x,int y)
        {
            this.e_SnakeBodyType = type;
            this.pos = new Position(x,y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x,pos.y);
            Console.ForegroundColor = e_SnakeBodyType == E_SnakeBodyType.Head ? ConsoleColor.Magenta : ConsoleColor.Yellow;
            Console.Write(e_SnakeBodyType == E_SnakeBodyType.Head ? "●" : "◎");
        }

        private E_SnakeBodyType e_SnakeBodyType;
    }
}
