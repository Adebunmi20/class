using System;

namespace ClassApp
{
    class Program
    {
        static void Main(string[] args)
         
        {

            string[] months = new string [12] {"January", "February", "March", "April", "May", "June", "July", "August", "Septemper", "Octomber", "November", "December"};
            {
                Console.WriteLine(months.Length);
            }
            for(int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }
            Array.Reverse(months);
            for(int i = 0; i < months.Length; i++)
            {
                Console.WriteLine(months[i]);
            }
            Array.Sort(months);
            Console.WriteLine("Sorted months:");
            foreach(string sortedMonths in months)
            {
                Console.WriteLine(sortedMonths);
            }
            string[] clonemonths = months.Clone() as string[];
           {
               Console.WriteLine(string.Join(",", clonemonths ));
           }
           Console.WriteLine("Rank of month returned:");
           for(int index = 0; index < months.Length; index++)
            {
                Console.WriteLine("{0} {1}", index, months[index]);
            } 
             string[] monthTarget = new string [6];
             Array.Copy(months, monthTarget, 6);
             Console.WriteLine("Copied Months:");
             foreach(string month in monthTarget)
            {
                Console.WriteLine(month);
            }
          Array.Clear(months, 0, months.Length);
          Console.WriteLine("Array after using clear:");
          foreach(string month in months)
            {
                Console.WriteLine(month);
            }
        
        }
    }
}
    
