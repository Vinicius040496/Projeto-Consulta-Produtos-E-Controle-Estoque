using System;
using System.Globalization;

public class Leite
{
    public int QuantidadeCompraLeite { get; private set; }
    public double PrecoCompraLeite { get; private set; }
    public int QuantidadeVendaLeite { get; private set; }
    public double PrecoVendaLeite { get; private set; }

    public Leite() { }

    public Leite(int quantidadeCompraLeite, double precoCompraLeite, int quantidadeVendaLeite, double precoVendaLeite)
    {
        QuantidadeCompraLeite = quantidadeCompraLeite;
        PrecoCompraLeite = precoCompraLeite;
        QuantidadeVendaLeite = quantidadeVendaLeite;
        PrecoVendaLeite = precoVendaLeite;
    }

    public int UnidadesVendidasLeite()
    {
        return QuantidadeVendaLeite;
    }

    public double ValorLiquidoLeite()
    {
        return (PrecoVendaLeite - PrecoCompraLeite) * QuantidadeVendaLeite;
    }

    public override string ToString()
    {
        return "Fechamento mensal produto: Leite" + ", Quantidade total movimentado ao estoque: " + UnidadesVendidasLeite().ToString("f2", CultureInfo.InvariantCulture) + " Unidades,  " + "Valor total liquido de vendas: " + ValorLiquidoLeite().ToString("f2", CultureInfo.InvariantCulture) + " Reais ";
    }
}
