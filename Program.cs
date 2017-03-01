using System;

namespace A115
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("115A.IN");
            int[] contests = new int[Int32.Parse(lines[0])];
            string[] numbers = lines[1].Split(' ');

            for(int i = 0; i < numbers.Length;i++)
            {
                contests[i] = Int32.Parse(numbers[i]);
            }
            
            int currentHighest = contests[0];
            int currentLowest = contests[0];

            int amazingContests = 0;
            
            for(int i = 1; i < contests.Length; i++)
            {
                if(contests[i] > currentHighest){
                    currentHighest = contests[i];
                    amazingContests++;
                }else if(contests[i] < currentLowest){
                    currentLowest = contests[i];
                    amazingContests++;
                }
            }

            Console.WriteLine(amazingContests);
            Console.Read();

        }
    }
}
