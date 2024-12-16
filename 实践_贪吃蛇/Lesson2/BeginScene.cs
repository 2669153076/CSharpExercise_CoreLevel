using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson1;

namespace 实践_贪吃蛇.Lesson2
{
    class BeginScene : BeginOrEndBaseScene
    {
        public BeginScene()
        {
            strTitle = "贪吃蛇";
            strOne = "开始游戏";
        }

        public override void EnterJDoSomthing()
        {
            if(currentSelIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }


    }
}
