function sumDigits(number) {
    let sum = 0;
    while (number > 0) {
        sum += number % 10;
        number = Math.floor(number / 10);
    }
    console.log(sum);
}

function charsToString(a, b, c) {
    console.log(a + b + c);
}

function townInfo(town, population, area) {
    console.log(`Town ${town} has population of ${population} and area ${area} square km.`);
}

function convertMetersToKilometers(meters){
    let kilometers = meters / 1000;
    console.log(kilometers.toFixed(2));
}

function poundsToDollars(pounds){
    let dollars = pounds * 1.31;
    console.log(dollars.toFixed(3));
}

function reversedChars(a, b, c){
    console.log(`${c} ${b} ${a}`);
}

function lowerOrUpper(char){
    if (char == char.toUpperCase())
        console.log('upper-case');
    else
        console.log('lower-case');
}

function calculator(number, operator, secondNumber){
    switch (operator) {
        case '+':
            console.log((number + secondNumber).toFixed(2));
            break;
        case '-':
            console.log((number - secondNumber).toFixed(2));
            break;
        case '*':
            console.log((number * secondNumber).toFixed(2));
            break;
        case '/':
            console.log((number / secondNumber).toFixed(2));
            break;
    }
}

function gladiatorExpenses(lostFights, helmet, sword, shield, armour){
    let expenses = 0;
    let shieldBreaks = 0;
    for (let i = 1; i <= lostFights; i++) {
        if (i % 2 == 0)
            expenses += helmet;
        
        if (i % 3 == 0)
            expenses += sword;
        
        if (i % 2 == 0 && i % 3 == 0){
            expenses += shield;
            shieldBreaks++;

            if (shieldBreaks % 2 == 0)
                expenses += armour;
        }
    }

    console.log(`Gladiator expenses: ${expenses.toFixed(2)} aureus`);
}

function spiceMustFlow(startingYield) {
    let total = 0;
    let days = 0;
    while (startingYield >= 100) {
        total += startingYield;
        total -= 26;
        startingYield -= 10;
        days++;
    }
    if (total >= 26)
        total -= 26;
    console.log(days);
    console.log(total);
}