using System;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("plan your hist");
            Console.WriteLine("please input tem member name");
            string memberName = Console.ReadLine();
             Console.WriteLine("please input tem member skill");
            int skillLevel = Convert.ToInt32(Console.ReadLine());
            if (skillLevel <= 0)
            {
                Console.WriteLine("please input tem member skill over zero");
                skillLevel = Convert.ToInt32(Console.ReadLine());
            }
            double courageFactor = Convert.ToDouble(Console.ReadLine());

        }
    }
}