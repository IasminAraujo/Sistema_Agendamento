$('#ModalPacote').on('click', '[name = BtnAdicionaPacote]', function () {
    $('[name=SalvarPacote]').click();
    $('.modal').modal('hide');
});

$('#ModalPacote').on('submit', '#FormAdicionaPacote', function (e) {
    e.preventDefault();
    var categoria = $('[name=CategoriaServico]').find(':selected').attr('id');
    var servico = $('[name=Servicos]').find(':selected').attr('id');
    var valorpacote = $('[name=ValorPacote]').val();
    var quantidadeSessoes = $('[name=QuantidadeSessoes]').val();
    var json = { A007_quantsessao: quantidadeSessoes, A007_valorpacote: valorpacote, A006_id: servico, A005_id: categoria }
    $.ajax({
        url: 'PacoteServicos/AdicionaPacote',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetPacotes();
        }
    });
});
