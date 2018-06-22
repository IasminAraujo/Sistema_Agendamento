$('#ModalServico').on('click', '[name = BtnAdicionaServico]', function () {
    $('[name=SalvarServico]').click();
    $('.modal').modal('hide');
});

$('#ModalServico').on('submit', '#FormAdicionaServico', function (e) {
    e.preventDefault();
    var categoria = $('[name=CategoriaServico]').find(':selected').attr('id');
    var nomeservico = $('[name=NomeServico]').val();
    var valorservico = $('[name=ValorServico]').val();
    var temposervico = $('[name=TempoServico]').val();
    var json = { A006_nome: nomeservico, A006_valorsessao: valorservico, A006_tempoduracao: temposervico, A005_id: categoria }
    $.ajax({
        url: 'Servicos/AdicionaServico',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetServicos();
        }
    });
});
