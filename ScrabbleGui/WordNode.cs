using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ScrabbleGui
{
    public class WordNode
    {
        public bool IsWord { get; set; }
        public string Word { get; set; }

        public Dictionary<char, WordNode> Childs { get; set; } = new Dictionary<char, WordNode>();
    
        public void Search(List<char> availableChars, ref string result, bool isRoot = false)
        {
            //pokud je node slovo, pridej ho do vysledku
            if (IsWord && result.Length<Word.Length)
            {
                result = Word;
            }

            //najdi všechny možné cesty ve stromu
            var indexes = Childs.Keys.Intersect(availableChars);

            //projdi všechyn cesty
            foreach (char index in indexes)
            {
                availableChars.Remove(index);
                Childs[index].Search(availableChars,ref result);
                availableChars.Add(index);
            }
        }

        public static WordNode CreateTree(string[] words)
        {
            //vytvor strom pro vyhledavani
            WordNode rootNode = new WordNode();
            foreach (string word in words)
            {
                string lower = word.ToLower();
                WordNode node = rootNode;
                for (int i = 0; i < lower.Length; i++)
                {
                    if (node.Childs.ContainsKey(lower[i]))
                    {
                        node = node.Childs[lower[i]];
                    }
                    else
                    {
                        node = node.Childs[lower[i]] = new WordNode();
                    }
                }

                node.Word = word;
                node.IsWord = true;
            }

            return rootNode;
        }
    }
}