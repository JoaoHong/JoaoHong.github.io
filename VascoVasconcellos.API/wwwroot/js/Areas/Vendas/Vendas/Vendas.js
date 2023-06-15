var VendasAPI = function () {
	
	var urlAdicionar = "/Vendas/Vendas/AdicionarVenda/";
	var urlIndex = "/Vendas/Vendas/Index?idOrc=";
	var urlProdutosColunas = "/Gerenciamento/Produtos/GetProdutosColunas/?IdProduto=";
	var urlCopiar = "/Vendas/Vendas/Copiar/";
	var urlAdicionarFirst = "/Vendas/Vendas/AdicionarVendaFirst/";
	var urlOrcIndex = "/Vendas/Orcamentos/Index/";
	var urlTrocarStatus = "/Vendas/Vendas/TrocarStatus/?idVenda=";
	var urlEditar = "/Vendas/Vendas/EditarVenda/";
	var validation = null;

	var initValidation = function () {

		var form = document.getElementById('vendaForm');

		validation = FormValidation.formValidation(form,
			{
				fields: {
					vendaUsuario: {
						validators: {
							notEmpty: {
								message: 'O usuario é obrigatorio!'
							},
						}
					},
					vendaValor: {
						validators: {
							notEmpty: {
								message: 'Valor da venda é obrigatorio!'
							}
						}
					},
					vendaPrevisao: {
						validators: {
							notEmpty: {
								message: 'Valor da venda é obrigatorio!'
							}
						}
					},
					vendaFaturamento: {
						validators: {
							notEmpty: {
								message: 'Valor da venda é obrigatorio!'
							}
						}
					},
					vendaItem: {
						validators: {
							notEmpty: {
								message: 'Valor da venda é obrigatorio!'
							}
						}
					},
					vendaEvento: {
						validators: {
							notEmpty: {
								message: 'Valor da venda é obrigatorio!'
							}
						}
					},
					codigoDeBarras: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Modelo é obrigatorio!"
							}
						}
					},
					qantidade: {
						validators: {
							notEmpty: {
								enabled: true,
								message: 'Quantidade é obrigatoria!'
							}
						}
					},
					modelo: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Modelo é obrigatorio!"
							}
						}
					},
					acabamentoLateral: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Acabamento lateral é obrigatorio!"
							}
						}
					},
					artigo: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Artigo é obrigatorio!"
							}
						}
					},
					bGolaCor: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor baixo de gola é obrigatorio!"
							}
						}
					},
					base: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Base é obrigatorio!"
							}
						}
					},
					bolso: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Bolso é obrigatorio!"
							}
						}
					},
					botao: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Botao é obrigatorio!"
							}
						}
					},
					corArtigo: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor do Artigo é obrigatorio!"
							}
						}
					},
					corDoCaseado: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor do caseado é obrigatorio!"
							}
						}
					},
					corForro: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor do forro é obrigatorio!"
							}
						}
					},
					corFraseB: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor frase de baixo é obrigatorio!"
							}
						}
					},
					corFraseBGola: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor frase de baixo de gola é obrigatorio!"
							}
						}
					},
					corFraseInt: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor da frase interna é obrigatorio!"
							}
						}
					},
					corGiroManga: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor giro de manga é obrigatorio!"
							}
						}
					},
					corLinhaBotao: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor da linha do botão é obrigatorio!"
							}
						}
					},
					corMonograma: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor do monograma é obrigatorio!"
							}
						}
					},
					corPespontoExt: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor pesponto externo é obrigatorio!"
							}
						}
					},
					corPespontoInt: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor pesponto interno é obrigatorio!"
							}
						}
					},
					corUltimoCaseado: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor do ultimo caseado é obrigatorio!"
							}
						}
					},
					corVivo: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Cor vivo é obrigatorio!"
							}
						}
					},
					//descricaoCodBarras: {
					//	validators: {
					//		notEmpty: {
					//			enabled: true,
					//			message: "Modelo é obrigatorio!"
					//		}
					//	}
					//},
					forro: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Forro é obrigatorio!"
							}
						}
					},
					fraseInt: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Frase interna é obrigatorio!"
							}
						}
					},
					giroManga: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Giro de manga é obrigatorio!"
							}
						}
					},
					//infoAdicionais: {
					//	validators: {
					//		notEmpty: {
					//			enabled: true,
					//			message: "Modelo é obrigatorio!"
					//		}
					//	}
					//},
					iniciais: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Iniciais é obrigatorio!"
							}
						}
					},
					modeloColarinho: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Modelo de colarinho é obrigatorio!"
							}
						}
					},
					monograma: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Monograma é obrigatorio!"
							}
						}
					},
					producao: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Produção é obrigatorio!"
							}
						}
					},
					punho: {
						validators: {
							notEmpty: {
								enabled: true,
								message: "Punho é obrigatorio!"
							}
						}
					},
				},
				plugins: {
					trigger: new FormValidation.plugins.Trigger,
					bootstrap: new FormValidation.plugins.Bootstrap5({ rowSelector: ".fv-row" })
				}
			}
		);

	}
    var onClickAdicionar = function () {
		$("#btnAdicionar").on("click", function (e) {
			
			validation.validate().then(function (status) {
				
				if (status == 'Valid') {

					Swal.fire({
						title: 'Tem certeza?',
						html: 'Realmente deseja adicionar essa venda?',
						icon: "warning",
						confirmButtonText: "Sim",
						showCancelButton: true,
						cancelButtonText: "Não",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary",
							cancelButton: "btn font-weight-bold btn-secondary"
						}
					}).then(async function (result) {

						if (result.isConfirmed) {
					

							var model = {};

							model.OS = 0;
							model.IdCliente = 1;
							model.IdUsuario = $('#vendaUsuario').val();
							model.Valor = parseFloat($('#vendaValor').val().replace(/[^0-9,]/g, '').replace(',', '.'));
							model.PrevisaoEntrega = moment($('#vendaPrevisao').val(), 'DD/MM/YYYY').format('MM/DD/YYYY');
							model.Faturamento = $('#vendaFaturamento').val();
							model.IdProduto = $('#vendaItem').val();
							model.Evento = $('#vendaEvento').val();
							model.Conjunto = $('#vendaConjunto').val();
							model.Modelo = $('#modelo').val();
							model.Producao = $('#producao').val();
							model.Base = $('#base').val();
							model.Artigo = $('#artigo').val();
							model.CorArtigo = $('#corArtigo').val();
							model.Quantidade = $('#qantidade').val();
							model.Forro = $('#forro').val();
							model.CorForro = $('#corForro').val();
							model.CorPespontoExterno = $('#corPespontoExt').val();
							model.CorPespontoInterno = $('#corPespontoInt').val();
							model.CorVivo = $('#corVivo').val();
							model.CorGola = $('#bGolaCor').val();
							model.Botao = $('#botao').val(); 
							model.CorLinhaBotao = $('#corLinhaBotao').val();
							model.CorFraseGolaB = $('#corFraseBGola').val();
							model.CorFraseB = $('#corFraseB').val();
							model.FraseInterna = $('#fraseInt').val();
							model.CorFraseInterna = $('#corFraseInt').val();
							model.CorCaseado = $('#corDoCaseado').val();
							model.CorUltimoCaseado = $('#corUltimoCaseado').val();
							model.Punho = $('#punho').val();
							model.ModeloColarinho = $('#modeloColarinho').val();
							model.Bolso = $('#bolso').val();
							model.GiroManga = $('#giroManga').val();
							model.CorGiroManga = $('#corGiroManga').val();
							model.Monograma = $('#monograma').val();
							model.CorMonograma = $('#corMonograma').val();
							model.Iniciais = $('#iniciais').val();
							model.AcabamentoLateral = $('#acabamentoLateral').val();
							model.InformacoesAdicionais = $('#vendaIndoAdd').val();
							model.IdOrcamento = $("#idOrcamento").val();
							console.log(model);
							debugger
							$.ajax({
								url: urlAdicionar,
								type: 'POST',
								contentType: 'application/json',
								data: JSON.stringify(model),
								success: function (data) {
									

									Swal.fire({
										title: data.title,
										html: data.message,
										icon: data.ok ? "success" : "error",
										confirmButtonText: "Ok",
										customClass: {
											confirmButton: "btn font-weight-bold btn-primary"
										}
									}).then(function () {

										if (data.ok) {
											window.location.href = urlIndex + $("#idOrcamento").val();
										}
									});

								},
								error: function () {
									
									Swal.fire({
										title: "Aviso",
										html: "Desculpe, houve um erro na requisição!",
										icon: "error",
										confirmButtonText: "Ok",
										customClass: {
											confirmButton: "btn font-weight-bold btn-primary"
										}
									}).then(function () {
										KTUtil.scrollTop();
									});

								}
							});

						}
					});

				} else {
					Swal.fire({
						title: "Aviso",
						html: "Você deve preencher todos os campos obrigatórios!",
						icon: "error",
						confirmButtonText: "Ok",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary"
						}
					}).then(function () {
						KTUtil.scrollTop();
					});
				}
			});

        })
	}

	var onClickEditar = function () {
		$("#btnEditar").on("click", function (e) {

			validation.validate().then(function (status) {

				if (status == 'Valid') {

					Swal.fire({
						title: 'Tem certeza?',
						html: 'Realmente deseja adicionar essa venda?',
						icon: "warning",
						confirmButtonText: "Sim",
						showCancelButton: true,
						cancelButtonText: "Não",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary",
							cancelButton: "btn font-weight-bold btn-secondary"
						}
					}).then(async function (result) {

						if (result.isConfirmed) {

							var model = {};

							model.Id = $('#idVenda').val();
							model.OS = 0;
							model.IdCliente = 1;
							model.IdUsuario = $('#vendaUsuario').val();
							model.Valor = parseFloat($('#vendaValor').val().replace(/[^0-9,]/g, '').replace(',', '.'));
							model.PrevisaoEntrega = moment($('#vendaPrevisao').val(), 'DD/MM/YYYY').format('MM/DD/YYYY');
							model.Faturamento = $('#vendaFaturamento').val();
							model.IdProduto = $('#vendaItem').val();
							model.Evento = $('#vendaEvento').val();
							model.Conjunto = $('#vendaConjunto').val();
							model.Modelo = $('#modelo').val();
							model.Producao = $('#producao').val();
							model.Base = $('#base').val();
							model.Artigo = $('#artigo').val();
							model.CorArtigo = $('#corArtigo').val();
							model.Quantidade = $('#qantidade').val();
							model.Forro = $('#forro').val();
							model.CorForro = $('#corForro').val();
							model.CorPespontoExterno = $('#corPespontoExt').val();
							model.CorPespontoInterno = $('#corPespontoInt').val();
							model.CorVivo = $('#corVivo').val();
							model.CorGola = $('#bGolaCor').val();
							model.Botao = $('#botao').val();
							model.CorLinhaBotao = $('#corLinhaBotao').val();
							model.CorFraseGolaB = $('#corFraseBGola').val();
							model.CorFraseB = $('#corFraseB').val();
							model.FraseInterna = $('#fraseInt').val();
							model.CorFraseInterna = $('#corFraseInt').val();
							model.CorCaseado = $('#corDoCaseado').val();
							model.CorUltimoCaseado = $('#corUltimoCaseado').val();
							model.Punho = $('#punho').val();
							model.ModeloColarinho = $('#modeloColarinho').val();
							model.Bolso = $('#bolso').val();
							model.GiroManga = $('#giroManga').val();
							model.CorGiroManga = $('#corGiroManga').val();
							model.Monograma = $('#monograma').val();
							model.CorMonograma = $('#corMonograma').val();
							model.Iniciais = $('#iniciais').val();
							model.AcabamentoLateral = $('#acabamentoLateral').val();
							model.InformacoesAdicionais = $('#vendaIndoAdd').val();
							model.IdOrcamento = $("#idOrcamento").val();
							console.log(model);
							debugger
							$.ajax({
								url: urlEditar,
								type: 'POST',
								contentType: 'application/json',
								data: JSON.stringify(model),
								success: function (data) {


									Swal.fire({
										title: data.title,
										html: data.message,
										icon: data.ok ? "success" : "error",
										confirmButtonText: "Ok",
										customClass: {
											confirmButton: "btn font-weight-bold btn-primary"
										}
									}).then(function () {

										if (data.ok) {
											window.location.href = urlIndex + $("#idOrcamento").val();
										}
									});

								},
								error: function () {

									Swal.fire({
										title: "Aviso",
										html: "Desculpe, houve um erro na requisição!",
										icon: "error",
										confirmButtonText: "Ok",
										customClass: {
											confirmButton: "btn font-weight-bold btn-primary"
										}
									}).then(function () {
										KTUtil.scrollTop();
									});

								}
							});

						}
					});

				} else {
					Swal.fire({
						title: "Aviso",
						html: "Você deve preencher todos os campos obrigatórios!",
						icon: "error",
						confirmButtonText: "Ok",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary"
						}
					}).then(function () {
						KTUtil.scrollTop();
					});
				}
			});

		})
	}
	var onClickAdicionarPrimeiraVenda = function () {
		$("#btnAdicionar").on("click", function () {
			validation.validate().then(function (status) {

				if (status == 'Valid') {

					Swal.fire({
						title: 'Tem certeza?',
						html: 'Realmente deseja adicionar essa venda?',
						icon: "warning",
						confirmButtonText: "Sim",
						showCancelButton: true,
						cancelButtonText: "Não",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary",
							cancelButton: "btn font-weight-bold btn-secondary"
						}
					}).then(async function (result) {

						if (result.isConfirmed) {


							var model = {};

							model.OS = 0;
							model.IdCliente = $('#vendaComprador').val();
							model.IdUsuario = $('#vendaUsuario').val();
							model.Valor = parseFloat($('#vendaValor').val().replace(/[^0-9,]/g, '').replace(',', '.'));
							model.PrevisaoEntrega = moment($('#vendaPrevisao').val(), 'DD/MM/YYYY').format('MM/DD/YYYY');
							model.Faturamento = $('#vendaFaturamento').val();
							model.IdProduto = $('#vendaItem').val();
							model.Evento = $('#vendaEvento').val();
							model.Conjunto = $('#vendaConjunto').val();
							model.Modelo = $('#modelo').val();
							model.Producao = $('#producao').val();
							model.Base = $('#base').val();
							model.Artigo = $('#artigo').val();
							model.CorArtigo = $('#corArtigo').val();
							model.Quantidade = $('#qantidade').val();
							model.Forro = $('#forro').val();
							model.CorForro = $('#corForro').val();
							model.CorPespontoExterno = $('#corPespontoExt').val();
							model.CorPespontoInterno = $('#corPespontoInt').val();
							model.CorVivo = $('#corVivo').val();
							model.CorGola = $('#bGolaCor').val();
							model.Botao = $('#botao').val();
							model.CorLinhaBotao = $('#corLinhaBotao').val();
							model.CorFraseGolaB = $('#corFraseBGola').val();
							model.CorFraseB = $('#corFraseB').val();
							model.FraseInterna = $('#fraseInt').val();
							model.CorFraseInterna = $('#corFraseInt').val();
							model.CorCaseado = $('#corDoCaseado').val();
							model.CorUltimoCaseado = $('#corUltimoCaseado').val();
							model.Punho = $('#punho').val();
							model.ModeloColarinho = $('#modeloColarinho').val();
							model.Bolso = $('#bolso').val();
							model.GiroManga = $('#giroManga').val();
							model.CorGiroManga = $('#corGiroManga').val();
							model.Monograma = $('#monograma').val();
							model.CorMonograma = $('#corMonograma').val();
							model.Iniciais = $('#iniciais').val();
							model.AcabamentoLateral = $('#acabamentoLateral').val();
							model.InformacoesAdicionais = $('#vendaIndoAdd').val();
							model.IdOrcamento = 0
							console.log(model);

							$.ajax({
								url: urlAdicionarFirst,
								type: 'POST',
								contentType: 'application/json',
								data: JSON.stringify(model),
								success: function (data) {


									Swal.fire({
										title: data.title,
										html: data.message,
										icon: data.ok ? "success" : "error",
										confirmButtonText: "Ok",
										customClass: {
											confirmButton: "btn font-weight-bold btn-primary"
										}
									}).then(function () {

										if (data.ok) {
											window.location.href = urlOrcIndex;
										}
									});

								},
								error: function () {

									Swal.fire({
										title: "Aviso",
										html: "Desculpe, houve um erro na requisição!",
										icon: "error",
										confirmButtonText: "Ok",
										customClass: {
											confirmButton: "btn font-weight-bold btn-primary"
										}
									}).then(function () {
										KTUtil.scrollTop();
									});

								}
							});

						}
					});

				} else {
					Swal.fire({
						title: "Aviso",
						html: "Você deve preencher todos os campos obrigatórios!",
						icon: "error",
						confirmButtonText: "Ok",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary"
						}
					}).then(function () {
						KTUtil.scrollTop();
					});
				}
			});
		})
	}
	var editarFormVendas = function () {
		$("#vendaItem").change(function () {
			
			$(".InputDivItem").addClass("d-none");
			var selectedValue = $("#vendaItem").val();
			$.ajax({
				url: urlProdutosColunas + selectedValue,
				type: 'GET',
				success: function (data) {
					console.log(data);
					$.each(data, function (inputName, ativo) {
						
						if (inputName != "id" && inputName != "idProduto" && inputName != "evento" && inputName != "descricaoCodBarras" && inputName != "infoAdicionais") {

							validation.disableValidator(inputName);
						}
					});

					$.each(data, function (inputName, ativo) {
						
						if (inputName != "id" && inputName != "idProduto" && ativo == 1 && inputName != "evento") {
							if (inputName != "descricaoCodBarras" && inputName != "infoAdicionais") {
								validation.enableValidator(inputName);
							}
							
							$("." + inputName).removeClass("d-none");
						}
					})
				},
				error: function () {

					Swal.fire({
						title: "Aviso",
						html: "Desculpe, houve um erro na requisição!",
						icon: "error",
						confirmButtonText: "Ok",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary"
						}
					}).then(function () {
						KTUtil.scrollTop();
					});

				}
			});
		})
	}

	var onClickMudarStatus = function () {
		$(".btnMudarStatus").on("click", function (e) {
			var id = $(this).attr("id");
			Swal.fire({
				title: 'Status da venda',
				input: 'select',
				inputOptions: {
					2: 'Aprovado',
					1: 'Recusado'
				},
				inputAttributes: {
					'data-value': 'custom-value'
				},
				showCancelButton: true,
				cancelButtonText: "Cancelar",
				confirmButtonText: 'Confirmar',
				customClass: {
					confirmButton: "btn font-weight-bold btn-primary",
					cancelButton: "btn font-weight-bold btn-secondary"
				}
			}).then((result) => {
				if (result.isConfirmed) {
					const selectedValue = result.value;
					
					$.ajax({
						url: urlTrocarStatus + id + "&status=" + selectedValue,
						type: 'GET',
						success: function (data) {
							if (data.ok) {
								window.location.href = urlIndex + $("#hiddenOrcVal").val();;
							}
						},

						error: function () {
							Swal.fire({
								title: "Aviso",
								html: "Houve um erro!",
								icon: "error",
								confirmButtonText: "Ok",
								customClass: {
									confirmButton: "btn font-weight-bold btn-primary"
								}
							}).then(function () {
								KTUtil.scrollTop();
							});
						}

					})
				}
			});
			
		});
	}
	var editarFormVendasVisualizar = function () {
		$(document).ready(function () {
			
			$(".InputDivItem").addClass("d-none");
			var selectedValue = $("#vendaItem").val();
			$.ajax({
				url: urlProdutosColunas + selectedValue,
				type: 'GET',
				success: function (data) {
					$.each(data, function (inputName, ativo) {

						if (inputName != "id" && inputName != "idProduto" && inputName != "evento" && inputName != "descricaoCodBarras" && inputName != "infoAdicionais") {

							validation.disableValidator(inputName);
						}
					});
					$.each(data, function (inputName, ativo) {

						if (inputName != "id" && inputName != "idProduto" && ativo == 1 && inputName != "evento") {
							if (inputName != "descricaoCodBarras" && inputName != "infoAdicionais") {
								validation.enableValidator(inputName);
							}
							$("." + inputName).removeClass("d-none");
						}
					})
				},
				error: function () {

					Swal.fire({
						title: "Aviso",
						html: "Desculpe, houve um erro na requisição!",
						icon: "error",
						confirmButtonText: "Ok",
						customClass: {
							confirmButton: "btn font-weight-bold btn-primary"
						}
					}).then(function () {
						KTUtil.scrollTop();
					});

				}
			});
		})
	}

	var voltarBtn = function () {
		$("#btnVoltar").on("click", function () {
			history.back();
		})
	}
	var InitDatePicker = function () {
		$("#vendaPrevisao").flatpickr({
			dateFormat: "d/m/Y",
			locale: {
				months: {
					shorthand: ['Jan', 'Feb', 'Mar', 'Abr', 'Mai', 'Jun', 'Jul', 'Ago', 'Set', 'Out', 'Nov', 'Dez'],
					longhand: ["Janeiro",
						"Fevereiro",
						"Março",
						"Abril",
						"Maio",
						"Junho",
						"Julho",
						"Agosto",
						"Setembro",
						"Outubro",
						"Novembro",
						"Dezembro"]
				},
				weekdays: {
					shorthand: ["Dom",
						"Seg",
						"Ter",
						"Qua",
						"Qui",
						"Sex",
						"Sáb"],
					longhand: ['Domingo', 'Segunda', 'Terça', 'Quarta', 'Quinta', 'Sexta', 'Sabado']
				}
			}
		});
	}	
	return {
		initIndex: function () {
			onClickMudarStatus();
			voltarBtn();
		},
		InitAdicionar: function () {
			initValidation('vendaForm');
			onClickAdicionar();
			editarFormVendas();
			InitDatePicker();
			Inputmask("R$ 999.999.999,99", {
				"numericInput": true
			}).mask("#vendaValor");
			voltarBtn();
		},
		InitVisualizar: function () {
			editarFormVendasVisualizar();
			voltarBtn();
		},
		InitPrimeiraVenda: function () {
			initValidation();
			onClickAdicionarPrimeiraVenda('vendaForm');
			editarFormVendas();
			InitDatePicker();
			Inputmask("R$ 999.999.999,99", {
				"numericInput": true
			}).mask("#vendaValor");
			voltarBtn();

		},
		InitEditar: function () {
			initValidation('vendaForm');
			editarFormVendasVisualizar();
			InitDatePicker();
			Inputmask("R$ 999.999.999,99", {
				"numericInput": true
			}).mask("#vendaValor");
			voltarBtn();
			onClickEditar();
		},
		InitCopiar: function () {
			initValidation('vendaForm');
			editarFormVendasVisualizar();
			InitDatePicker();
			Inputmask("R$ 999.999.999,99", {
				"numericInput": true
			}).mask("#vendaValor");
			voltarBtn();
			onClickAdicionar();
		}
	
		
    }
}();
