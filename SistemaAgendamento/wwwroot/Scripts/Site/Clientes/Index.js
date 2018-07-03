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
        GetNomeCliente();
        GetColaboradores();
        GetCategorias();
        GetServicos();
        $('.modal').modal('show');
    });
});

function GetColaboradores() {
    $.getJSON('Colaboradores/GetColaboradores').done(function (ret) {
        ret.forEach(function (v) {
            $('[name=Colaboradores]').append('<option id="' + v.a003_id + '">' + v.a003_nome + '</option>');
        });
    });
}

function GetNomeCliente() {
    $.getJSON("Clientes/GetClienteById?id=" + idCliente)
        .done(function (cli) {
            $('#myModalLabel').html('Agendamento para: ' + cli.a004_nome);
        });
}

function GetCategorias() {
    $.getJSON('CategoriaServicos/GetCategorias').done(function (ret) {
        ret.forEach(function (v) {
            $('[name=CategoriaServico]').append('<option id="' + v.a005_id + '">' + v.a005_nome + '</option>');
        });
    });
}

function GetServicos() {
    $.getJSON('Servicos/GetServicos').done(function (ret) {
        ret.forEach(function (v) {
            $('[name=Servicos]').append('<option id="' + v.a006_id + '">' + v.a006_nome + '</option>');
        });
    });
}