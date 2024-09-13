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