$('#ModalCategoria').on('click', '[name=BtnEditaCategoria]', function () {
    $('[name=SalvarEdicao]').click();
    $('.modal').modal('hide');
    console.log('log');
});

$('#ModalCategoria').on('submit', '#FormEditaCategoria', function (e) {
    e.preventDefault();
    var nomecategoria = $('[name=NomeCategoria]').val();
    var json = { A005_id: idCategoria, A005_nome: nomecategoria }
    $.ajax({
        url: 'CategoriaServicos/EditarCategoria',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetCategorias();
        }
    }).done();
});