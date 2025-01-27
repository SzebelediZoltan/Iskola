const buek = document.querySelector("#buek")

function random(a, b) {
    return Math.floor(Math.random() * (b-a+1) + a)
}

// function szinezes() {
//     buek.style.backgroundColor = `rgb(${random(0,255)}, ${random(0,255)}, ${random(0,255)})`
//     buek.style.color = `rgb(${random(0,255)}, ${random(0,255)}, ${random(0,255)})`
// }

// setInterval(szinezes, 1000)

function szinezesRek() {
    buek.style.backgroundColor = `rgb(${random(0,255)}, ${random(0,255)}, ${random(0,255)})`
    buek.style.color = `rgb(${random(0,255)}, ${random(0,255)}, ${random(0,255)})`

    setTimeout(szinezesRek, 1000)
}

szinezesRek()


const bar = document.querySelector("#loading div")
let precent = 0
let timeFirst = Date.now()
let i = 1

function varas() {
    i++
    setTimeout(varas, 1)
    if (i == 100) {
        console.log(Date.now()-timeFirst);
    }
}

varas()

function loading() {
    precent += 1
    bar.style.width = `${precent}%` 
    if (precent < 100) {
        setTimeout(loading, random(1, 150))
    }
}

loading()

function getTime(time) {
    time = Math.round(time/10).toString().padStart(4, "0")
    return time.slice(0, 2) + ":" + time.slice(2)
}

function reduceTime(time, start) {
    time = 5000 - (Date.now()-start)
    const timeSpan = document.querySelector("#time")
    timeSpan.innerText = getTime(time)
    if (time > 0) {
        setTimeout(() => {
            reduceTime(time, start)
        }, 1)
    } else {
        timeSpan.innerText = "00:00"
        input.disabled = true
    }
}

function handleStart() {
    let time = 5000
    const start = Date.now()
    input.removeEventListener("click", handleStart)
    reduceTime(time, start)
}

const input = document.querySelector("input")

input.addEventListener("click", handleStart)