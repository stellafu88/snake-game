class Program {
    static string[][] canva = new string[][] {
        new string[] {".", ".", "."},
        new string[] {".", ".", "."},
        new string[] {".", ".", "."}
    };

    public static void Print() {
        for (int i = 0; i < canva.Length; i++){
            Console.WriteLine(string.Join(" ", canva[i]));
        }
    }

    public static void Main() {
        Print();
    }
}

