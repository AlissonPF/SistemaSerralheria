using System;

namespace LojaGestaoAPI.Models;

public class Orcamento
{
    public int Id { get; set; }
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set; } // Relacionamento com Cliente
    public List<OrcamentoItem> Itens { get; set; } = new List<OrcamentoItem>();
    public decimal MaoDeObra { get; set; }
    public decimal ValorTotal { get; set; }
    public string Status { get; set; } // Pendente, Aprovado, Rejeitado
    public DateTime DataOrcamento { get; set; }
}
