using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[Index("IdAspNetUser", Name = "FK_Usuario_AspNetUsers_IdAspNetUser")]
[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class Usuario
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public string IdAspNetUser { get; set; } = null!;

    [StringLength(150)]
    public string? Nome { get; set; }

    [StringLength(255)]
    public string Senha { get; set; } = null!;

    public bool Ativo { get; set; }
	[ForeignKey("IdAspNetUser")]
	[InverseProperty("Usuario")]
	public virtual AspNetUsers IdAspNetUserNavigation { get; set; } = null!;

    [InverseProperty("IdVendedorNavigation")]
    public virtual ICollection<Boleta> Boleta { get; set; } = new List<Boleta>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<LogAcesso> LogAcesso { get; set; } = new List<LogAcesso>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<LogErro> LogErro { get; set; } = new List<LogErro>();

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<LogOperacao> LogOperacao { get; set; } = new List<LogOperacao>();

    [InverseProperty("IdVendedorNavigation")]
    public virtual ICollection<Orcamentos> Orcamentos { get; set; } = new List<Orcamentos>();

    [InverseProperty("IdVendedorNavigation")]
    public virtual ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();
}
