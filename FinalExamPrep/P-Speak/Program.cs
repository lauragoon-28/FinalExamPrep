using System;

namespace P_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of animal would you like to know the sound of?(dog, cat, or giraffe)");
            string answer = Console.ReadLine().ToLower();
            string animalsound = Speak(answer);
            if (answer == "dog" || answer == "cat" || answer == "giraffe")
            {
                Console.WriteLine($"A {answer} makes a {animalsound}!");
            }
            else
            {
                Console.WriteLine("Sorry that animal wasn't found, Goodbye!");
            }
        }

        static string Speak(string animal)
        {
            string sound = "";
            if (animal == "dog")
            {
                sound = "Woof";
            }
            else if (animal == "cat")
            {
                sound = "Meow";
            }
            else if (animal == "giraffe")
            {
                sound = "Pft";
            }
            return sound;
        }

    }
}
