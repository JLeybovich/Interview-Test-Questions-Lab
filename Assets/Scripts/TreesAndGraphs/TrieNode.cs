using System.Collections.Generic;

namespace InterviewQuestions.TreesAndGraphs
{
    public class TrieNode
    {
        private Dictionary<char, TrieNode> _nodeChildren = new Dictionary<char, TrieNode>();

        public bool HasChildNode(char character)
        {
            return _nodeChildren.ContainsKey(character);
        }

        public void MakeChildNode(char character)
        {
            _nodeChildren[character] = new TrieNode();
        }

        public TrieNode GetChildNode(char character)
        {
            return _nodeChildren[character];
        }
    }
}