// 1st way (try to change the parameter) - BAD
function roundGrades(grades) {
    for (let i = 0; i < grades.length; i++) {
        if (grades[i] >= 38 && (grades[i]%5 === 3 || grades[i]%5 === 4)) {
            grades[i] += 5 - grades[i]%5;
        }
    }
}

// 2nd way (create and return a new array) - GOOD
function roundGradesReturn(grades) {
    let result = [];
    for (let i = 0; i < grades.length; i++) {
        if (grades[i] >= 38 && (grades[i]%5 === 3 || grades[i]%5 === 4)) {
            result.push(grades[i] + 5 - grades[i]%5);
        }
        else {
            result.push(grades[i]);
        }
    }
    return result;
}

// 2nd way easier
function roundGradesReturnForIn(grades) {
    let result = [];
    for (let grade of grades) {
        if (grade >= 38 && grade % 5 > 2) {
            result.push(grade + 5 - grade % 5);
        }
        else {
            result.push(grade);
        }
    }
    return result;
}

// 2nd way using map method
function roundGrade(grade) {
    if (grade >= 38 && grade % 5 > 2) {
        return grade + 5 - grade % 5;
    }
    return grade;
}

function roundGradesReturnMap(grades) {
    return grades.map(roundGrade);
}

// using ES6 syntax
let roundGradeES6 = (grade) => {
    if (grade >= 38 && grade % 5 > 2) {
        return grade + 5 - grade % 5;
    }
    return grade;
}

let roundGradesReturnMapES6 = (grades) => grades.map(roundGradeES6);

let grades_1 = [42, 58, 60, 26, 89];
console.log(grades_1);
roundGrades(grades_1);
console.log(grades_1);

console.log("---");

let grades_2 = [42, 58, 60, 26, 89];
console.log(grades_2);
console.log(roundGradesReturn(grades_2));
console.log(grades_2);

console.log("---");

let grades_3 = [42, 58, 60, 26, 89];
console.log(grades_3);
console.log(roundGradesReturnForIn(grades_3));
console.log(grades_3);

console.log("---");

let grades_4 = [42, 58, 60, 26, 89];
console.log(grades_4);
console.log(roundGradesReturnMap(grades_4));
console.log(grades_4);