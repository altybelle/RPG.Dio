using RPG.Dio.src.Entities;
using System;

namespace RPG.Dio
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard jennica = new Wizard("Jennica", 23, "White Wizard");
            
            Console.WriteLine(arus.Attack());
            Console.WriteLine(jennica.Attack(7));
        }
    }
}
