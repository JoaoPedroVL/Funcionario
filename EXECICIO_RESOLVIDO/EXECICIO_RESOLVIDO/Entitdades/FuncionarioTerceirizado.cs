using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXECICIO_RESOLVIDO.Entitdades
{
    internal class FuncionarioTerceirizado : Funcionario
    {
        public double DespesasAdicionais { get; set; }

        public FuncionarioTerceirizado() { }

        public FuncionarioTerceirizado(string nome, double valorHoraTrabalhada, int horas ,double despesasAdicionais)
            : base(nome, valorHoraTrabalhada, horas)
        {
            DespesasAdicionais = despesasAdicionais;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + 1.1 * DespesasAdicionais;

        }
    }
}
