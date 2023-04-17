using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.DAO.Models;

[Index("IdUsuario", Name = "IdUsuario_idx")]
public partial class LogAcesso
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IdUsuario { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Data { get; set; }

    public bool? Status { get; set; }

    [ForeignKey("IdUsuario")]
    [InverseProperty("LogAcesso")]
    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
