using System;
using System.Security.Cryptography.X509Certificates;
using ScriptureMemorizer;

Console.Clear();

var book1 = new Reference();
book1._book = "John";
book1._chapter = 3;
book1._verse = 16;


var word1 = new Word();
word1._text = "16. For God so loved the world that he gave his one and only Son,that whoever believes in him shall not perish but have eternal life.";


var myScriptures = new Scripture();
myScriptures._reference = "John 3:16";
myScriptures._words.Add(word1);
myScriptures.Scriptures();
myScriptures.GetDisplayText();
