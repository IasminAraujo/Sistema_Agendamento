$('#ModalCliente').on('click', '[name = BtnAgendaCliente]', function () {
    $('[name=SalvarAgendamento]').click();
    $('.modal').modal('hide');
    console.log('passou');
});

$('#ModalCliente').on('submit', '#FormAgendaCliente', function (e) {
    e.preventDefault();
    var colaborador = $('[name=Colaboradores]').find(':selected').attr('id');
    var categoria = $('[name=CategoriaServico]').find(':selected').attr('id');
    var servico = $('[name=Servicos]').find(':selected').attr('id');
    var data = $('[name=Data]').val();
    if (data != null) {
        data = data.split('/').reverse().join('/').replace('/', '-').replace('/', '-');
    }
    var json = { A004_id: idCliente, A003_id: colaborador, A006_id: servico, A005_id: categoria, A009_data: data }
    $.ajax({
        url: 'Agendamento/AgendarCliente',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetAgendamentos();
        }
    });
});
