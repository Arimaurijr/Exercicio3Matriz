using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        const int ORDEM = 3;
        const int TAMANHO = ORDEM * ORDEM;


        int[,] matriz = new int[ORDEM, ORDEM];
        int[,] matriz_inversa = new int[ORDEM, ORDEM];
        int[] vetor_aux = new int[TAMANHO];

        void EntradaDados()
        {
            int cont = 0;
            for (int linha = 0; linha < ORDEM; linha++)
            {
                
                Console.WriteLine("LINHA " + (linha + 1));
                for(int coluna = 0; coluna < ORDEM; coluna++)
                {
                    Console.WriteLine("COLUNA " + (coluna + 1));
                    matriz[linha,coluna] = int.Parse(Console.ReadLine());
                    vetor_aux[cont] = matriz[linha,coluna];
                    cont++;
                }
            }
        }

        EntradaDados();

        Console.WriteLine();
        Console.WriteLine("IMPRESSAO DA MATRIZ DE ENTRADA");
        for(int i = 0; i < ORDEM;i++)
        {
            for(int j = 0; j < ORDEM;j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }


       int cont = TAMANHO - 1;
       for(int linha = 0; linha < ORDEM; linha++)
        {
            for(int coluna = 0; coluna < ORDEM; coluna++)
            {
                matriz_inversa[linha, coluna] = vetor_aux[cont];
                cont = cont - 1;
            }
        }

        Console.WriteLine();
        Console.WriteLine("MATRIZ INVERTIDA");

        for(int linha = 0; linha < ORDEM; linha++)
        {
            for(int coluna =0; coluna < ORDEM; coluna++)
            {
                Console.Write(matriz_inversa[linha, coluna] + " ");
            }
            Console.WriteLine();
        }
       
    }
}