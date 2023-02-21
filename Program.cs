using System;

namespace boletim
{

    class notas
    {

        static void Main(string[] args)
        {

            /*[M1S01] Ex 3 - Boletim
            [Estrutura de Decisão]
            Crie um programa para calcular a média dos alunos e informar se o aluno foi aprovado, 
            ficou de recuperação ou foi reprovado.

            O programa deve receber 3 notas e calcular a média entre elas utilize a seguinte fórmula 
            para calcular a média: media = (nota1 + nota2 + nota3 )÷3.  após calcular a média, verifique se o aluno 
            foi aprovado seguindo os critérios: 
            Se nota maior ou igual 6 : Saída-> Aluno Aprovado com média {Valor da Média} 
            Se nota maior ou igual 5, e menor que 6 : Saída-> Aluno em Recuperação com média {Valor da Média} 
            Se nota menor que 5 : Saída-> Aluno Reprovado com média {Valor da Média} 
            */

            System.Console.WriteLine("Digite a nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            System.Console.WriteLine("Digite a nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("A média do aluno é " + Math.Round(media, 1));

            if (media >= 8)
            {
                System.Console.WriteLine("Aluno está **Aprovado** com média " + Math.Round(media, 1));
            }
            else if (media >= 5 && media <= 8)
            {
                System.Console.WriteLine("Aluno em Recuperação com média " + Math.Round(media, 1));
            }
            else if (media < 5)
            {
                System.Console.WriteLine("Aluno :( Reprovado com média " + Math.Round(media, 1));

            }
        }
    }
}