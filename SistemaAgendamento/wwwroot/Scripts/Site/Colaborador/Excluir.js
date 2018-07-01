$('#ModalColaborador').on('click', '[name=ExcluirColaborador]', function (e) {
    e.preventDefault();
    $.getJSON("Colaboradores/ExcluirColaborador?id=" + idColaborador).done(function (ret) {
        if (ret == "sucesso") {
            GetColaboradores();
            $('.modal').modal('hide');
        }
    });
});