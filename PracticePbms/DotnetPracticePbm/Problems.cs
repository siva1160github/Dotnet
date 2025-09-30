using System.Text;

namespace DotnetPracticePbm
{
    public class Problems
    {
        public void ReverseString()
        {
            Console.WriteLine("Please Enter the String");
            string input = Console.ReadLine();
            StringBuilder output = new();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                output.Append(input[i]);
            }
            Console.WriteLine(output.ToString());
        }
    }
}
