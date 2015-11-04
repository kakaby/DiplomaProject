using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    public class SuffixTree
    { 
        //TODO
        private Node Root = new Node();
        public SuffixTree(Node root)
        {
            Root = root; 
        }
        public void AddNewNode( ref Node parent, ref List<Node> children)
        {
            Node node = new Node(ref parent, ref children);
        }
        public void AddNewNode(ref Node parent)
        {
            Node node = new Node(ref parent);
        }
    }
}
