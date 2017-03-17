using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadTree
{
    class Tree
    {
        public Node root;
        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node newNode = new Node();
            newNode.Seed = id;
            if (root == null)
                root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.Seed)
                    {
                        current = current.TeamA;
                        if (current == null)
                        {
                            parent.TeamA = newNode;
                            return;
                        }
                    }
                    else
                    {
                        current = current.TeamB;
                        if (current == null)
                        {
                            parent.TeamB = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void Preorder(Node Root)
        {
            if (Root != null)
            {
                Root.Display();
                Preorder(Root.TeamA);
                Preorder(Root.TeamB);
            }
        }
        public void Inorder(Node Root)
        {
            if (Root != null)
            {
                Inorder(Root.TeamA);
                Root.Display();
                Inorder(Root.TeamB);
            }
        }
        public void Postorder(Node Root)
        {
            if (Root != null)
            {
                Postorder(Root.TeamA);
                Postorder(Root.TeamB);
                Root.Display();
            }
        }
    }
}
