$('#ModalServico').on('click', '[name = BtnAdicionaServico]', function () {
    $('[name=SalvarServico]').click();
    $('.modal').modal('hide');
});

$('#ModalServico').on('submit', '#FormAdicionaServico', function (e) {
    e.preventDefault();
    var nomecategoria = $('[name=NomeCategoria]').find(':selected').attr('id');
    var nomeservico = $('[name=NomeServico]').val();
    var valorservico = $('[name=ValorServico]').val();
    var temposervico = $('[name=TempoServico]').val();
    var json = { A005_nome: nomecategoria }
    $.ajax({
        url: 'Servicos/AdicionaServico',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetCategorias();
        }
    });
});