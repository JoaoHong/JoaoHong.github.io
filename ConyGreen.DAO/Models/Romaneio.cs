using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.DAO.Models;

public partial class Romaneio
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Corte { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Modelo { get; set; }

    [StringLength(255)]
    public string? Descricao { get; set; }

    public float? TAB1 { get; set; }

    public float? TAB2 { get; set; }

    public bool? Conjunto { get; set; }
}
