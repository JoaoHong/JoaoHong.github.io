using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[Index("IdUsuario", Name = "IdUsuario_idx")]
[MySqlCharSet("utf8mb4")]
[MySqlCollation("utf8mb4_general_ci")]
public partial class LogOperacao
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IdUsuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Data { get; set; }

    [StringLength(255)]
    public string? Status { get; set; }

    [StringLength(255)]
    public string? Acao { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("LogOperacao")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
