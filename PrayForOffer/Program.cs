using System.Linq;
namespace PrayForOffer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] defaultArray = new string[] { "ток", "рост", "кот", "торс", "Кто", "фывап", "рок" };
            string[] defaultArray2 = new string[] { "кит","кот", "тор", "раз", "зар","рза"};
            string[] defaultArray3 = new string[] {};
            string[] defaultArray4 = new string[] {"5"};
            var defaultArray5 = new string[] { "floor", "roof", "rofo", "roller", "guide", "idegu" };

            PrintArray(Parser.ParseStringArray(defaultArray));
            PrintArray(Parser.ParseStringArray(defaultArray2));
            PrintArray(Parser.ParseStringArray(defaultArray3));
            PrintArray(Parser.ParseStringArray(defaultArray4));
            PrintArray(Parser.ParseStringArray(defaultArray5));
        }
        static void PrintArray(string[][] array) {
            foreach (var item in array)
            {
                foreach (var el in item)
                {
                    Console.Write(el+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}