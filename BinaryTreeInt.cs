using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    public class BinaryTreeInt
    {
        private NodeInt root;

        public BinaryTreeInt()
        {
            root = null;
        }

        public void Insert(int data)
        {
            root = Insert(root, data);
        }

        private NodeInt Insert(NodeInt node, int data)
        {
            if (node == null)
            {
                node = new NodeInt(data);
            }
            else
            {
                if (data < node.Data)
                {
                    node.Left = Insert(node.Left, data);
                }
                else if (data > node.Data)
                {
                    node.Right = Insert(node.Right, data);
                }
            }
            return node;
        }

        public List<int> PreOrder()
        {
            List<int> result = new List<int>();
            PreOrderTraversal(root, result);
            return result;
        }

        private void PreOrderTraversal(NodeInt node, List<int> result)
        {
            if (node != null)
            {
                result.Add(node.Data);
                PreOrderTraversal(node.Left, result);
                PreOrderTraversal(node.Right, result);
            }
        }

        public List<int> InOrder()
        {
            List<int> result = new List<int>();
            InOrderTraversal(root, result);
            return result;
        }

        private void InOrderTraversal(NodeInt node, List<int> result)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Data);
                InOrderTraversal(node.Right, result);
            }
        }

        public List<int> PostOrder()
        {
            List<int> result = new List<int>();
            PostOrderTraversal(root, result);
            return result;
        }

        private void PostOrderTraversal(NodeInt node, List<int> result)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left, result);
                PostOrderTraversal(node.Right, result);
                result.Add(node.Data);
            }
        }

        public int Count()
        {
            return Count(root);
        }

        private int Count(NodeInt node)
        {
            if (node == null)
                return 0;
            return 1 + Count(node.Left) + Count(node.Right);
        }
    }
}