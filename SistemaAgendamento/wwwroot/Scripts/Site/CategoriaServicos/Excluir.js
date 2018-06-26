$('#ModalCategoria').on('click', '[name=ExcluirCategoria]', function (e) {
    e.preventDefault();
    $.getJSON("CategoriaServicos/ExcluirCategoria?id=" + idCategoria).done(function (ret) {
        if (ret == "sucesso") {
            GetCategorias();
            $('.modal').modal('hide');
        }
    });
});