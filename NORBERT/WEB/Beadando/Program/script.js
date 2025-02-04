const bunny = {x: 0, y: 0}
const fox = {x: 0, y: 0 }
let n = 8
let m = 5
let actLevel = 1
let intID

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
    console.log("Lepes");
    

    return false
}

function level(actLevel) {


    return new Promise((resolve, reject) => {
        setTimeout(() => {
            reject(actLevel)
        }, 7000);
        
        intID =
        setInterval(() => {
            console.log(Math.round((Date.now() - startTime)/1000));
            
            if (placeBunny()) {
                console.log("Elkapta");      
                resolve(12)
            }
        }, 1000);
    });
}

function handleEnd() {
    console.log("Vege");
    window.removeEventListener("keydown", handleControls)
    fox.x =-1
    fox.y= -1
    showTable()
}

let startTime = 0

function jatek() {
    startTime = Date.now();
        
    placeBF()
    level(actLevel)
        .then(time => {
            clearInterval(intID)
            if (actLevel == 3) {
                console.log("Win");
                
                handleEnd()
            } else {
                console.log("Tovabb");
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

function start() {
    button.disabled = true
    placeBF()
    window.addEventListener("keydown", handleControls)
    jatek()
}

const button = document.querySelector("#start")
button.addEventListener("click", start)