function aggiungiBacchetta(){
    let elencoBacchette = localStorage.getItem("bacchette") != null 
                            ? JSON.parse(localStorage.getItem("bacchette")) : [];
    
    let varMate = document.getElementById("Input-Materiale").value;                               //JQUERY
    let varNucl = document.getElementById("Input-Nucleo").value;
    let varLung = document.getElementById("Input-Lunghezza").value;
    let varResi = document.getElementById("Input-Resistenza").value;
    let varMago = document.getElementById("Input-NomeMago").value;
    let varCasa = document.getElementById("Input-Casata").value;
    let varLink = document.getElementById("Input-Link").value;


    let bacchetta = {
        materiale: varMate,
        nucleo: varNucl,
        lunghezza: varLung,
        resistenza: varResi,
        mago: varMago,
        casata: varCasa,
        link: varLink
    }

    elencoBacchette.push(bacchetta);
    localStorage.setItem("bacchette", JSON.stringify(elencoBacchette))
    
    location.href = "elencoBacchette.html"
}

