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
