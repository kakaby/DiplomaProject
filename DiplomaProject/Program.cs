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

            SuffixTree tree = SuffixTreeHelper.BuildSuffixTree<CharType>(b, b);
            int result = SearchHelper.Search(b, tree);
            Console.WriteLine(result);




            Node sq = new Node(6);
            sq.Children = new List<Node>();
            sq.Children.Add(new Node(ref sq, 7));

            foreach (var elem in sq.Children)
            {
                Console.WriteLine(elem.PositionInText);
            }
            Console.ReadKey();   
        }
    }
}
