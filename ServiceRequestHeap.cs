using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    // Service Request Heap Implementation
    public class ServiceRequestHeap
    {
        private List<Issue> heap;

        public ServiceRequestHeap()
        {
            heap = new List<Issue>();
        }

        public void Insert(Issue issue)
        {
            heap.Add(issue);
            HeapifyUp(heap.Count - 1);
        }

        public Issue ExtractMin()
        {
            if (heap.Count == 0)
                throw new InvalidOperationException("Heap is empty");

            Issue min = heap[0];
            heap[0] = heap[heap.Count - 1];
            heap.RemoveAt(heap.Count - 1);

            if (heap.Count > 0)
                HeapifyDown(0);

            return min;
        }

        private void HeapifyUp(int index)
        {
            int parent = (index - 1) / 2;
            while (index > 0 && CompareIssues(heap[index], heap[parent]) < 0)
            {
                Swap(index, parent);
                index = parent;
                parent = (index - 1) / 2;
            }
        }

        private void HeapifyDown(int index)
        {
            int smallest = index;
            int left = 2 * index + 1;
            int right = 2 * index + 2;

            if (left < heap.Count && CompareIssues(heap[left], heap[smallest]) < 0)
                smallest = left;

            if (right < heap.Count && CompareIssues(heap[right], heap[smallest]) < 0)
                smallest = right;

            if (smallest != index)
            {
                Swap(index, smallest);
                HeapifyDown(smallest);
            }
        }

        private void Swap(int i, int j)
        {
            Issue temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        private int CompareIssues(Issue a, Issue b)
        {
            // Compare based on status priority
            int statusCompare = GetStatusPriority(a.Status).CompareTo(GetStatusPriority(b.Status));
            if (statusCompare != 0)
                return statusCompare;

            // If status is same, compare by location
            return string.Compare(a.Location, b.Location);
        }

        private int GetStatusPriority(string status)
        {
            switch (status)
            {
                case "To Do": return 1;
                case "In Progress": return 2;
                case "Done": return 3;
                default: return 4;
            }
        }
    }
}

