using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MunServices.ServiceRequestNode;


namespace MunServices
{
    // Service Request Tree Manager - Handles different tree implementations
    public class ServiceRequestTreeManager
    {
        private ServiceRequestNode root;
        private const string RED = "RED";
        private const string BLACK = "BLACK";

        // BST Operations
        public void InsertBST(Issue issue)
        {
            root = InsertBSTRecursive(root, issue);
        }

        private ServiceRequestNode InsertBSTRecursive(ServiceRequestNode node, Issue issue)
        {
            if (node == null)
                return new ServiceRequestNode(issue);

            int compareResult = string.Compare(issue.Location, node.Data.Location);
            if (compareResult < 0)
            {
                node.Left = InsertBSTRecursive(node.Left, issue);
                node.Left.Parent = node;
            }
            else if (compareResult > 0)
            {
                node.Right = InsertBSTRecursive(node.Right, issue);
                node.Right.Parent = node;
            }

            return node;
        }

        // AVL Tree Operations
        public void InsertAVL(Issue issue)
        {
            root = InsertAVLRecursive(root, issue);
        }

        private ServiceRequestNode InsertAVLRecursive(ServiceRequestNode node, Issue issue)
        {
            if (node == null)
                return new ServiceRequestNode(issue);

            int compareResult = string.Compare(issue.Location, node.Data.Location);
            if (compareResult < 0)
            {
                node.Left = InsertAVLRecursive(node.Left, issue);
                node.Left.Parent = node;
            }
            else if (compareResult > 0)
            {
                node.Right = InsertAVLRecursive(node.Right, issue);
                node.Right.Parent = node;
            }
            else
                return node;

            node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));
            int balance = GetBalance(node);

            // Left Left Case
            if (balance > 1 && string.Compare(issue.Location, node.Left.Data.Location) < 0)
                return RightRotate(node);

            // Right Right Case
            if (balance < -1 && string.Compare(issue.Location, node.Right.Data.Location) > 0)
                return LeftRotate(node);

            // Left Right Case
            if (balance > 1 && string.Compare(issue.Location, node.Left.Data.Location) > 0)
            {
                node.Left = LeftRotate(node.Left);
                node.Left.Parent = node;
                return RightRotate(node);
            }

            // Right Left Case
            if (balance < -1 && string.Compare(issue.Location, node.Right.Data.Location) < 0)
            {
                node.Right = RightRotate(node.Right);
                node.Right.Parent = node;
                return LeftRotate(node);
            }

            return node;
        }

        // Red-Black Tree Operations
        public void InsertRB(Issue issue)
        {
            ServiceRequestNode node = new ServiceRequestNode(issue);
            root = InsertRBRecursive(root, node);
            FixViolation(node);
        }

        private ServiceRequestNode InsertRBRecursive(ServiceRequestNode root, ServiceRequestNode node)
        {
            if (root == null) return node;

            int compareResult = string.Compare(node.Data.Location, root.Data.Location);
            if (compareResult < 0)
            {
                root.Left = InsertRBRecursive(root.Left, node);
                root.Left.Parent = root;
            }
            else if (compareResult > 0)
            {
                root.Right = InsertRBRecursive(root.Right, node);
                root.Right.Parent = root;
            }

            return root;
        }

        private void FixViolation(ServiceRequestNode node)
        {
            ServiceRequestNode parent = node.Parent;
            ServiceRequestNode grandParent = parent?.Parent;

            while (node != root && node.Color == RED && parent?.Color == RED)
            {
                if (parent == grandParent?.Left)
                {
                    ServiceRequestNode uncle = grandParent.Right;
                    if (uncle != null && uncle.Color == RED)
                    {
                        grandParent.Color = RED;
                        parent.Color = BLACK;
                        uncle.Color = BLACK;
                        node = grandParent;
                    }
                    else
                    {
                        if (node == parent.Right)
                        {
                            LeftRotate(parent);
                            node = parent;
                            parent = node.Parent;
                        }
                        RightRotate(grandParent);
                        SwapColors(parent, grandParent);
                        node = parent;
                    }
                }
                else
                {
                    ServiceRequestNode uncle = grandParent?.Left;
                    if (uncle != null && uncle.Color == RED)
                    {
                        grandParent.Color = RED;
                        parent.Color = BLACK;
                        uncle.Color = BLACK;
                        node = grandParent;
                    }
                    else
                    {
                        if (node == parent.Left)
                        {
                            RightRotate(parent);
                            node = parent;
                            parent = node.Parent;
                        }
                        LeftRotate(grandParent);
                        SwapColors(parent, grandParent);
                        node = parent;
                    }
                }
            }
            root.Color = BLACK;
        }

        // Helper methods for tree operations
        private int GetHeight(ServiceRequestNode node)
        {
            if (node == null)
                return 0;
            return node.Height;
        }

        private int GetBalance(ServiceRequestNode node)
        {
            if (node == null)
                return 0;
            return GetHeight(node.Left) - GetHeight(node.Right);
        }

        private ServiceRequestNode RightRotate(ServiceRequestNode y)
        {
            ServiceRequestNode x = y.Left;
            ServiceRequestNode T2 = x.Right;

            x.Right = y;
            y.Left = T2;

            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;
            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;

            // Update parent pointers
            y.Parent = x;
            if (T2 != null)
                T2.Parent = y;
            x.Parent = y.Parent;
            if (y.Parent != null)
            {
                if (y.Parent.Left == y)
                    y.Parent.Left = x;
                else
                    y.Parent.Right = x;
            }
            else
            {
                root = x;
            }

            return x;
        }

        private ServiceRequestNode LeftRotate(ServiceRequestNode x)
        {
            ServiceRequestNode y = x.Right;
            ServiceRequestNode T2 = y.Left;

            y.Left = x;
            x.Right = T2;

            x.Height = Math.Max(GetHeight(x.Left), GetHeight(x.Right)) + 1;
            y.Height = Math.Max(GetHeight(y.Left), GetHeight(y.Right)) + 1;

            // Update parent pointers
            x.Parent = y;
            if (T2 != null)
                T2.Parent = x;
            y.Parent = x.Parent;
            if (x.Parent != null)
            {
                if (x.Parent.Left == x)
                    x.Parent.Left = y;
                else
                    x.Parent.Right = y;
            }
            else
            {
                root = y;
            }

            return y;
        }

        private void SwapColors(ServiceRequestNode node1, ServiceRequestNode node2)
        {
            string temp = node1.Color;
            node1.Color = node2.Color;
            node2.Color = temp;
        }
    }
}
