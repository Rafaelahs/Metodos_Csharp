using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    public class matematica
    {
        public int operacoes(int p1, int p2, string operacao)
        {
            int resultado = -1;
            switch (operacao)
            {
                case "adicao":
                    resultado = p1 + p2;
                    break;
                case ("multiplicacao"):
                    resultado = p1 * p2;
                    break;
                case ("subtracao"):
                    resultado = p1 - p2;
                    break;
            }

            return resultado;
        }
    }
}










//      public int adicao(int parcela1, int parcela2)
//{
//    int resultado = parcela1 + parcela2;
//    return resultado;
//}
//    public int multiplicacao(int parcela1,int  parcela2)
//{
//    return parcela1 * parcela2;
//}