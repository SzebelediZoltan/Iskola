const x = [2, 6, 5, 1, 6, -2, 12, -1, 12, 6, -5, 7]; // 12 elem
console.log("Eredeti:", x);

function square(e) {
    return e * e;
}

function isNegative(e) {
    return e < 0;
}



// ------------------------------------------------------
// 2015 - ES6

// 1. Másolás - Adjuk meg a számok négyzeteit!
const squares = x.map(square);
console.log("Négyzetek:", squares);

// 2. Kiválogatás - Adjuk meg a negatív elemeket!
const negatives = x.filter(isNegative);
console.log("Negatívak:", negatives);

// 3. Megszámolás - Negatívak száma
const negativeCount = x.filter(isNegative).length;
console.log("Negatívak száma:", negativeCount);

// 4. Eldöntés - Van-e páros?
const anyEven = x.some(e => e % 2 === 0);
console.log("Van-e páros:", anyEven);

// 5. Eldöntés (optimista) - Mindegyik páros?
const everyEven = x.every(e => e % 2 === 0);
console.log("Mindegyik páros:", everyEven);

// 6. Keresés
// a) Hol van az első negatív? Ha nincs, akkor a -1 helyen van.
// b) Mennyi az értéke? Ha nincs, akkor undefined.
const firstNegative = x.find(isNegative);
const firstNegativeIndex = x.findIndex(isNegative);
const lastNegative = x.findLast(isNegative); // !!! 2022 !!!
const lastNegativeIndex = x.findLastIndex(isNegative);
console.log("Első negatív (hely, érték):", firstNegativeIndex+1, firstNegative);
console.log("Utolsó negatív (hely, érték):", lastNegativeIndex+1, lastNegative);



// ------------------------------------------------------
// 7. Rendezzük az elemeket növekvő sorrendbe:
const sorted = x.sort((a,b) => a - b); // !!! 2023 !!!
console.log("Növekvő sorrend:", sorted);

// Comparer function: (a, b)-ről képez le -1, 0, 1 elemekre
// -1, ha a < b
// 0, ha a === b
// 1, ha a > b
const evensFirst = [];
console.log("Párosak előre sorrend:", evensFirst);



// ------------------------------------------------------
// 8. Összegzés - Mennyi az elemek összege?
const sum = "";
console.log("Összeg:", sum);

// 9. Maximum kiválasztás
// a) Mennyi a legnagyobb elem?
// b) Hol van a legnagyobb?
const maxValue = "";
const maxIndex = "";
const maxIndex2 = "";
console.log("Maximum (első, utolsó, érték):", maxIndex, maxIndex2, maxValue);



// ------------------------------------------------------
// Kiterjesztés (indexek)
// 10. Kiválogatás - Minden második elemet (páros indexűeket)
const evenPositions = [];
console.log("Páros sorszámúak:", evenPositions);

// 11. Keresés - Adjuk meg az elsőt, aminek az értéke nagyobb az indexénél
const firstBig = "";
console.log("Értéke nagyobb, mint az indexe:", firstBig);

// 12. Írjuk ki a sorszámokat és az értékeket egymás mellé!
for (const e of x) {
    //console.log(`${e}`);
}
