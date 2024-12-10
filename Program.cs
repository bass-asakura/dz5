namespace dz5;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = {1, 1, 1, 1, 2, 2, 2, 3, 4, 5, 6, 7, 8, 9, 9};
        int[] uniq_arr = arr.Distinct().ToArray();
        int[] povt_chisla = new int[uniq_arr.Length];
        for (int i = 0; i < uniq_arr.Length; i++){
            int cnt = 0;
            for (int j = 0; j < arr.Length; j++){
                if (uniq_arr[i] == arr[j]){
                    cnt++;
                }
            }

            if (cnt > 1){   
            povt_chisla[i] = uniq_arr[i];
            }
        }

        for (int i = 0; i < povt_chisla.Length; i++){
            int b = povt_chisla[new Random().Next(0, povt_chisla.Length)]; 

            if (b > 0){
                Console.WriteLine("Задание 1: \n" + b);
                break;
            }

            else{
                continue;
            }
        }

        Console.WriteLine("Задание 2");
        int[,] matrix = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}};
        Console.WriteLine("Матрица");
        PrintMatrix(matrix);
        Console.WriteLine("Транспонированная матрица");
        PrintMatrix(Transpose(matrix));
    }

    public static int[,] Transpose(int[,] a)
    {
        int stroki = a.GetLength(0);
        int colonni = a.GetLength(1);
        int[,] new_a = new int[stroki, colonni];
        for (int i = 0; i < stroki; i++){
            for (int j = 0; j < colonni; j++){
                new_a[j, i] = a[i, j];
            }
        }
        return new_a;
    }
    
    public static void PrintMatrix(int[,] a)
    {
        int stroki = a.GetLength(0);
        int colonni = a.GetLength(1);
        for (int i = 0; i < stroki; i++){
            for (int j = 0; j < colonni; j++){
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
 