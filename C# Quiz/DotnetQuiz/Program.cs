using DotnetQuiz.Quiz;

Console.WriteLine("1. Method Overloading");
Console.WriteLine("2. IEnumerable Compare");
Console.WriteLine("3. List Count and Capacity");
Console.WriteLine("4. CheckedKeyword");
Console.WriteLine("5. Select vs SelectMany");
int input = int.Parse(Console.ReadLine()!);
Questions questions = new Questions(input);
questions.QuestionSet();