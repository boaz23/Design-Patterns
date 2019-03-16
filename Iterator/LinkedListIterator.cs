using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    // Iterator
    partial class LinkedList<T>
    {
        public struct LinkedListIterator : IEnumerator<T>
        {
            private readonly LinkedList<T> list;

            // Link
            private LinkedListNode<T> currentLink;

            public LinkedListIterator(LinkedList<T> list)
            {
                if (list == null)
                {
                    throw new ArgumentNullException(nameof(list));
                }

                // Initialize the state to before the beginning of the list
                this.list = list;
                this.currentLink = null;
                this.Current = default(T);
            }

            // Data
            public T Current { get; private set; }

            public bool MoveNext()
            {
                if (this.currentLink == null)
                {
                    // Before the beginning
                    this.currentLink = this.list.first;
                }
                else
                {
                    // We're in the middle
                    this.currentLink = this.currentLink.Next;
                }

                // The end of the list
                if (this.currentLink == null)
                {
                    return false;
                }

                // Get the current data
                this.Current = this.currentLink.Data;
                return true;
            }

            public void Reset()
            {
                // Initialize the state to before the beginning of the list
                this.currentLink = null;
                this.Current = default(T);
            }

            public void Dispose() { }

            object IEnumerator.Current => this.currentLink;
        }
    }
}