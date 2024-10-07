function handleChoose() {
    this.classList.add("active")
}

const images = document.querySelectorAll("img")

for (const image of images) {
    image.addEventListener("click", handleChoose)
}