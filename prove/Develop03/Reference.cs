using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Collections;

namespace ScriptureMemorizer
{
    class Reference
    {
        public string _book;
        public int _chapter;
        public int _verse;
        public int _endVerse; 

        public void GetDisplayText()
        {
            WriteLine($"{_book} {_chapter}:{_verse}");
            WriteLine($"{_book} {_chapter}:{_verse}-{_endVerse}");
        }
    }
}