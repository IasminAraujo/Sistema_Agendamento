$('#ModalColaborador').on('click', '[name = BtnAdicionaColaborador]', function () {
    $('[name=SalvarColaborador]').click();
    $('.modal').modal('hide');
});

$('#ModalColaborador').on('submit', '#FormAdicionaColaborador', function (e) {
    e.preventDefault();
    var nomecolaborador = $('[name=NomeColaborador]').val();
    var telcolaborador = $('[name=NumTelefoneColaborador]').val();
    var emailcolaborador = $('[name=EmailColaborador]').val();
    var endcolaborador = $('[name=Rua]').val();
    var json = { A003_nome: nomecolaborador, A003_email: emailcolaborador, A003_endereco: endcolaborador, A003_telefone: telcolaborador }
    $.ajax({
        url: 'Colaboradores/AdicionaColaborador',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetColaboradores();
        }
    });
});