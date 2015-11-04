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
        public int PositionOfSymbolInText { get; set; }
        public int IndexStartSubsequence { get; set; }
        public int IndexEndSubsequence { get; set; }
        public int IndexInAlbhabet { get; set; }

        public Node( ) { }

        public Node( int positionInText )
        {
            _positionOfSymbolInText = positionInText;
        }

        public Node( ref Node parent, ref List<Node> children)
        {
            _parent = parent;
            _children = children;
        }

        public Node( ref List<Node> children)
        {
            _children = children;
        }

        public Node( ref Node parent)
        {
            _parent = parent;
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
            return _positionOfSymbolInText;
        }

        public void SetPositionInText(int position)
        {
            _positionOfSymbolInText = position;
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