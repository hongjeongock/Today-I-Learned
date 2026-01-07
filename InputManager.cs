using System;
using System.Collections.Generic;
using System.Text;

namespace _20260107
{
    public static class InputManager
    {
        private static ConsoleKey _current;

        private static readonly ConsoleKey[] _keys =
        {
            ConsoleKey.UpArrow,
            ConsoleKey.DownArrow,
            ConsoleKey.LeftArrow,
            ConsoleKey.RightArrow,
            ConsoleKey.Enter,
        };
        public static void GetUserInput()
        {
            ConsoleKey input =Console.ReadKey(true).Key;
            bool isValid = false;
            _current = ConsoleKey.None;

            foreach (ConsoleKey key in _keys)
            {
                isValid = true;
                _current = input;
                break;
            }
        }
    }
}
