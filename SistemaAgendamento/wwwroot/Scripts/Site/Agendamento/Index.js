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
            console.log(data);
        }
    );
}