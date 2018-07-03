var idAgendamento;

$(document).ready(function () {
    GetAgendamentos();
});

function GetAgendamentos() {
    $.getJSON('Agendamento/GetAgendamentos').done(
        function (data) {
            var template = $('#TemplateTabelaAgendamentos').html();
            var rendered = Mustache.render(template, { Agendamento: data });
            $('#CorpoTabelaAgendamento').html(rendered);
        }
    );
}

$('#CorpoTabelaAgendamento').on('click', '[name=ExcluirAgendamento]', function (e) {
    idAgendamento = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Agendamento/Excluir").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
    });
});