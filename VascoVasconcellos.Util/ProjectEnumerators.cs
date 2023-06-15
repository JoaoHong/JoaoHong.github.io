using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace VascoVasconcellos.Util.ProjectEnumeratos
{
	public enum EnumEventos
	{
		[Display(Name = "Uso Diário")]
		UsoDiario = 1,
		[Display(Name = "Casamento")]
		Casamento = 2,
		[Display(Name = "Trabalho")]
		Trabalho = 3,
		[Display(Name = "Batismo")]
		Batismo = 4,
		[Display(Name = "Evento Religioso")]
		EventoReligioso = 5,
		[Display(Name = "Evento Publico")]
		EventoPublico = 6,
		[Display(Name = "Evento Particular")]
		EventoParticular = 7,
	}

	public enum EnumStatusvenda
	{
		[Display(Name = "Aguardando Resposta")]
		AguardandoResposta = 0,
		[Display(Name = "Recusado")]
		Recusado = 1,
		[Display(Name = "Aprovado")]
		Aprovado = 2,
	}

	public enum EnumTipoConjunto
	{
		[Display(Name = "Costume")]
		Costume = 1,
		[Display(Name = "Terno")]
		Terno = 2,
	}
	public enum EnumTipoProducao
	{
		[Display(Name = "CV")]
		CV = 1,
		[Display(Name = "Pronto")]
		Pronto = 2,
		[Display(Name = "Terceirizado")]
		Terceirizado = 3,
	}

	public enum EnumTipoForro
	{
		[Display(Name = "Sem forro")]
		SemForro = 1,
		[Display(Name = "Meio forro")]
		MeioForro = 2,
		[Display(Name = "Completo")]
		Completo = 3,
	}

    public enum  EnumModeloColarinho
    {
		[Display(Name = "Italiano")]
		Italiano = 1,
		[Display(Name = "Button Down")]
		ButtonDown = 2,
		[Display(Name = "Clássico")]
		Classico = 3,
		[Display(Name = "Italiano Aberto")]
		ItalianoAberto = 4,
		[Display(Name = "Entretela")]
		Entretela = 5,
		[Display(Name = "Dura")]
		Dura = 6,
		[Display(Name = "Media")]
		Media = 7,
		[Display(Name = "Soft")]
		Soft = 8,
	}

	public enum EnumTipoPunho
	{
		[Display(Name = "Simples")]
		Simples = 1,
		[Display(Name = "Simples Chanfrado")]
		SimplesChanfrado = 2,
		[Display(Name = "Simples Quadrado")]
		SimplesQuadrado = 3,
		[Display(Name = "Duplo")]
		Duplo = 4,
		[Display(Name = "Dois Botões")]
		DoisBotoes = 5,
		[Display(Name = "Misto")]
		Misto = 6,
	}

	public enum EnumTipoMonograma
	{
		[Display(Name = "Costela")]
		Costela = 1,
		[Display(Name = "Peito")]
		Peito = 2,
		[Display(Name = "Punho Direito")]
		PunhoDireito = 3,
		[Display(Name = "Punho Esquerdo")]
		PunhoEsquerdo = 4,
		[Display(Name = "Interior Fralda")]
		InteriorFralda = 5,
	}
}