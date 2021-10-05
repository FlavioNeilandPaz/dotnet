using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1 - Inserir novo aluno:");
            Console.WriteLine("2 - Listar alunos:");
            Console.WriteLine("3 - Calcular média geral:");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        //TODO: adicionar pessoas
                        break;
                    case "2":
                        //TODO: listar pessoas
                        break;
                    case "3":
                        //TODO: calcular média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();               

                }

                Console.WriteLine("Informe a opção desejada:");
                Console.WriteLine("1 - Inserir novo aluno:");
                Console.WriteLine("2 - Listar alunos:");
                Console.WriteLine("3 - Calcular média geral:");
                Console.WriteLine("X - Sair");
                Console.WriteLine();

                opcaoUsuario = Console.ReadLine();

            }
        }
    }
}
