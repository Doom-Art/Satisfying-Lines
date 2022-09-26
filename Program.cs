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
                int randXPosition = rand.Next(20, 100);
                int randYPosition = rand.Next(20, 100);
                int countingToSize = ((randXPosition + randYPosition)/2)*20;
                continueToRun = true;
                countReset = 0;
                if (randXPosition == randYPosition)
                    randYPosition--;
                //Console.WriteLine($"\nrand X is: {randXPosition}, rand Y is {randYPosition}, counting Size is {countingToSize}");
                //Console.ReadLine();
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
                        countColor = 1;
                    }
                    Console.Write("O");

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