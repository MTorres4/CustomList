﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Node
    {
        public int Nums;
        public Node Left;
        public Node Right;

        public Node(int nums)
        {
            Nums = nums;
        }
    }
}
