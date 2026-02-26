class Program
{
    static void Main()
    {
        List<int> numbers = new List<int>{ -5, 3, 0, -1, 8, 2, 10 };
        List<int> quadro = new List<int>();

        quadro = numbers.Where(x => x > 0).Select(x => x * x).ToList();

        foreach(var i in quadro)
        {
            Console.WriteLine(i);
        }
    }
}
