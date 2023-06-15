using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[Index("IdVenda", Name = "Fk_Conjuntos_Vendas_IdVendas_idx")]
public partial class Conjuntos
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IdVenda { get; set; }

    [Column(TypeName = "int(11)")]
    public int? TipoConjunto { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IdentificadorConjunto { get; set; }

    [ForeignKey("IdVenda")]
    [InverseProperty("Conjuntos")]
    public virtual Vendas? IdVendaNavigation { get; set; }
}
