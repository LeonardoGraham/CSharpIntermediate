using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push( object obj )
        {
            if (obj == null)
            {
                throw new InvalidOperationException("obj");
            }
            this._stack.Add(obj);
        }

        public object Pop()
        {
            if (this._stack.Count == 0)
            {
                throw new InvalidOperationException("_stack");
            }

            int lastIndex = this._stack.Count - 1;
            object obj = this._stack[lastIndex];
            this._stack.RemoveAt(lastIndex);

            return obj;
        }

        public void Clear()
        {
            this._stack.Clear();
        }
    }
}
