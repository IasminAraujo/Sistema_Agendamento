$('#ModalAgendamento').on('click', '[name=BtnRemarcaCliente]', function () {
    $('[name=SalvarAgendamento]').click();
    $('.modal').modal('hide');
});

$('#ModalAgendamento').on('submit', '#FormRemarcar', function (e) {
    e.preventDefault();
    var data = $('[name=Data]').val();
    if (data != null) {
        data = data.split('/').reverse().join('/').replace('/', '-').replace('/', '-');
    }
    var json = { A009_id: idAgendamento, A009_data: data }
    $.ajax({
        url: 'Agendamento/RemarcarAgendamento',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetAgendamentos();
        }
    }).done();
});