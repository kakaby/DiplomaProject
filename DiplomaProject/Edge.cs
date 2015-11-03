using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    public class Edge
    {
        Node _aboveNode = null;
        List<Node> _belowNodes = new List<Node>();  
        public Edge()
        {
            
        }

        public Edge(ref List<Node> belowNodes)
        {
            _aboveNode = null;
            _belowNodes = belowNodes;
        }

        public Edge(ref Node aboveNode)
        {
            _aboveNode = aboveNode;
        }

        public Edge( ref Node aboveNode, ref List<Node> belowNodes )
        {
            _aboveNode = aboveNode;
            _belowNodes = belowNodes;
        }

        public Node GetAboveNode()
        {
            return _aboveNode;
        }

        public void SetAboveNode(Node node)
        {
            _aboveNode = node;
        } 

        public List<Node> GetBelowNodes()
        {
            return _belowNodes;
        }

        public void SetBelowNodes(List<Node> nodes)
        {
            _belowNodes = nodes;
        }

        public void AddBelowNode(Node node)
        {
            _belowNodes.Add(node);
        }
    }
}
