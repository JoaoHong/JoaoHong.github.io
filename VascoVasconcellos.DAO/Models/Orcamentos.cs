using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[Index("IdComprador", Name = "Fk_Orcamento_Cliente_IdComprador_idx")]
[Index("IdVendedor", Name = "Fk_Orcamento_Usuario_IdVendedor")]
[MySqlCollation("utf8_general_ci")]
public partial class Orcamentos
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAbertura { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFechamento { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdVendedor { get; set; }

    public bool Status { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IdComprador { get; set; }

    [InverseProperty("IdOrcamentoNavigation")]
    public virtual ICollection<Boleta> Boleta { get; set; } = new List<Boleta>();

    [ForeignKey("IdComprador")]
    [InverseProperty("Orcamentos")]
    public virtual Clientes? IdCompradorNavigation { get; set; }

    [ForeignKey("IdVendedor")]
    [InverseProperty("Orcamentos")]
    public virtual Usuario IdVendedorNavigation { get; set; } = null!;

    [InverseProperty("IdOrcamentoNavigation")]
    public virtual ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();
}
