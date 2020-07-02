using System;
using System.Collections.Generic;

public class Boggle
{
    private const ulong LongOne = 1;
    private const char EndOfWordMarker = '\0';

    private class TrieNode
    {
        private Dictionary<char, TrieNode> _children = new Dictionary<char, TrieNode>();

        public bool HasChild(char ch) 
            => _children.ContainsKey(ch);

        public TrieNode AddChild(char ch)
            => _children[ch] = new TrieNode();

        public TrieNode GetChild(char ch)
            => _children[ch];

        public TrieNode GetOrAddChild(char ch)
            => HasChild(ch)
                ? GetChild(ch)
                : AddChild(ch);

        public bool IsEndOfWord { get => HasChild(EndOfWordMarker); }
    }

    private class Trie
    {
        public TrieNode Root { get; private set; }
        private int _minWordLength;

        public Trie(int minWordLength = 3)
        {
            _minWordLength = minWordLength;
            Root = new TrieNode();
        }

        public void AddWord(string word)
        {
            if(word.Length < _minWordLength)
            {
                return;
            }

            TrieNode current = Root;
            foreach(char ch in word)
            {
                current = current.GetOrAddChild(ch);
            }
            current.GetOrAddChild(EndOfWordMarker);
        }
    }

    private Trie _legalWords = new Trie();

    // prior to solving a board, configure legal words
    public void SetLegalWords(
        // the legal words, alphabetically-sorted
        IEnumerable<string> allWords)
    {
        _legalWords = new Trie();
        
        foreach(string word in allWords)
        {
            _legalWords.AddWord(word);
        }
    }

    private void Validate(ref string board, TrieNode currNode,
        ulong visited, string currentWord, int idx, int w, int h, ref HashSet<string> results)
    {
        visited |= LongOne << idx;
        char character = board[idx];

        if(!currNode.HasChild(character))
        {
            // no way we can build a legal word out of this
            return;
        }

        // Is this a word?
        currNode = currNode.GetChild(character);
        currentWord += character;

        if (currNode.IsEndOfWord)
        {
            results.Add(currentWord);
        }

        int r = idx / w;
        int c = idx % w;
        int row = Math.Max(r - 1, 0);

        for(; row < r + 2 && row < h; ++row)
        {
            int col = Math.Max(c - 1, 0);
            for (; col < c + 2 && col < w; ++col)
            {
                int newIdx = (row * w) + col;
                ulong mask = LongOne << newIdx;

                if((visited & mask) == 0)
                {
                    Validate(ref board, currNode, visited, currentWord, newIdx, w, h, ref results);
                }
            }
        }
    }

    // find all words on the specified board
    public IEnumerable<string> SolveBoard(
        // width of the board
        int boardWidth,
        // height of the board
        int boardHeight,
        // board width*height characters in row major order
        string boardLetters)
    {
        HashSet<string> wordsOnBoard = new HashSet<string>();
        TrieNode legalWordsRoot = _legalWords.Root;

        for(int idx = 0; idx < boardLetters.Length; ++idx)
        {
            Validate(ref boardLetters, legalWordsRoot, 0, string.Empty, idx, boardWidth, boardHeight, ref wordsOnBoard);
        }

        return wordsOnBoard;
    }
}

