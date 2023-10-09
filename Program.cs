// See https://aka.ms/new-console-template for more information

public class Calculator
{
    public static void Main()
    {
        int result = 0;
        int result2 = 0;
        int firstNumber = 0;
        int secondNumber = 0;
        string sign = "";
        string question = "";
        bool check = true;

        Console.WriteLine("Введите число");
        firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите знак");
        sign = Console.ReadLine();

        Console.WriteLine("Введите число");
        secondNumber = Convert.ToInt32(Console.ReadLine());

        if (sign == "/" && secondNumber == 0)
        {
            Console.WriteLine("Error: divide by zero");
            check = false;
        }

        if (sign == "+")
        {
            result = firstNumber + secondNumber;
        }

        if (sign == "*")
        {
            result = firstNumber * secondNumber;
        }

        if (sign == "-")
        {
            result = firstNumber - secondNumber;
        }

        if (sign == "/")
        {
            result = firstNumber / secondNumber;
        }

        result2 = result;

        while (check == true)
        {
            Console.WriteLine("Продолжить?");
            question = Console.ReadLine();

            if (question == "Да" || question == "да")
            {
                Console.WriteLine("Введите число");
                secondNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите знак");
                sign = Console.ReadLine();

                if (sign == "/" && secondNumber == 0)
                {
                    Console.WriteLine("Error: divide by zero");
                    check = false;
                }

                if (sign == "+")
                {
                    result2 = result2 + secondNumber;
                }

                if (sign == "*")
                {
                    result2 = result2 * secondNumber;
                }

                if (sign == "-")
                {
                    result2 = result2 - secondNumber;
                }

                if (sign == "/")
                {
                    result2 = result2 / secondNumber;
                }
                Console.WriteLine(result2);
            }

            else if (question == "Нет" || question == "нет")
            {
                Console.WriteLine("Ответ: " + result2);
                check = false;
            }

        }
    }
}