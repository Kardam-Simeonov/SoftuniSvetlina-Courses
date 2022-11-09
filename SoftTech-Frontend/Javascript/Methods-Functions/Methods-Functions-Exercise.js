function smallestNumber(first, second, third) {
    let smallest = Math.min(first, second, third);
    console.log(smallest);
}

function addAndSubtract(first, second, third){
    function add(firstToAdd, secondtoAdd){
        return firstToAdd + secondtoAdd;
    }
    function subtract(addProduct, subtractNumber){
        return addProduct - subtractNumber;
    }

    return subtract(add(first, second), third);
}

function characterInRange(firstChar, secondChar){
    let firstCharCode = firstChar.charCodeAt(0);
    let secondCharCode = secondChar.charCodeAt(0);
    let result = '';
    let start = Math.min(firstCharCode, secondCharCode);
    let end = Math.max(firstCharCode, secondCharCode);

    for (let i = start + 1; i < end; i++) {
        result += String.fromCharCode(i) + ' ';
    }
    return result;
}

function oddAndEvenSum(number){
    let numberAsString = number.toString();
    let oddSum = 0;
    let evenSum = 0;

    for (let i = 0; i < numberAsString.length; i++) {
        let currentNumber = Number(numberAsString[i]);

        if (currentNumber % 2 === 0) {
            evenSum += currentNumber;
        } else {
            oddSum += currentNumber;
        }
    }
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}

function palindromeIntegers(arr){
    for (let number of arr) {
        let numberAsString = number.toString();

        if (numberAsString === numberAsString.split('').reverse().join('')) {
            console.log(true);
        }
        else {
            console.log(false);
        }
    }
}

function passwordValidator(password){
    function isBetween6And10Chars(password){
        return password.length >= 6 && password.length <= 10;
    }
    function consistsOnlyOfLettersAndDigits(password){
        let isValid = true;

        for (let i = 0; i < password.length; i++) {
            let currentChar = password[i];

            if (!currentChar.toLowerCase().match(/[a-z]|[1-9]/gm)) {
                isValid = false;
                break;
            }
        }
        return isValid;
    }
    function hasAtLeast2Digits(password){
        let digitsCount = 0;

        for (let i = 0; i < password.length; i++) {
            let currentChar = password[i];

            if (currentChar.match(/[1-9]/gm)) {
                digitsCount++;
            }
        }
        return digitsCount >= 2;
    }

    if (isBetween6And10Chars(password) && consistsOnlyOfLettersAndDigits(password) && hasAtLeast2Digits(password)) {
        console.log('Password is valid');
    }
    if (!isBetween6And10Chars(password)) {
        console.log('Password must be between 6 and 10 characters');
    }
    if (!consistsOnlyOfLettersAndDigits(password)) {
        console.log('Password must consist only of letters and digits');
    }
    if (!hasAtLeast2Digits(password)) {
        console.log('Password must have at least 2 digits');
    }
}

function NxNMatrix(number){
    for (let i = 0; i < number; i++) {
        console.log((number + ' ').repeat(number));
    }
}

function perfectNumber(number){
    let divisorsSum = 0;

    for (let i = 1; i < number; i++) {
        if (number % i === 0) {
            divisorsSum += i;
        }
    }

    if (divisorsSum === number) {
        console.log('We have a perfect number!');
    }
    else {
        console.log("It's not so perfect.");
    }
}

function loadingBar(num){
    let percent = num / 10;
    let dots = 10 - percent;
    let result = '';

    if (num === 100) {
        result = '100% Complete!';
    }
    else {
        result = `${num}% [${'%'.repeat(percent)}${'.'.repeat(dots)}]\nStill loading...`;
    }
    console.log(result);
}

function factorialDivision(firstNumber, secondNumber){
    let firstFactorial = 1;
    let secondFactorial = 1;

    for (let i = 1; i <= firstNumber; i++) {
        firstFactorial *= i;
    }
    for (let i = 1; i <= secondNumber; i++) {
        secondFactorial *= i;
    }

    let result = firstFactorial / secondFactorial;
    console.log(result.toFixed(2));
}