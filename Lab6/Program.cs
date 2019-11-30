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
