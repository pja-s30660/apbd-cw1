public class Program {
    public static void Main(string[] args)
    {
        List<string> list = new List<string>() { 
            "a",
            "b",
            "c"
        };

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }
    }
}