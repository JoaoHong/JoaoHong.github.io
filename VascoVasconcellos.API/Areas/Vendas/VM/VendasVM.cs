using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VascoVasconcellos.API.Areas.Vendas.VM
{
    public class VendasVM
    {
        public int Id { get; set; }

        public int? OS { get; set; }

        public int IdCliente { get; set; }

        public DateTime PrevisaoEntrega { get; set; }

        public float Valor { get; set; }

        public int Faturamento { get; set; }

        public int IdProduto { get; set; }

        public string? Modelo { get; set; }

        public int? Producao { get; set; }

        public string? Base { get; set; }

        public string? Artigo { get; set; }

        public string? CorArtigo { get; set; }

        public int? Quantidade { get; set; }

        public int? Forro { get; set; }

        public string? CorForro { get; set; }

        public string? CorPespontoExterno { get; set; }

        public string? CorPespontoInterno { get; set; }

        public string? CorVivo { get; set; }

        public string? CorGola { get; set; }

        public string? Botao { get; set; }

        public string? CorLinhaBotao { get; set; }

        public string? CorFraseGolaB { get; set; }

        public string? CorFraseB { get; set; }

        public string? FraseInterna { get; set; }

        public string? CorFraseInterna { get; set; }

        public string? CorCaseado { get; set; }

        public string? CorUltimoCaseado { get; set; }

        public string? InformacoesAdicionais { get; set; }

        public int? ModeloColarinho { get; set; }

        public int? Bolso { get; set; }

        public int? GiroManga { get; set; }

        public string? CorGiroManga { get; set; }

        public int? Monograma { get; set; }

        public string? CorMonograma { get; set; }

        public string? Iniciais { get; set; }

        public int? AcabamentoLateral { get; set; }

        public int Evento { get; set; }

        public int IdOrcamento { get; set; }

        public int? Conjunto { get; set; }

        public int? Status { get; set; }

        public int? Entregue { get; set; }

        public int IdUsuario { get; set; }

        public int? Punho { get; set; }

        public int IdVendedor { get; set;}

        public string? CodigoDeBarras { get; set; }

        public string? DescricaoCodBarrras { get; set; }
    }

}

