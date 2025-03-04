public class Program {
    public static double Average(int[] arr) {
        double result = 0.0;
        if (arr.Length == 0) return result;

        foreach (int i in arr)
        {
            result += i;
        }

        return result / arr.Length;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Average(new int[]{
            1, 2, 3, 4
        }));

        /*List<string> list = new List<string>() { 
            "a",
            "b",
            "c"
        };

        HashSet<string> set = new HashSet<string>();

        int[] a = { 1, 2, 3 };

        foreach (string s in list)
        {
            Console.WriteLine(s);
        }*/
        // comment
        // c
        // a
    }
}