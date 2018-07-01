$('#ModalColaborador').on('click', '[name=BtnEditaColaborador]', function () {
    $('[name=SalvarAlteracoesColaborador]').click();
    $('.modal').modal('hide');
});

$('#ModalColaborador').on('submit', '#FormEditaColaborador', function (e) {
    e.preventDefault();
    var nome = $('[name=NomeColaboradorEditar]').val();
    var email = $('[name=EmailColaboradorEditar]').val();
    var telefone = $('[name=NumTelefoneColaboradorEditar]').val();
    var endereco = $('[name=RuaEditar]').val();
    var json = { A003_id: idColaborador, A003_nome: nome, A003_email: email, A003_telefone: telefone, A003_endereco: endereco }
    $.ajax({
        url: 'Colaboradores/EditarColaborador',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetColaboradores();
        }
    }).done();
});