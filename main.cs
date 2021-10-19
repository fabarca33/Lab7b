using System;

class Program {
  public static int IntegerPower(int num1, int num2)
{
  int total = num1;
  int i = 1;
  while(i < num2)
  {
    total = total * num1;
    
    i++;
  }
  

  return total;
}

  public static void Main (string[] args) {

    int output=0;

    Console.WriteLine ("Insert a number");
    int input1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Insert another number");
    int input2 = Convert.ToInt32(Console.ReadLine());

    output = IntegerPower(input1, input2);

    Console.WriteLine("The first number power by the second number is: " +output);
    

  }
}