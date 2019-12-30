using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSenaEstatisticas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n");
            Estatisticas estatisticas = new Estatisticas();
            estatisticas.FazLeitura();
            estatisticas.SeparaCampos();
            estatisticas.FazContagem();
            estatisticas.FrequenciaDasDezenas();
            estatisticas.SorteadasAscendentes();
            Console.WriteLine("\n\n");
        }
    }
}
