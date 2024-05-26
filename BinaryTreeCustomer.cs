using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise2
{
    public class BinaryTreeCustomer
    {
        private NodeCustomer root;

        public BinaryTreeCustomer()
        {
            root = null;
        }

        public void Insert(Customer data)
        {
            root = Insert(root, data);
        }

        private NodeCustomer Insert(NodeCustomer node, Customer data)
        {
            if (node == null)
            {
                node = new NodeCustomer(data);
            }
            else
            {
                if (data.CompareTo(node.Data) < 0)
                {
                    node.Left = Insert(node.Left, data);
                }
                else if (data.CompareTo(node.Data) > 0)
                {
                    node.Right = Insert(node.Right, data);
                }
            }
            return node;
        }

        public List<string> PreOrder()
        {
            List<string> result = new List<string>();
            PreOrderTraversal(root, result);
            return result;
        }

        private void PreOrderTraversal(NodeCustomer node, List<string> result)
        {
            if (node != null)
            {
                result.Add(node.Data.GetInformation());
                PreOrderTraversal(node.Left, result);
                PreOrderTraversal(node.Right, result);
            }
        }

        public List<string> InOrder()
        {
            List<string> result = new List<string>();
            InOrderTraversal(root, result);
            return result;
        }

        private void InOrderTraversal(NodeCustomer node, List<string> result)
        {
            if (node != null)
            {
                InOrderTraversal(node.Left, result);
                result.Add(node.Data.GetInformation());
                InOrderTraversal(node.Right, result);
            }
        }

        public List<string> PostOrder()
        {
            List<string> result = new List<string>();
            PostOrderTraversal(root, result);
            return result;
        }

        private void PostOrderTraversal(NodeCustomer node, List<string> result)
        {
            if (node != null)
            {
                PostOrderTraversal(node.Left, result);
                PostOrderTraversal(node.Right, result);
                result.Add(node.Data.GetInformation());
            }
        }

        public Customer FindCustomer(string name)
        {
            return FindCustomer(root, name);
        }

        private Customer FindCustomer(NodeCustomer node, string name)
        {
            if (node == null)
                return null;

            int comparison = name.CompareTo(node.Data.Name);
            if (comparison == 0)
                return node.Data;
            else if (comparison < 0)
                return FindCustomer(node.Left, name);
            else
                return FindCustomer(node.Right, name);
        }


        public int Count()
        {
            return Count(root);
        }

        private int Count(NodeCustomer node)
        {
            if (node == null)
                return 0;
            return 1 + Count(node.Left) + Count(node.Right);
        }
    }
}