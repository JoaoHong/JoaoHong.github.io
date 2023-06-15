var OrcamentoAPI = function () {
    var urlAdicionar = "/Vendas/Orcamentos/AdicionarOrcamento/";
    var urlVendaIndex = "/Vendas/Orcamentos/Index/";
    var urlFinalizarOrcamento = "/Vendas/Orcamentos/FinalizarOrcamento/?id="
    var urlIndex = "/Vendas/Orcamentos/Index/"

    var onClickAdicionar = function () {
        $("#btnAddOrc").on("click", function (e) {
            
            Swal.fire({
                title: "Tem certeza?",
                html: "Realmente deseja adicionar esse orçamento?",
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
                    
                    $.ajax({
                        url: urlAdicionar,
                        type: 'GET',
                        success: function (data) {
                            Swal.fire({
                                title: data.title,
                                html: data.message,
                                icon: data.ok ? "success" : "error",
                                confirmButtonText: "Ok",
                                customClass: {
                                    confirmButton: "btn font-weigth-bold btn-primary"
                                }
                            }).then(function () {
                                if (data.ok) {
                                    window.location.href = urlVendaIndex;
                                }
                            })
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
                    });
                }
            })
            
        });
    }

    var onClickMudarStatus = function () {
        $(".btnFinalizar").on("click", function () {
            var id = $(this).attr("id");

            Swal.fire({
                title: 'Realmente deseja mudar o status do orçameto?',
                html: 'Uma vez mudado o status a troca podera ser feita apenas com o administrador do site.',
                icon: "warning",
                confirmButtonText: "Sim",
                showCancelButton: true,
                cancelButtonText: "Não",
                customClass: {
                    confirmButton: "btn font-weight-bold btn-primary",
                    cancelButton: "btn font-weight-bold btn-secondary"
                }
            }).then((result) => {
                if (result.isConfirmed) {

                    $.ajax({
                        url: urlFinalizarOrcamento + id,
                        type: 'GET',
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
                                    window.location.href = urlIndex;
                                }
                            });
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
        })
    }

    return {
        initIndex: function () {
            onClickAdicionar();
            onClickMudarStatus();
        }
    }
}();
