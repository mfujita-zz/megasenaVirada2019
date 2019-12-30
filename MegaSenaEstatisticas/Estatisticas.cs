using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaSenaEstatisticas
{
    class Estatisticas
    {
        string[] todoTexto;
        List<int> listaNumero;
        List<int> listaFrequencia;
        Dictionary<int, int> dezenaFrequencia;

        public void FazLeitura()
        {
            string[] tudo = File.ReadAllLines("megasena.csv");
            todoTexto = tudo;
            Console.WriteLine("Número de jogos realizados: {0}", todoTexto.Length);
        }

        // Se for para usar a classe Dados e a listaNumero<Dados>
        //public void SeparaCampos()
        //{
        //    listaNumero = new List<Dados>();
        //    foreach (var item in todoTexto)
        //    {
        //        string[] campo = item.Split(';');
        //        Dados dados = new Dados(Convert.ToInt16(campo[2]),
        //            Convert.ToInt16(campo[3]),
        //            Convert.ToInt16(campo[4]),
        //            Convert.ToInt16(campo[5]),
        //            Convert.ToInt16(campo[6]),
        //            Convert.ToInt16(campo[7]));
        //        listaNumero.Add(dados);
        //    }
        //} 

        public void SeparaCampos()
        {
            int quantidade = 0;
            listaNumero = new List<int>();
            foreach (var item in todoTexto)
            {
                string[] campo = item.Split(';');
                for (int i = 2; i <= 7; i++)
                {
                    listaNumero.Add(Convert.ToInt32(campo[i]));
                    quantidade++;
                }
            }
            //Console.WriteLine("{0} dezenas armazenadas.", quantidade);
        }

        public void FazContagem()
        {
            int frequencia = 0;
            listaFrequencia = new List<int>();
            dezenaFrequencia = new Dictionary<int, int>();
            for (int i = 1; i <= 60; i++)
            {
                frequencia = listaNumero.Count(x => x == i);
                //listaFrequencia.Add(frequencia);
                dezenaFrequencia.Add(i, frequencia);
            }
        }

        //public void ImprimeResultados()
        //{
        //    int i = 1;
        //    int total = 0;
        //    foreach (var item in listaFrequencia)
        //    {
        //        if (i %5 != 0)
        //            Console.Write("{0,2} {1,3}\t\t", i, item);
        //        else
        //            Console.WriteLine("{0,2} {1,3}\t\t", i, item);
        //        total += item;
        //        i++;
        //    }
        //    Console.WriteLine("{0} dezenas armazenadas.\n", total);
        //}
        public void FrequenciaDasDezenas()
        {
            int total = 0;
            Console.WriteLine("Quantas vezes a dezena foi sorteada.");
            foreach (var item in dezenaFrequencia)
            {
                if (item.Key % 6 != 0)
                    Console.Write("{0,2} {1,3}\t\t", item.Key, item.Value);
                else
                    Console.WriteLine("{0,2} {1,3}", item.Key, item.Value);
                total += item.Value;
            }
            //Console.WriteLine("{0} dezenas armazenadas.\n", total);
        }

        public void SorteadasAscendentes()
        {
            Console.WriteLine("\nFrequência de cada dezena em ordem ascendente");
            int contagem = 1;
            var maisSorteadas = dezenaFrequencia.OrderBy(x => x.Value);                

            foreach (var item in maisSorteadas)
            {
                if (contagem % 6 != 0)
                    Console.Write("{0,2} {1,3}\t\t", item.Key, item.Value);
                else
                    Console.WriteLine("{0,2} {1,3}", item.Key, item.Value);
                contagem++;
            }
        }
    }
}
