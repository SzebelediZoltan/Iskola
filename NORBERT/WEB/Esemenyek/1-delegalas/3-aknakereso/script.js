const n = 12;
const mineCount = 10;
let board = [];
let revealedCount = 0;

const table = document.querySelector("table");

// --------------------------------------------

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function createBoard() {
    board = []
    for (let i = 0; i < n; i++) {
        board.push([])
        for (let j = 0; j < n; j++) {
            board[i].push({value: 0, isMine: false})
            
        }
    }
    console.log(board);
}

function showBoard() {
    const table = document.querySelector("table")
    table.innerHTML = ""
    for (let i = 0; i < board.length; i++) {
        const tr = document.createElement("tr")
        for (let j = 0; j < board[i].length; j++) {
            const td = document.createElement("td")
            td.innerText = board[i][j].value
            tr.appendChild(td)
        }
        table.appendChild(tr)
    }
}

function startGame() {
    createBoard()
    showBoard()
}

const button = document.querySelector("button")

button.addEventListener("click", startGame)