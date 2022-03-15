int numberOne, numberTwo;

Console.WriteLine("Enter a number: ");

numberOne = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter another number: ");

numberTwo = Convert.ToInt32(Console.ReadLine());



Console.WriteLine("The sum of the two numbers you entered is: ");

int sum;

sum = numberOne + numberTwo;

Console.WriteLine(sum);



Console.WriteLine("The product of the two numbers is:  ");

int product;

product = numberOne * numberTwo;

Console.WriteLine(product);



Console.WriteLine("The different between the two numbers is: ");

int difference;

difference = numberOne - numberTwo;

Console.WriteLine(difference);



Console.WriteLine("The quotient of the two numbers is:  ");

int quotient;

int remainder;

quotient = Math.DivRem(numberOne, numberTwo, out remainder);

Console.WriteLine("Quotient = " + quotient);

Console.WriteLine("Remainder = " + remainder);