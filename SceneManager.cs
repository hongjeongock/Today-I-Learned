using System;
using System.Collections.Generic;
using System.Text;

namespace _20260107
{
    internal class StatePattern
    {
        public Action OnChangeScene;
        //현재 상태가 뭔지?
        public State Current { get; private set; };

        // 어떤 상태들이 있는지?
        private Dictionary<string, State> _states = new Dictionary<string, State>();

        public void AddState(string key, State state)
        {
            if (_states.ContainsKey(key)) return;

            _states.Add(key, state);
        }
        // 상태 바꾸는 기능
        public void Change(string key)
        {
            if(!_states.ContainsKey(key)) return;

            State next = _states[key];

            if (Current == next) return;

            Current?.Exit();
            next = 
            Current.Enter();

            OnChangeScene?.Invoke(next);

        }
        public void Update()
        {

        }
    }
}
