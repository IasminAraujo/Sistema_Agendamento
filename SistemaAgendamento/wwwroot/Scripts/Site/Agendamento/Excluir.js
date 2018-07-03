$('#ModalAgendamento').on('click', '[name=ExcluirAgendamento]', function (e) {
    e.preventDefault();
    $.getJSON("Agendamento/ExcluirAgendamento?id=" + idAgendamento).done(function (ret) {
        if (ret == "sucesso") {
            GetAgendamentos();
            $('.modal').modal('hide');
        }
    });
});