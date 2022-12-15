function solution () {
    let recipes = {
        apple: {carbohydrate: 1, flavour: 2},
        lemonade: {carbohydrate: 10, flavour: 20},
        burger: {carbohydrate: 5, fat: 7, flavour: 3},
        eggs: {protein: 5, fat: 1, flavour: 1},
        turkey: {protein: 10, carbohydrate: 10, fat: 10, flavour: 10}
    };

    let stock = {
        protein: 0,
        carbohydrate: 0,
        fat: 0,
        flavour: 0
    };

    return function (input) {
        let [command, item, quantity] = input.split(' ');
        quantity = Number(quantity);

        if (command === 'restock') {
            stock[item] += quantity;
            return 'Success';
        } else if (command === 'prepare') {
            let needed = Object.entries(recipes[item]);
            for (let [ing, qty] of needed) {
                if (stock[ing] < qty * quantity) {
                    return `Error: not enough ${ing} in stock`;
                }
            }
            for (let [ing, qty] of needed) {
                stock[ing] -= qty * quantity;
            }
            return 'Success';
        } else if (command === 'report') {
            return `protein=${stock.protein} carbohydrate=${stock.carbohydrate} fat=${stock.fat} flavour=${stock.flavour}`;
        }
    };
}

let manager = solution();
console.log (manager ("restock flavour 50")); // Success
console.log (manager ("prepare lemonade 4")); // Error: not enough carbohydrate in stock