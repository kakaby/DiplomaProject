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

            SearchHelper.Initialize<CharType>( b, b );
            int result = SearchHelper.Search(b);
            Console.WriteLine(result);

            Console.ReadKey();   
        }
    }
}
