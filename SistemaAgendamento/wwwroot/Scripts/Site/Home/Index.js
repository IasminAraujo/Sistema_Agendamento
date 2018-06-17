$(document).ready(function () {
    $.get("/CategoriaServicos").done(function (ret) {
        $('.ConteudoSite').html(ret);
    });
});

function Navegar(pagina) {
    $.get("/" + pagina).done(function (ret) {
        $('.ConteudoSite').html(ret);
    });
}