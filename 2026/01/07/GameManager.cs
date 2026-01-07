using System;
using System.Collections.Generic;
using System.Text;

namespace _20260107
{
    internal class GameManager
    {
        public static bool IsGameOver {  get; set; }
        public void Run()
        {
            // 게임 루틴 가동
            Init();

            while (!IsGameOver)
            {
                if(Console.ReadKey(true).Key == ConsoleKey.A)
                {
                    _statePattern.Change("Move");
                }
                else if(Console.ReadKey(true).Key == ConsoleKey.S)
                {
                    _statePattern.Change("Idle");
                }
                else
                {
                    Console.WriteLine("잘못된 키 입력");
                }

                _statePattern.Update();
            }
        }
        private void Init()
        {
            IsGameOver = false;
            _statePattern = new StatePattern();

            _statePattern.AddState("Idle", new Idle());
            _statePattern.AddState("Move", new Move());
        }
    }
}
