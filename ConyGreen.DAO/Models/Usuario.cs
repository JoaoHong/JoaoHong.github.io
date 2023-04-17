using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.DAO.Models;

[Index("IdAspNetUser", Name = "IX_Usuario_IdAspNetUser", IsUnique = true)]
[MySqlCollation("utf8_general_ci")]
public partial class Usuario
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    public string IdAspNetUser { get; set; } = null!;

    [StringLength(150)]
    public string Nome { get; set; } = null!;

    public string Senha { get; set; } = null!;

    public bool Ativo { get; set; }

	[ForeignKey("IdAspNetUser")]
	[InverseProperty("Usuario")]
	public virtual AspNetUser IdAspNetUserNavigation { get; set; }

    [InverseProperty("IdUsuarioNavigation")]
    public virtual ICollection<LogAcesso> LogAcesso { get; } = new List<LogAcesso>();
}
