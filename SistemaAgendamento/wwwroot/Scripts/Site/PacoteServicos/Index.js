var idPacote;
$(document).ready(function () {
    GetPacotes();
});

function GetPacotes() {
    $.getJSON('PacoteServicos/GetPacotes').done(
        function (data) {
            var template = $('#TemplateTabelaPacotes').html();
            var rendered = Mustache.render(template, { Pacote: data });
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
        ret.forEach(function (v) {
            $('[name=Servicos]').append('<option id="' + v.a006_id + '">' + v.a006_nome + '</option>');
        });
    });
}

$('#CorpoTabelaPacotes').on('click', '[name=EditarPacote]', function (e) {
    idPacote = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/PacoteServicos/Editar").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
        CarregarDadosEditarPacote();
    });
});

function CarregarDadosEditarPacote() {
    $.getJSON("PacoteServicos/GetPacoteById?id=" + idPacote).done(function (dados) {
        GetCategorias();
        GetServicos();
        $('[name=CategoriaServico]').val(dados.a005_id);
        $('[name=Servicos]').val(dados.a006_id);
        $('[name=QuantidadeSessoesEditar]').val(dados.a007_quantsessao);
        $('[name=ValorPacoteEditar]').val(dados.a007_valorpacote);
    });
}

$('#CorpoTabelaPacotes').on('click', '[name=ExcluirPacote]', function (e) {
    idPacote = $($(this).parent().parent().find("td")[0]).attr('id');
    $.get("/PacoteServicos/Excluir").done(function (ret) {
        $('.modal-content').html(ret);
        $('.modal').modal('show');
    });
});