function aggiungiCasata(){
    let elencoCasate = localStorage.getItem("casate") != null 
                            ? JSON.parse(localStorage.getItem("casate")) : [];
    
    let varCasa = document.getElementById("Input-nome-casata").value;                               //JQUERY
    let vardesc = document.getElementById("Input-descrizione").value;
    let varlogo = document.getElementById("Input-logo").value;



    let casata = {
        casata: varCasa,
        descrizione: vardesc,
        logo: varlogo
    }

    elencoCasate.push(casata);
    localStorage.setItem("casate", JSON.stringify(elencoCasate))
    
    location.href = "casate.html"
}