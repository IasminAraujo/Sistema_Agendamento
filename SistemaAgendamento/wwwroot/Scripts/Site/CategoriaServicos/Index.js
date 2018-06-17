$(document).ready(function () {
    GetCategorias();
});

function GetCategorias() {
    $.getJSON('CategoriaServicos/GetCategorias').done(
        function (data) {
            var template = $('#TemplateTabelaCategoria').html();
            var rendered = Mustache.render(template, { Categoria: data });
            $('#CorpoTabelaCategoria').html(rendered);
            console.log('passou aqui');
        }
    );
}

$('#BtnNovaCategoria').click(function () {
    $.get("/CategoriaServicos/Adicionar").done(function (ret) {
        $('#ModalCategoria').html(ret);
        $('.modal').modal('show');
    });
});