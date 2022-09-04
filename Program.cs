
        System.Console.WriteLine("Введите три числа:");

        string first = Console.ReadLine();
        string second = Console.ReadLine();
        string third = Console.ReadLine();


        int number1 = int.Parse(first);

        int number2 = int.Parse(second);

        int number3 = int.Parse(third);


        if (number1 > number2) ;
        {
            number1 = int.MaxValue;

            else
            {
                
                number2 = int.MaxValue;
            }
        }
            if (number2>number3);
            {
            number2 = int.MaxValue;

            else 
            {
            number3 = int.MaxValue;
            }
            }
            
            if (number3 > number1);
            {
            number3 = int.MaxValue;
            
            else 
            {
            number1 = int.MaxValue;
            }
            }
            
            System.Console.WriteLine ($"{int.MaxValue} наибольшее число");

        