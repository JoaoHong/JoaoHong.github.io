using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ConyGreen.DAO.Models;

public partial class Modelos
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [StringLength(255)]
    public string Codigo { get; set; } = null!;

    [StringLength(255)]
    public string? Descricao { get; set; }

    [StringLength(255)]
    public string? Alteracao { get; set; }

    [StringLength(255)]
    public string? Origem { get; set; }

    [StringLength(255)]
    public string? Tipo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDesenvolvimento { get; set; }

    [Column(TypeName = "blob")]
    public byte[]? Frente { get; set; }

    [Column(TypeName = "blob")]
    public byte[]? Costas { get; set; }

    [StringLength(255)]
    public string? Tecido { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Forro { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Entretela { get; set; }

    [StringLength(255)]
    public string? Base { get; set; }

    [StringLength(255)]
    public string? Partes { get; set; }

    [StringLength(255)]
    public string? Aviamento { get; set; }

    [StringLength(45)]
    public string? DetalhesDesenvolvimento { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DataDigitalizacao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Digitalizacao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Verificacao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Graduacao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? VerificacaoGraduacao { get; set; }
}
