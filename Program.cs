namespace carDriver
{
    class Car
    {
        private int driverX = 0;
        private int driverY = 0;

        private string[,] track = new string[,]
        {
        {".",".","."},
        {".",".","."},
        {".",".","."},
        };
        public int Сontrol()
        {
            ConsoleKey key = ConsoleKey.Separator; 
            do
            {
                switch (key)
                {
                    case ConsoleKey.W:
                        if (driverY > 0) 
                            driverY--;   //change player position
                        break;
                    case ConsoleKey.D:
                        if (driverX < track.GetLength(1) - 1)
                            driverX++;
                        break;
                    case ConsoleKey.S:
                        if (driverY < track.GetLength(0) - 1)
                            driverY++;
                        break;
                    case ConsoleKey.A:
                        if (driverX > 0)
                            driverX--;
                        break;
                }
                Console.Clear(); //clear console to redraw field

                for (int i = 0; i < track.GetLength(0); i++)
                {
                    for (int k = 0; k < track.GetLength(1); k++)
                    {
                        if (i == driverY && k == driverX) //проверить, находится ли игрок в ячейке [i,k]
                            Console.Write("Car\t"); //draw player
                        else
                            Console.Write(track[i, k] + "\t"); //draw place
                    }
                    Console.WriteLine();
                }
                key = Console.ReadKey(true).Key; //read new key
            }
            while (key != ConsoleKey.X); //exit condition
            return 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Сontrol();
        }
    }
}