const telepulesek = [
    {nev: "Cegléd", csapadek: 6},
    {nev: "Albertirsa", csapadek: 5},
    {nev: "Debrecen", csapadek: 7},
    {nev: "Szeged", csapadek: 8},
    {nev: "Veszprém", csapadek: 4},
    {nev: "Pilis", csapadek: 3},
    {nev: "Kecskemét", csapadek: 6},
    {nev: "Budapest", csapadek: 7},
    {nev: "Szolnok", csapadek: 5},
    {nev: "Pécs", csapadek: 6},
    {nev: "Abony", csapadek: 4}
];

const szavazas = {
    igen: 73,
    nem: 408
};



// F1

const gen = document.querySelector("#generalas")
gen.addEventListener("click", () => {
    const select = document.querySelector("select")
    for (let i = 0; i < 9; i+=2) {
        const option = document.createElement("option")
        option.innerText = `${i} - ${i+1}`
        select.appendChild(option)
    }
    select.style.display = "inline"
    gen.disabled = true
})



// F2
function listaGeneralas(also, felso) {
    const ul = document.createElement("ul")
    for (const telepules of telepulesek) {
        if(telepules.csapadek <= felso && telepules.csapadek >= also) {
            const li = document.createElement("li")
            li.innerText = `${telepules.nev}: ${telepules.csapadek} mm`
            ul.appendChild(li)
        }
    }

    return ul
}

const select = document.querySelector("select")
select.addEventListener("change", () => {
    const telep = document.querySelector("#telepulesek")
    telep.innerHTML = ""
    const ertekek = select.value.split(" ")
    document.querySelector("#telepulesek").appendChild(listaGeneralas(ertekek[0], ertekek[2]))
})




// F3
function keres(nev) {
    let i = 0
}



// F4




// F5




// F6




// F7 - Részben kitekintés



