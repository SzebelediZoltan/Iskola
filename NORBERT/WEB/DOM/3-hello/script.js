function handleClick() {
    const name = document.querySelector("input").value
    const oldDiv = document.querySelector("#regi")
    oldDiv.innerHTML = `<p>Szia ${name}!</p>`

    const newDiv = document.querySelector("#uj")
    newDiv.style.display = "none"

    localStorage.setItem("name", name)
}

const button = document.querySelector("button")
button.addEventListener("click", handleClick)

function handleLoad() {
    const name = localStorage.getItem("name")

    if (name) {
        const oldDiv = document.querySelector("#regi")
        oldDiv.innerHTML = `<p>Szia ${name}!</p>`
    
        const newDiv = document.querySelector("#uj")
        newDiv.style.display = "none"
    }
}

window.addEventListener("load", handleLoad)