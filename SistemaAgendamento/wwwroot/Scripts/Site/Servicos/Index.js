var idServico;

$(document).ready(function () {
    GetServicos();
});

function GetServicos() {
    $.getJSON('Servicos/GetServicos').done(
        function (data) {
            var template = $('#TemplateTabelaServicos').html();
            var rendered = Mustache.render(template, { Servico: data });
            $('#CorpoTabelaServicos').html(rendered);
        }
    );
}

$('[name=BtnNovoServico]').click(function () {
    $.get("/Servicos/Adicionar").done(function (ret) {
        $('#ModalServico').html(ret);
        GetCategorias();
        $('.modal').modal('show');
    });
});

function GetCategorias() {
    $.getJSON('CategoriaServicos/GetCategorias').done(function (ret) {
        ret.forEach(function (v) {
            $('[name=CategoriaServico]').append('<option id="' + v.a005_id + '">' + v.a005_nome + '</option>');
        });
    });
}

$('#CorpoTabelaServicos').on('click', '[name=EditarServico]', function (e) {
    idServico = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/Servicos/Editar").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
        CarregarDadosEditarServico();
    });
});

function CarregarDadosEditarServico() {
    $.getJSON("Servicos/GetServicoById?id=" + idServico).done(function (dados) {
        GetCategorias();
        $('[name=NomeServicoEditar]').val(dados.a006_nome);
        $('[name=ValorServicoEditar]').val(dados.a006_valorsessao);
        $('[name=TempoServicoEditar]').val(dados.a006_tempoduracao);
    });
}
