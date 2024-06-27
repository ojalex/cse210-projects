using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Collections;

namespace JornalApp
{
    
    class Journal
    {

        private string JournalFile = "MyJournal.txt"; //this is declaired so that I can refer to it severally
        //Introduction and Menu
        public void Run()
        {
            Title="Journal App";
            CreateJornalFile();//Create a txt file if not exist
            DisplayIntro(); // display introduction
            RunMenu(); //run menu
                    
        }
        
        public void RunMenu()
        { 
            string choice;
            choice = GetChoice();
            
            do{
                switch(choice)
                {
                    case "1":
                        DisplayJournalContent();
                        break;
                    case "2":
                        ClearFile();
                        break;
                    case "3":
                        AddEntry();
                        break;
                    default:
                        DisplayOutro();
                        break;
                }        
            } while (choice != "4");

           
        }
        private string GetChoice()
        {
            bool isChoiceValid = false;
            string choice = " ";
            do
            {
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("\n====== MAIN MENU ======");
                WriteLine("\n1. Read the journal");
                WriteLine("2. Clear the journal");
                WriteLine("3. Add Activity");
                WriteLine("4. Quit");
                WriteLine("\n========================");
                WriteLine("\nSelect an option above i.e 1,2,3,4: ");
                
                ForegroundColor = ConsoleColor.DarkBlue;
                choice = ReadLine().Trim();
                ForegroundColor = ConsoleColor.Black;

                if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
                {
                    isChoiceValid = true;
                    
                }
                else 
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"\"{choice}\" is not a valid choice please choose between 1 - 4");
                    
                }
            } while(!isChoiceValid);
            
            return choice;            

        }
        //Check if file exist otherwise create it if not
        private void CreateJornalFile()
        {
            //Checks if file exist in the directory where program is
            //WriteLine($"Does file exist? {File.Exists("MyJornal.txt")}");
            // ! is NOt exist
            if (!File.Exists(JournalFile))
            {
                File.CreateText(JournalFile);
            }
        }
        private void DisplayIntro()
        {
            ForegroundColor = ConsoleColor.Black;
            BackgroundColor = ConsoleColor.White;
            Clear();
            WriteLine("\nWELCOME TO YOUR JOURNAL APP PLEASE UPDATE YOUR TODAYS ACTIVITIES.");
            WaitForKey();
        }
        private void DisplayOutro()
        {
            WriteLine("Thank you for updating you work");
        
            
        }
        private void DisplayJournalContent()
        {
            if (File.Exists(JournalFile))
            {
                ForegroundColor = ConsoleColor.Cyan;
                string JournalText = File.ReadAllText(JournalFile);
                WriteLine("\n======= Obervatins during the visit =======");
                WriteLine(JournalText);
                WriteLine("=============================================");
                WaitForKey();
                RunMenu();
            }
        }
        private void ClearFile()
        {
            ForegroundColor = ConsoleColor.Black;
            File.WriteAllText(JournalFile, ""); //Pass in empty string
            WriteLine("\nJournal Cleared Successfully");
            WaitForKey();
            RunMenu();
        }
        private void AddEntry()
        {
            ForegroundColor = ConsoleColor.Black;
            WriteLine("Enter todays date in the format DD/MM/YYYY: ");
            ForegroundColor = ConsoleColor.Cyan;
            string dateVisited = ReadLine();
            ForegroundColor = ConsoleColor.Black;
            File.AppendAllText(JournalFile,$"\nDate of Visit:  {dateVisited}");
            WriteLine("Enter name of the site visited: ");
            ForegroundColor = ConsoleColor.Cyan;
            string siteVisited = ReadLine();
            ForegroundColor = ConsoleColor.Black;
            File.AppendAllText(JournalFile,$"\nSite Visited:  {siteVisited}");
            WriteLine("Activity done: ");
            ForegroundColor = ConsoleColor.Cyan;
            string activityDone = ReadLine();
            ForegroundColor = ConsoleColor.Black;
            File.AppendAllText(JournalFile,$"\nSite Visited:  {activityDone}");
            ForegroundColor = ConsoleColor.Green;
            WriteLine("Content Added to your journal successfuly");
            WaitForKey();
            RunMenu();
        }
        private void WaitForKey()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\nPress any key to continue.");
            ReadKey(true);
        }

    }
}
