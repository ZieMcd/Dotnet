using System;
using System.Collections.Generic;

namespace Stack
{
    public class stack
    {
        private List<object> objs = new List<object>();
        public void Push(object obj)
        {
            objs.Add(obj);
        }
        public object Pop()
        {
          return objs[objs.Count-1];
          objs.RemoveAt(objs.Count);
        } 
        
    }
}