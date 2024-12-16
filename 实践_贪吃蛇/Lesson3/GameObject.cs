using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 实践_贪吃蛇.Lesson3
{
    abstract class GameObject : IDraw
    {

        //可以继承接口后 把接口中的方法 变成 抽象方法
        //供子类去实现 因为是抽象行为 所以子类中是必须去实现的
        public abstract void Draw();

        public Position pos;
    }
}
