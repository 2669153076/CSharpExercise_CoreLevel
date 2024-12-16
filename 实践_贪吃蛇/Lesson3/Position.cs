using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实践_贪吃蛇.Lesson3
{
    struct Position
    {
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(Position left, Position right)
        {
            if(left.x == right.x && left.y == right.y)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Position left, Position right)
        {
            return !(left == right);
        }

        public int x;
        public int y;
    }
}
