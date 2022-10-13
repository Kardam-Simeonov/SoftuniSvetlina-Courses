function leapYears(yearOne, yearTwo){
    for (let year = Number(yearOne); year <= Number(yearTwo); year++) {
        if (year % 4 === 0 && year % 100 !== 0 || year % 400 === 0) {
            console.log(year);
        }
    }
}

function factorial(n){
    let result = 1;
    for (let i = 1; i <= Number(n); i++) {
        result *= i;
    }
    console.log(result);
}

function examPreparation(input){
    let unsatisfactoryGrades = Number(input.shift());
    let unsatisfactoryGradesCounter = 0;
    let taskName = '';
    let taskGrade = 0;
    let gradeSum = 0;
    
    for (let i = 0; i < input.length; i+=2) {
        taskName = input[i];
        if (taskName === 'Enough') {
            input.shift();
            console.log(`Average score: ${(gradeSum / (input.length / 2)).toFixed(2)}`);
            console.log(`Number of problems: ${input.length / 2}`);
            console.log(`Last problem: ${input[input.length - 3]}`);
        }
        taskGrade = Number(input[i + 1]);
        gradeSum += taskGrade;
        if (taskGrade <= 4){
            unsatisfactoryGradesCounter++;
        }
        if (unsatisfactoryGradesCounter === unsatisfactoryGrades){
            console.log(`You need a break, ${unsatisfactoryGradesCounter} poor grades.`);
            break;
        } 
    }
}

function walking(input){
    let steps = 0;
    let stepsToHome = 10000;
    let index = 0;
    let command = input[index];
    while (steps < stepsToHome) {
        if (command === 'Going home') {
            steps += Number(input[index + 1]);
            break;
        }
        steps += Number(command);
        index++;
        command = input[index];
    }
    if (steps >= stepsToHome) {
        console.log('Goal reached! Good job!');
        console.log(`${steps - stepsToHome} steps over the goal!`);
    } else {
        console.log(`${stepsToHome - steps} more steps to reach goal.`);
    }
}

function coins(input){
    let change = input * 100;
    let coins = 0;
    while (change > 0) {
        if (change >= 200) {
            change -= 200;
            coins++;
        } else if (change >= 100) {
            change -= 100;
            coins++;
        } else if (change >= 50) {
            change -= 50;
            coins++;
        } else if (change >= 20) {
            change -= 20;
            coins++;
        } else if (change >= 10) {
            change -= 10;
            coins++;
        } else if (change >= 5) {
            change -= 5;
            coins++;
        } else if (change >= 2) {
            change -= 2;
            coins++;
        } else if (change >= 1) {
            change -= 1;
            coins++;
        }
    }
    console.log(coins);
}

function sumPrimeNonPrime(input){
    let command = input.shift();
    let primeSum = 0;
    let nonPrimeSum = 0;
    while (command !== 'stop') {
        let number = Number(command);
        if (number < 0) {
            console.log('Number is negative.');
        } else {
            let isPrime = true;
            for (let i = 2; i < number; i++) {
                if (number % i === 0) {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime) {
                primeSum += number;
            } else {
                nonPrimeSum += number;
            }
        }
        command = input.shift();
    }
    console.log(`Sum of all prime numbers is: ${primeSum}`);
    console.log(`Sum of all non prime numbers is: ${nonPrimeSum}`);
}

function trainTheTrainers(input){
    let jury = Number(input.shift());
    let presentation = input.shift();
    let totalSum = 0;
    let totalGrades = 0;
    while (presentation !== 'Finish') {
        let sum = 0;
        for (let i = 0; i < jury; i++) {
            let grade = Number(input.shift());
            sum += grade;
            totalGrades++;
        }
        console.log(`${presentation} - ${(sum / jury).toFixed(2)}.`);
        totalSum += sum;
        presentation = input.shift();
    }
    console.log(`Student's final assessment is ${(totalSum / totalGrades).toFixed(2)}.`);
}
