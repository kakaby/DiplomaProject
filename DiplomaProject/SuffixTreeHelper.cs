using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject
{
    static class SuffixTreeHelper
    {
        private const int ThresholdValue = 0;
        public static SuffixTree BuildSuffixTree<T>( List<T> alphabet, List<T> sequence )
        {
            return BasicAlgorithm(alphabet, sequence);
            if (alphabet.Count <= ThresholdValue)
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
            return new SuffixTree(new Node());    
        }
        private static SuffixTree AlgorithmForLargeAlphabet<T>( List<T> alphabet, List<T> sequence )
        {
            //TODO
            return new SuffixTree(new Node());    
        }
        private static SuffixTree BasicAlgorithm<T>(List<T> alphabet, List<T> sequence)
        {
            Node root = new Node();
            SuffixTree tree = new SuffixTree(root);
            foreach (var element in sequence)
            {   
                
                
                
            }
            
            //TODO
            return tree;
        }
    }
}
