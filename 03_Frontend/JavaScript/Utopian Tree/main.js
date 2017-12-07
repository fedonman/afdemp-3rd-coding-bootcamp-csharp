function growth(n, h) {
    let result = [h];
    for (let i = 0; i < n; i++) {
        if (i % 2 === 0) {
            result.push(result[i] * 2);
        }
        else {
            result.push(result[i] + 1);
        }
    }
    return result;
}

function print(arr) {
    for (let x of arr) {
        console.log(x);
    }
}

//this
print(growth(10, 1));

//or this
growth(10, 1).map(x => console.log(x));