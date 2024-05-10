// F1
function beolvas(termekek) {
    const elemek = document.querySelectorAll("ul li");
    for (const li of elemek) {
        const adatok = li.innerText.split(" - ");
        const termek = {
            nev: adatok[0],
            ar: parseInt(adatok[1])
        };
        termekek.push(termek)
    }
}



// F2
function osszesAr(termekek) {
    let osszeg = 0;
    for (const elem of termekek) {
        osszeg += elem.ar;
    }

    document.querySelector("#koltseg").innerText = osszeg
}



// F3
function kerekAr(termekek) {
    const hely = document.querySelector("#nulla")
    if (kerekE(termekek)) {
        hely.innerText += " Igen"
    } else {
        hely.innerText += " Nem"
    }
}

function kerekE(termekek) {
    for (const elem of termekek) {
        if (elem.ar[elem.length-1] === "0") {
            return true
        }
    }
}



// F4
function dragak(termekek) {
    for (const iterator of object) {
        
    }
}


// F5
function legdragabb(termekek) {
    const hely = document.querySelector("#legdragabb")
    let maxi = 0
    for (let i = 1; i < termekek.length; i++) {
        if (termekek[i].ar > termekek[maxi].ar) {
            maxi = i
        }
    }

    hely.innerText += " " + termekek[maxi].nev
}




// F6




// F7




// F8




// F9




function bevasarlo(termekek) {
    beolvas(termekek);
    osszesAr(termekek);
    kerekAr(termekek);
    legdragabb(termekek);
    dragak();
    diagram(termekek);
}

// Termékek listája:
/*
termekek = [
    {
        nev: "Sajt",
        ar: 2849
    },
    {
        nev: "Szalonna",
        ar: 1637
    },
    ...
]
*/
function main() {
    const termekek = [];
    const kepek = ["sajt", "kave", "tejfol"];
    bevasarlo(termekek);
    kepekBeszuras(kepek);
    hivatkozasok();
}

main()
