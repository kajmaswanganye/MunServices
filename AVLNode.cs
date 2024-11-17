using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunServices
{
    // AVL Tree node for organizing service requests by priority
    public class AVLNode
    {
        public Issue Data { get; set; }
        public AVLNode Left { get; set; }
        public AVLNode Right { get; set; }
        public int Height { get; set; }

        public AVLNode(Issue data)
        {
            Data = data;
            Height = 1;
        }
    }
}
