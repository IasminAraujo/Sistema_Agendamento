﻿var idCategoria;

$(document).ready(function () {
    GetCategorias();
});

function GetCategorias() {
    $.getJSON('CategoriaServicos/GetCategorias').done(
        function (data) {
            var template = $('#TemplateTabelaCategoria').html();
            var rendered = Mustache.render(template, { Categoria: data });
            $('#CorpoTabelaCategoria').html(rendered);
        }
    );
}

$('[name=BtnNovaCategoria]').click(function () {
    $.get("/CategoriaServicos/Adicionar").done(function (ret) {
        $('#ModalCategoria').html(ret);
        $('.modal').modal('show');
    });
});

$('#CorpoTabelaCategoria').on('click', '[name=EditarCategoria]', function (e) {
    idCategoria = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/CategoriaServicos/Editar").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
        CarregarDadosEditarCategoria();
    });
});

function CarregarDadosEditarCategoria() {
    $.getJSON("CategoriaServicos/GetCategoriaById?id=" + idCategoria).done(function (dados) {
        $('[name=NomeCategoria]').val(dados.a005_nome);
    });
}

$('#CorpoTabelaCategoria').on('click', '[name=ExcluirCategoria]', function (e) {
    idCategoria = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/CategoriaServicos/Excluir").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
    });
});