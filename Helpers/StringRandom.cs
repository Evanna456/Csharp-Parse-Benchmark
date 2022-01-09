namespace Csharp_Parse_Benchmark.Helpers
{
    internal interface IStringRandom
    {
        string generateAlphanumeric(int number);

        string generateNumber(int number);
    }

    public class StringRandom : IStringRandom
    {
        public string generateAlphanumeric(int number)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] string_chars = new char[number];
            Random random = new Random();

            for (int it = 0; it < string_chars.Length; it++)
            {
                string_chars[it] = chars[random.Next(chars.Length)];
            }

            string final_string = new String(string_chars);

            return final_string;
        }

        public string generateNumber(int number)
        {
            string chars = "0123456789";
            char[] string_chars = new char[number];
            Random random = new Random();

            for (int it = 0; it < string_chars.Length; it++)
            {
                string_chars[it] = chars[random.Next(chars.Length)];
            }

            string final_string = new String(string_chars);

            return final_string;
        }
    }
}