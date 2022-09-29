function convertFunc(input){
    console.log(Number(input) * 1.79549);
}

function depositCalculator(amount, term, rate){
    let depositAmount = amount + term * ((amount * rate) / 100) / 12;
    console.log(depositAmount);
}

function dayofWeek(day){
    let output = 'Error';
    switch (day){
        case 1:
            output = 'Monday';
            break;
        case 2:
            output = 'Tuesday';
            break;
        case 3:
            output = 'Wednesday';
            break;
        case 4:
            output = 'Thursday';
            break;        
        case 5:
            output = 'Friday';
            break;
        case 6:
            output = 'Saturday';
            break;
        case 7:
            output = 'Sunday';
            break;      
    }
    console.log(output);
}

function shop(product, city, quantity){
    if (city == 'Sofia'){
        switch (product){
            case 'coffee':
                console.log(0.50 * quantity);
                break;
            case 'water':
                console.log(0.80 * quantity);
                break;
            case 'juice':
                console.log(1.20 * quantity);
                break;
            case 'sweets':
                console.log(1.45 * quantity);
                break;
            case 'peanuts':
                console.log(1.60 * quantity);
                break;
        }
    }
    else if (city == 'Plovdiv'){
        switch (product){
            case 'coffee':
                console.log(0.40 * quantity);
                break;
            case 'water':
                console.log(0.70 * quantity);
                break;
            case 'juice':
                console.log(1.15 * quantity);
                break;
            case 'sweets':
                console.log(1.30 * quantity);
                break;
            case 'peanuts':
                console.log(1.50 * quantity);
                break;
        }
    }
    else if (city == 'Varna'){
        switch (product){
            case 'coffee':
                console.log(0.45 * quantity);
                break;
            case 'water':
                console.log(0.70 * quantity);
                break;
            case 'juice':
                console.log(1.10 * quantity);
                break;
            case 'sweets':
                console.log(1.35 * quantity);
                break;
            case 'peanuts':
                console.log(1.55 * quantity);
                break;
        }
    }
}

function fruitOrVegetable(plantName){
    switch (plantName){
        case 'tomato':
            console.log('vegetable');
            break;
        case 'cucumber':
            console.log('vegetable');
            break;
        case 'pepper':
            console.log('vegetable');
            break;
        case 'carrot':
            console.log('vegetable');
            break;
        case 'banana':
            console.log('fruit');
            break;
        case 'apple':
            console.log('fruit');
            break;
        case 'kiwi':
            console.log('fruit');
            break;
        case 'cherry':
            console.log('fruit');
            break;
        case 'lemon':
            console.log('fruit');
            break;
        case 'grapes':
            console.log('fruit');
            break;
        default:
            console.log('unknown');
            break;
    }
}