using System;

class Program {
    static void Main(string[] args) {
        Console.Write("Informe um número: ");
        int num = int.Parse(Console.ReadLine());

        int a = 0;
        int b = 1;
        int fib = a + b;

        while (fib < num) {
            a = b;
            b = fib;
            fib = a + b;
        }

        if (fib == num || num == 0) {
            Console.WriteLine("{0} pertence à sequência de Fibonacci.", num);
        }
        else {
            Console.WriteLine("{0} não pertence à sequência de Fibonacci.", num);
        }
    }
}
