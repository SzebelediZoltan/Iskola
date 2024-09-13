const products = [
    {
        name: "Televízió",
        price: 80000,
        category: "Elektronika"
    },
    {
        name: "Hűtőszekrény",
        price: 120000,
        category: "Háztartási gépek"
    },
    {
        name: "Mosógép",
        price: 100000,
        category: "Háztartási gépek"
    },
    { 
        name: "Laptop",
        price: 150000,
        category: "Elektronika"
    },
    {
        name: "Kávéfőző",
        price: 25000,
        category: "Konyhai eszközök"
    }
];

function legkissebb(products) {
    let min = Infinity
    let termek = products[0].name
    for (const elem of products) {
        if (elem.price < min) {
            min = elem.price
            termek = elem.name
        }
    }
    return termek
}

console.log(`A legolcsóbb termék: ${legkissebb(products)}`);

countABPairs("abba") === 1; countABPairs("abaabaaabaaaa") === 3;
countABPairs("baba") === 1; countABPairs("ababba") === 2;
countABPairs("bbaa") === 0

function countABPairs(szoveg) {
    let elindult = false
    let db = 0
    for (const betu of szoveg) {
        if (betu === "a") {
            elindult = true
        } else if (betu === "b" && elindult) {
            db++
            elindult = false
        } else {
            elindult = false
        }
    }

    console.log(db);
    
}

const abc = ['a', 'á', 'b', 'c', 'd', 'e', 'é', 'f', 'g', 'h', 'i', 'í', 'j', 'k', 'l', 'm', 'n', 'o', 'ó', 'ö', 'ő', 'p', 'q', 'r', 's', 't', 'u', 'ú', 'ü', 'ű', 'v', 'w', 'x', 'y', 'z'];

function keres(c) {
    let i = 0;
    while (i < abc.length && abc[i] !== c) {
        i++;
    }
    return i;
}

function hasonlit(a, b) {
    let i = 0;
    while (i < a.length && i < b.length && a[i] === b[i]) {
        i++;
    }

    // edge case (szélsőséges eset)
    if (i >= a.length && i >= b.length) return 0;
    else if (i >= a.length) return -1;
    else if (i >= b.length) return 1;

    let elso = keres(a[i]);
    let masodik = keres(b[i]);
    return elso < masodik ? -1 : 1;
}

function solveQuadratic(a, b, c) {
    const D = b*b - 4*a*c;
    if (D < 0) {
        return {}
    } else if (D === 0) {
        return {x: -b/(2*a)}
    } else {
        return {
            x1: (-b+Math.sqrt(D))/(2*a),
             x2:(-b-Math.sqrt(D))/(2*a)
            }
    }
}

