$('#ModalServico').on('click', '[name=BtnEditaServico]', function () {
    $('[name=SalvarAlteracoesServico]').click();
    $('.modal').modal('hide');
    console.log('lll');
});

$('#ModalServico').on('submit', '#FormEditaServico', function (e) {
    e.preventDefault();
    var categoria = $('[name=CategoriaServico]').find(':selected').attr('id');
    var nomeservico = $('[name=NomeServicoEditar]').val();
    var valorservico = $('[name=ValorServicoEditar]').val();
    var temposervico = $('[name=TempoServicoEditar]').val();
    var json = { A006_id: idServico, A006_nome: nomeservico, A006_valorsessao: valorservico, A006_tempoduracao: temposervico, A005_id: categoria }
    $.ajax({
        url: 'Servicos/EditarServico',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetServicos();
        }
    }).done();
});