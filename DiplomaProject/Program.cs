using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomaProject.DataTypes;

namespace DiplomaProject
{
    class Program
    {
        static void Main( )
        {
            CharType a = new CharType( 'a' );
            List<CharType> b = new List<CharType>();
            b.Add(a);
            //
            SuffixTree tree = SuffixTreeHelper.BuildSuffixTree<CharType>(b, b);
            int result = SearchHelper.Search(b, tree);
            Console.WriteLine(result);
            //
            Node parent = new Node(5);
            Node son = new Node(ref parent, 9);
            parent.AddChildren(ref son);
            foreach (var child in parent.GetChildren())
            {
                Console.WriteLine(child.GetParent().GetPositionInText());
            }
            //
            Console.ReadKey();   
        }
    }
}
