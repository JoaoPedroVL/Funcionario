using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXECICIO_RESOLVIDO.Entitdades
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double ValorHoraTrabalhada { get; set; }
        public int Horas { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, double valorHoraTrabalhada, int horas)
        {
            Nome = nome;
            ValorHoraTrabalhada = valorHoraTrabalhada;
            Horas = horas;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorHoraTrabalhada;
        }
    }
}
