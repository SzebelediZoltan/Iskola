function checkData(e) {
    const checkBox = document.querySelector("input[type=checkbox]")

    if (!checkBox.checked) {
        e.preventDefault()
    }
}

const button = document.querySelector("button")
button.addEventListener("click", checkData)