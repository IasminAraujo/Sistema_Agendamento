var idCliente;

$(document).ready(function () {
    GetClientes();
});

function GetClientes() {
    $.getJSON('Clientes/GetClientes').done(
        function (data) {
            var template = $('#TemplateTabelaClientes').html();
            var rendered = Mustache.render(template, { Cliente: data });
            $('#CorpoTabelaClientes').html(rendered);
        }
    );
}

$('[name=BtnNovoCliente]').click(function () {
    $.get("/Clientes/Adicionar").done(function (ret) {
        $('#ModalCliente').html(ret);
        $('.modal').modal('show');
    });
});