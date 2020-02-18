using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace dictionary
{
   public class Program
    {
        

       

        static void Main(string[] args)
        {
            var gunsSold = new Dictionary<string, int>() {
                    { "9mm", 344},
                    { "10mm", 763},
                    { "40 cal", 551},
                    { "dessert 50", 298} };
            gunsSold.Add("FN 57", 1200);

            foreach (KeyValuePair<string, int> guns in gunsSold)
            {
                Console.WriteLine($"{guns.Key} price ${guns.Value}");
            }

            Dictionary<int, string> top5guns = new Dictionary<int, string>();
            top5guns.Add(1, "FN 57");
            top5guns.Add(2, "DE 10mm");
            top5guns.Add(3, "Bush Master Carbin 15 pistol");
            top5guns.Add(4, "The Muler");
            top5guns.Add(5, "38 Snub Throw away");

            foreach (KeyValuePair<int, string> gun in top5guns)
            {
                Console.WriteLine(gun.Key + " " + gun.Value);
            }

            if (gunsSold.ContainsKey("FN 57"))

            {


                Console.WriteLine(gunsSold["FN 57"]);
            }

            else
            {
                Console.WriteLine("Key Not Present");
                return;
            }
            Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>(){
                {"Bud Lite", "non-potent weed"},
                {"Satan Death", "Describes highly potent narcotics"},
                {"College Knowledge", "Something you learn in college, but not in class  ;)"}
            };
            wordsAndDefinitions.Add("nubstep", "the type of music shitty dj's make in attempt to make a GOOD dubstep beat. Usually made by a nub, or newb, who thinks he can make beats");
            wordsAndDefinitions.Add("swaners", "People with jobs that dont actually spend time or do jobs at there supposed workplace");
            wordsAndDefinitions.Add("Jobby Job", "Being forced to get a job at an workplace you really do not want to work at. Usually by a parent");

            Console.WriteLine("Returns the value(defintion) of the key specified, ex: nameOfDictionary[key]");
            Console.WriteLine(wordsAndDefinitions["Bud Lite"]);
            Console.WriteLine(wordsAndDefinitions["College Knowledge"]);

            foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
            {
                Console.WriteLine($" -{word.Key}- Definition: {word.Value}");
            }
            List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

            Dictionary<string, string> excited = new Dictionary<string, string>();

            excited.Add("word", "excited");
            excited.Add("definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness");
            excited.Add("part of speech", "adjective");
            excited.Add("example sentence", "I am excited to learn C#!");

            dictionaryOfWords.Add(excited);



            Dictionary<string, string> bitcoin = new Dictionary<string, string>();

            bitcoin.Add("word", "bitcoin");
            bitcoin.Add("definition", "majik internet monies");
            bitcoin.Add("part of speech", "noun");
            bitcoin.Add("example sentence", "I am excited to stack bitcoin sats");



            dictionaryOfWords.Add(bitcoin);

            Dictionary<string, string> computers = new Dictionary<string, string>();

            computers.Add("word", "computers");
            computers.Add("definition", "boxes for data");
            computers.Add("part of speech", "noun");
            computers.Add("example sentence", "I am excited to computer");



            dictionaryOfWords.Add(computers);

            foreach (Dictionary<string, string> list in dictionaryOfWords)
            {

                Console.WriteLine("------");
                foreach (KeyValuePair<string, string> word in list)
                {

                    Console.WriteLine($"{word.Key}: {word.Value} ");
                }
                Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
                idioms.Add("Breaker", new List<string> { "Make", "people", "feel", "more", "comfortable" });
                idioms.Add("Pricey", new List<string> { "Very", "expensive" });
                idioms.Add("Rarely", new List<string> { "Once", "in", "a", "blue", "moon" });
                idioms.Add("Raincheck", new List<string> { "Postpone", "a", "plan" });
                idioms.Add("Calculated", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
                idioms.Add("Grain", new List<string> { "Take", "what", "someone", "says", "with", "a", "grain", "of", "salt" });
                idioms.Add("Decision", new List<string> { "I'm", "on", "the", "fence", "about", "it" });



                //This is how you access and loop through a single item in the dictionary 'idioms' 
                //will pirint every word(value) in list with key of "Moon"
                foreach (string value in idioms["Breaker"])
                {
                    Console.WriteLine(value);
                }


                //this is to put a space between the words so the sentence is readable
                string emptySpace = " ";

                //Loop through the Dictionary with foreach and use .Join() to combine all the words in the 
                foreach (string key in idioms.Keys)

                {
                    string results = String.Join(emptySpace, idioms[key]);
                    Console.WriteLine($"{key}: {results} ");
                }
                SortedList<int, string> sortedList1 = new SortedList<int, string>();
                sortedList1.Add(3, "Three");
                sortedList1.Add(4, "Four");
                sortedList1.Add(1, "One");
                sortedList1.Add(5, "Five");
                sortedList1.Add(2, "Two");
                Console.WriteLine("sortedList1 has " + sortedList1.Count + " items in the list");
                foreach (KeyValuePair<int, string> item in sortedList1)
                { Console.WriteLine($"{item.Key}: {item.Value} ");
                    //add code here to console.WriteLine each items key and value
                    //notice how the SortedList automatically sorts all keyValuePairs by the key, 
                    //either alphabetically or by number depending on the keys type, here the keys are of type int
                    //HINT: look below where I loop over sortedList2 and sortedList3
                }
            }
        }
    }
}
