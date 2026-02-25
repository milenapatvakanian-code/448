using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;

namespace _448
{
    internal class MyLinkedList<T> : ICollection<T>

    {
        public MyLinkedListNode<T> Head { get; private set; }
        public MyLinkedListNode<T> Tail { get; private set; }
        #region ICollection 
        public int Count { get; private set; }

        public bool IsReadOnly { get => false; }


        public void Add(T item)
        {
            AddFirst(item);

        }


        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }

        public bool Contains(T item)
        {
            MyLinkedListNode<T> current = Head;
            while (current != null)
            {
                if (current.Value.Equals(item))
                    return true;
                current = current.Next;
            }
            return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            MyLinkedListNode<T> current = Head;
            while (current != null)
            {
                array[arrayIndex++] = current.Value;
                current = current.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion
        #region Add

        public void AddFirst(T item)

        {
            AddFirst(new MyLinkedListNode<T>(item));
        }
        private void AddFirst(MyLinkedListNode<T> node)
        {
            MyLinkedListNode<T> temp = Head;
            Head = node;
            Head.Next = temp;
            Count++;
            if (Count == 1)
                Tail = Head;

        }
        public void AddLast(T item)
        {
            AddLast(new MyLinkedListNode<T>(item));
        }
        private void AddLast(MyLinkedListNode<T> node)
        {
            if (Count == 0)

            {
                Tail = Head;
                Head = node;
                Tail = node;
            }
            else
            {
                Tail = node;
                Tail.Next = node;
                Count++;
            }
        }
        #endregion
        #region Remove
        public void RemoveFirst(T item)
        {
            RemoveFirst(new MyLinkedListNode<T>(item));
        }
        private void RemoveFirst(MyLinkedListNode<T> node)
        {
            Head = Head.Next;
            Count--;
        }
        public void RemoveLast(T item)
        {
            RemoveLast(new MyLinkedListNode<T>(item));
        }
        private void RemoveLast(MyLinkedListNode<T> node)
        {
            if (Count != 0)
            {
                if (Count == 1)
                {
                    Head = null;
                    Tail = null;

                }
                else
                {
                    MyLinkedListNode<T> current = Head;
                    while (current.Next != Tail)
                    {
                        current = current.Next;
                    }
                    current.Next = null;
                    Tail = current;
                }
                Count--;





            }
        }
        #endregion
    }
}



