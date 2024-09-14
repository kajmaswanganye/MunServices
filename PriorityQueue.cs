using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    public class PriorityQueue<TElement, TPriority> where TPriority : IComparable<TPriority>
    {
        private List<(TElement Element, TPriority Priority)> elements;

        public PriorityQueue()
        {
            elements = new List<(TElement, TPriority)>();
        }

        public void Enqueue(TElement element, TPriority priority)
        {
            elements.Add((element, priority));
            elements.Sort((a, b) => a.Priority.CompareTo(b.Priority));
        }

        public TElement Dequeue()
        {
            if (elements.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            TElement item = elements[0].Element;
            elements.RemoveAt(0);
            return item;
        }

        public int Count => elements.Count;

        public IEnumerable<TElement> UnorderedItems => elements.Select(e => e.Element);
    }
}
