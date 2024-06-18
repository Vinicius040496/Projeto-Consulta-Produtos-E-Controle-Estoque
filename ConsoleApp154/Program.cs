using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp154
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arroz P = new Arroz();
            Feijao p1 = new Feijao();
            Leite P3 = new Leite();
            Console.WriteLine("Qual produto deseja consultar: ");
            Console.WriteLine("1- Arroz");
            Console.WriteLine("2- Feijão");
            Console.WriteLine("3- Leite");
            int Resp = int.Parse(Console.ReadLine());
            if (Resp == 1)
            {
                Console.WriteLine("Dados do produto Arroz");
                Console.Write("Entre com quantidade de compra ao estoque: ");
                int quantidadeCompraArroz = int.Parse(Console.ReadLine());
                Console.Write("Entre com valor de compra do produto ao estoque: ");
                double precoCompraArroz = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com quantidade de vendas do produto ao estoque: ");
                int quantidadevendaarroz = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com valor de venda do produto ao estoque: ");
                double precoVendaArroz = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Arroz p = new Arroz(quantidadeCompraArroz, precoCompraArroz, quantidadevendaarroz, precoVendaArroz);
                P.UnidadesVendidasArroz();
                P.ValorLiquidoArroz();
                Console.WriteLine(p1);
                Console.ReadLine();
            }
            else if (Resp == 2)
            {
                Console.Write("Entre com quantidade de compra ao estoque: ");
                int quantidadeCompraFeijao = int.Parse(Console.ReadLine());
                Console.Write("Entre com valor de compra do produto ao estoque: ");
                double precoCompraFeijao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com quantidade de vendas do produto ao estoque: ");
                int quantidadeVendaFeijao = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com valor de venda do produto ao estoque: ");
                double precoVendaFeijao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Feijao  P1 = new Feijao(quantidadeCompraFeijao, precoCompraFeijao, quantidadeVendaFeijao, precoVendaFeijao);
                P1.UnidadesVendidasFeijao();
                P1.ValorLiquidoFeijao();
                Console.WriteLine(P1);
                Console.ReadLine();
            }
            else if (Resp == 3)
            {

                Console.Write("Entre com quantidade de compra ao estoque: ");
                int quantidadeCompraLeite = int.Parse(Console.ReadLine());
                Console.Write("Entre com valor de compra do produto ao estoque: ");
                double precoCompraLeite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com quantidade de vendas do produto ao estoque: ");
                int quantidadeVendaLeite = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Entre com valor de venda do produto ao estoque: ");
                double precoVendaLeite = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Leite P4= new Leite(quantidadeCompraLeite, precoCompraLeite, quantidadeVendaLeite, precoVendaLeite);
                P4.UnidadesVendidasLeite();
                P4.ValorLiquidoLeite();
                Console.WriteLine(P4);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Produto não encontrado!!");
            }
            Console.ReadLine();
        }
    }
}

