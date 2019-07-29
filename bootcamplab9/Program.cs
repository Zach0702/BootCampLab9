using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace bootcamplab9
{
    class Program
    {
       

        public static char IsValidLoopBreaker (string testChar)
        {
            bool isInvalidChar = true;

            Regex pattern = new Regex(@"^[y|n]$");

            char validChar = ' ';

            while (isInvalidChar)
            {
                if (pattern.IsMatch(testChar))
                {
                    isInvalidChar = false;
                    validChar = char.Parse(testChar);
                }
                else
                {
                    Console.WriteLine($"ERROR invalid input of {testChar}  entered please try again");
                    Console.WriteLine("Do you wish to continue(enter y/n): ");
                    testChar = Console.ReadLine();
                }
            }
            return validChar;
        }

        public static int IsValidIntEntered(string testInt)
        {
            bool isInvalidInput = true;
            Regex pattern = new Regex(@"^[1|2]$");
            int validInt = 0;

            while (isInvalidInput)
            {
                if (pattern.IsMatch(testInt))
                {
                    isInvalidInput = false;
                    validInt = int.Parse(testInt);
                }
                else
                {
                    Console.WriteLine($"ERROR: invalid input of {testInt}  entered please try again");
                    Console.WriteLine("Would you like to add a student, or find information about a student (enter 1 to add, enter 2 to find info): ");
                    testInt = Console.ReadLine();

                }
                
            }
            return validInt;
        }

        public static string IsValidName (string testName)
        {
            bool isInvalidInput = true;
            Regex pattern = new Regex(@"[a-zA-Z\-'\s]+");
            string validName = " ";

            while (isInvalidInput)
            {
                if (pattern.IsMatch(testName))
                {
                    isInvalidInput = false;
                    validName = testName;
                }
                else
                {
                    Console.WriteLine($"ERROR: Invalid name of {testName} entered please try again: ");
                    Console.WriteLine("Please enter the students name(first and last): ");
                    testName = Console.ReadLine();
                }
            }
            return testName;

        }
        public static int IsValidStudentNumber(string studentNumber)
        {
            bool isInvalidInput = true;
            int validStudentNumber = 0;

            while (isInvalidInput)
            {
                if (int.TryParse(studentNumber, out validStudentNumber))
                {
                    isInvalidInput = false;
                }
                else
                {
                    Console.WriteLine($"ERROR: invalid student number {studentNumber} entered please try again..");
                    Console.WriteLine("What student would you like to know more about(enter student number: )");
                    studentNumber = Console.ReadLine();

                }
            }
            return validStudentNumber;
        }
        public static string IsValidStudentInfoOption(string testString)
        {
            bool isInvalidInput = true;
            string coorectStudentOption = " ";

            while(isInvalidInput)
            {
                if(testString == "hometown" || testString == "favorite food" || testString == "favorite color")
                {
                    isInvalidInput = false;
                    coorectStudentOption = testString;
                }
                else
                {
                    Console.WriteLine($"ERROR invalid student info of {testString} entered please try again...");
                    Console.WriteLine("(enter in \"hometown\" or \"favorite food\" or \"favorite color\": ");
                    testString = Console.ReadLine();
                }
            }
            return coorectStudentOption;
        }

        //public static void SortListAlpabetically
            /*(List<string> listOfstudentsNames*//*, List<int> listOfIndexValues*//*, Dictionary<string, int> studentIndexNumber*/
        //    List<string> listOfStudentsFavoriteFoods,
        //    List<string> listOfStudentsHomeTown,
        //    List<string> listOfStudentsFavoriteColor)
        //{
            //Dictionary<List<string>, int> studentIndexNumber = new Dictionary<List<string>, int>();
            //List<string> unSortedList = new List<string>(listOfstudentsNames);
            //List<int> unsortedIndex = new List<int>();
            //List<string> tempListOfStudentsFood = new List<string>(listOfStudentsFavoriteFoods);
            //List<string> tempListHomeTown = new List<string>(listOfStudentsHomeTown);
            //List<string> tempListFavColor = new List<string>(listOfStudentsFavoriteColor);


////    unSortedList.Sort();

////            for (int i = 0; i < unSortedList.Count; i++)
////            {

////                listOfstudentsNames[i] = unSortedList[i];
               

                
////            }
////}
        public static string IsAnswerBlank(string testAnswer)
        {

            string testTest = testAnswer;
            bool IsValidinput = true;

            while (IsValidinput)
            {
                if (String.IsNullOrEmpty(testTest))
                {
                    Console.WriteLine("ERROR: Answer can't be empty please try again");
                    testTest = Console.ReadLine();
                }
                else
                {
                    IsValidinput = false;
                }
            }
            return testTest;
        }


        public static void RunApp()
{
    List<string> listOfStudentsNames = new List<string>();
    List<string> listOfStudentsHomeTown = new List<string>();
    List<string> listOfStudentsFavoriteFood = new List<string>();
    List<string> listOfStudentsFavoriteColor = new List<string>();
    char loopBreaker;
    int validInt;
    string validName;
    string studentHomeTown;
    string studentFavoriteFood;
    string studentFavoriteColor;
    int studentNumber;
    string studentInfoOption;
    char studentOptionLoopBreaker;
    //Dictionary<string, int> studentIndexNumber = new Dictionary<string, int>();
    //List<int> listOfIndexValues = new List<int>();
    


    do
    {
        Console.WriteLine("Welcome to the Students Information Application...");
        Console.WriteLine("Would you like to add a student, or find information about a student (enter 1 to add, enter 2 to find info): ");
        validInt = IsValidIntEntered(Console.ReadLine());

        if (validInt == 1)
        {
            Console.WriteLine("Please enter the students name(first and last): ");
            validName = IsValidName(Console.ReadLine());
            listOfStudentsNames.Add(validName);
            //studentIndexNumber.Add(validName, i);
                    //studentIndexNumber[listOfStudentsNames] = 0;
                    //SortListAlpabetically(listOfStudentsNames/*, studentIndexNumber*/);

                    //for (int i = 0; i < listOfIndexValues.Count; i++)
                    //{
                    //    Console.WriteLine(listOfIndexValues[i]);
                    //}
                    //foreach (KeyValuePair<string, int> kvp in studentIndexNumber)
                    //{
                    //    Console.WriteLine($"this is the {kvp.Key}, and the {kvp.Value}");
                    //}




                    Console.WriteLine($"Please enter {validName}'s home town: ");
                    studentHomeTown = IsAnswerBlank(Console.ReadLine());
                    listOfStudentsHomeTown.Add(studentHomeTown);
                    Console.WriteLine($"Please enter {validName}'s favorite food: ");
                    studentFavoriteFood = IsAnswerBlank(Console.ReadLine());
                    listOfStudentsFavoriteFood.Add(studentFavoriteFood);
                    Console.WriteLine($"Please enter {validName}'s favorite color: ");
                    studentFavoriteColor = IsAnswerBlank(Console.ReadLine());
                    listOfStudentsFavoriteColor.Add(studentFavoriteColor);
                    //SortListAlpabetically(listOfStudentsNames, listOfStudentsFavoriteFood, listOfStudentsHomeTown, listOfStudentsFavoriteColor);
                    
                }
                else if (validInt == 2)
                {
                    //SortListAlpabetically(listOfStudentsNames);
                    Console.WriteLine("What student would you like to know more about(enter student number)(first student is number 0): ");
                    studentNumber = IsValidStudentNumber(Console.ReadLine());
                   
                    do
                    {
                        Console.WriteLine($"Student {studentNumber} is {listOfStudentsNames[studentNumber]} " +
                       $". What would you like to know about {listOfStudentsNames[studentNumber]} ? " +
                       $"(enter in \"hometown\" or \"favorite food\" or \"favorite color\"): ");
                        studentInfoOption = IsValidStudentInfoOption(Console.ReadLine());


                        if (studentInfoOption == "hometown")
                        {
                            Console.WriteLine($"{listOfStudentsNames[studentNumber]} is from {listOfStudentsHomeTown[studentNumber]}. ");
                            
                        }
                        else if (studentInfoOption == "favorite food")
                        {
                            Console.WriteLine($"{listOfStudentsNames[studentNumber]}'s favorite food is: {listOfStudentsFavoriteFood[studentNumber]}.");
                        }
                        else
                        {
                            Console.WriteLine($"{listOfStudentsNames[studentNumber]}'s favorite color is: {listOfStudentsFavoriteColor[studentNumber]}. ");
                        }
                        Console.WriteLine($"Would you like to know more info on {listOfStudentsNames[studentNumber]}? (enter y/n): ");
                        studentOptionLoopBreaker = IsValidLoopBreaker(Console.ReadLine());

                    } while (studentOptionLoopBreaker == 'y');

                }

                Console.WriteLine("Do you wish to continue(enter y/n): ");
                loopBreaker = IsValidLoopBreaker(Console.ReadLine());
                //i++;
            } while (loopBreaker == 'y');
        }
        static void Main(string[] args)
        {
            try
            {
                RunApp();
                Console.WriteLine("End of Students Information Application");
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw (e);
            }
            finally
            {
                Console.WriteLine("The application has failed and is shutting down");
            }
        }
    }
}
