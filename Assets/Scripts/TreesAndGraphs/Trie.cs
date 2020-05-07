namespace InterviewQuestions.TreesAndGraphs
{
    public class Trie
    {
        private const char EndOfWordMarker = '\0';

        private TrieNode _rootNode = new TrieNode();

        public bool AddWord(string word)
        {
            var currentNode = _rootNode;
            bool isNewWord = false;

            // Work downwards through the trie, adding nodes
            // as needed, and keeping track of whether we add
            // any nodes.
            foreach (var character in word)
            {
                if (!currentNode.HasChildNode(character))
                {
                    isNewWord = true;
                    currentNode.MakeChildNode(character);
                }

                currentNode = currentNode.GetChildNode(character);
            }

            // Explicitly mark the end of a word.
            // Otherwise, we might say a word is
            // present if it is a prefix of a different,
            // longer word that was added earlier.
            if (!currentNode.HasChildNode(EndOfWordMarker))
            {
                isNewWord = true;
                currentNode.MakeChildNode(EndOfWordMarker);
            }

            return isNewWord;
        }
    }
}