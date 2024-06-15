using EXECICIO_RESOLVIDO.Entitdades;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EXERCICIO_RESOLVIDO
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Entre com o numero de funcionarios: ");
            int fun = int.Parse(Console.ReadLine());

            for (int i = 1; i <= fun; i++)
            {
                Console.WriteLine($"Entre com o funcionario #{i}");

                Console.Write("Vai ser tercerizado ? S/N");
                char ch = char.Parse(Console.ReadLine().ToUpper());

                Console.Write("Entre com o nome do seu funcionario: ");
                string nome = Console.ReadLine();

                Console.Write("Entre com a quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());

                Console.Write("Entre com o valor das horas: ");
                double valorhora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(ch == 'S')
                {
                    Console.WriteLine("Entre com o adicional de custo: ");
                    double custoAdcional = double.Parse(Console.ReadLine());
                    list.Add(new FuncionarioTerceirizado(nome, valorhora, horas, custoAdcional));
                }
                else
                {
                    list.Add(new Funcionario(nome, valorhora, horas));
                }
                
            }
            Console.WriteLine("Pagamentos: ");

            foreach(Funcionario funcionario in list)
            {
                Console.WriteLine($"{funcionario.Nome} - ${funcionario.Pagamento().ToString("F2", CultureInfo.InvariantCulture)} ");
            }

        }
    }
}