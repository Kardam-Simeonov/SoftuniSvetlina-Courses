function calculateSugarIntake(days){
    let cookieIntake = 2.5;
    let waffleIntake = 9;
    let cupcakeIntake = 15;

    let totalIntake = 0;

    for (let i = 1; i <= days; i++) {
        totalIntake += cookieIntake + waffleIntake;

        if (i % 5 == 0){
            totalIntake += cupcakeIntake;
        }
    }

    return 'You have consumed ' + totalIntake + ' grams of sugar';
}

console.log(calculateSugarIntake(1));
console.log(calculateSugarIntake(9));