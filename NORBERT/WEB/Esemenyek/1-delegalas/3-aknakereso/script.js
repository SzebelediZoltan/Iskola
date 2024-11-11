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
            board[i].push({
                    value: 0,
                    isMine: false
                })
            
        }
    }
    generateMines()
}

function generateMines() {
    let actMines = 0

    while(actMines < mineCount) {
        const x = randint(0, n-1)
        const y = randint(0, n-1)

        if(!board[x][y].isMine) {
            board[x][y].isMine = true
            actMines++
            incrementNeighbors(x, y)
        }
    }
}

function incrementNeighbors(x, y) {
    for (let i = x-1; i <= x+1; i++) {
        for (let j = y-1; j <= y+1; j++) {
            if (0 <= i && 0<= j && i < n && j < n) {
                board[i][j].value++
            }
        }
    }
}

function showBoard() {
    const table = document.querySelector("table")
    table.innerHTML = ""
    for (let i = 0; i < board.length; i++) {
        const tr = document.createElement("tr")
        for (let j = 0; j < board[i].length; j++) {
            const td = document.createElement("td")
            if (board[i][j].isMine) {
                td.innerText = "💣"
            } else {
                td.innerText = board[i][j].value
            }
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