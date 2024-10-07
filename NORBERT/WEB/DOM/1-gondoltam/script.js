// const n = Math.floor(Math.random() * 100) + 1;

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}
const n = randint(1, 100);
console.log(n);

function handleGuess() {
    const input = document.querySelector("input");
    let li = document.createElement("li")
    if (n === parseInt(input.value)) {
        li.innerText = "Eltaláltad!!"
    } else if (n < input.value) {
        li.innerText = "Lejjebb!!"
    } else {
        li.innerText = "Feljebb!!"
    }

    const ol = document.querySelector("ol")
    ol.appendChild(li)
}
const button = document.querySelector("button");
button.addEventListener("click", handleGuess);