using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Clientes
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string Nome { get; set; } = null!;

    [StringLength(255)]
    public string? CPF { get; set; }

    [InverseProperty("IdCompradorNavigation")]
    public virtual ICollection<Orcamentos> Orcamentos { get; set; } = new List<Orcamentos>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();
}
