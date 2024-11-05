function handleClick(e) {
    const li = e.target
    if (li.matches("ul li")) {
        console.log(li.innerText)
    }
}

const movies = document.querySelector("ul")
movies.addEventListener("click", handleClick)

function swapMovies(li1, li2) {
    let tmp = li1.innerText
    li1.innerText = li2.innerText
    li2.innerText = tmp
}

let first = null;
function selectMovie(e) {
    const li = e.target
    if(!li.matches(li)) {
        return
    }

    if(first) {
        swapMovies(first, li)
        first = null
    } else {
        first = li
    }
}

movies.addEventListener("click", selectMovie)