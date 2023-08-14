using DotnetQuiz.Classes;

namespace DotnetQuiz.Quiz
{
    public class Questions
    {
        private readonly int _input;
        public Questions(int input)
        {
            _input = input;
        }

        public void QuestionSet()
        {
            switch (_input)
            {
                case 1:
                    MethodOverloading();
                    break;
                case 2:
                    CollectionCompare();
                    break;
                case 3:
                    ListCountAndCapacity();
                    break;
                case 4:
                    Checked();
                    break;
                case 5:
                    SelectAndSelectMany();
                    break;
            }
        }

        #region CollectionCompare
        public static void CollectionCompare()
        {
            int[] array = new[] { 1, 2, 3 };
            List<int> list = new() { 1, 2, 3 };
            var result = list.SequenceEqual(array);
        }

        #endregion

        #region MethodOverloading
        public static void MethodOverloading()
        {
            bool flag = true;
            M1(flag ? -22267 : 2);
        }

        private static void M1(short v)
        {
            Console.WriteLine("short: " + v);
        }

        private static void M1(long v)
        {
            Console.WriteLine("long: " + v);
        }
        #endregion

        #region Capacity and Count
        public static void ListCountAndCapacity()
        {
            List<int> list = new();
            list.Add(1);
            Console.WriteLine($"The capacity of list is {list.Capacity} and count is {list.Count}");
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(1);
            list.Add(2);
            Console.WriteLine($"The capacity of list is {list.Capacity} and count is {list.Count}");
            list.TrimExcess();
            Console.WriteLine($"The capacity of list is {list.Capacity} and count is {list.Count}");
        }
        #endregion

        #region Checked
        public static void Checked()
        {
            try
            {
                int a = int.MaxValue;
                int b = int.MaxValue;
                int c = checked(a + b);
                Console.WriteLine(c);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception thrown: {ex}");
            }
        }
        #endregion

        public void SelectAndSelectMany()
        {
            Students student1 = new()
            {
                Name = "John",
                InterestedTopics = new() { "C#", "ASP.NET", "Azure" }
            };
            Students student2 = new()
            {
                Name = "Jane",
                InterestedTopics = new() { "C++", "ASP.NET", "Azure" }
            };
            Students student3 = new()
            {
                Name = "Jack",
                InterestedTopics = new() { "Python", "ASP.NET", "Azure" }
            };
            List<Students> students = new() { student1, student2, student3 };
            //selectMany
            var studentTopics = students.SelectMany(s => s.InterestedTopics!);
            foreach (var topic in studentTopics)
            {
                Console.WriteLine(topic);
            }
            //select
            foreach (var student in students)
            {
                var studentTopic = student.InterestedTopics!.Select(s => s);
                foreach (var topic in studentTopic)
                {
                    Console.WriteLine(topic);
                }
            }
        }
    }
}
