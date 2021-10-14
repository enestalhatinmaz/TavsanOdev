using System;

namespace Rabbits
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please input 4 integers with spaces in between. \n [1st Rabbit's Start Coordinate] [1st Rabbit's Step Length] [2nd Rabbit's Start Coordinate] [2nd Rabbit's Step Length]");
            string[] rabbitDatas = Console.ReadLine().TrimEnd().Split(' ');
            bool error = false;
            while (!error && rabbitDatas.Length == 4)
            {
                bool test1 = int.TryParse(rabbitDatas[0], out int rabbit1Coordinate);
                bool test2 = int.TryParse(rabbitDatas[1], out int rabbit1JumpDistance);
                bool test3 = int.TryParse(rabbitDatas[2], out int rabbit2Coordinate);
                bool test4 = int.TryParse(rabbitDatas[3], out int rabbit2JumpDistance);

                if (test1 && test2 && test3 && test4)
                {
                }
                else
                {
                    Console.WriteLine("Values you have enter is wrong. Please Check your values");
                    return;
                }
                var rabbit1 = new Rabbit(rabbit1Coordinate, rabbit1JumpDistance);
                var rabbit2 = new Rabbit(rabbit2Coordinate, rabbit2JumpDistance);



                for (int startStep = 1; startStep < 3000; startStep++)
                {
                    rabbit1.Jump();
                    rabbit2.Jump();
                    if (rabbit1.Coordinate == rabbit2.Coordinate)
                    {
                        Console.WriteLine("They have met at " + startStep + ". step");
                        return;
                    }

                }
                Console.WriteLine("They haven't met ");
                return;
            }
            Console.WriteLine("Values you have enter is wrong. Please Check your values");
        }
    }
}