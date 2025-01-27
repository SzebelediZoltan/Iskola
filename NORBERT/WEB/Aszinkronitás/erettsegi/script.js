function walkDog(cb) {
    setTimeout(() => {
        cb("Kutya!");
    }, 2500);
}

function washDishes(cb) {
    setTimeout(() => {
        cb("Mosogatas!");
    }, 1000);
}

function takeTrash(cb) {
    setTimeout(() => {
        cb("Kivittem!");
    }, 100);
}

async function hazimunka() {
    walkDog(result => {
        console.log(result);
        washDishes(result => {
            console.log(result);
            takeTrash(result => {
                console.log(result);
            })
        })
    })
}

hazimunka();