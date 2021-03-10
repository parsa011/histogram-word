using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;
            Console.WriteLine("How much name you want ?");
            int namesCount;
            if (int.TryParse(Console.ReadLine(),out namesCount))
            {
                names = new string[namesCount];
                int biggest = 0;
                for (var i = 0; i < namesCount; i++)
                {
                    Console.Write("> ");
                    var line = Console.ReadLine();
                    biggest = line.Length > biggest ? line.Length : biggest;
                    names[i] = line;
                }
                for (var i = 0; i < names.Length; i++)
                {
                    var current = names[i];
                    var need = biggest - current.Length;
                    var finallSpaces = GiveMeSpace(need);
                    names[i] = current + finallSpaces;
                }
                int neededLoopTimes = biggest - 1;
                Console.ForegroundColor = ConsoleColor.Red;
                while (neededLoopTimes >= 0)
                {
                    //Console.WriteLine(neededLoopTimes + "-|");
                    for (var i = 0; i < names.Length; i++)
                    {
                        Console.Write(GiveMeSpace(10));
                        if (names[i][neededLoopTimes] == ' ')
                            Console.Write(" ");
                        else
                            Console.Write("*");
                    }
                    neededLoopTimes--;
                    Console.WriteLine();
                }
                Console.ResetColor();
                neededLoopTimes = 0;
                while (neededLoopTimes < biggest)
                {
                    for (var index = 0; index < names.Length; index++)
                    {
                        Console.Write($"{GiveMeSpace(10) + GiveMeSpace(neededLoopTimes) + names[index][neededLoopTimes].ToString() } ");
                    }
                    neededLoopTimes++;
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("please enter valid in32 number");
            
        }

        public static string GiveMeSpace(int count)
        {
            var finallSpaces = "";
            for (var j = 0; j < count; j++)
            {
                finallSpaces += " ";
            }
            return finallSpaces;
        }
    }
}