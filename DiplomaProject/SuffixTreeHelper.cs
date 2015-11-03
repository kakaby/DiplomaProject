using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    static class SuffixTreeHelper
    {
        private static Type _typeOfModel;
        private static int _thresholdValue = 0;
        public static SuffixTree BuildSuffixTree<T>( List<T> alphabet, List<T> sequence )
        {
            return BasicAlgorithm(alphabet, sequence);
            if (alphabet.Count <= _thresholdValue)
            {
                return AlgorithmForSmallAlphabet(alphabet, sequence);
            }
            else
            {
                return AlgorithmForLargeAlphabet(alphabet, sequence);
            }
        }
        private static SuffixTree AlgorithmForSmallAlphabet<T>( List<T> alphabet, List<T> sequence )
        {
            //TODO
            return new SuffixTree();    
        }
        private static SuffixTree AlgorithmForLargeAlphabet<T>( List<T> alphabet, List<T> sequence )
        {
            //TODO
            return new SuffixTree();    
        }
        private static SuffixTree BasicAlgorithm<T>(List<T> alphabet, List<T> sequence)
        {
            //TODO
            return new SuffixTree();
        }
    }
}
