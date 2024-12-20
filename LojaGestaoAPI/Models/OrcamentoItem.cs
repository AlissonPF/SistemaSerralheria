using System;

namespace LojaGestaoAPI.Models;

public class OrcamentoItem
{
    public int Id { get; set; }
    public int OrcamentoId { get; set; }
    public Orcamento Orcamento { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public decimal Subtotal => Quantidade * PrecoUnitario;
}
