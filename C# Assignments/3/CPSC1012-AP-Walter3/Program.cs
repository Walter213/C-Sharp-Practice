using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPSC1012_AP_Walter3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TriviaQuestion> Questions = new List<TriviaQuestion>();
            int choice = 99, AmountOfQuestions = 0;
            string filename = "c:\\temp\\TriviaQuestions.csv";

            OpenFile(filename, Questions);

            while (choice != 4)
            {               
                choice = GetChoice();               

                switch (choice)
                {
                    case 1: // Lists Trivia Questions
                        {
                            int count = 1;

                            for (int c = 0; c < Questions.Count; c++)
                            {
                                ShowMenuItem(Questions[c], count);
                                count++;
                            }

                            if (Questions.Count == 0)
                            {
                                Console.WriteLine();
                                Console.WriteLine("There are currently no items in the database");
                                Console.WriteLine();
                            }

                            break;
                        }
                    case 2: // Create Trivia Questions
                        {
                            Questions.Add(CreateQuestion());

                            AmountOfQuestions++;

                            break;
                        }
                    case 3: // Delete Trivia Questions
                        {
                            Console.WriteLine("Item#            Question");
                            Console.WriteLine("-----            -----------------------------------------------------------------------------");

                            int Dcount = 1;

                            for (int c = 0; c < Questions.Count; c++)
                            {
                                ShowDeleteItem(Questions[c], Dcount);
                                Dcount++;
                            }

                            if (Questions.Count == 0)
                            {
                                Console.WriteLine("There Are No Questions To Delete From This File Since There Are No Questions In This File");
                                Console.WriteLine();

                                break;
                            }

                            bool TestInput = false;

                            while (TestInput == false)
                            {
                                Console.WriteLine("Enter the item to delete: ");

                                int RemoveItem = Convert.ToInt32(Console.ReadLine());

                                if (RemoveItem > 0)
                                {
                                    Console.WriteLine("Item #{0} has been deleted from the database", RemoveItem);
                                    Console.WriteLine();

                                    RemoveItem--;

                                    Questions.RemoveAt(RemoveItem);
                                    AmountOfQuestions--;                                   

                                    TestInput = true;
                                }
                                else
                                {
                                    Console.WriteLine("Can not remove negative numbers or letters");

                                    break;
                                }
                            }

                            break;
                        }
                    case 4:
                        {
                            SaveFile(filename, Questions);

                            Console.WriteLine("The trivia items has been saved to file '" + filename + "'.");                            

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("\nInvalid choice... try again\n");
                            break;
                        }
                }
            }
        } // closes main


        static TriviaQuestion CreateQuestion()
        {
            string Questions = GetString("Enter the trivia question: ");
            string Answer1 = GetString("Enter answer #1: ");
            string Answer2 = GetString("Enter answer #2: ");
            string Answer3 = GetString("Enter answer #3: ");
            string Answer4 = GetString("Enter answer #4: ");
            int Answer = GetInt("Enter the correct answer choice (1-4): ");

            TriviaQuestion Question = new TriviaQuestion(Questions, Answer, Answer1, Answer2, Answer3, Answer4);

            return Question;
        }

        static int GetChoice()
        {
            int choice = 0;

            Console.WriteLine("******************************");
            Console.WriteLine("* Trivia Game Administration *");
            Console.WriteLine("******************************");
            Console.WriteLine("1.   List Trivia Items");
            Console.WriteLine("2.   Add Trivia Item");
            Console.WriteLine("3.   Delete Trivia Item");
            Console.WriteLine("4.   Quit");
            choice = GetInt("Your choice: ");

            return choice;
        }

        static void ShowDeleteItem(TriviaQuestion Questions, int Dcount)
        {
            Console.WriteLine("{0}                {1}", Dcount, Questions.GetQuestion());
        }

        static void ShowMenuItem(TriviaQuestion Questions, int count)
        {
            Console.WriteLine();
            Console.WriteLine("{0}.   {1}", count, Questions.GetQuestion());
            Console.WriteLine("     1.  {0}", Questions.GetQuestion1());
            Console.WriteLine("     2.  {0}", Questions.GetQuestion2());
            Console.WriteLine("     3.  {0}", Questions.GetQuestion3());
            Console.WriteLine("     4.  {0}", Questions.GetQuestion4());
            Console.WriteLine("Current answer: {0}", Questions.GetAnswer());
            Console.WriteLine();
        }

        static int GetInt(string prompt)
        {
            int value = 0;
            bool bValid = false;
            while (!bValid)
            {
                try
                {
                    Console.Write(prompt);
                    value = Convert.ToInt32(Console.ReadLine());
                    bValid = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nInvalid input... try again.\n");
                }
            }
            return value;
        } 

        static string GetString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }

        static void SaveFile(string filename, List<TriviaQuestion> Questions)
        {
            try
            {
                using (StreamWriter fout = new StreamWriter(filename))
                {
                    for (int index = 0; index < Questions.Count; index++)
                    {
                        TriviaQuestion temp = Questions[index];
                        fout.WriteLine("{0},{1},{2},{3},{4},{5}", temp.GetQuestion(), temp.GetQuestion1(),temp.GetQuestion2(), temp.GetQuestion3(), temp.GetQuestion4(), temp.GetAnswer());
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File save failed for: {0}", filename);
            }
        }

        static List<TriviaQuestion> OpenFile(string filename)
        {
            List<TriviaQuestion> Questions = new List<TriviaQuestion>();
            try
            {
                using (StreamReader fin = new StreamReader(filename))
                {
                    string line = "";
                    while ((line = fin.ReadLine()) != null)
                    {
                        TriviaQuestion temp = new TriviaQuestion();
                        string[] parsed = line.Split(',');
                        temp.SetQuestion(parsed[0]);
                        temp.SetQuestion1(parsed[1]);
                        temp.SetQuestion2(parsed[2]);
                        temp.SetQuestion3(parsed[5]);
                        temp.SetQuestion4(parsed[4]);
                        temp.SetAnswer(Convert.ToInt32(parsed[5]));
                        Questions.Add(temp);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File open for: {0} failed.", filename);
            }
            return Questions;
        }
        static List<TriviaQuestion> OpenFile(string filename, List<TriviaQuestion> Questions)
        {
            try
            {
                using (StreamReader fin = new StreamReader(filename))
                {
                    string line = "";
                    while ((line = fin.ReadLine()) != null)
                    {
                        TriviaQuestion temp = new TriviaQuestion();
                        string[] parsed = line.Split(',');
                        temp.SetQuestion(parsed[0]);
                        temp.SetQuestion1(parsed[1]);
                        temp.SetQuestion2(parsed[2]);
                        temp.SetQuestion3(parsed[5]);
                        temp.SetQuestion4(parsed[4]);
                        temp.SetAnswer(Convert.ToInt32(parsed[5]));
                        Questions.Add(temp);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("File open for: {0} failed.", filename);
            }
            return Questions;
        }
    }
}
