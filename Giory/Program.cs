using System;
class github
{
    static void Main()
    {

        Console.Write("Digite um número....");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nDigite outro número....");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"\nA soma deste dois número equivale a {num1 + num2}");

        if (num2 > num1)
        {
            Console.WriteLine($"\nO numero {num2} é maior");
        }
        else
        {
            Console.WriteLine($"\nO numero {num1} é maior");
        }

        Console.ReadKey();

    }
}