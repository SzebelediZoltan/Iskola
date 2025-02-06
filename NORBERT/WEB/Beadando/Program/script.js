const bunny = {x: 0, y: 0}
const fox = {x: 0, y: 0 }
const n = 8
const m = 5
let actLevel = 1
let intID

const button = document.querySelector("#start")
button.addEventListener("click", start)

const szint = document.querySelector("#szint")
let startTime

function randomInt(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a
}

function showTable() {
    const table = document.querySelector("table")
    table.innerHTML = ""
    for(let i = 0; i < m; i++) {
        const tr = document.createElement("tr")
        for(let j = 0; j < n; j++) {
            const td = document.createElement("td")
            if(fox.x == j && fox.y == i) {
                td.innerText = "🦊";
            } else if(bunny.x == j && bunny.y == i) {
                td.innerText = "🐰";
            } else {
                td.innerText = "O"
            }
            tr.appendChild(td)
        }
        table.appendChild(tr)
    }
}

function placeBF() {
    fox.x = n-1
    fox.y = m-1
    bunny.x = randomInt(0, Math.floor(n/2)-1)
    bunny.y = randomInt(0, m-1)
    showTable()
}

function handleControls(e) {
    if(e.key == "ArrowUp" && fox.y != 0){
        fox.y--
    } else if (e.key == "ArrowDown" && fox.y != m-1) {
        fox.y++
    } else if (e.key == "ArrowRight" && fox.x != n-1) {
        fox.x++
    } else if (e.key == "ArrowLeft" && fox.x != 0) {
        fox.x--
    }
    showTable()
}

function placeBunny() {
    if (bunny.x == fox.x && bunny.y == fox.y) {
        return true
    }

    bunny.x = randomInt(0, n-1)
    bunny.y = randomInt(0, m-1)
    
    showTable()
    
    return false
}

function writeStats() {
    startTime = Date.now();
    const div = document.createElement("div")
    div.innerHTML = "<p>Aktuális szint: " + actLevel + "</p><p id=ido"+ actLevel +">Idő: 0"

    szint.appendChild(div)
}

function level() {
    writeStats()

    return new Promise((resolve, reject) => {
        setTimeout(() => {
            reject(actLevel)
        }, 8000);
        
        intID =
        setInterval(() => {
            document.querySelector("#ido"+ actLevel).innerText = "Idő: "+ Math.round((Date.now() - startTime)/1000)

            if (placeBunny()) {
                resolve(12)
            }
        }, 1000);
    });
}

function handleEnd() {
    window.removeEventListener("keydown", handleControls)
    fox.x =-1
    fox.y= -1
    button.disabled = false
    showTable()
}

function jatek() {
    placeBF()
        
    level()
        .then(time => {
            clearInterval(intID)
            if (actLevel == 3) {
                console.log("Win");
                
                handleEnd()
            } else {
                actLevel++
                jatek()
            }
        })
        .catch(endLevel => {
            clearInterval(intID)
            console.log("Lose");
            handleEnd()
        })
}

function reset() {
    szint.innerHTML = ""
    actLevel = 1
}

function start() {
    button.disabled = true
    window.addEventListener("keydown", handleControls)
    reset()
    jatek()
}