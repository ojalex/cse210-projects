using System;
using System.Security.Cryptography.X509Certificates;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        
        public string _reference;
        public List<Word> _words = new List<Word>();

        public void GetDisplayText()
        {
            foreach (Word verse in _words)
        {
            verse.GetDisplayText();
        }

        }
        public void Scriptures()
        {
            
            Console.WriteLine(_reference);
        }
        //private void HideRandomWords()
       // {}
    }
    

}