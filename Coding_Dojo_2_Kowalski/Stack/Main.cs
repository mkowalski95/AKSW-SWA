using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding_Dojo_2_Kowalski.Stack
{
    class Stack<T>
    {
        public Element<T> current;
        public T Pop()
        {
            if (current != null)
            {
                T temp = current.ElementValue;
                current = current.Vorgaenger;
                return temp;
            }
            else
            {
                throw new NullReferenceException();
            }
        }
        public void Push(T value)
        {
            if (current != null)
            {
                Element<T> neu = new Element<T>() { ElementValue=value, Vorgaenger=current };
                current = neu;
            }
            else
            {
                current = new Element<T>() { ElementValue = value, Vorgaenger = null };
            }

        }
            
        public T Peek()
        {
            if (current == null)
                return default(T);
            else
            {
                return current.ElementValue;
            }
        }

    }
}
