internal class Program
{
    private static void Main(string[] args)
    {
        const int ORDEM = 3;

        int[,] matriz = new int[ORDEM, ORDEM];
        int[,] matriz_inversa = new int[ORDEM, ORDEM];

        for (int linha = 0; linha < ORDEM; linha++)
        {
            for (int coluna = 0; coluna < ORDEM; coluna++)
            {
                Console.WriteLine("DIGITE UM ELEMENTO DA MATRIZ:");
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }

        for (int linha = 0; linha < ORDEM; linha++)
        {
            for (int coluna = 0; coluna < ORDEM; coluna++)
            {
                matriz_inversa[ORDEM - 1 - linha, ORDEM - 1 - coluna] = matriz[linha, coluna];
            }
        }

        Console.WriteLine("IMPRESSÃO DA MATRIZ INVERSA");
        for (int linha = 0; linha < ORDEM; linha++)
        {
            for (int coluna = 0; coluna < ORDEM; coluna++)
            {
                Console.Write(matriz_inversa[linha, coluna] + " ");
            }

            Console.WriteLine();
        }


    }
}