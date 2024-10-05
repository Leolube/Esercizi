function stampaCasate(){
    console.log("Invocato Stampa")
    debugger   ;
    let elencoCasate = localStorage.getItem("casate") != null 
                            ? JSON.parse(localStorage.getItem("casate")) : [];

    let contenitore = "";
    for(let [idx, item] of elencoCasate.entries()){
        contenitore += `
            <tr>
                <td>${idx + 1}</td>
                <td>${item.casata}</td>
                <td>${item.descrizione}</td>
                <td><a href=${item.logo}>Foto</a></td>
                <td>${item.bacchette}</td>
             
                
            </tr>
        `;
    }
    document.getElementById("corpo-tabella").innerHTML = contenitore;
}

stampaCasate();

function caricaCasate(){
    let nomeCasate = localStorage.getItem("nCasate") != null ? JSON.parse(localStorage.getItem("nCasate")) : [];
    let cont = "";

    for(let [item] of nomeCasate.entries()){
        cont += `
                    <option>${item.casata}</option>
                            
                            `;
    }
    document.getElementById("Input-Casata").innerHTML = cont;
}

caricaCasate();