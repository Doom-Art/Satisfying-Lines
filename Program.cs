namespace Part_6._5_loop_tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continueToRun = true;
            int x = 1; int y = 1; int change = 1; int change2 = 1; int countColor = 1; int countReset = 0;
            Random rand = new Random();
            bool foreverLoop = true;
            
            while (foreverLoop)
            {
                x = 1; y = 1; change = 1; change2 = 1;
                int randXPosition = rand.Next(20, 150);
                int randYPosition = rand.Next(20, 60);
                int countingToSize = (((randXPosition + randYPosition)/2)*20)+100;
                continueToRun = true;
                countReset = 0;
                Console.Clear();
                Console.CursorVisible = true;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Your random X is {randXPosition}, Your Random Y is {randYPosition} and it will repeat {countingToSize} times.\n");
                Console.WriteLine("What Symbol would you like for your satisfying lines?");
                string symbol = Console.ReadLine();
                Console.CursorVisible = false;
                Console.Clear();
                while (continueToRun)
                {
                    y += change;
                    x += change2;
                    Console.SetCursorPosition(x, y);
                    if (countColor == 1){
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        countColor++;
                    }
                    else if (countColor == 2){
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        countColor++;
                    }
                    else if (countColor == 3){
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        countColor++;
                    }
                    else if (countColor == 4){
                        Console.ForegroundColor = ConsoleColor.Green;
                        countColor++;
                    }
                    else if (countColor == 5){
                        Console.ForegroundColor = ConsoleColor.White;
                        countColor++;
                    }
                    else if (countColor == 6){
                        Console.ForegroundColor = ConsoleColor.Red;
                        countColor = 1;
                    }
                    Console.Write(symbol);

                    Console.CursorVisible = false;
                    Thread.Sleep(20);

                    if (x > randXPosition){
                        change2 = (-1);
                    }
                    else if (x == 1){
                        change2 = 1;
                    }
                    if (y > randYPosition){
                        change = (-1);
                    }
                    else if (y == 1){
                        change = 1;
                    }
                    if (countReset < countingToSize)
                        countReset++;
                    else
                        continueToRun = false;
                }
            }
            
        }
    }
}