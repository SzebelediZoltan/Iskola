function handleClick(e) {
    const li = e.target
    if (li.matches("ul li")) {
        console.log(li.innerText)
    }
}

const movies = document.querySelector("ul")
movies.addEventListener("click", handleClick)

function swapMovies(li1, li2) {
    const firstNumber = li1.innerText.split(". ")[0]
    const firstTitle = li1.innerText.split(". ")[1]
    
    const secondNumber = li2.innerText.split(". ")[0]
    const secondTitle = li2.innerText.split(". ")[1]

    li1.innerText = `${firstNumber}. ${secondTitle}`
    li2.innerText = `${secondNumber}. ${firstTitle}`

    li1.classList.add("swap")
    li2.classList.add("swap")

    // setTimeout(() => {
    //     li1.classList.remove("swap")
    //     li2.classList.remove("swap")
    // }, 350);
}

let first = null;
function selectMovie(e) {
    const li = e.target
    if(!li.matches("li")) {
        return
    }

    if(first && first !== li) {
        li.classList.add("selected")
        swapMovies(first, li)
        first = null
    } else if (first === li) {
        first = null
        e.target.classList.remove("selected")
    } else {
        first = li
        first.classList.add("selected")
    }
}

movies.addEventListener("click", selectMovie)

function handleEnd(e) {
    if (e.animationName === "swap") {
        e.target.classList.remove("selected")
        e.target.classList.remove(e.animationName)
    }
}

movies.addEventListener("animationend", handleEnd)