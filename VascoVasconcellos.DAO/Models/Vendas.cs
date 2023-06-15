using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace VascoVasconcellos.DAO.Models;

[Index("IdUsuario", Name = "Fk_Vendas_Clientes_IdUsuario")]
[Index("IdOrcamento", Name = "Fk_Vendas_Orcamentos_IdOrcamento")]
[Index("IdProduto", Name = "Fk_Vendas_Produto_IdProduto")]
[Index("IdVendedor", Name = "Fk_Vendas_Usuario_IdVendedor")]
[MySqlCollation("utf8_general_ci")]
public partial class Vendas
{
    [Key]
    [Column(TypeName = "int(11)")]
    public int Id { get; set; }

    [Column(TypeName = "int(11)")]
    public int OS { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PrevisaoEntrega { get; set; }

    [Precision(10, 2)]
    public decimal Valor { get; set; }

    [Column(TypeName = "int(11)")]
    public int Faturamento { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdProduto { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? Modelo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Producao { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? Base { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? Artigo { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorArtigo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Quantidade { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Forro { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorForro { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorPespontoExterno { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorPespontoInterno { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorVivo { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorGola { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? Botao { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorLinhaBotao { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorFraseGolaB { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorFraseB { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? FraseInterna { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorFraseInterna { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorCaseado { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorUltimoCaseado { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? InformacoesAdicionais { get; set; }

    [Column(TypeName = "int(11)")]
    public int? ModeloColarinho { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Bolso { get; set; }

    [Column(TypeName = "int(11)")]
    public int? GiroManga { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorGiroManga { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Monograma { get; set; }

    [StringLength(255)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? CorMonograma { get; set; }

    [StringLength(45)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? Iniciais { get; set; }

    [Column(TypeName = "int(11)")]
    public int? AcabamentoLateral { get; set; }

    [Column(TypeName = "int(11)")]
    public int Evento { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdOrcamento { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Conjunto { get; set; }

    [Column(TypeName = "int(11)")]
    public int Status { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Entregue { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdUsuario { get; set; }

    [Column(TypeName = "int(11)")]
    public int? Punho { get; set; }

    [Column(TypeName = "int(11)")]
    public int IdVendedor { get; set; }

    [StringLength(255)]
    public string? CodigoDeBarras { get; set; }

    [StringLength(255)]
    public string? DescricaoCodBarras { get; set; }

    [InverseProperty("IdVendaNavigation")]
    public virtual ICollection<Conjuntos> Conjuntos { get; set; } = new List<Conjuntos>();

    [ForeignKey("IdOrcamento")]
    [InverseProperty("Vendas")]
    public virtual Orcamentos IdOrcamentoNavigation { get; set; } = null!;

    [ForeignKey("IdProduto")]
    [InverseProperty("Vendas")]
    public virtual Produtos IdProdutoNavigation { get; set; } = null!;

    [ForeignKey("IdUsuario")]
    [InverseProperty("Vendas")]
    public virtual Clientes IdUsuarioNavigation { get; set; } = null!;

    [ForeignKey("IdVendedor")]
    [InverseProperty("Vendas")]
    public virtual Usuario IdVendedorNavigation { get; set; } = null!;
}
