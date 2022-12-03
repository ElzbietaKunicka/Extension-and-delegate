namespace lapkricio30
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string str = "Hello, world";
            str.Split();
            str.Trim();
            var wordCount = str.WordCount();
            Console.WriteLine(str);
            Console.WriteLine(wordCount);

            //
        }
    }

    public static class MyExtensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(" ").Length;
        }
    }
    //
    public static class Number
    {

    }

}