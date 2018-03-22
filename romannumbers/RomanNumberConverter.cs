namespace romannumbers
{
    class RomanNumberConverter
    {
        static void Main(string[] args)
        {
            var number = GetNumberToConvert(args);
        }

        private static int GetNumberToConvert(string[] args)
        {
            return int.Parse(args[0]);
        }
    }
}
