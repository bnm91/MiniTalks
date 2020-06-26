using System;
using System.Collections.Generic;
using System.Text;

namespace Learning.StrategyPattern.WhatNotToDo
{
    public class DuckData
    {
        private IList<Duck> ducks;

        public DuckData()
        {
            ducks = new List<Duck>()
            {
                new MallardDuck(),
                new RedheadDuck()
            };
        }
        public IEnumerable<Duck> ReadAll()
        {
            return ducks;
        }

        public void Write(Duck duck)
        {
            ducks.Add(duck);
        }

        public void Delete(Duck duck)
        {
            ducks.Remove(duck);
        }
    }
}
