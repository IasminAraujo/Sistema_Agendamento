$('#ModalPacote').on('click', '[name = BtnAdicionaPacote]', function () {
    $('[name=SalvarPacote]').click();
    $('.modal').modal('hide');
});

$('#ModalPacote').on('submit', '#FormAdicionaPacote', function (e) {
    e.preventDefault();
    var categoria = $('[name=CategoriaServico]').find(':selected').attr('id');
    var servico = $('[name=Servico]').find(':selected').attr('id');
    var valorpacote = $('[name=ValorServico]').val();
    var quantidadeSessao = $('[name=TempoServico]').val();
    var json = { A006_nome: nomeservico, A006_valorsessao: valorservico, A006_tempoduracao: temposervico, A005_id: categoria }
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
