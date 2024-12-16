using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 实践_贪吃蛇.Lesson2;

namespace 实践_贪吃蛇.Lesson1
{
    enum E_SceneType
    {
        Begin,
        Game,
        End,
    }

    class Game
    {
        /// <summary>
        /// 初始化控制台
        /// </summary>
        public void Init()
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(w, h);
            Console.SetBufferSize(w, h);

            ChangeScene(E_SceneType.Begin);
        }
        /// <summary>
        /// 游戏开始方法
        /// </summary>
        public void Start()
        {
            while (true)
            {
                if (currentScene != null)
                {
                    currentScene.Update();
                }
            }
        }

        public static void ChangeScene(E_SceneType e_SceneType)
        {
            Console.Clear();
            switch (e_SceneType)
            {
                case E_SceneType.Begin:
                    currentScene = new BeginScene();
                    break;
                case E_SceneType.Game:
                    currentScene = new GameScene();
                    break;
                case E_SceneType.End:
                    currentScene = new EndScene();
                    break;
            }
        }



        public static ISceneUpdate currentScene;

        public const int w = 80;
        public const int h = 20;
    }
}
