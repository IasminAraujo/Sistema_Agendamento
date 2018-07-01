var idColaborador;

$(document).ready(function () {
    GetColaboradores();
    console.log('kçç');
});

function GetColaboradores() {
    $.getJSON('Colaboradores/GetColaboradores').done(
        function (data) {
            var template = $('#TemplateTabelaColaboradores').html();
            var rendered = Mustache.render(template, { Colaborador: data });
            $('#CorpoTabelaColaboradores').html(rendered);
        }
    );
}

$('[name=BtnNovoColaborador]').click(function () {
    $.get("/Colaboradores/Adicionar").done(function (ret) {
        $('#ModalColaborador').html(ret);
        $('.modal').modal('show');
    });
});

$('#CorpoTabelaColaboradores').on('click', '[name=EditarColaborador]', function (e) {
    idColaborador = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Colaboradores/Editar").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
        CarregarDadosEditarColaborador();
    });
});

function CarregarDadosEditarColaborador() {
    $.getJSON("Colaboradores/GetColaboradorById?id=" + idColaborador).done(function (dados) {
        $('[name=NomeColaboradorEditar]').val(dados.a003_nome);
        $('[name=NumTelefoneColaboradorEditar]').val(dados.a003_telefone);
        $('[name=EmailColaboradorEditar]').val(dados.a003_email);
        $('[name=RuaEditar]').val(dados.a003_endereco);
    });
}

$('#CorpoTabelaColaboradores').on('click', '[name=ExcluirColaborador]', function (e) {
    idColaborador = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Colaboradores/Excluir").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
    });
});