using System;

namespace LabCleanCode
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Roman.To(3999));
            Hangman.PlayHangman();
            NumberGuessing.Play();
            Letters.Count();
        }
    }
}
