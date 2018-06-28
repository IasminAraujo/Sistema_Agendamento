﻿var idPacote;
$(document).ready(function () {
    GetPacotes();
    console.log('hue');
});

function GetPacotes() {
    $.getJSON('PacoteServicos/GetPacotes').done(
        function (data) {
            var template = $('#TemplateTabelaPacotes').html();
            var rendered = Mustache.render(template, { Servico: data });
            $('#CorpoTabelaPacotes').html(rendered);
        }
    );
}

$('[name=BtnNovoPacote]').click(function () {
    $.get("/PacoteServicos/Adicionar").done(function (ret) {
        $('#ModalPacote').html(ret);
        GetCategorias();
        GetServicos();
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

function GetServicos() {
    $.getJSON('Servicos/GetServicos').done(function (ret) {
        console.log("lala");
        ret.forEach(function (v) {
            $('[name=Servicos]').append('<option id="' + v.a006_id + '">' + v.a006_nome + '</option>');
        });
    });
}