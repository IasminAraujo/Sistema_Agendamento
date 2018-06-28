$('#ModalPacote').on('click', '[name=BtnEditaPacote]', function () {
    $('[name=SalvarAlteracoesPacote]').click();
    $('.modal').modal('hide');
});

$('#ModalPacote').on('submit', '#FormEditaPacote', function (e) {
    e.preventDefault();
    var categoria = $('[name=CategoriaServico]').find(':selected').attr('id');
    var servico = $('[name=Servicos]').find(':selected').attr('id');
    var quantidadesessao = $('[name=QuantidadeSessoesEditar]').val();
    var valorpacote = $('[name=ValorPacoteEditar]').val();
    var json = { A007_id: idPacote, A007_quantsessao: quantidadesessao, A007_valorpacote: valorpacote, A005_id: categoria, A006_id: servico }
    $.ajax({
        url: 'PacoteServicos/EditarPacote',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetPacotes();
        }
    }).done();
});