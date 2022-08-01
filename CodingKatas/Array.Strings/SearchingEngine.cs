using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CodingKatas.Array.Strings
{
    public class SearchingEngine
    {
        public class TrieNode
        {
            public bool IsAWord { get; set; }
            public char Value { get; set; }
            public Dictionary<char, TrieNode> Nodes { get; set; }

            public TrieNode()
            {
                this.Nodes = new Dictionary<char, TrieNode>();
            }

            public TrieNode(char value) : this()
            {
                this.Value = value;
            }
            
            public TrieNode FindNode(string expression)
            {
                var trieNode = this;
                foreach (var letter in expression)
                {
                    if (!trieNode.Nodes.TryGetValue(letter, out var n1))
                    {
                        return null;
                    }

                    trieNode = n1;
                }
                return trieNode;
            }
        }

        private List<string> MoreThanWords { get; set; }

        public IList<IList<string>> SuggestedProducts(string[] products, string searchWord)
        {
            this.MoreThanWords = new List<string>();

            var root = new TrieNode();
            foreach (var word in products)
            {
                AddNode(word, 0, root);
            }

            var toSearch = "";
            var terms = new List<IList<string>>();
            foreach (var l in searchWord)
            {
                toSearch += l;
                this.MoreThanWords = new List<string>();
                var trieNode=root.FindNode(toSearch);
                if ( trieNode != null )
                {
                    if (trieNode.IsAWord)
                    {
                        this.MoreThanWords.Add(toSearch);
                    }

                    ReadNode(trieNode, toSearch);
                }
                terms.Add(this.MoreThanWords.OrderBy(w => w).Take(3).ToList());
            }

            return terms;
        }
        private void ReadNode(TrieNode trieNode, string newWord)
        {
            foreach (var matchedNode in trieNode.Nodes)
            {
                var word =newWord  + matchedNode.Value.Value;
                
                if (matchedNode.Value.IsAWord)
                {
                    this.MoreThanWords.Add(word);
                }

                if (matchedNode.Value.Nodes.Count > 0)
                {
                    ReadNode(matchedNode.Value, word);
                }
            }
        }
        
        private void AddNode(string word, int index, TrieNode root)
        {
            if (index >= word.Length)
            {
                root.IsAWord = true;
                return;
            }

            var c = word[index];
            if (root.Nodes.TryGetValue(c, out var node))
            {
                AddNode(word, index + 1, node);
            }
            else
            {
                var n = new TrieNode(c);
                root.Nodes.Add(c, n);
                AddNode(word, index + 1, n);
            }
        }
    }
}