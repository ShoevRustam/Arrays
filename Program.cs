using System;

namespace Arr {
    class Program {
        static void Main (string[] args) {
            System.Console.WriteLine ("Start Incriment");
            for (int i = 1; i <= 10; i++) {
                System.Console.WriteLine ("");
                for (int j = i; j > 0; j--) {
                    System.Console.Write (j);
                }
            }
            
            System.Console.WriteLine("\n");
            System.Console.WriteLine ("Finish incriment");
            Console.ReadKey ();

        }
    }
}