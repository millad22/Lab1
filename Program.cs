using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {




            markRightNumbers("");

        }
        public static string markRightNumbers(string userInput)
        {
            long total = 0;

            Console.WriteLine("Enter a string");
            userInput = Console.ReadLine();

            for (int i = 0; i < userInput.Length; i++)
            {

                if (char.IsDigit(userInput[i]))
                {

                    char c = userInput[i];
                    for (int j = i + 1; j < userInput.Length; j++)
                    {

                        if (!char.IsDigit(userInput[j]))
                        {
                            break;
                        }

                        if (userInput[j] == c)
                        {
                            try
                            {



                                string firstLetters = userInput.Substring(0, i);
                                string digits = userInput.Substring(i, j - i + 1);
                                string lastLetters = userInput.Substring(j + 1, userInput.Length - j - 1);

                                total += long.Parse(digits);

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(firstLetters);

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(digits);

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine(lastLetters);
                                Console.ResetColor();

                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                Environment.Exit(0);


                            }


                        }
                    }






                }
            }
            Console.WriteLine($"The Total: {total}");






            return userInput;
        }
    }
}