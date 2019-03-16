using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    public partial class LinkedList<T> : IEnumerable<T>
    {
        private LinkedListNode<T> first;
        private LinkedListNode<T> last;

        public bool IsEmpty => this.first == null;

        public void Add(T data)
        {
            var link = new LinkedListNode<T>(data, null);
            if (this.IsEmpty)
            {
                this.first = link;
                this.last = link;
            }
            else
            {
                this.last.Next = link;
                this.last = link;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            // Return a new enumerator
            return new LinkedListIterator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}