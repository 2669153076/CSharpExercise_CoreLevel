using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson1;

namespace 实践_贪吃蛇.Lesson2
{
    class EndScene : BeginOrEndBaseScene
    {
        public EndScene()
        {
            strTitle = "游戏结束";
            strOne = "返回开始界面";
        }

        public override void EnterJDoSomthing()
        {
            if(currentSelIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Begin);
            }
            else
            {
                Environment.Exit(0);
            }
        }

        
    }
}
