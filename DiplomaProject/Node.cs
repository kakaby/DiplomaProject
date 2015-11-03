using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    public class Node
    {
        public Node Parent = null;
        public List<Node> Children;
        public int PositionInText;
        public Node( )
        {

        }
        public Node(int index)
        {
            PositionInText = index;
        }
        public Node(ref Node parent, int index)
        {
            Parent = parent;
            PositionInText = index;
        }
    }
}
