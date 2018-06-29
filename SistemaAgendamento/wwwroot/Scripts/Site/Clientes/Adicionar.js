$('#ModalCliente').on('click', '[name = BtnAdicionaCliente]', function () {
    $('[name=SalvarCliente]').click();
    $('.modal').modal('hide');
    console.log('jjj');
});

$('#ModalCliente').on('submit', '#FormAdicionaCliente', function (e) {
    e.preventDefault();
    var nomecliente = $('[name=NomeCliente]').val();
    var telcliente = $('[name=NumTelefoneCliente]').val();
    var emailcliente = $('[name=EmailCliente]').val();
    var endcliente = $('[name=Rua]').val();
    var json = { A004_nome: nomecliente, A004_email: emailcliente, A004_endereco: endcliente, A004_telefone: telcliente }
    $.ajax({
        url: 'Clientes/AdicionaCliente',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetClientes();
        }
    });
});