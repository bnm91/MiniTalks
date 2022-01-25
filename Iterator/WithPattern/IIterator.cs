using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.Iterator.WithPattern
{
    public interface IIterator
    {
        bool HasNext();
        Object Next();
    }
}
