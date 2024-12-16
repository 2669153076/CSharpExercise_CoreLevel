using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson3;
using 实践_贪吃蛇.Lesson4;
using 实践_贪吃蛇.Lesson5;

namespace 实践_贪吃蛇.Lesson6
{
    enum E_MoveDir
    {
        Up,
        Down,
        Left,
        Right
    }

    class Snake : IDraw
    {
        public Snake(int x,int y)
        {
            bodys = new SnakeBody[capacity];
            bodys[0] = new SnakeBody(E_SnakeBodyType.Head,x,y);
            length = 1;

            currentDir = E_MoveDir.Right;
        }

        public void Draw()
        {
           for(int i = 0;i<length;i++)
            {
                bodys[i].Draw();
            }
        }

        public void Move()
        {
            //移动前
            //擦除最后一个位置
            SnakeBody lastBody = bodys[length - 1];
            Console.SetCursorPosition(lastBody.pos.x,lastBody.pos.y);
            Console.Write("  ");

            for(int i=length-1;i>0;--i)
            {
                bodys[i].pos = bodys[i-1].pos;
            }

            switch (currentDir)
            {
                case E_MoveDir.Up:
                    --bodys[0].pos.y;
                    break;
                case E_MoveDir.Down:
                    ++bodys[0].pos.y;
                    break;
                case E_MoveDir.Left:
                    bodys[0].pos.x -= 2;
                    break;
                case E_MoveDir.Right:
                    bodys[0].pos.x += 2;
                    break;
            }
        }

        public void ChangeDir(E_MoveDir moveDir)
        {
            if (moveDir == this.currentDir ||
                length > 1 &&
                (this.currentDir == E_MoveDir.Left && moveDir == E_MoveDir.Right ||
                this.currentDir == E_MoveDir.Right && moveDir == E_MoveDir.Left ||
                this.currentDir == E_MoveDir.Up && moveDir == E_MoveDir.Down ||
                this.currentDir == E_MoveDir.Down && moveDir == E_MoveDir.Up))
            {
                return;
            }
            this.currentDir = moveDir;
        }

        public bool CheckEnd(Map map)
        {
            for(int i = 0; i < map.walls.Length; ++i)
            {
                if (bodys[0].pos == map.walls[i].pos)
                {
                    return true;
                }
            }
            for (int i = 1; i < length; i++)
            {
                if (bodys[0].pos == bodys[i].pos)
                {
                    return true;
                }

            }
            return false;
        }

        public bool CheckSamePos(Position pos)
        {
            for(int i = 0; i<length;i++)
            {
                if (bodys[i].pos == pos)
                {
                    return true;
                }
            }
            return false;
        }

        public void CheckEatFood(Food food)
        {
            if (bodys[0].pos == food.pos)
            {
                food.RandomPos(this);
                AddBody();
            }
        }

        private void AddBody()
        {
            SnakeBody frontBody = bodys[length - 1];
            if (length < capacity)
            {

                bodys[length] = new SnakeBody(E_SnakeBodyType.Body, frontBody.pos.x, frontBody.pos.y);

                ++length;
            }
            else
            {
                capacity *= 2;
                SnakeBody[] newBodys = new SnakeBody[capacity];
                for (int i = 0; i < length; ++i)
                {
                    newBodys[i] = bodys[i];
                }
                bodys = newBodys;
                bodys[length] = new SnakeBody(E_SnakeBodyType.Body, frontBody.pos.x, frontBody.pos.y);

                ++length;
            }
        }

        private SnakeBody[] bodys;
        private int length;
        private int capacity = 3;
        private E_MoveDir currentDir;
    }
}
