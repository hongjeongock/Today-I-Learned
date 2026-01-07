using System;
using System.Collections.Generic;
using System.Text;

namespace _20260107
{
    internal class TitleScene : Scene
    {
        private MenuList _titleMenu;

        public TitelScene()
        {
            Init();
        }
        public void Init()
        {
            _titleMenu = new MenuList();
            _titleMenu.Add("게임 시작", GameStart);
            _titleMenu.Add("크레딧", ViewCredits);
            _titleMenu.Add("게임 종료", GameQuit);

        }
        public override void Enter()
        {

        }
        private string[] _menus =
        {
            "게임 시작",
            "크레딧",
            "게임 종료"
        };

        private int _currentIndex;
        public override void Enter()
        {
            _titleMenu.Reset();
        }

        public override void Update()
        {
           if(InputManager.GetKey(ConsoleKey.UpArrow))
            {
                _currentIndex--;
            }
            else if (InputManager.GetKey(ConsoleKey.DownArrow))
            {
                _currentIndex++;
            }
           if (InputManager.GetKey(ConsoleKey.Enter))
            {

            }
        }

        public void SelectUp()
        {
            _currentIndex--;
            if(_currentIndex < 0) _currentIndex = 0;
        }
        public void SelectDown()
        {
            _currentIndex++; 

        }
        public override void Render()
        {
            Console.SetCursorPosition(5, 1);
            GameManager.GameName.Print(ConsoleColor.Yellow);

            Console.SetCursorPosition(5, 7);

            int x = 5;
            int y = 3;
            

            for (int i = 0; i < _menus.Length; i++)
            {
                y++;
                Console.SetCursorPosition(x, y);
                if (i == _currentIndex)
                {
                    "->".Print(ConsoleColor.Green);
                    _menus[i].Print(ConsoleColor.Green);
                    continue;
                }
                else
                {
                    Console.Write("  ");
                }
                _menus[i].Print(ConsoleColor.Green);
               
                Console.WriteLine();
            }
        }

        public override void Exit()
        {
            
        }
        public void GameQuit()
        {
            GameManager.IsGameOver = true;
        }
        public void 
        public void TempMethod()
        {

        }
    }
}
