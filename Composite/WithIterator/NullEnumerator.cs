using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Learning.Composite.WithIterator
{
    public class NullEnumerator : IEnumerator
    {
        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public object Current
        {
            get
            {
                return null;
            }
        }
    }
}
