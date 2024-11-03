using System;

namespace ArrayDefinitionAndUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bir dizi tanımlama ve başlatma
            int[] numbers = { 1, 2, 3, 4, 5 };
            Console.WriteLine("Array elements:");

            // Dizi elemanlarını yazdırma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();

            // Boş bir dizi tanımlayıp değer atama
            string[] names = new string[3];
            names[0] = "Alice";
            names[1] = "Bob";
            names[2] = "Charlie";

            Console.WriteLine("\nNames array elements:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // Diziyi tersine çevirme ve yazdırma
            Array.Reverse(numbers);
            Console.WriteLine("\nReversed numbers array:");
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Dizideki elemanların toplamını bulma
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"\nSum of numbers array: {sum}");
        }
    }
}