function greetUser(greeting, name) {
    const oldDiv = document.querySelector("#regi")
    oldDiv.innerHTML = `<p>${greeting} ${name}!</p>`

    const newDiv = document.querySelector("#uj")
    newDiv.style.display = "none"
}

function handleClick() {
    const name = document.querySelector("input").value

    const select = document.querySelector("select");
    const greeting = select[select.selectedIndex].innerText;

    greetUser(greeting, name)

    localStorage.setItem("name", name)
    localStorage.setItem("greeting", greeting)
}

const button = document.querySelector("button")
button.addEventListener("click", handleClick)

function handleLoad() {
    const name = localStorage.getItem("name")
    const greeting = localStorage.getItem("greeting")

    if (name) {
        greetUser(greeting, name)
    }
}

window.addEventListener("load", handleLoad)