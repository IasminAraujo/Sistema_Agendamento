$('#ModalServico').on('click', '[name=ExcluirServico]', function (e) {
    e.preventDefault();
    $.getJSON("Servicos/ExcluirServico?id=" + idServico).done(function (ret) {
        if (ret == "sucesso") {
            GetServicos();
            $('.modal').modal('hide');
        }
    });
});