// - Codice
//             - Materiale
//             - Nucleo
//             - Lunghezza
//             - Resistenza
//             - Nome del mago proprietario
//             - Se presente scegliere tra la casata ( select con il NOME della casata) - Ambito di utilizzo
//             - Foto (link)

function stampaBacchette(){
    console.log("Invocato Stampa")
    debugger   ;
    let elencoBacchette = localStorage.getItem("bacchette") != null 
                            ? JSON.parse(localStorage.getItem("bacchette")) : [];

    let contenitore = "";
    for(let [idx, item] of elencoBacchette.entries()){
        contenitore += `
            <tr>
                <td>${idx + 1}</td>
                <td>${item.materiale}</td>
                <td>${item.nucleo}</td>
                <td>${item.lunghezza}</td>
                <td>${item.resistenza}</td>
                <td>${item.mago}</td>
                <td>${item.casata}</td>
                <td><a href=${item.link}>Foto</a></td>
             
                
            </tr>
        `;
    }
    document.getElementById("corpo-tabella").innerHTML = contenitore;
}

// function elimina(indice){
//     let elencoBacchette = localStorage.getItem("bacchette") != null 
//                             ? JSON.parse(localStorage.getItem("bacchette")) : [];

//     elencoBacchette.splice(indice, 1);

//     localStorage.setItem("bacchette", JSON.stringify(elencoBacchette))
//     stampaBacchette();
// }

// function modifica(indice){
//     $("#modaleModifica").modal('show');
//     $("#btn-salva").data('identif', indice);

//     let elencoBacchette = localStorage.getItem("bacchette") != null 
//                             ? JSON.parse(localStorage.getItem("bacchette")) : [];

//     for(let [idx, item] of elencoBacchette.entries()){
//         if(indice == idx){
//             $("#input-nome").val(item.nome);                                //Notazione JQuery
//             document.getElementById("input-cognome").value = item.cognome;
//             document.getElementById("input-matricola").value = item.matr;
//         }
//     }
// }

// function salva(varBottone){

//     let posizione = $(varBottone).data('identif')
//     let varNome = document.getElementById("input-nome").value;
//     let varCogn = document.getElementById("input-cognome").value;
//     let varMatr = document.getElementById("input-matricola").value;

//     let elencoBacchette = localStorage.getItem("bacchette") != null 
//                             ? JSON.parse(localStorage.getItem("bacchette")) : [];

//     for(let [idx, item] of elencoBacchette.entries()){
//         if(idx == posizione){
//             item.nome = varNome;
//             item.cognome = varCogn;
//             item.matr = varMatr;

//             localStorage.setItem("bacchette", JSON.stringify(elencoBacchette));
//             stampaBacchette();
//             $("#modaleModifica").modal('hide');
//             return;
//         }
//     }
// }

stampaBacchette();