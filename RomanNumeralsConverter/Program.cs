// See https://aka.ms/new-console-template for more information
using RomanNumeralsConverter.Functions;


ConverterService converter = new ConverterService();

while (true)
{
    Console.WriteLine("Enter number up to 1000:");

    //read input
    string line = Console.ReadLine();
    int number;

    //check input is a valid number between 1 and 1000
    if (!int.TryParse(line, out number))
        {
            Console.WriteLine("Please enter a valid number");
        }
    else if (number <= 0 || number > 1000)
        {
            Console.WriteLine("Please enter a number between 0 and 1000");
        }
    //if number is valid it is passed to the converter and the result is printed
    else
        {
            string romanNumeral = converter.ConvertNumberToRoman(number);

            Console.WriteLine("result: " + romanNumeral);
        }
  
}
   
