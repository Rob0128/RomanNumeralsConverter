
namespace RomanNumeralsConverter.Functions
{
    internal class ConverterService
    {
        public string ConvertNumberToRoman(int number)
        {
            int givenNum = number;
            List<string> resultRomanNumerals = new List<string>();
            List<int> numberValues = new List<int>() { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1  };
            List<string> romanNumerals = new List<string>() { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            //two lists of numbers and their roman numeral conterparts are iterated through until the input 'number' is greater than the current 'numberValue'
            for (int x = 0; x < numberValues.Count; x++)
            {
                while(givenNum >= numberValues.ElementAt(x))
                {
                    //the 'numberValue' is subtracted from the input 'number' and the numberValue's romanNumeral equivilent is added to the 'resultRomanNumerals' list
                    givenNum = givenNum - numberValues.ElementAt(x);
                    resultRomanNumerals.Add(romanNumerals.ElementAt(x));
                }
            }
            //the 'resultRomanNumerals' List is converted to a string and returned
            return String.Join("", resultRomanNumerals);
        }
    }
}
