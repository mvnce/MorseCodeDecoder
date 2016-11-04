using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    class MorseTree
    {
        public MorseTree ()
        {
            insert("A", ".-");
            insert("B", "-...");
            insert("C", "-.-.");
            insert("D", "-..");
            insert("E", ".");
            insert("F", "..-.");
            insert("G", "--.");
            insert("H", "....");
            insert("I", "..");
            insert("J", ".---");
            insert("K", "-.-");
            insert("L", ".-..");
            insert("M", "--");
            insert("N", "-.");
            insert("O", "---");
            insert("P", ".--.");
            insert("Q", "--.-");
            insert("R", ".-.");
            insert("S", "...");
            insert("T", "-");
            insert("U", "..-");
            insert("V", "...-");
            insert("W", ".--");
            insert("X", "-..-");
            insert("Y", "-.--");
            insert("Z", "--..");

            insert("1", ".----");
            insert("2", "..---");
            insert("3", "...--");
            insert("4", "....-");
            insert("5", ".....");
            insert("6", "-....");
            insert("7", "--...");
            insert("8", "---..");
            insert("9", "----.");
            insert("0", "-----");
        }

        private void insert(String letter, String signals)
        {
            MorseNode current = root;
            String signal;

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
                    }
                }
                else
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
            }
            current.letter = letter;
        }

        public MorseNode getRoot()
        {
            return root;
        }

        private MorseNode root = new MorseNode();
    }
}
