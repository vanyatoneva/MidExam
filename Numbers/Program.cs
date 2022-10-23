using System;
using System.Linq;
using System.Collections.Generic;

namespace Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "Finish")
            {
                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    numbers.Remove(int.Parse(command[1]));
                }
                else if (command[0] == "Replace")
                {
                    Replace(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "Collapse")
                {
                    Collapse(numbers, int.Parse(command[1]));
                }
                command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine(String.Join(' ', numbers));
        }
       
        static void Replace(List<int> numbers, int value, int replacement)
        {
            int index = numbers.IndexOf(value);
            if(index != -1)
            {
                numbers[index] = replacement;
            }
        }
        static void Collapse(List<int> numbers, int value)
        {
            for(int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < value)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }
        }
    }
}
