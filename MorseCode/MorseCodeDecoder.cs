using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseCodeDecoder
    {
        private MorseTree tree = new MorseTree();

        public List<String> decode(String word)
        {
            List<String> potentials = new List<String>();
            decodeHelper(word, potentials);
            return potentials;
        }

        public void decodeHelper(String signals, List<String> potentials)
        {
            MorseNode current = tree.getRoot();
            String signal = "";
            bool hasUnknown = false;

            for (int i = 0; i < signals.Length; i++)
            {
                signal = signals.Substring(i, 1);

                if (signal.Equals("."))
                {
                    if (current.left != null)
                    {
                        current = current.left;
                    }
                    else
                    {
                        current.left = new MorseNode();
                        current = current.left;
                    }
                }
                else if (signal.Equals("-"))
                {
                    if (current.right != null)
                    {
                        current = current.right;
                    }
                    else
                    {
                        current.right = new MorseNode();
                        current = current.right;
                    }
                }
                else
                {
                    decodeHelper(signals.Substring(0, i) + "." + signals.Substring(i + 1, signals.Length), potentials);
                    decodeHelper(signals.Substring(0, i) + "-" + signals.Substring(i + 1, signals.Length), potentials);
                    hasUnknown = true;
                }
            }

            if (!hasUnknown && !potentials.Contains(current.letter))
            {
                potentials.Add(current.letter);
            }
        }
    }
}
