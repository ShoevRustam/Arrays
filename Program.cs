using System;

namespace Arr {
    class Program {
        static void Main (string[] args) {
            int[] number = { 1, 2, 3, 4, 5, 6, 7, 8, 21, 5, 1 };
            foreach(var item in number){
                System.Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}