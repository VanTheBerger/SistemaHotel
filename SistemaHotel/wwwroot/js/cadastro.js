


//function atualizarCadastro(cadastro) {
//    $("input, textarea").blur();
//    FormData.append("json", JSON.stringify(cadastro));
//    $.ajax({
//        url: `${urlBase}api/cadastro`,
//        type: 'PUT',
//        async: true,
//        data: FormData,
//        processData: false,
//        contentType: false,
//        success: async (retorno) => {
//            toastr.success("Cadastro atualizado com sucesso!");
//        }
//    });
//}

//async function ativarModoEdicao(id) {
//    let cadastro = await requisicaoCadastro(urlBase + "api/cadastro" + id);
//    $("#idCadastro").attr('value', id);


//    $("#novo-cadastro .modal-header").addClass("bg-dark");
//    $("#novo-cadastro .modal-footer").addClass("bg-dark");
//    $("#novo-cadastro .modal-content").addClass("")

  

//}



//async function requisicaoCadastro(url, options) {
//    const response = await fetch(`${url}`, options);
//    const json = await response.json();
//    return json.data;
//}
