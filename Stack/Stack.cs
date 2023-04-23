using System.Collections;

namespace Stack
{
    public  class LinkedListStack<T> : IEnumerable<T>
    {
        Node<T> head;
        private int count;

        public int Count { get { return count; } }
        public bool IsEmpty { get { return count == 0; } }

        public void Push(T item)
        {
            var node = new Node<T>(item);
            node.Next = head;
            head = node;
            count++;
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty!");
            return head.Data;
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty!");

            var tmp = head;
            head = head.Next;
            count--;
            return tmp.Data;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
