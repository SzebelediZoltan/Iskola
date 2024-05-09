// F1




// F2




// F3




// F4




// F5




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
