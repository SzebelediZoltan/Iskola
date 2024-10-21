// HTML table <=> JS matrix
let m = [];
const table = document.querySelector("table");

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function showTable() {
    let data = "";
    for (let i = 0; i < 10; i++) {
        data += "<tr>";
        for (let j = 0; j < 10; j++) {
            data += `<td>${m[i][j]}</td>`;
        }
        data += "</tr>";
    }
    table.innerHTML = data;
    setClickHandlers()
}

function generate() {
    m = []; // m.splice(0, m.length); // m = [];
    for (let i = 0; i < 10; i++) {
        const row = [];
        for (let j = 0; j < 10; j++) {
            const r = randint(10, 99);
            row.push(r);
        }
        m.push(row);
    }
    localStorage.setItem("numbers", JSON.stringify(m));
    showTable();
}

const button = document.querySelector("button");
button.addEventListener("click", generate);

function handleLoad() {
    m = JSON.parse(localStorage.getItem("numbers"));
    if (!m) return;
    showTable();
}
window.addEventListener("load", handleLoad);

function setClickHandlers() {
    const rows = table.rows;
    for (const row of rows) {
        const cells = row.cells
        for (const cell of cells) {
            cell.addEventListener("click", handleClick)
        }
    }
}

function handleClick() {
    this.classList.toggle("oszthato")
}

const number = document.querySelector("input")
number.addEventListener("input", selectNumbers)

function selectNumbers() {
    const d = parseInt(number.value)
    for (const row of table.rows) {
        for (const cell of row.cells) {
            cell.classList.toggle("oszthato", cell.innerText % d === 0)
        }
    }
}