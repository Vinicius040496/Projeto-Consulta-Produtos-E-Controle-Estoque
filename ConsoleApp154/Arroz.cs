using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp154
{
    internal class Arroz
    {
        public double PrecoCompraArroz { get; private set; }
       
        public int QuantidadeCompraArroz { get; private set; }
       
        public double PrecoVendaArroz { get; private set; }
       
        public int QuantidadeVendaArroz { get; private set; }
      
        public Arroz() { }
        public Arroz(int quantidadeCompraArroz, double precoCompraArroz, int quantidadevendaarroz, double precoVendaArroz)
        {
            QuantidadeCompraArroz = quantidadeCompraArroz;
            PrecoCompraArroz = precoCompraArroz;
            QuantidadeVendaArroz = quantidadevendaarroz;
            PrecoVendaArroz = precoVendaArroz;
        }

        public int UnidadesVendidasArroz()
        {
            return QuantidadeVendaArroz;
        }

        public double ValorLiquidoArroz()
        {
            return (PrecoVendaArroz - PrecoCompraArroz) * QuantidadeVendaArroz;
        }

        public override string ToString()
        {
            return "Fechamento mensal produto: Arroz" + ", Quantidade total movimentado ao estoque: " + UnidadesVendidasArroz().ToString("f2", CultureInfo.InvariantCulture) + " Unidades,  " + "Valor total liquido de vendas: " + ValorLiquidoArroz().ToString("f2", CultureInfo.InvariantCulture) + " Reais ";
        }
    }
}
