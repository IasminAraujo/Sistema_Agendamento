$('#ModalCliente').on('click', '[name=ExcluirCliente]', function (e) {
    e.preventDefault();
    $.getJSON("Clientes/ExcluirCliente?id=" + idCliente).done(function (ret) {
        if (ret == "sucesso") {
            GetClientes();
            $('.modal').modal('hide');
        }
    });
});