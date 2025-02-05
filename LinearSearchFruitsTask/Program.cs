namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.Writeline("what word would you like to enter");
            string word = Console.Readline();
            if (fruits[0] == word)
            {
                Console.Writeline("True")
            }
            
            else if (fruits[1] == word)
            {
                Console.Writeline("true")
            }
           
            else if (fruits[2] == word)
            {
                Console.Writeline("true")
            }
            else if (fruits[3] == word)
            {
                Console.Writeline("true")
            }
            else if (fruits[4] == word)
            {
                Console.Writeline("true")
            }
            else if (fruits[5] == word)
            {
                Console.Writeline("true")
            }
            else 
            {
                  Console.Writeline("false")                        
            }

                                   
                                
                                  

            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
