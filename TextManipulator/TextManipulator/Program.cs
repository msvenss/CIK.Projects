using System;
using System.Collections.Generic;
using TextManipulator.Core.ManipulateText;
using TextManipulator.Core.ManipulateText.Rules;
using TextManipulator.Core.ReadText;
using TextManipulator.Core.WriteText;

namespace TextManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintAllText();
            AddNewWords();
            }
        public static void PrintAllText()
        {
            IReadText readText = new ReadText();
            IWriteText writeText = new TextToStringWriter();
            var text = readText.Read().Manipulate(GetManipulatorRules());
            Console.Write(writeText.Write(text));
            Console.ReadKey();
        }

        private static void AddNewWords()
        {
            Console.WriteLine("Change more words? Y/N");
            string result = Console.ReadLine();
            while ((result.ToString() == "Y") || (result.ToString() == "y"))
            {
                Console.WriteLine("Enter old word");
                string oldWord = Console.ReadLine();
                Console.WriteLine("Enter new word");
                string newWord = Console.ReadLine();
                WordsToReplace.Add(oldWord, newWord);
                Console.WriteLine("Add more words? Y/N");
                result = Console.ReadLine();
              
                }
            ShowReplacedWords();
            PrintAllText();
            Console.WriteLine("Add more");
            }

      private static void ShowReplacedWords()
        {
            Console.WriteLine("Dictionary");
            const string format = "{0,-20} - {1,20}";
            string outputTitle = string.Format(format, "Original word", "New Word\n");
            Console.WriteLine(outputTitle);
            foreach (KeyValuePair<string, string> pair in WordsToReplace)
            {
                string output = string.Format(format, pair.Key, pair.Value);
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }

        private static List<IManipulateTextRule> GetManipulatorRules()
        {
            return new List<IManipulateTextRule> {new ReplaceWord(WordsToReplace)};
        }

        private static Dictionary<string, string> WordsToReplace =  new Dictionary<string, string>
            {
                {"Företaget", "Forefront"},
                {"applikationerna", "systemen"},
                {"annorlunda", "tvärtom"},
                {"bra", "flexibla"},
                {"offshore", "Frontshore"},
                {"China", "Kina"}
            };

       

    }
}
