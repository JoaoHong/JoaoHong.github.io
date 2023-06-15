using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Produtos
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(45)]
    public string Produto { get; set; } = null!;

    [InverseProperty("IdProdutoNavigation")]
    public virtual ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();
}
