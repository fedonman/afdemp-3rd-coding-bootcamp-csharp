printStaircase(4);
printStaircaseFunctional(4);

function printStaircase(n) {
    for (let i = 0; i < n; i++) {
        let x = "";
        for (let y = 0; y < n; y++) {
            if (y < n - i - 1) {
                x += " ";
            }
            else {
                x += "#";
            }
        }
        console.log(x);
    }
}

function printStaircaseFunctional(n) {
    for (let i = 0; i < n; i++) {
        let x = " ".repeat(n - i - 1) + "#".repeat(i + 1);
        console.log(x);
    }
}