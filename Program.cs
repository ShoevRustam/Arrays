using System;

namespace Arr {
    class Program {
        static void Main (string[] args) {

            for(int i=1; i<=10; i++)
            {
                System.Console.WriteLine("");
                for(int j=i; j>0; j--)
                {
                        System.Console.Write(j);
                }
            }
           Console.ReadKey();
           
        }
    }
}