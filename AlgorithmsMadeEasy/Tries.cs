using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsMadeEasy
{
    class Tries
    {
        TrieNode root;

        public void CreateRoot()
        {
            root = new TrieNode();
        }

        public void Add(char[] chars)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                TrieNode newTrie;
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];
                }
                else
                {
                    newTrie = new TrieNode();

                    if (total == i)
                    {
                        newTrie.endOfWord = true;
                    }

                    tempRoot.children.Add(chars[i], newTrie);
                    tempRoot = newTrie;
                }
            }
        }

        public bool FindPrefix(char[] chars)
        {
            TrieNode tempRoot = root;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool FindWord(char[] chars)
        {
            TrieNode tempRoot = root;
            int total = chars.Count() - 1;
            for (int i = 0; i < chars.Count(); i++)
            {
                if (tempRoot.children.Keys.Contains(chars[i]))
                {
                    tempRoot = tempRoot.children[chars[i]];

                    if (total == i)
                    {
                        if (tempRoot.endOfWord == true)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        public void Delete(char[] chars)
        {
            DeleteWord(this.root, chars, 0);
        }

        private bool DeleteWord(TrieNode root, char[] chars, int index)
        {
            if (index == chars.Length)
            {
                if (root.endOfWord == true && root.children.Count != 0)
                {
                    root.endOfWord = false;
                    return false;
                }

                return root.children.Count == 0;
            }

            if (!root.children.ContainsKey(chars[index]))
            {
                return false;
            }

            bool deleteWord = DeleteWord(root.children[chars[index]], chars, index + 1);

            if (deleteWord)
            {
                root.children.Remove(chars[index]);
            }

            return root.children.Count == 0;
        }
    }

    public class TrieNode
    {
        public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
        public bool endOfWord;
    }
}

/*
Calling Code:
    Tries t = new Tries();
    t.CreateRoot();
    t.Add("abc".ToCharArray());
    t.Add("abgl".ToCharArray());
    t.Add("cdf".ToCharArray());
    t.Add("abcd".ToCharArray());
    t.Add("lmn".ToCharArray());

    bool findPrefix1 = t.FindPrefix("ab".ToCharArray());
    bool findPrefix2 = t.FindPrefix("lo".ToCharArray());

    bool findWord1 = t.FindWord("lmn".ToCharArray());
    bool findWord2 = t.FindWord("ab".ToCharArray());
    bool findWord3 = t.FindWord("cdf".ToCharArray());
    bool findWord4 = t.FindWord("ghi".ToCharArray());

    t.Delete("abc".ToCharArray());
    t.Delete("abgl".ToCharArray());
    t.Delete("abcd".ToCharArray());
    t.Delete("xyz".ToCharArray());
*/