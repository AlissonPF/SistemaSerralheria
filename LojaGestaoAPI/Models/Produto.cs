using System;

namespace LojaGestaoAPI.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; } // Loja, Serralheria, Vidraçaria
    public int Quantidade { get; set; }
    public decimal PrecoCusto { get; set; }
    public decimal PrecoVenda { get; set; }
    public string Localizacao { get; set; } // Ex.: Loja, Serralheria
}

