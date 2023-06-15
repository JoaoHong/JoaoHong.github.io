using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

public partial class ProdutosColunas
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? IdProduto { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Modelo { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Producao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Base { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Artigo { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorArtigo { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Qantidade { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Forro { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorForro { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorPespontoExt { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorPespontoInt { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorVivo { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? BGolaCor { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Botao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorLinhaBotao { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorFraseBGola { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorFraseB { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? FraseInt { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorFraseInt { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorDoCaseado { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorUltimoCaseado { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? InfoAdicionais { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Punho { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? ModeloColarinho { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Bolso { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? GiroManga { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorGiroManga { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Monograma { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CorMonograma { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Iniciais { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? AcabamentoLateral { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? Evento { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? CodigoDeBarras { get; set; }

    [Column(TypeName = "bit(1)")]
    public ulong? DescricaoCodBarras { get; set; }
}
