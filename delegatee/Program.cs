namespace delegatee
{
    internal class Program
    {
        private delegate int NumberChanger(int n);

        private delegate string StringDelegate(string firstName, string lastName, int age);
        private delegate int Numberrr(int number1, int number2);

        private delegate List<string> SomeList(List<string> list, int step);

        private delegate string GetTypeDelegate<T>(T parametras);

        private static string Gettypemethod<T>(T parametras)
        {
            return typeof(T).Name;
        }

        private static int _globalNumber = 12;

        public static int AddNumber(int number)
        {
            return _globalNumber + number;
        }

        public static int SubstractNumber(int number)
        {
            return _globalNumber - number;
        }

        public static string Task1(string firstName, string lastName, int age)
        {
            return firstName + "," + lastName + ", " + age;
        }

        private static int Numbering(int number1, int number2)
        {
            return number1 + number2;
        }


        private static List<string> ListFunction(List<string>list, int step)
        {
            var result = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if(i%step == 0)
                {
                    result.Add(list[i]);
                }
            }
            return result;
        }
        static void Main(string[] args)
        {

            //var numberChenge1 = new NumberChanger(AddNumber);
            var numberChange2 = new NumberChanger(SubstractNumber);

            var numberChenge1 = AddNumber;
           // Console.WriteLine(numberChenge1(2));
            //Console.WriteLine(numberChange2(2));

            var newUser = new StringDelegate(Task1);
            Console.WriteLine(newUser);

            var someList = new SomeList(ListFunction);

            var ourList = new List<string>()
            {
                "vardas",
                "pavarde"
            };
            //Console.WriteLine(someList(ourList, 1)); printina objekta
            var numberMethod = new Numberrr(Numbering);

            var ourTypeMethod = new GetTypeDelegate<string>(Gettypemethod<string>);
            Console.WriteLine(ourTypeMethod("param"));
            var t = 1;
            var function = (string str, int inti) =>
            {
                //t++; negalima is scaupu
                Console.WriteLine("Test");
                return "as";

            };
            //Anonym method
            var metodas = (string firstName, string lastName, int age) =>
            {
                return firstName + "," + lastName + ", " + age;
            };
            var result = metodas("Elia", "Kunicka", 10);
            Console.WriteLine(result);

            var numeringAnom = (int number1, int number2) =>
            {
                return number1 + number2;
            };
            var rezult1 = numeringAnom(2, 5);
            Console.WriteLine(rezult1);

            var listmethod = (List<string> list, int step) =>
            {
                var result = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    if (i % step == 0)
                    {
                        result.Add(list[i]);
                    }
                }
                return result;
            };
            Console.WriteLine(listmethod);





            //Test(function);
        }

        //internal static void Test(Func<string>)
        //{
        //    fun(1);
        //}
    }
}