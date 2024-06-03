using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class CalculadoraImp
    {
        private Stack<decimal> _historico;
        public CalculadoraImp()
        {
            _historico = new Stack<decimal>();
        }

        private void AddHistorico(decimal valor)
        {
            _historico.Push(valor);
        }

        public decimal Somar(decimal val1, decimal val2)
        {
            var resultado = val1 + val2;
            AddHistorico(resultado);
            return resultado;
        }

        public decimal Subtrair(decimal val1, decimal val2)
        {
            var resultado = val1 - val2;
            AddHistorico(resultado);
            return resultado;
        }
        public decimal Multiplicar(decimal val1, decimal val2)
        {
            var resultado = val1 * val2;
            AddHistorico(resultado);
            return resultado;
        }
        public decimal Dividir(decimal val1, decimal val2)
        {
            var resultado = val1 / val2;
            AddHistorico(resultado);
            return resultado;
        }
        public decimal UltimoResultado()
        {

            return _historico.Pop();
        }


    }
}