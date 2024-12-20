using System;

namespace LojaGestaoAPI.Models;

public class Venda
{
    public int Id { get; set; }
    public DateTime DataVenda { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } // Relacionamento com Cliente
    public List<VendaItem> Itens { get; set; } = new List<VendaItem>();
    public decimal ValorTotal { get; set; }
    public string FormaPagamento { get; set; } // À Vista, Parcelado
    public int FuncionarioId { get; set; }
    public Funcionario Funcionario { get; set; } // Relacionamento com Funcionário
}
