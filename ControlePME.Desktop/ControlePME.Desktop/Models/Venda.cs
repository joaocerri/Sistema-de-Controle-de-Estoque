// Models/Venda.cs
using System;
using System.Collections.Generic;

namespace ControlePME.Desktop.Models;

public class Venda
{
    public int Id { get; set; }
    public DateTime DataHora { get; set; }
    public decimal Total { get; set; }
    public int? ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
    public List<ItemVenda> ItensVenda { get; set; } = new List<ItemVenda>();
}