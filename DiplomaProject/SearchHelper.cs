using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    static public class SearchHelper
    {
        static SuffixTree suffixTree;
        static public void Initialize<T>(List<T> alphabet, List<T> sequence)
        {
            suffixTree = SuffixTreeHelper.BuildSuffixTree(alphabet, sequence);
        }

        static public int Search<T>(List<T> subsequence)
        {
            int positionOfEntry = 0;
            return positionOfEntry;
        }
    }
}
