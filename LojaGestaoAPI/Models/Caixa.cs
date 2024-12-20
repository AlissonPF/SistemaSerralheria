using System;

namespace LojaGestaoAPI.Models;

public class Caixa
{
    public int Id { get; set; }
    public DateTime Data { get; set; }
    public decimal ValorEntrada { get; set; }
    public decimal ValorSaida { get; set; }
    public decimal SaldoDia { get; set; }
    public string Observacoes { get; set; }
}
