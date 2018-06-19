$('#ModalCategoria').on('click', '[name = BtnAdicionaCategoria]',function () {
    $('[name=SalvarCategoria]').click();
    $('.modal').modal('hide');
});

$('#ModalCategoria').on('submit', '#FormAdicionaCategoria',function (e) {
    e.preventDefault();
    var nomecategoria = $('[name=NomeCategoria]').val();
    var json = { A005_nome: nomecategoria }
    $.ajax({
        url: 'CategoriaServicos/AdicionaCategoria',
        contentType: 'application/json',
        method: 'POST',
        data: JSON.stringify(json),
        success: function (data) {
            GetCategorias();
        }
    });
});