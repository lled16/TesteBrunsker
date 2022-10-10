const botaoCadastra = document.getElementById('botaoCadastra');

function cadastraImovel (){
    var nome = document.querySelector('#nome').value;
    var valor = document.querySelector('#valor').value;
    var rua = document.querySelector('#rua').value;
    var bairro = document.querySelector('#bairro').value;
    var numero = document.querySelector('#numero').value;
    var cidade = document.querySelector('#cidade').value;
    var estado = document.querySelector('#estado').value;
    var qtdQuartos = document.querySelector('#qtdQuartos').value;
    var qtdBanheiros = document.querySelector('#qtdBanheiros').value;
    var infoAdc = document.querySelector('#infoAdc').value;

    var registra = 
            cadImovel("https://localhost:7183/CadastraImvl?nome=" + nome + 
            "&valor=" + valor +
            "&rua=" + rua + 
            "&bairro=" + bairro +
            "&numero=" + numero +
            "&cidade=" + cidade +
            "&estado=" + estado +
            "&qtdQuartos=" + qtdQuartos +
            "&qtdBanheiros=" + qtdBanheiros +
            "&infoAdc=" + infoAdc
            );

            window.location.href = 'index.html';

}
function cadImovel(url) {
    let request = new XMLHttpRequest();
    request.open("POST", url, false);
    request.send();
    return request.responseText;


}