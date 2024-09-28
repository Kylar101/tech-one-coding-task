namespace DollarsToWordConverter.Services
{
    public interface INumberConversionService
    {
        string ConvertToDollarsInWords(decimal value);
    }
    public class NumberConversionService : INumberConversionService
    {

        private readonly string[] BelowTwenty =
            [
                "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven",
                "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"
            ];

        private readonly string[] Tens = ["Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"];

        private readonly string[] Units = ["", "Thousand", "Million", "Billion"];

        public NumberConversionService() { }

        public string ConvertToDollarsInWords(decimal value)
        {
            string decimals = "";
            // round to 2 decimal places
            string input = Math.Round(value, 2).ToString("F2");

            if (input.Contains('.'))
            {
                decimals = input[(input.IndexOf('.') + 1)..];
                input = input.Remove(input.IndexOf('.'));
            }

            string words = $"{this.GetWords(input)}Dollars";

            if (decimals.Length > 0 && int.Parse(decimals) > 0)
            {
                words += $" and {this.GetWords(decimals)}Cents";
            }

            return words;
        }

        private string GetWords(string input)
        {
            int counter = 0;

            string words = "";

            while (input.Length > 0)
            {
                string block = input.Length < 3 ? input : input[^3..];
                input = input.Length < 3 ? "" : input.Remove(input.Length - 3);

                int number = int.Parse(block);

                block = this.GetWord(number);

                if (block != "")
                {
                    block += $" {this.Units[counter]}";
                }

                words = block + words;
                counter++;
            }
            return words;
        }

        private string GetWord(int number)
        {
            string word = "";

            if (number > 99 && number < 1000)

            {
                int i = number / 100;
                word = $"{word} {this.BelowTwenty[i - 1]} Hundred";
                number %= 100;
            }

            var hasHundreds = word.Contains("Hundred");
            var addedHundreds = false;

            if (number > 19 && number < 100)
            {
                int i = number / 10;
                var spacing = hasHundreds ? " and" : "";
                word = $"{word}{spacing} {this.Tens[i - 1]} ";
                addedHundreds = true;
                number %= 10;
            }

            if (number > 0 && number < 20)
            {
                var spacing = hasHundreds && !addedHundreds ? " and " : "";

                word += $"{spacing}{BelowTwenty[number - 1]}";
            }

            if (number == 0 && String.IsNullOrEmpty(word))
            {
                word += "Zero";
            }

            return word;
        }
    }
}
