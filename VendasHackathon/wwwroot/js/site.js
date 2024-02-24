$(document).ready(function () {
    $('#tabela-formatada').DataTable();
});

$(document).ready(function () {
    $('#tabela-formatada').DataTable({
        language: {
            "decimal": "",
            "emptyTable": "Nenhum dado disponível.",
            "info": "Mostrando START para END de TOTAL resultados",
            "infoEmpty": "Mostrando 0 para 0 de 0 resultados",
            "infoFiltered": "(filtrado de MAX resultados totais)",
            "infoPostFix": "",
            "thousands": ",",
            "lengthMenu": "Mostrar MENU resultados",
            "loadingRecords": "Carregando...",
            "processing": "",
            "search": "Buscar:",
            "zeroRecords": "Não foram encontrados resultados correspondentes",
            "paginate": {
                "first": "Primeira",
                "last": "Última",
                "next": "Próxima",
                "previous": "Anterior"
            },
            "aria": {
                "orderable": "Ordene por essa coluna",
                "orderableReverse": "Ordem inversa por essa coluna"
            }
        }
    });