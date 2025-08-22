namespace ControlePME.Desktop.Models;

public class Produto
{
    public int Id { get; set; }
    public string? SKU { get; set; }
    public string? Nome { get; set; }
    public decimal PrecoVenda { get; set; }
    public decimal PrecoCusto { get; set; }
    public int EstoqueAtual { get; set; }
    public int EstoqueMinimo { get; set; }
    public bool Ativo { get; set; }
}