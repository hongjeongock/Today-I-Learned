using System;
using System.Collections.Generic;
using System.Text;

namespace _20260107
{
    public abstract class State // 상태를 객체화 하자
    {
        public abstract void Enter();
        public abstract void Update();
        public abstract void Exit();

    }
}
