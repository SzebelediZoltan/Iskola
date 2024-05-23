function szamolas() {
    document.querySelector("p span").innerHTML = document.querySelector("#sugar").value ** 2;
}
szamolas();
document.querySelector("button").addEventListener("click", szamolas);