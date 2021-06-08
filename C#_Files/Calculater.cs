using System;

namespace RevisingCS
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var total = 0;
            do
            {
                Console.WriteLine("X = ");
                string str = Console.ReadLine();
                if (str == "exit")
                {
                    break;
                }
                int x = Convert.ToInt32(str);

                Console.WriteLine("Y = ");
                string str1 = Console.ReadLine();
                if (str1 == "exit")
                {
                    break;
                }
                int y = Convert.ToInt32(str1);

                Console.WriteLine("Enter the Operation\n");
                Console.WriteLine("1 for sum, 2 for sub, 3 for mult, 4 for div\n");
                int oper = Convert.ToInt32(Console.ReadLine());

                switch (oper)
                {
                    case 1:
                        total = x + y;
                        break;

                    case 2:
                        total = x - y;
                        break;

                    case 3:
                        total = x * y;
                        break;

                    case 4:
                        total = x / y;
                        break;
                }

                Console.WriteLine("Asnwer is {0}\n\n", total);
            }
            while (true);

        }
    }
}
