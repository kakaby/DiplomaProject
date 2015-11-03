using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    public class Node
    {
        Node _parent = null;
        List<Node> _children = new List<Node>();
        int _positionInText;
        public Node( ) { }
        public Node( int positionInText )
        {
            _positionInText = positionInText;
        }
        public Node( ref Node parent, ref List<Node> children, int positionInText )
        {
            _parent = parent;
            _children = children;
            _positionInText = positionInText;
        }
        public Node( ref List<Node> children, int positionInText )
        {
            _children = children;
            _positionInText = positionInText;
        }
        public Node( ref Node parent, int positionInText )
        {
            _parent = parent;
            _positionInText = positionInText;
        }
        public Node GetParent()
        {
            return _parent;
        }
        public void SetParent(ref Node parent)
        {
            _parent = parent;
        }
        public int GetPositionInText()
        {
            return _positionInText;
        }
        public void SetPositionInText(int position)
        {
            _positionInText = position;
        }
        public List<Node> GetChildren()
        {
            return _children;
        }
        public void AddChildren(ref Node node)
        {
            _children.Add(node);
        }
        public void AddChildren(ref List<Node> nodes)
        {
            _children.AddRange(nodes);
        }
    }
}