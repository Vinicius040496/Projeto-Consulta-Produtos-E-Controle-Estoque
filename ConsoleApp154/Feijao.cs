using System;
using System.Globalization;

public class Feijao
{
    public int QuantidadeCompraFeijao { get; private set; }
    public double PrecoCompraFeijao { get; private set; }
    public int QuantidadeVendaFeijao { get; private set; }
    public double PrecoVendaFeijao { get; private set; }


    public Feijao() { }

    public Feijao(int quantidadeCompraFeijao, double precoCompraFeijao, int quantidadeVendaFeijao, double precoVendaFeijao)
    {
        QuantidadeCompraFeijao = quantidadeCompraFeijao;
        PrecoCompraFeijao = precoCompraFeijao;
        QuantidadeVendaFeijao = quantidadeVendaFeijao;
        PrecoVendaFeijao = precoVendaFeijao;
    }

    public int UnidadesVendidasFeijao()
    {
        return QuantidadeVendaFeijao;
    }


    public double ValorLiquidoFeijao()
    {
        return (PrecoVendaFeijao - PrecoCompraFeijao) * QuantidadeVendaFeijao;
    }

    public override string ToString()
    {
        return "Fechamento mensal produto: Feijão" + ", Quantidade total movimentado ao estoque: " + UnidadesVendidasFeijao().ToString("f2", CultureInfo.InvariantCulture) + " Unidades,  " + "Valor total liquido de vendas: " + ValorLiquidoFeijao().ToString("f2", CultureInfo.InvariantCulture) + " Reais ";
    }
}
