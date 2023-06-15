using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[Index("IdOrcamento", Name = "Fk_Boleta_Orcamento_IdOrcamento")]
[Index("IdVendedor", Name = "Fk_Boleta_Usuario_IdVendedor")]
[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Boleta
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdVendedor { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataFechamento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataAbertura { get; set; }

    [Column(TypeName = "int(11)")]
    public int FormaPagamento { get; set; }

    [Column(TypeName = "int(11)")]
    public int Parcelas { get; set; }

    [Precision(10, 2)]
    public decimal? Desconto { get; set; }

    [Column(TypeName = "int(11)")]
    public int Tipo { get; set; }

    [Precision(10, 2)]
    public decimal Valor { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdOrcamento { get; set; }

    [ForeignKey("IdOrcamento")]
    [InverseProperty("Boleta")]
    public virtual Orcamentos IdOrcamentoNavigation { get; set; } = null!;

    [ForeignKey("IdVendedor")]
    [InverseProperty("Boleta")]
    public virtual Usuario IdVendedorNavigation { get; set; } = null!;
}
