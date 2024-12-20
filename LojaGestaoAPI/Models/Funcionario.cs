using System;

namespace LojaGestaoAPI.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cargo { get; set; } // Administrador, Vendedor
    public List<Venda> Vendas { get; set; } = new List<Venda>();
}
