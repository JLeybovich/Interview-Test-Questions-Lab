using System;
using System.Collections;
using System.Collections.Generic;

namespace InterviewQuestions.LinkedLists
{
    public class LinkedList<T> : IEnumerable<T>
    {
        private class LinkedListEnumerator : IEnumerator<T>
        {
            public LinkedList<T> list;
            LinkedListNode<T> position;

            public LinkedListEnumerator(LinkedList<T> list)
            {
                this.list = list;
            }

            public bool MoveNext()
            {
                if (position == null)
                {
                    position = list.Head;
                }
                else
                {
                    position = position.Next;
                }
                
                return position != null;
            }

            public void Reset()
            {
                position = null;
            }

            public void Dispose()
            {
                position = null;
            }

            public T Current
            {
                get
                {
                    return position.Value;
                }
            }

            object IEnumerator.Current => Current;
        }

        public LinkedListNode<T> Head { get; protected set; }
        public LinkedListNode<T> Tail { get; protected set; }

        public int Count { get; protected set; }

        public LinkedList(params T[] values)
        {
            Add(values);
        }

        public T this[int key]
        {
            get
            {
                if(key < 0 || key >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = Head;

                for (int i = 0; i < key; ++i)
                {
                    if(current == null)
                    {
                        throw new IndexOutOfRangeException();
                    }

                    current = current.Next;
                }

                return current.Value;
            }
            set
            {
                if (key < 0 || key >= Count)
                {
                    throw new IndexOutOfRangeException();
                }

                var current = Head;
                
                for (int i = 0; i < key; ++i)
                {
                    current = current.Next;
                }

                current.Value = value;
            }
        }

        public void Add(T value)
        {
            var newNode = new LinkedListNode<T>(value);

            if(Head == null)
            {
                Head = newNode;
            }
            else
            {
                Tail.Next = newNode;
            }

            Tail = newNode;
            ++Count;
        }

        public void Add(params T[] values)
        {
            foreach(var value in values)
            {
                Add(value);
            }
        }

        public void Remove(T value)
        {
            if (Head == null)
            {
                throw new InvalidOperationException();
            }

            LinkedListNode<T> previous = null;
            var current = Head;

            while(current != null)
            {
                if(current.Value.Equals(value))
                {
                    break;
                }

                previous = current;
                current = current.Next;
            }

            if(current == null)
            {
                throw new InvalidOperationException();
            }

            if(previous != null)
            {
                previous.Next = current.Next;
            }
            else
            {
                Head = current.Next;
            }

            if(current.Next == null)
            {
                Tail = previous;
            }

            --Count;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                throw new IndexOutOfRangeException();
            }

            LinkedListNode<T> previous = null;
            var current = Head;

            for (int i = 0; i < index; ++i)
            {
                previous = current;
                current = current.Next;
            }

            if (previous != null)
            {
                previous.Next = current.Next;
            }
            else
            {
                Head = current.Next;
            }

            if (current.Next == null)
            {
                Tail = previous;
            }

            --Count;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new LinkedListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
