function calculateMoney(fruit, weigth, pricePerKilo){
    let kiloWeight = weigth/ 1000;
    let money = pricePerKilo * kiloWeight;
    console.log(`I need $${money.toFixed(2)} to buy ${kiloWeight.toFixed(2)} kilograms ${fruit}.`);
}