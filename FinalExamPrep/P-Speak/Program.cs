using System;

namespace P_Speak
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What type of animal would you like to know the sound of?(dog, cat, or giraffe)");
            string answer = Console.ReadLine();

            if (answer.ToLower() == "dog" || answer.ToLower() == "cat" || answer.ToLower() == "giraffe")
            {
                Console.WriteLine(Speak(answer));
            }
        }

        static string Speak(string animal)
        {
            string sound = "";
            if (animal == "dog")
            {
                sound = "Woof";
                return sound;
            }
            else if (animal == "cat")
            {
                sound = "Meow";
                return sound;
            }
            else if (animal == "Giraffe")
            {
                sound = "Pft";
                return sound;
            }
            return "Invalid";
        }

    }
}
