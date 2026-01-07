using System;
using System.Collections.Generic;
using System.Text;

namespace _20260107
{
    internal class MenuList
    {
        private List<(string, Action)> _menus;
        private int _currentIndex;

        public MenuList(params (string, Action)[] menuTexts)
        {
            if (menuTexts.Length == 0)
            {
                _menus = menuTexts.ToList();
            }
            else
            {
                _menus = menuTexts.ToList();
            }
        }

        public void Reset()
        {
            _currentIndex = 0;
        }

    }
}
