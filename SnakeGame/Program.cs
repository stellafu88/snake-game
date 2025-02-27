class Program {
    static string[][] canva = new string[][] {
        new string[] {".", ".", "."},
        new string[] {".", ".", "."},
        new string[] {".", ".", "."}
    };

    static string[] snake = new string[] {"0,0"};

    public static void Print() {
        for (int i = 0; i < canva.Length; i++){
            for (int j = 0; j < canva[i].Length; j++){
                if (snake.Contains($"{i},{j}")){
                    Console.Write("X");
                }else{
                    Console.Write(canva[i][j]);
                } 
            }
            Console.WriteLine();
        }
    }

    public static void Main() {
        Print();
    }
}

