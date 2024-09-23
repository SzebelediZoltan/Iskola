const points = [
    {x: 1, y: -1},
    {x: 4, y: 0},
    {x: 5, y: 3},
    {x: 3, y: 4},
    {x: -1, y: 2}
];

function perimeter(points) {
    let kerulet = 0
    for (let i = 0; i < points.length; i++) {
        kerulet += distance(points[i], points[(i+1)%points.length])
    }

    return kerulet
}

function distance(A, B) {
    const elso = (A.x-B.x)**2;
    const masodik = (A.y-B.y)**2;
    return Math.sqrt(elso + masodik);
}