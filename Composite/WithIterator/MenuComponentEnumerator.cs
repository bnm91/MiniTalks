using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
    public class MenuComponentEnumerator : IEnumerator<MenuComponent>
    {
        Stack<IEnumerator> _stack = new Stack<IEnumerator>();
        private MenuComponent _current { get; set; }

        public MenuComponentEnumerator(IEnumerator enumerator)
        {
            _stack.Push(enumerator);
            MoveNext();
        }

        public MenuComponent Current
        {
            get
            {
                return _current;
            }
            set
            {
                _current = value;
            }
        }

        public bool MoveNext()
        {
            if (_stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator enumerator = _stack.Peek();
                if(!enumerator.MoveNext())
                {
                    _stack.Pop();
                    return MoveNext();
                }
                else
                {
                    Current = (MenuComponent)enumerator.Current;
                    if (Current is Menu menu)
                        _stack.Push(menu.CreateEnumerator());
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }
        object IEnumerator.Current => Current;
    }
}
