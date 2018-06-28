$('#ModalPacote').on('click', '[name=ExcluirPacote]', function (e) {
    e.preventDefault();
    $.getJSON("PacoteServicos/ExcluirPacote?id=" + idPacote).done(function (ret) {
        if (ret == "sucesso") {
            GetPacotes();
            $('.modal').modal('hide');
        }
    });
});