$(document).ready(function () {
    $.get("/Agendamento").done(function (ret) {
        $('.ConteudoSite').html(ret);
    });
});

function Navegar(pagina) {
    $.get("/" + pagina).done(function (ret) {
        $('.ConteudoSite').html(ret);
    });
}