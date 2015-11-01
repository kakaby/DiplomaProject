using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    static class SuffixTreeHelper
    {
        public static Type TypeOfModel;
        public static SuffixTree BuildSuffixTree<T>( List<T> alphabet, List<T> sequence )
        {
            //как это не тривиально, но построение суффиксного дерева. Всего-то
            TypeOfModel = alphabet.GetType();
            SuffixTree tree = new SuffixTree();
            return tree;
        }
    }
}
