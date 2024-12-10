function Main() {
    n = 12;
    mineCount = 10;
    board = [];
    revealedCount = 0;
    
    table = document.querySelector("table");
    button = document.querySelector("button")
    
    button.addEventListener("click", startGame)
}

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
                    isMine: false,
                    isReveled: false,
                    isFlagged: false
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

function getText(i, j) {
    if (board[i][j].isReveled) {
        if (board[i][j].isMine) {
            return "💣"
        } else if (board[i][j].value !== 0) {
            return board[i][j].value
        }
    } else {
        if (board[i][j].isFlagged) {
            return "🚩"
        }
    }

    return ""
}

function showBoard() {
    const table = document.querySelector("table")
    table.innerHTML = ""
    let revealActCount = 0
    for (let i = 0; i < board.length; i++) {
        const tr = document.createElement("tr")
        for (let j = 0; j < board[i].length; j++) {
            const td = document.createElement("td")
            if (board[i][j].isReveled) {
                revealActCount++
                td.classList.add("revealed")
            }
            td.innerText = getText(i, j)
            tr.appendChild(td)
        }
        table.appendChild(tr)
    }

    revealedCount = revealActCount
}

function revealNeighbors(x, y) {
    board[x][y].isReveled = true
    for (let i = x-1; i <= x+1; i++) {
        for (let j = y-1; j <= y+1; j++) {
            if (0 <= i && 0<= j && i < n && j < n) {
                if (board[i][j].value > 0) {
                    board[i][j].isReveled = true
                } else if (board[i][j].value === 0) {
                    if (!board[i][j].isReveled) {
                        revealNeighbors(i, j)
                    }
                }
            }
        }
    }
}

function handleWin() {
    for (const row of board) {
        for (const cell of row) {
            if (cell.isMine) {
                cell.isFlagged = false
                cell.isReveled = true
            }
        }
    }

    showBoard()
}

function checkGameEnd(i, j) {
    if (board[i][j].isMine || revealedCount == n*n - mineCount) {
        table.removeEventListener("click", handleClick)
        table.removeEventListener("contextmenu", handleFlag)
        handleWin()
        if (board[i][j].isMine) {
            console.log(board[i][j]);
            const audio = document.createElement('audio')
            audio.src = "./audio/hang.mp3"
            audio.volume = 1
            audio.play()

            table.rows[i].cells[j] .style.backgroundColor = "red"
        }
    }
}

function handleClick(e) {

    const td = e.target;
    const tr = td.parentNode

    if (!td.matches("td")) return

    const i = tr.rowIndex
    const j = td.cellIndex
    
    if (board[i][j].isFlagged) {
        return
    }

    board[i][j].isReveled = true
    
    if (board[i][j].value === 0) {
        revealNeighbors(i, j)
    }

    showBoard()
    checkGameEnd(i, j)
}

function handleFlag(e) {
    e.preventDefault()
    const td = e.target;
    const tr = td.parentNode

    if (!td.matches("td")) return
    
    const i = tr.rowIndex
    const j = td.cellIndex

    board[i][j].isFlagged = !board[i][j].isFlagged

    showBoard()

}

function startGame() {
    createBoard()
    showBoard()
    table.addEventListener("click", handleClick)
    table.addEventListener("contextmenu", handleFlag)
}

Main()