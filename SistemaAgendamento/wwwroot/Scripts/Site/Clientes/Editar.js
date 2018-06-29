$('#ModalCliente').on('click', '[name=BtnEditaCliente]', function () {
    $('[name=SalvarAlteracoesCliente]').click();
    $('.modal').modal('hide');
    console.log('kkk');
});

$('#ModalCliente').on('submit', '#FormEditaCliente', function (e) {
    e.preventDefault();
    var nome = $('[name=NomeClienteEditar]').val();
    var email = $('[name=EmailClienteEditar]').val();
    var telefone = $('[name=NumTelefoneClienteEditar]').val();
    var endereco = $('[name=RuaEditar]').val();
    var json = { A004_id: idCliente, A004_nome: nome, A004_email: email, A004_telefone: telefone, A004_endereco: endereco }
    $.ajax({
        url: 'Clientes/EditarCliente',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetClientes();
        }
    }).done();
});