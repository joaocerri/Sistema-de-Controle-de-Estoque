using System;

namespace ControlePME.Desktop.Models;

public class MovimentacaoEstoque
{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public int Quantidade { get; set; }
    public string? Tipo { get; set; } 
    public string? Descricao { get; set; }
    public int ProdutoId { get; set; }
    public Produto Produto { get; set; } = null!;
}