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

$('#CorpoTabelaClientes').on('click', '[name=EditarCliente]', function (e) {
    idCliente = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Clientes/Editar").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
        CarregarDadosEditarCliente();
    });
});

function CarregarDadosEditarCliente() {
    $.getJSON("Clientes/GetClienteById?id=" + idCliente).done(function (dados) {
        $('[name=NomeClienteEditar]').val(dados.a004_nome);
        $('[name=NumTelefoneClienteEditar]').val(dados.a004_telefone);
        $('[name=EmailClienteEditar]').val(dados.a004_email);
        $('[name=RuaEditar]').val(dados.a004_endereco);
    });
}

$('#CorpoTabelaClientes').on('click', '[name=ExcluirCliente]', function (e) {
    idCliente = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Clientes/Excluir").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
    });
});

$('#CorpoTabelaClientes').on('click', '[name=AgendarCliente]', function (e) {
    idCliente = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Clientes/Agendar").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
    });
});