 async function abreTelaVerImoveis() {

    let response = await fetch(`https://localhost:7183/CadastraImvl?`);
    let userData = await response.json();
    console.log(userData[0].nome);



    let tbody = document.getElementById("tbody");
    tbody.innerText = '';

    if (userData.length > 0) {

        for (var i = 0; i < userData.length; i++) {
            let tr = tbody.insertRow();

            let td_nome = tr.insertCell();
            let td_endereco = tr.insertCell();
            let td_valor = tr.insertCell();
            let td_qtdQuartos = tr.insertCell();
            let td_qtdBanheiros = tr.insertCell();
            let td_disponibilidade = tr.insertCell();
            let td_edita = tr.insertCell();
            const btnModal = document.createElement("button");
            btnModal.innerHTML = "Editar";
            btnModal.setAttribute("data-bs-toggle", "modal");
            btnModal.setAttribute("class", "btn btn-primary");
            btnModal.setAttribute("data-bs-target", "#exampleModal");
            btnModal.setAttribute("data-bs-target", "#exampleModal");
            btnModal.setAttribute("data-bs-whatever", "@getbootstrap");

            td_nome.innerText = userData[i].nome;
            td_endereco.innerText = userData[i].endereco;
            td_valor.innerText = userData[i].valorAluguel;
            td_qtdQuartos.innerText = userData[i].qtdQuartos;
            td_qtdBanheiros.innerText = userData[i].qtdBanheiros;
            td_disponibilidade.innerText = userData[i].disponibilidade;
            td_edita.appendChild(btnModal);

        }
    }

}


function atualizaImovel (){
    
}

