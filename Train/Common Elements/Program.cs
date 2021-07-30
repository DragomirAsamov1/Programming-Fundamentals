using System;

namespace Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] randomText = Console.ReadLine().Split(' ');
            string[] randomWords = Console.ReadLine().Split(' ');
            for (int i = 0; i < randomWords.Length; i++)
            {
                for (int k = 0; k < randomText.Length; k++)
                {
                    if (randomWords[i]==randomText[k])
                    {
                        Console.Write(randomWords[i] + " ");
                    }
                }
            }
        }
    }
}
