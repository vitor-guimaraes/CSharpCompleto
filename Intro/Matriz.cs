using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Intro
{
    public class Matriz
    {
        public void MontaMatriz()
        {
            Console.WriteLine("Digite a ordem da Matriz: ");
            int n = int.Parse(Console.ReadLine());

            double[,] matriz = new double[n, n];

            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {
                    Console.WriteLine("Digite o elemento da Matriz: ");

                    matriz[linha, coluna] = Convert.ToInt16(Console.ReadLine());
                }
            }

            // Print matrix
            Console.WriteLine("Matriz digitada:");
            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine(); // Move to the next line after printing a row
            }

            // Diagonal Principal
            Console.WriteLine("Diagonal Principal:");
            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {
                    if (coluna == linha)
                    {
                        Console.Write(matriz[linha, coluna] + " ");
                    }
                }
            }

            // Numeros Negativos
            Console.WriteLine(); // Move to the next line after printing a row
            Console.WriteLine("Números Negativos:");
            int contador = 0;
            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {
                    if (matriz[linha, coluna] < 0)
                    {
                        Console.Write(matriz[linha, coluna] + " ");
                        contador++;
                    }
                }

            }
            Console.WriteLine(); // Move to the next line after printing a row
            Console.WriteLine("Quantidade Números Negativos: " + contador);

        }


        public void MatrizEx()
        {
            Console.WriteLine("Digite o número de linhas da Matriz: ");
            int M = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de colunas da Matriz: ");
            int N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                Console.WriteLine("Digite a linha " + (i + 1) + " da matriz: ");
                string[] valores = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    //matriz[i,j] = int.Parse(Console.ReadLine());
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            // Print matrix
            Console.WriteLine("Matriz digitada:");
            for (int linha = 0; linha < M; linha++)
            {
                for (int coluna = 0; coluna < N; coluna++)
                {
                    Console.Write(matriz[linha, coluna] + " ");
                }
                Console.WriteLine(); // Move to the next line after printing a row
            }

            Console.WriteLine("Escolha um número:");
            int x = int.Parse(Console.ReadLine());
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (matriz[i, j] == x)
                    {
                        Console.WriteLine("Posição " + i + ", " + j + " :");

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: ");
                            Console.WriteLine(matriz[i - 1, j]);
                        }

                        if (i + 1 < M)
                        {
                            Console.WriteLine("Down: ");
                            Console.WriteLine(matriz[i + 1, j]);
                        }

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: ");
                            Console.WriteLine(matriz[i, j - 1]);
                        }

                        if (j + 1 < N)
                        {
                            Console.WriteLine("Right: ");
                            Console.WriteLine(matriz[i, j + 1]);
                        }

                        //Console.WriteLine(x); 
                    }
                }
                Console.WriteLine(); // Move to the next line after printing a row
            }
        }

    }
}
