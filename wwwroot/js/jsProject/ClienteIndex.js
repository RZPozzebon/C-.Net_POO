function TrocarDados() {
    var nome1 = document.getElementById("nome1").value;
    document.getElementById("Nome2").value = nome1;
}

// Salvar dados 
$('btnSalvar').click(function () {
    var cliente = {
        Id: 1,
        Nome: $("nomeCliente".value),
        Cpf: $("cpfCliente").value,
    };

    $.ajax({
        type: "POST",
        url: '/Cliente/SalvarClienteAjax',
        data: JSON.stringify(cliente),
        contentType: "application/json; charset=utf-8",
        success: function (response) {
            alert('Cliente salvo com sucesso!');
        },
        error: function () {
            alert('Erro ao salvar cliente');
        }
    });
})


