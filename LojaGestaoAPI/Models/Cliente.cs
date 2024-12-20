using System;

namespace LojaGestaoAPI.Models;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string CPF_CNPJ { get; set; }
    public string Contato { get; set; } // Telefone, WhatsApp ou E-mail
    public List<Venda> Vendas { get; set; } = new List<Venda>();
}
