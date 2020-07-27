using System;
using System.Collections.Generic;

namespace ConsoleApp2.Data
{
    public class TrieProblem
    {
        public bool ParseTrie(string word, Trie t, Dictionary<char, Trie> option)
        {
            if (word == null && t.Letter == '\\') return true;

            if (t == null)
            {
                if (option.ContainsKey(word[0]))
                {
                    return ParseTrie(word, option[word[0]], option);
                }
                else
                    return false;
            }

            if (t.Letter == word[0])
            {
                if (word.Length > 1 && t.Next.ContainsKey(word[1]))
                {
                    return ParseTrie(word.Substring(1, word.Length - 1), t.Next[word[1]], option);
                }

                if (t.Next.ContainsKey('\\') && word.Length == 1) return true;

                if (t.Next.ContainsKey('\\') && !t.Next.ContainsKey(word[0]))
                    return ParseTrie(word.Substring(1, word.Length - 1), null, option);
            }

            return false;
        }

        public Trie BuildTrie(int pos, string word)
        {
            if (pos < word.Length)
            {
                if (pos + 1 < word.Length)
                {
                    var t = new Dictionary<char, Trie>();
                    t.Add(word[pos + 1], BuildTrie(pos + 1, word));
                    return new Trie { Letter = word[pos], Next = t };
                }
                else
                {
                    var t = new Dictionary<char, Trie>();
                    t.Add('\\', null);
                    return new Trie { Letter = word[pos], Next = t };
                }
            }
            else
                return null;
        }
    }

    public class Trie
    {
        public char Letter { get; set; }
        public Dictionary<char, Trie> Next { get; set; }
    }
}
