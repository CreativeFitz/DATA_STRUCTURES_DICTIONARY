using System;
using System.Collections.Generic;

namespace Chapter5_Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

// // //////////////////////////////Dictionary of Words////////////////////////

// You are going to buid a C# Dictionary to represent an actual dictionary. Each KeyValuePair within the Dictionary will contain a single word as the key, and a definition as the value. Below is some starter code. You need to add a few more words and definitions to the dictionary.

// After you have added them, use square bracket notation to output the definition of two of the words to the console.

// Lastly, use the foreach loop to iterate over the KeyValuePairs and display the entire dictionary to the console.

/*
    Create a dictionary with key value pairs to
    represent words (key) and its definition (value)
*/
Dictionary<string, string> wordsAndDefinitions = new Dictionary<string, string>();

// Add several more words and their definitions
wordsAndDefinitions.Add("Awesome", "The feeling of students when they are learning C#");
wordsAndDefinitions.Add("Cool", "Looked at as being wanted or admired");
wordsAndDefinitions.Add("Joke", "adjective explaining my ability to code");

/*
    Use square bracket lookup to get the definition two
    words and output them to the console
*/
    Console.WriteLine(wordsAndDefinitions["Cool"]);
    Console.WriteLine(wordsAndDefinitions["Joke"]);

/*
    Loop over dictionary to get the following output:
        The definition of [WORD] is [DEFINITION]
        The definition of [WORD] is [DEFINITION]
        The definition of [WORD] is [DEFINITION]
*/
foreach (KeyValuePair<string, string> word in wordsAndDefinitions)
{Console.WriteLine($"The definition of {word.Key} is {word.Value}");
}

// ////////////////////////List of Dictionaries about Words/////////////////////////


// Make a new list
List<Dictionary<string, string>> dictionaryOfWords = new List<Dictionary<string, string>>();

/*
    You want to track the following about each word:
        word, definition, part of speech, example sentence

    Example of one dictionary in the list:
    {
        "word": "excited",
        "definition": "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness",
        "part of speech": "adjective",
        "example sentence": "I am excited to learn C#!"
    }
*/

// Create dictionary to represent a few word
Dictionary<string, string> excitedWord = new Dictionary<string, string>(){
        {"word", "excited"},
        {"definition", "having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness"},
        {"part of speech", "adjective"},
        {"example sentence", "I am excited to learn C#!"}
};



// Add each of the 4 bits of data about the word to the Dictionary


// Add Dictionary to your `dictionaryOfWords` list

dictionaryOfWords.Add(excitedWord);
// create another Dictionary and add that to the list
Dictionary<string, string> sadWord = new Dictionary<string, string>(){
        {"word", "sad"},
        {"definition", "having, showing, or characterized by a lowered state of energy, enthusiasm, eagerness"},
        {"part of speech", "adjective"},
        {"example sentence", "I am sad about learning C#!"}
};

dictionaryOfWords.Add(sadWord);

/*
    Iterate your list of dictionaries and output the data

    Example output for one word in the list of dictionaries:
        word: excited
        definition: having, showing, or characterized by a heightened state of energy, enthusiasm, eagerness
        part of speech: adjective
        example sentence: I am excited to learn C#!
*/


// // Iterate the List of Dictionaries
// foreach ()
// {
//     // Iterate the KeyValuePairs of the Dictionary
//     foreach ()
//     {
//         Console.WriteLine($"{wordData.Key}: {wordData.Value}");
//     }
// }

foreach (Dictionary <string, string> word in dictionaryOfWords){
    foreach(KeyValuePair<string, string> info in word){
        Console.WriteLine($"{info.Key}:{info.Value}");
    }
}

///////////////////////////////// English Idioms /////////////////////////////////

Dictionary<string, List<string>> idioms = new Dictionary<string, List<string>>();
idioms.Add("Penny", new List<string> { "A", "penny", "for", "your", "thoughts" });
idioms.Add("Injury", new List<string> { "Add", "insult", "to", "injury" });
idioms.Add("Moon", new List<string> { "Once", "in", "a", "blue", "moon" });
idioms.Add("Grape", new List<string> { "I", "heard", "it", "through", "the", "grapevine" });
idioms.Add("Murder", new List<string> { "Kill", "two", "birds", "with", "one", "stone" });
idioms.Add("Limbs", new List<string> { "It", "costs", "an", "arm", "and", "a", "leg" });
idioms.Add("Grain", new List<string> { "Take","what","someone","says","with","a","grain","of","salt" });
idioms.Add("Fences", new List<string> { "I'm", "on", "the", "fence", "about", "it" });
idioms.Add("Sheep", new List<string> { "Pulled", "the", "wool", "over", "his", "eyes" });
idioms.Add("Lucifer", new List<string> { "Speak", "of", "the", "devil" });



foreach (string idiom in idioms.Keys){
    string results = string.Join(" ",idioms[idiom]);
    Console.WriteLine($"{idiom}: {results}");
}




        }
    }
}
