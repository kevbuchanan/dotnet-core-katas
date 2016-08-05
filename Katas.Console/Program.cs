public class Program {
    public static void Main(string[] args) {
        var roman = new RomanNumerals();
        System.Console.WriteLine("Give me a number:");
        var input = System.Console.ReadLine();
        var output = roman.Convert(int.Parse(input));
        System.Console.WriteLine("The roman numeral is:");
        System.Console.WriteLine(output);
    }
}