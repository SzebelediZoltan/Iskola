function round() {
    new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(Math.floor(Math.random() * 301))
        }, 1000);
    })
}

function competition() {
    round()
    .then((result) => {
        
    }).catch((err) => {
        
    });
}
competition();