using System;

namespace IT1050IndiaCampbellLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[]months = {"January","Febuary", "March", "April", "May","June", "July","August", "September", "October", "November", "December"};

            for (int i = 0; i < months.Length; i++) 
               Console.WriteLine("{0} {1}", i + 1, months[i]);
        }
    }
}

namespace IT1050IndiaCampbellLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] seasons = { "Spring", "Summer", "Fall", "Winter" };

            foreach (string day in seasons)
                Console.WriteLine(day);
        }
    }
}

namespace IT1050IndiaCampbellLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = new int[1000];

            foreach (int element in elements)
                Console.WriteLine(element);

            Random random = new Random();
            int randomNumber;
                randomNumber = random.Next(5,60);
        }
    }
}

using System;

namespace IT1050IndiaCampbellLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            for (int i = 0; i < names.Length; i++)
            
            {
                Console.WriteLine(names[i]);


            }


        }
    }
}


using System;

namespace IT1050IndiaCampbellLab6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };

            for (int i = 0; i < names.Length; i++)
            
            {
                Console.WriteLine("{0,2}. {1}", i, names[i]);


            }


        }
    }
}


